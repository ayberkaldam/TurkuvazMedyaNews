using TurkuvazMedyaNews.Core.DTOs;
namespace TurkuvazMedyaNews.Web.Services
{
    public class NewsApiService
    {
        private readonly HttpClient _httpClient;

        public NewsApiService(HttpClient httpClient)
        {


            _httpClient = httpClient;
        }

        public async Task<List<NewsDto>> GetAllNewsAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<NewsDto>>("News/GetAllNews");
            return response;
        }
    }
}
