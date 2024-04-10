using Newtonsoft.Json;
using System;
using System.Text;
using System.Text.Json.Serialization;

namespace API_Content
{
    internal class Program
    {
        static async Task Main()
        {
            await GetAsync("https://retoolapi.dev/Icdxi0/data");
        }

        static async Task PostAsync(string uri)
        {

        }

        static async Task GetAsync(string uri)
        {
            using (HttpClient client = new HttpClient())

            using(var r = await client.GetAsync(new Uri(uri)))
            {
                string result = await r.Content.ReadAsStringAsync();

                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(result);

                foreach (var customer in customers)
                {
                    Console.WriteLine($"The customer named {customer.Name} has an id {customer.Id}");
                }
            }
        }
    }
}