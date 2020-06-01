using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiclient2.Models;

namespace webapiclient2
{
    public partial class ApiClient
    {
        public async Task<PassengerSet> GetPassenger(string firstname, string lastname)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "PassengerSets/"+firstname+"/"+lastname));
            return await GetAsync<PassengerSet>(requestUrl);
        }
        public async Task<Message<PassengerSet>> PostPassengerSet(string firstname, string lastname)
        {
            PassengerSet passenger = new PassengerSet();
            passenger.Surname = firstname;
            passenger.GivenName = lastname;
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "PassengerSets/"));
            return await PostAsync<PassengerSet>(requestUrl, passenger);
        }
    }
}
