using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ServiceStack;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace FdaService
{
    public class ServiceHelper
    {
        public static string ApiKey = "40tqTRFnKf0bViGI2fkXF6kxZjQhqzY41UaeGa5D";
        public static string ApiKeyTemplate = "api_key={0}&";
        public static T GetData<T>(string baseUri, string endPoint, string parameters)
        {
            var apiKeyParam = String.Format(ApiKeyTemplate, ApiKey);
            //var client = new JsonServiceClient(baseUri); //"http://host/api/"
            //var response = client.Get<T>(endPoint + apiKeyParam + parameters); //"/hello/World!"
            //return response;
            var httpClient = new System.Net.Http.HttpClient();
            var data = httpClient.GetStringAsync(baseUri + endPoint + apiKeyParam + parameters).Result;

            //var webClient = new WebClient();
            //var data = webClient.DownloadString(baseUri + endPoint + apiKeyParam + parameters);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));

            using (var memoryStream = new MemoryStream(Encoding.Unicode.GetBytes(data)))
            {
                var returnObject = (T)serializer.ReadObject(memoryStream);
                return returnObject;
            }
            
        }
    }
}
