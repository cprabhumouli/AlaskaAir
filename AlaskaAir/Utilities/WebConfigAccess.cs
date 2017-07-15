using DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using DataAccess.Interfaces;

namespace AlaskaAir.Utilities
{
    public class WebConfigAccess
    {
        public static IDataAccess GetDataAccess()
        {
            var da = ConfigurationManager.AppSettings["DataAccess"];

            switch (da)
            {
                case "csv":
                    return new CsvDataManager();
                default:
                    throw new Exception("Data Source is not configured or exist");
            }
        }
    }
}