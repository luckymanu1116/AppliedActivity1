using System;
namespace COVID19.services
{
    interface  ICovidDataStore<T>
    {
        Task<IEnumerable<Models.Covid>> GetCovidAsync(int count);
    }
}

