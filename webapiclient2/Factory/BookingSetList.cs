using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiclient2.Models;

namespace webapiclient2
{
    public partial class ApiClient
    {
        public async Task<List<BookingSet>> GetBookings()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "BookingSets/"));
            return await GetAsync<List<BookingSet>>(requestUrl);
        }
        public async Task<BookingSet> GetBookingSet(int id)
        {
            string urWithlId = "BookingSets/" + id;
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                urWithlId));
            return await GetAsync<BookingSet>(requestUrl);
        }

        public async Task<Message<BookingSet>> CreateBooking(int flightNo, int persId, double salesPrice)
        {
            BookingSet bookingSet = new BookingSet();
            bookingSet.FlightNo = flightNo;
            bookingSet.PassengerId = persId;
            bookingSet.SalePrice = salesPrice;
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                "BookingSets/"));
            return await PostAsync<BookingSet>(requestUrl, bookingSet);
        }
    }
}
