using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace CuHackathon.C_Classes
{
    class PythonMedian
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GenerateCrime(string villainName)
        {
            string result = "Error through function";
            try
            {
                var json = $"{{\"villain_name\":\"{villainName}\"}}";
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:5000/generate-crime", content);
                result = await response.Content.ReadAsStringAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            result = "Got through function";
            return result;
        }

        public static async Task<string> GenerateHeroDescription(string heroName, string villainName)
        {
            var json = $"{{\"hero_name\":\"{heroName}\", \"villain_name\":\"{villainName}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://localhost:5000/generate-hero-description", content);
            var result = await response.Content.ReadAsStringAsync();

            return result;
        }

        public static async Task<string> GenerateFight(string heroName, string villainName, string setting, string winner)
        {
            var json = $"{{\"hero_name\":\"{heroName}\", \"villain_name\":\"{villainName}\", \"setting\":\"{setting}\", \"winner\":\"{winner}\"}}";
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://localhost:5000/generate-fight", content);
            var result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}

