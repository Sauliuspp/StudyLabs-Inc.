
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp.Web
{
    public static class webService
    {
        public static async Task GetWebStuff()
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://localhost:44347/weatherforecast").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            Console.WriteLine(response.Content);
        }
        public static async Task GetWebStuffPOST(AStuddyBuddy buddy)
        {
            string json = JsonConvert.SerializeObject(buddy);
            var payload = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var result = await client.PostAsync("https://localhost:44347/weatherforecast", payload);
                var response = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                Console.WriteLine(response);
            }
        }
    }
}