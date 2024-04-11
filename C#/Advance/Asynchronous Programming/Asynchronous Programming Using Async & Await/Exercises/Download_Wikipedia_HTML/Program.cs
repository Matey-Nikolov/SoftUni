namespace Download_Wikipedia_HTML
{
    public class Program
    {
        private static string url = "https://developer.wikimedia.org";

        static async Task Main()
        {
            await GetHTMLAsync();
        }

        public static async Task GetHTMLAsync()
        {
            using (HttpClient client = new HttpClient())

            using (var request = await client.GetAsync(new Uri(url)))
            {
                var resultHTML = await request.Content.ReadAsStringAsync();

                Console.WriteLine(resultHTML);
            }
        }
    }
}