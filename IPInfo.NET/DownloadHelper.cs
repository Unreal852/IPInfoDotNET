using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace IPInfo
{
    internal static class DownloadHelper
    {
        public async static Task<byte[]> DownloadDataAsync(string url)
        {
            byte[] data = new byte[0];
            try
            {
                WebRequest wRequest = WebRequest.Create(url);
                WebResponse wResponse = await wRequest.GetResponseAsync();
                using (Stream wStream = wResponse.GetResponseStream())
                {
                    byte[] buffer = new byte[1024];
                    int dataLenght = (int)wResponse.ContentLength;
                    using (MemoryStream mStream = new MemoryStream())
                    {
                        int bytesRead;
                        while((bytesRead = wStream.ReadAsync(buffer, 0, buffer.Length).Result)> 0)
                        {
                            mStream.Write(buffer, 0, bytesRead);
                        }
                        data = mStream.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return data;
        }
    }
}
