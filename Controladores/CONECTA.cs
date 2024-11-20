using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
//using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Controladores
{
    public class CONECTA
    {
        // Obtiene la conexión desde App.config
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BDFloristeria"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
