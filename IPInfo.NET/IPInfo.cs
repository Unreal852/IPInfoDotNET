using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using IPInfo.JSON;

namespace IPInfo
{
    public partial class IPInfo
    {
        private const string c_baseURL = "https://ipinfo.io/";

        /// <summary>
        /// Get informations about the specified IP address ( leave blank to get the caller's IP informations ) asynchroniously
        /// </summary>
        /// <returns><see cref="IPResult"/> Result</returns>
        public async static Task<IPResult> GetAsync(string ip = null, string token = null)
        {
            string json = await Task.Run(() => RequestAsync(ip, token));
            return new IPResult(JSONParser.FromJson<Dictionary<string, object>>(json));
        }

        /// <summary>
        /// Get a specified information about the specified IP address ( leave blank to get the caller's IP informations ) asynchroniously
        /// </summary>
        /// <returns><see cref="string"/> Result</returns>
        public async static Task<string> GetAsync(IPInfoKey key, string ip = null, string token = null)
        {
            string text = await Task.Run(() => RequestAsync(ip, token, key));
            return text;
        }

        /// <summary>
        /// Get informations about the specified IP address ( leave blank to get the caller's IP informations )
        /// </summary>
        /// <returns><see cref="IPResult"/> Result</returns>
        public static IPResult Get(string ip = null, string token = null)
        {
            return new IPResult(JSONParser.FromJson<Dictionary<string, object>>(Request(ip, token)));
        }

        /// <summary>
        /// Get a specified information about the specified IP addres ( leave blank to get the caller's IP informations )
        /// </summary>
        /// <returns><see cref="string"/> Result</returns>
        public static string Get(IPInfoKey key, string ip = null, string token = null)
        {
            return Request(ip, token, key);
        }

        private static string Request(string ip = null, string token = null, IPInfoKey? key = null)
        {
            string json = null;
            Task.WaitAll(Task.Run(async () =>
            {
                json = await RequestAsync(ip, token, key);
            }));
            return json;
        }

        private async static Task<string> RequestAsync(string ip = null, string token = null, IPInfoKey? key = null)
        {
            WebRequest wRequest = WebRequest.Create($"{c_baseURL}{(ip == null ? "" : ip)}{(key.HasValue ? $@"{key.ToString().ToLower()}" : "")}{(token == null ? "" : $"?token={token}")}");
            System.Diagnostics.Debug.Print(wRequest.RequestUri.ToString());
            WebResponse wResponse = await wRequest.GetResponseAsync();
            using (StreamReader sReader = new StreamReader(wResponse.GetResponseStream()))
                return sReader.ReadToEnd();
        }
    }
}
