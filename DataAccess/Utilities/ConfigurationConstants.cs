using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Utilities
{
    public static class ConfigurationConstants
    {
        public static readonly string CsvPathAirports = Convert.ToString(ConfigurationManager.AppSettings["CsvPathAirports"]);
        public static readonly bool CsvPathAirportsHasHeader = Convert.ToBoolean(ConfigurationManager.AppSettings["CsvPathAirportsHasHeader"]);
        public static readonly string CsvPathFlights = Convert.ToString(ConfigurationManager.AppSettings["CsvPathFlights"]);
        public static readonly bool CsvPathFlightsHasHeader = Convert.ToBoolean(ConfigurationManager.AppSettings["CsvPathFlightsHasHeader"]);
    }
}
