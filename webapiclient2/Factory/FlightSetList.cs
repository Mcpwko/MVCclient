using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiclient2.Models;

namespace webapiclient2
{
    public partial class ApiClient
    {
        public async Task<List<FlightSet>> GetFlightSetItems()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "FlightSets/"));
            return await GetAsync<List<FlightSet>>(requestUrl);
        }

        public async Task<List<FlightSet>> GetAvailableFlightSetItems()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
               "FlightSets/Available"));
            return await GetAsync<List<FlightSet>>(requestUrl);
        }

        public async Task<FlightSet> GetFlightSet(int id)
        {
            string urWithlId = "FlightSets/" + id;
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                urWithlId));
            return await GetAsync<FlightSet>(requestUrl);
        }
    }
}
