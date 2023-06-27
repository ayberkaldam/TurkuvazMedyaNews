using TurkuvazMedyaNews.Core.DTOs;

namespace TurkuvazMedyaNews.Web.Models
{
    public class HomeViewModel
    {
        public List<VideosDto> Videos { get; set; }
        public List<NewsDto> News { get; set; }

        public HomeViewModel()
        {
            Videos = new List<VideosDto>();
            News = new List<NewsDto>();
        }
    }
}
