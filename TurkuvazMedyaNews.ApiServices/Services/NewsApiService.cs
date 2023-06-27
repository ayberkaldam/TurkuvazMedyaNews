using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkuvazMedyaNews.Core.Models;

namespace TurkuvazMedyaNews.ApiServices.Services
{
    public class NewsApiService : IApiServices<NewsList>
    {
        public async Task<IEnumerable<NewsList>> GetDataFromApi()
        {
            var options = new RestClientOptions("https://api.tmgrup.com.tr")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/v1/link/352", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Root news = JsonConvert.DeserializeObject<Root>(response.Content);
            if (news.meta.status_code == 200)
            {
                return news.data.news.newsList;
            }

            throw new NotImplementedException();
        }
    }
}
