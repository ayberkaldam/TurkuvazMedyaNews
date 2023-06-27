using Newtonsoft.Json;
using RestSharp;
using TurkuvazMedyaNews.Core.Models;
using TurkuvazMedyaNews.Core.Repositories;

namespace TurkuvazMedyaNews.Repository.Repositories
{
    public class NewsRepository : INewsRepository
    {
        public async Task<List<Response>> GetAllNewsAsync()
        {
            var options = new RestClientOptions("https://api.tmgrup.com.tr")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/v1/link/352", Method.Get);
            var response = await client.ExecuteAsync(request);
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response.Content);
            if(myDeserializedClass == null || myDeserializedClass.meta.status_code!=200)
            {
                throw new Exception();
            }
            return myDeserializedClass.data.articles.Response;
        }

    }
}
