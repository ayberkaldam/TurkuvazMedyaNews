using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TurkuvazMedyaNews.Web.Models;
using TurkuvazMedyaNews.Web.Services;

namespace TurkuvazMedyaNews.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsApiService _newsApiService;
        private readonly VideosApiService _videosApiService;

        public HomeController(NewsApiService newsApiService, VideosApiService videosApiService)
        {
            _newsApiService = newsApiService;
            _videosApiService = videosApiService;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel homeModel = new HomeViewModel();
            homeModel.News = await _newsApiService.GetAllNewsAsync();
            homeModel.Videos = await _videosApiService.GetAllVideosAsync();
            return View(homeModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}