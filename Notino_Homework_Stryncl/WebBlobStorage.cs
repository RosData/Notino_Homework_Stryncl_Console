using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Notino_Homework_Stryncl
{
    public class WebBlobStorage : IBlobStorage
    {
        private static HttpClient httpClient = new HttpClient();

        public string ReadAsString(string filePathOrUrl)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, filePathOrUrl);

            // jsem v synchronní metodě
            HttpResponseMessage response = httpClient.SendAsync(request).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;

            return responseBody;
        }

        public void SaveContent(string targetFileName, byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
