using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiclient2.Models
{
    public partial class BookingSet
    {
        public int FlightNo { get; set; }
        public int PassengerId { get; set; }
        public double SalePrice { get; set; }

        public virtual FlightSet FlightNoNavigation { get; set; }
        public virtual PassengerSet Passenger { get; set; }

    }
}
