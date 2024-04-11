using Newtonsoft.Json;

namespace Joke
{
    public class Program
    {
        private static string uri = "https://v2.jokeapi.dev/joke/Any?safe-mode";
        public static AJoke joke = new AJoke();

        static async Task Main()
        {
            await GetAsync();
        }

        public static async Task GetAsync()
        {

            using (HttpClient client = new HttpClient())

            using (var r = await client.GetAsync(new Uri(uri)))
            {
                string result = await r.Content.ReadAsStringAsync();

                AJoke jsonObject = JsonConvert.DeserializeObject<AJoke>(result);

                Console.WriteLine($"Joke id: {jsonObject.Id}");
                Console.WriteLine($"Joke category: {jsonObject.Category}");

                if (jsonObject.Type == "twopart")
                {
                    Console.WriteLine($"{jsonObject.Setup}");
                    Console.WriteLine($"{jsonObject.Delivery}");
                }
                else
                {
                    Console.WriteLine($"{jsonObject.Joke}");
                }

            }



        }
    }
}