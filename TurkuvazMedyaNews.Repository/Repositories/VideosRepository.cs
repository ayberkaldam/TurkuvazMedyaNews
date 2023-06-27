using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkuvazMedyaNews.Core.Models;
using TurkuvazMedyaNews.Core.Repositories;
using static TurkuvazMedyaNews.Core.Models.NewsVideos;

namespace TurkuvazMedyaNews.Repository.Repositories
{
    public class VideosRepository : IVideoRepository
    {
        public async Task<List<NewsVideos.VideoResponse>> GetAllVideosAsync()
        {
            var options = new RestClientOptions("https://api.tmgrup.com.tr")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/v1/link/424", Method.Get);
            var response = await client.ExecuteAsync(request);
            VideoRoot myDeserializedClass = JsonConvert.DeserializeObject<VideoRoot>(response.Content);
            if (myDeserializedClass == null || myDeserializedClass.meta.status_code != 200)
            {
                throw new Exception();
            }
            return myDeserializedClass.data.videos.Response;
        }

    }
}
