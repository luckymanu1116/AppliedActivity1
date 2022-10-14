using System;
using COVID19.Models;
using Newtonsoft.Json;

namespace COVID19.services
{
     class CovidDataStoreAPI : ICovidDataStore<Covid>
    {
        private static string API => "https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/total";
        public async Task<IEnumerable<Covid>> GetCovidAsync(int count)
        {
            var service = DependencyService.Get<IWebClientService>();
            var json = await service.GetAsync($"{API}?results={count}");

            var covid = CovidBuilder(json);

            return covid;
        }
        private List<Covid> CovidBuilder(string json)
        {

            var response = JsonConvert.DeserializeObject<dynamic>(json);
            var data = response.results;

            var Covid = new List<Covid>();

            foreach (var info in data)
            {
                var recovered = data.recovered.ToString();
                var deaths = data.deaths.ToString();
                var confirmed = data.confirmed.ToString();


                Covid.Add(new Covid(recovered, deaths, confirmed));

            }

            return Covid;
        }

        public static class UserBuilder
        {

        }
    }
}