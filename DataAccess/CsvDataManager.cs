using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Model;
using System.IO;
using CsvHelper;
using DataAccess.Utilities;

namespace DataAccess
{
    public class CsvDataManager : IDataAccess
    {

        #region Constructor
        public CsvDataManager()
        {

        }
        #endregion

        #region Implementations

        public IEnumerable<Airport> GetAirports()
        {
            List<Airport> _airports = new List<Airport>();
            try
            {
                using (var streamReader = new StreamReader("C:\\Repository\\AlaskaAir\\DataAccess\\DataSource\\csv\\airports.csv"))
                //using (var streamReader = new StreamReader(ConfigurationConstants.CsvPathAirports))
                {

                    var reader = new CsvReader(streamReader);

                    reader.Configuration.HasHeaderRecord = true;
                    //csv.Configuration.HasHeaderRecord = ConfigurationConstants.CsvPathAirportsHasHeader;

                    _airports = reader.GetRecords<Airport>().ToList();
                }
            }
            catch (Exception ex)
            {
                //log
            }
            return _airports;
        }

        public Airport GetAirports(string airportCode)
        {
            return GetAirports().ToList().Where(a => String.Equals(a.Code, airportCode, StringComparison.CurrentCultureIgnoreCase)).SingleOrDefault();
        }

        public IEnumerable<Flight> GetFlights()
        {
            List<Flight> _flights = new List<Flight>();
            try
            {
                using (var streamReader = new StreamReader("C:\\Repository\\AlaskaAir\\DataAccess\\DataSource\\csv\\flights.csv"))
                //using (var streamReader = new StreamReader(ConfigurationConstants.CsvPathFlights))
                {

                    var reader = new CsvReader(streamReader);

                    reader.Configuration.HasHeaderRecord = true;
                    //csv.Configuration.HasHeaderRecord = ConfigurationConstants.CsvPathFlightsHasHeader;

                    _flights = reader.GetRecords<Flight>().ToList();
                }
            }
            catch (Exception ex)
            {
                //log
            }
            return _flights;
        }

        public IEnumerable<Flight> GetFlightsBySelection(string from, string to)
        {
            return GetFlights().Where(f => String.Equals(f.From, from, StringComparison.CurrentCultureIgnoreCase) && String.Equals(f.To, to, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        #endregion

    }
}
