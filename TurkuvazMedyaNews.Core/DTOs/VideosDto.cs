using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkuvazMedyaNews.Core.DTOs
{
    public class VideosDto
    {
        public string primaryImage { get; set; }
        public string secondaryImage { get; set; }
        public string VideoUrl { get; set; }
        public string OutputDate { get; set; }
        public string Title { get; set; }
        public string TitleShort { get; set; }
        public string Url { get; set; }
        public string Spot { get; set; }
    }
}
