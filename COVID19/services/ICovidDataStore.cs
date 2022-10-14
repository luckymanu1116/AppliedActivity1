using COVID19.Models;
using COVID19.services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace COVID19.services
{
    interface  ICovidDataStore<T>
    {
        Task<IEnumerable<Models.Covid>> GetCovidAsync(int count);
    }
}

