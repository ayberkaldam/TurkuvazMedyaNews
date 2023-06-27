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
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;

        public NewsService(INewsRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Response>> GetAllNewsAsync()
        {
            return await _repository.GetAllNewsAsync();
        }
    }
}
