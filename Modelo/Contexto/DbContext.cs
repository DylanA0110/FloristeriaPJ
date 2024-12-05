using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Modelo.Contexto
{
    public class DbContext
    {
        private readonly string _connectionString;

        public DbContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["BDFloristeria"].ConnectionString;
        }


        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString); // No abrir aquí
        }

    }
}
