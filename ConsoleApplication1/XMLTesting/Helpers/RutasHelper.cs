using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLTesting.Helpers
{
    public static class RutasHelper
    {
        public static string RutaTareas()
        {
            return ConfigurationManager.AppSettings["RutaTareas"];
        }
    }
}
