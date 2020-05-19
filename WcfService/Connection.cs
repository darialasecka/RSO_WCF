using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class Connection
    {
        public string StartCity { get; set; }
        public string EndCity { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }

        public Connection (string startCity, DateTime departure, string endCity, DateTime arrival) {
            StartCity = startCity;
            EndCity = endCity;
            Departure = departure;
            Arrival = arrival;
        }

        public override string ToString()
        {
            string departure = Departure.ToString();
            string arrival = Arrival.ToString();

            return StartCity + " [" + departure + "] --> " + EndCity + " [" + arrival + "]";
        }


    }
}