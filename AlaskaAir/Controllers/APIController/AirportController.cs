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
    public class AirportController : ApiController
    {
        private IDataAccess DataAccess;

        public AirportController()
        {
            DataAccess = WebConfigAccess.GetDataAccess();
        }

        [HttpGet]
        public JsonResult<IEnumerable<Airport>> Get(string airportCode = null)
        {
            try
            {
                if (string.IsNullOrEmpty(airportCode))
                {
                    var result = DataAccess.GetAirports();
                    return Json<IEnumerable<Airport>>(result.ToList());
                }
                else
                {
                    var result = DataAccess.GetAirports(airportCode);
                    return Json<IEnumerable<Airport>>(new List<Airport>() { result });
                }
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }
        }

    }
}
