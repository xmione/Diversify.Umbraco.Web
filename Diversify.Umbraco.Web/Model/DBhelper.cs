using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Diversify.Umbraco.Web.Model
{
    public class DBHelper
    {
        private string _connectionString;
        public DBHelper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DiversifyDB"].ConnectionString;
        }


    }
}