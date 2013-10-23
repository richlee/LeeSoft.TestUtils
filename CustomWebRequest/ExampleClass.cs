using System;
using System.IO;
using System.Net;

namespace LeeSoft.TestUtils.CustomWebRequest
{
    public class ExampleClass
    {
        public string RequestData(Uri uri)
        {
            var response = CreateWebRequest(uri).GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream == null) return null;

            string responseData;
            using (var reader = new StreamReader(responseStream))
            {
                responseData = reader.ReadToEnd();
            }

            return responseData;
        }

        private static HttpWebRequest CreateWebRequest(Uri uri)
        {
            var request = WebRequest.Create(uri) as HttpWebRequest;

            if (request == null) return null;

            request.ContentType = "text/xml;charset=\"utf-8\"";
            request.Method = "GET";
            request.Timeout = 1000;
            request.Credentials = CredentialCache.DefaultNetworkCredentials;

            return request;
        }
    }
}
