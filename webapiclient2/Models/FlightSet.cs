using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapiclient2.Models
{
    public class FlightSet
    {
        public int FlightNo { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public short Seats { get; set; }
        public double Price { get; set; }
        public int PilotId { get; set; }
    }
}
