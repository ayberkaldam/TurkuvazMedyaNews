using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkuvazMedyaNews.Core.Models;
using TurkuvazMedyaNews.Core.Repositories;
using TurkuvazMedyaNews.Core.Services;

namespace TurkuvazMedyaNews.Service.Services
{
    public class VideosService : IVideosService
    {
        private readonly IVideoRepository _repository;

        public VideosService(IVideoRepository repository)
        {
            _repository = repository;
        }
        public Task<List<NewsVideos.VideoResponse>> GetAllVideosAsync()
        {
            return _repository.GetAllVideosAsync();
        }
    }
}
