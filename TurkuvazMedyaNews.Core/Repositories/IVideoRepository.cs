using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TurkuvazMedyaNews.Core.Models.NewsVideos;

namespace TurkuvazMedyaNews.Core.Repositories
{
    public interface IVideoRepository
    {
        Task<List<VideoResponse>> GetAllVideosAsync();
    }
}
