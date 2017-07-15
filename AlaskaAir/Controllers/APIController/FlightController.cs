using AlaskaAir.Utilities;
using DataAccess.Interfaces;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace AlaskaAir.Controllers.APIController
{
    public class FlightController : ApiController
    {
        private IDataAccess DataAccess;

        public FlightController()
        {
            DataAccess = WebConfigAccess.GetDataAccess();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var result = DataAccess.GetFlights();

                return Json<IEnumerable<Flight>>(result);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }
        }

        [HttpGet]
        public IHttpActionResult Get(string from, string to)
        {
            try
            {
                var result = DataAccess.GetFlightsBySelection(from, to);

                return Json<IEnumerable<Flight>>(result);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }
        }
    }
}
