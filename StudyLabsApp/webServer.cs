using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudyLabsApp
{
    public static class webServer
    {
        static async Task GetWebStuff()
        {
            var client = new HttpClient();

            var response = await client.GetAsync("https://localhost:44347/weatherforecast").ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            Console.WriteLine(response.Content);
        }
    }
}
