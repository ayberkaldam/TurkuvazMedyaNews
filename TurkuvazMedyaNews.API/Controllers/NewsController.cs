using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurkuvazMedyaNews.Core.DTOs;
using TurkuvazMedyaNews.Core.Services;

namespace TurkuvazMedyaNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly INewsService _newsService;
        public NewsController(INewsService newsService, IMapper mapper)
        {
            _mapper = mapper;
            _newsService = newsService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllNews()
        {
            var news = await _newsService.GetAllNewsAsync();
            var newsDto = _mapper.Map<List<NewsDto>>(news);
            return Ok(newsDto);
        }

    }
}
