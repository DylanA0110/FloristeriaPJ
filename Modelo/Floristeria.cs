using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using NLog.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{

    public class FloristeriaModel
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["FloristeriaDB"].ConnectionString;
        }

        public void AgregarCliente(string nombre, string telefono, string correo)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                string query = "INSERT INTO Clientes (Nombre, Telefono, Correo) VALUES (@Nombre, @Telefono, @Correo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Correo", correo);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public SqlDataReader ObtenerClientes()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());
            string query = "SELECT * FROM Clientes";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            return command.ExecuteReader(); // Recuerda cerrar la conexión después de consumir el lector
        }
    }
}
