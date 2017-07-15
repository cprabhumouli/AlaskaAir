using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DataAccess.Tests
{
    [TestClass]
    public class CsvDataManager_Test
    {
        [TestMethod]
        public void GetAirports_GetRecords_True()
        {
            CsvDataManager csvDataManager = new CsvDataManager();
            var airports = csvDataManager.GetAirports();
            Assert.IsTrue((airports.ToList().Count > 0));
        }

        [TestMethod]
        public void GetAirport_GetRecords_Pass()
        {
            CsvDataManager csvDataManager = new CsvDataManager();
            var airports = csvDataManager.GetAirports("SEA");
            Assert.AreEqual("Seattle WA (SEA-Seattle/Tacoma Intl.)".Trim(), airports.Name.Trim());
        }

        [TestMethod]
        public void GetFlights_GetRecords_True()
        {
            CsvDataManager csvDataManager = new CsvDataManager();
            var flights = csvDataManager.GetFlights();
            Assert.IsTrue((flights.ToList().Count > 0));
        }

        [TestMethod]
        public void GetFlightsBySelection_GetRecords_Pass()
        {
            CsvDataManager csvDataManager = new CsvDataManager();
            var flights = csvDataManager.GetFlightsBySelection("SEA","PHX");
            Assert.IsTrue((flights.ToList().Count == 4));
        }
    }
}
