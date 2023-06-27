using AutoMapper;
using TurkuvazMedyaNews.Core.Models;
using TurkuvazMedyaNews.Core.DTOs;
using static TurkuvazMedyaNews.Core.Models.NewsVideos;

namespace TurkuvazMedyaNews.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Response, NewsDto>().ReverseMap();
            CreateMap<VideoResponse, VideosDto>().ReverseMap();
        }
    }
}
