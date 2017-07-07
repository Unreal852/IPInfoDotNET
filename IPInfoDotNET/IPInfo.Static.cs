using System;
using System.IO;
using System.Net;

namespace IPInfoDotNET
{
    public partial class IPInfo
    {
        /// <summary>
        /// Get the IP information of the current machine ( public IP )
        /// </summary>
        /// <returns><see cref="IPInfo"/> Result</returns>
        public static IPInfo Get() => Get(null);

        /// <summary>
        /// Get the IP information of the given IP
        /// </summary>
        /// <param name="ip">IP to check</param>
        /// <returns><see cref="IPInfo"/> Result</returns>
        public static IPInfo Get(string ip) => new IPInfo(GetParserRequest(ip));

        /// <summary>
        /// Get a specific IP information of the current machine
        /// </summary>
        /// <param name="key"><see cref="IPInfoKey"/> Value to get</param>
        /// <returns>Result</returns>
        public static string Get(IPInfoKey key) => GetRequest(key, null);

        /// <summary>
        /// Get the specific IP information of the given IP
        /// </summary>
        /// <param name="key"><see cref="IPInfoKey"/> Value to get</param>
        /// <param name="ip">IP to check</param>
        /// <returns>Result</returns>
        public static string Get(IPInfoKey key, string ip) => GetRequest(key, ip);

        /// <summary>
        /// Get request for the given ip
        /// </summary>
        /// <param name="ip">IP</param>
        /// <returns>Response</returns>
        private static string GetRequest(string ip)
        {
            WebRequest request = WebRequest.Create(ip == null ? "http://ipinfo.io/" : "http://ipinfo.io/" + ip);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }

        /// <summary>
        /// Get request for the given key and ip
        /// </summary>
        /// <param name="key"><see cref="IPInfoKey"/> Value to get</param>
        /// <param name="ip">IP</param>
        /// <returns>Response</returns>
        private static string GetRequest(IPInfoKey key, string ip)
        {
            WebRequest request = WebRequest.Create(ip == null ? "http://ipinfo.io/" + key.ToString().ToLower() : "http://ipinfo.io/" + ip + "/" + key.ToString().ToLower());
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }

        /// <summary>
        /// Get a request and parse it
        /// </summary>
        /// <param name="ip">IP</param>
        /// <returns>Parser</returns>
        private static JSParser GetParserRequest(string ip)
        {
            string json = GetRequest(ip);
            return new JSParser(json);
        }

        /// <summary>
        /// Download data from the given URL ( used for downloading google map location )
        /// </summary>
        /// <param name="url">Url to download the file from</param>
        /// <returns>Downloaded Data</returns>
        private static byte[] DownloadData(string url)
        {
            byte[] downloadedData = new byte[0];
            try
            {
                WebRequest req = WebRequest.Create(url);
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();

                byte[] buffer = new byte[1024];
                int dataLength = (int)response.ContentLength;

                MemoryStream memStream = new MemoryStream();
                while (true)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                        break;
                    else
                        memStream.Write(buffer, 0, bytesRead);
                }
                downloadedData = memStream.ToArray();
                stream.Close();
                memStream.Close();
            }
            catch (Exception ex)
            {

            }
            return downloadedData;
        }
    }
}
