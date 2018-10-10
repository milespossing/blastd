using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Threading.Tasks;
using blastd.Json;
using blastd.Models;
using Newtonsoft.Json;

namespace blastd
{
    public class Requester
    {
        public async Task<List<string>> GetValues()
        {
            HttpClient client = new HttpClient();
            Uri address =  new Uri(string.Format($"https://blastd.azurewebsites.net/api/values",string.Empty));
            HttpResponseMessage response = await client.GetAsync(address);
            List<string> output = new List<string>();
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                output = JsonConvert.DeserializeObject<List<string>>(content);
            }
            return output;
        }
    }
}