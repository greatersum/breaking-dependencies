using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BreakingDependencies
{
    public class PlaceCaller
    {
        private HttpClient httpClient;

        public PlaceCaller()
        {
            httpClient = new HttpClient();
        }

        public string CountryInfo(string countryCode)
        {
            return
                httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get,
                        $"http://api.geonames.org/countryInfoJSON?formatted=true&lang=en&country={countryCode}&username=demo&style=full"))
                    .Result.Content.ReadAsStringAsync().Result;
        }
    }

}
