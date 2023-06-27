using TurkuvazMedyaNews.Core.DTOs;
namespace TurkuvazMedyaNews.Web.Services
{
    public class VideosApiService
    {
        private readonly HttpClient _httpClient;

        public VideosApiService(HttpClient httpClient)
        {


            _httpClient = httpClient;
        }

        public async Task<List<VideosDto>> GetAllVideosAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<VideosDto>>("Videos/GetAllVideos");
            return response;
        }
    }
}
