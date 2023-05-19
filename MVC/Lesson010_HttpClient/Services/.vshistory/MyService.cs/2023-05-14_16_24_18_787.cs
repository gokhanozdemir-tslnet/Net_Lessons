using System.Text.Json;

namespace Lesson010_HttpClient.Services
{
    public class MyService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task Method()
        {
            using (HttpClient client = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://jsonplaceholder.typicode.com/todos/1"),
                    Method = HttpMethod.Get
                };

                HttpResponseMessage httpResponseMessage = await client.SendAsync(httpRequestMessage);
                Stream stream = httpResponseMessage.Content.ReadAsStream();
                StreamReader streamReader = new StreamReader(stream);
                string response = streamReader.ReadToEnd();

                Dictionary<string, object> responseDictionary =
                JsonSerializer.Deserialize<Dictionary<string, object>>(response);

                if (responseDictionary == null)
                {
                    throw new Exception("Service Error");
                }
                if (responseDictionary.ContainsKey("error")
                {
                    throw new InvalidOperationException((Convert.ToString(responseDictionary["error"])));

                }
            };
        }
    }
}
