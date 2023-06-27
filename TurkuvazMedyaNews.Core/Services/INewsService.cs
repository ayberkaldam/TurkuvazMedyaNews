using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkuvazMedyaNews.Core.Models;

namespace TurkuvazMedyaNews.Core.Services
{
    public interface INewsService
    {
        Task<List<Response>> GetAllNewsAsync();
    }
}
