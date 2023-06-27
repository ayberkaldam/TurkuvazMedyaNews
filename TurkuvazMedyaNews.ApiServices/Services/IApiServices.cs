using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkuvazMedyaNews.ApiServices.Services
{
    public interface IApiServices<T> where T : class
    {
        Task<IEnumerable<T>> GetDataFromApi();
    }
}
