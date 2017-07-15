using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IDataAccess
    {

        IEnumerable<Airport> GetAirports();

        IEnumerable<Flight> GetFlights();

        Airport GetAirports(string airportCode);

        IEnumerable<Flight> GetFlightsBySelection(string from, string to);


    }
}
