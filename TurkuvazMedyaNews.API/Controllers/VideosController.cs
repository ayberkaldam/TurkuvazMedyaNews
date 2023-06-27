using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurkuvazMedyaNews.Core.DTOs;
using TurkuvazMedyaNews.Core.Services;

namespace TurkuvazMedyaNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IVideosService _videoservice;
        public VideosController(IVideosService videosService, IMapper mapper)
        {
            _mapper = mapper;
            _videoservice = videosService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllVideos()
        {
            var videos = await _videoservice.GetAllVideosAsync();
            var videoDto = _mapper.Map<List<VideosDto>>(videos);
            return Ok(videoDto);
        }
    }
}
