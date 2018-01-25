using System;

namespace REST_JSON_git
{
    class Program
    {
        static void Main(string[] args)
        {
            //fetch data (as JSON string)
            var url = new Uri("http://localhost:1234/MyService.svc/json/4");
            var client = new System.Net.WebClient();
            var json = await client.DownloadStringTaskAsync(url);

            //deserialize JSON into objects jjjjjjjj
            var serializer = new JavaScriptSerializer();
            var data = serializer.Deserialize<JSONSAMPLE.Data>(json);

            //use the objects
            Console.WriteLine(data.Numbre);
            foreach (var item in data.Multiples)
                Console.WriteLine("{0}, ", item);
        }
    }
}
