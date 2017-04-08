using System;
using System.IO;
using System.Net;

namespace IPInfoDotNET
{
    public partial class IPInfo
    {
        public static IPInfo Get()
        {
            return Get(null);
        }

        public static IPInfo Get(string ip)
        {
            return new IPInfo(GetParserRequest(ip));
        }

        public static string Get(IPInfoKey key)
        {
            return GetRequest(key, null);
        }

        public static string Get(IPInfoKey key, string ip)
        {
            return GetRequest(key, ip);
        }

        private static string GetRequest(string ip)
        {
            WebRequest request = WebRequest.Create(ip == null ? "http://ipinfo.io/" : "http://ipinfo.io/" + ip);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }

        private static string GetRequest(IPInfoKey key, string ip)
        {
            WebRequest request = WebRequest.Create(ip == null ? "http://ipinfo.io/" + key.ToString().ToLower() : "http://ipinfo.io/" + ip + "/" + key.ToString().ToLower());
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }

        private static JSParser GetParserRequest(string ip)
        {
            string json = GetRequest(ip);
            return new JSParser(json);
        }

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
