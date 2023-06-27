using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TurkuvazMedyaNews.Core.Models.NewsVideos;

namespace TurkuvazMedyaNews.Core.Services
{
    public interface IVideosService
    {
        Task<List<VideoResponse>> GetAllVideosAsync();
    }
}
