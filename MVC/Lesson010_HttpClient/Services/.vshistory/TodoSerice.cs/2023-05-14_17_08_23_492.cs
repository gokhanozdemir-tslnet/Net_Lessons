using Lesson010_HttpClient.Models;
using Lesson010_HttpClient.SericeContracts;
using System.Text.Json;

namespace Lesson010_HttpClient.Services
{
    public class TodoSerice : ITodoService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TodoSerice(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }




        public async Task<Dictionary<string, object>> GetTodos()
        {
            using (HttpClient client = _httpClientFactory.CreateClient())
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://jsonplaceholder.typicode.com/todos"),
                    Method = HttpMethod.Get
                };

                HttpResponseMessage httpResponseMessage = await client.SendAsync(httpRequestMessage);
                Stream stream = httpResponseMessage.Content.ReadAsStream();
                StreamReader streamReader = new StreamReader(stream);
                string response = streamReader.ReadToEnd();

                Dictionary<string, object> responseDictionary =
                JsonSerializer.Deserialize<List<Todo>>(response);

                if (responseDictionary == null)
                {
                    throw new Exception("Service Error");
                }
                if (responseDictionary.ContainsKey("error"))
                {
                    throw new InvalidOperationException((Convert.ToString(responseDictionary["error"])));

                }
                return responseDictionary;
            };
        }
    }
}
