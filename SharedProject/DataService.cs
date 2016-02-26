using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject
{
    public class DataService
    {
        public static async Task<dynamic> getDataFormService(string queryString)
        {
            HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(queryString);
            var response = await request.GetResponseAsync().ConfigureAwait(false);
            var stream = response.GetResponseStream();

            var streamReader = new StreamReader(stream);
            string responseText = streamReader.ReadToEnd();

            dynamic data = JsonConvert.DeserializeObject(responseText);

            return data;

        }
    }
}
