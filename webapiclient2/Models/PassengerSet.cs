using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiclient2.Models
{
    public partial class PassengerSet
    {
        public PassengerSet()
        {
            BookingSet = new HashSet<BookingSet>();
        }
        public int PersonId { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public int Weight { get; set; } = 8;

        public virtual ICollection<BookingSet> BookingSet { get; set; }
    }
}
