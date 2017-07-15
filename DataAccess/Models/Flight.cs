using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Flight
    {
        public string From { get; set; }

        public string To { get; set; }

        public int FlightNumber { get; set; }

        public DateTime Departs { get; set; }

        public DateTime Arrives { get; set; }

        public decimal MainCabinPrice { get; set; }

        public decimal FirstClassPrice{ get; set; }

    }
}
