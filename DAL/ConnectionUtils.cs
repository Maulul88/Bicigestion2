using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectionUtils
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BiciGestionConnStr"].ConnectionString;
        }
    }
}
