using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkuvazMedyaNews.Core.Models;

namespace TurkuvazMedyaNews.Core.Repositories
{
    public interface INewsRepository
    {
        Task<List<Response>> GetAllNewsAsync();
    }
}
