using Azure;
using Microsoft.Data.SqlClient;
using Modelo.Contexto;
using Modelo.Entidades;
using Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositories
{
    public class FacturaRepository : IFacturaRepository
    {
       private readonly DbContext _dbContext;

       public FacturaRepository() 
        {
            _dbContext = new DbContext();
        }
      

        public void Add(Facturas factura)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Factura (Id_pedido ,Monto_Total, NumFactura) VALUES (@Id_pedido, @Monto_Total, @NumFactura)", connection);
                command.Parameters.AddWithValue("@Id_pedido", factura.Id_pedido);
                command.Parameters.AddWithValue("@Monto_Total", factura.Monto_total);
                command.Parameters.AddWithValue("@NumFactura", factura.NumFactura);
                command.ExecuteNonQuery();
            }
        }



        public void Delete(int id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Factura WHERE Id_factura = @Id_factura", connection);
                command.Parameters.AddWithValue("@Id_factura", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Facturas> GetAll()
        {
            var factura = new List<Facturas>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Factura", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        factura.Add(new Facturas
                        {
                            // Verifica si el valor es DBNull antes de realizar el cast
                            Id_factura = reader["Id_factura"] != DBNull.Value ? (int)reader["Id_factura"] : 0, // O un valor por defecto
                            Id_Empleado = reader["Id_Empleado"] != DBNull.Value ? (int)reader["Id_Empleado"] : 0, // O un valor por defecto
                            Id_pedido = reader["Id_pedido"] != DBNull.Value ? (int)reader["Id_pedido"] : 0, // O un valor por defecto
                            Monto_total = reader["Monto_Total"] != DBNull.Value ? (decimal)reader["Monto_Total"] : 0m, // Cambiado a decimal
                            Estado = reader["Estado"] != DBNull.Value && (bool)reader["Estado"], // Para booleanos, se verifica DBNull
                            NumFactura = reader["NumFactura"] != DBNull.Value ? (int)reader["NumFactura"] : 0 // O un valor por defecto
                        });

                    }
                }
            }
            return factura;
        }

        public Facturas GetById(int id)
        {
            Facturas factura = new Facturas();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Factura WHERE Id_factura = @Id_factura", connection);
                command.Parameters.AddWithValue("@Id_factura", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        factura = new Facturas
                        {
                            Id_factura = (int)reader["Id_factura"],
                            Id_Empleado = (int)reader["Id_Empleado"],
                            Id_pedido = (int)reader["Id_pedido"],
                            Monto_total = (int)reader["Monto_Total"],
                            Estado = reader["Estado"] != DBNull.Value && (bool)reader["Estado"],
                            NumFactura = (int)reader["NumFactura"]
                        };
                    }
                }
            }
            return factura;
        }



        public IEnumerable<Facturas> Search(string searchTerm)
        {
            var factura = new List<Facturas>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM Factura WHERE NumFactura LIKE @searchTerm", connection))
                {

                    command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            factura.Add(new Facturas
                            {
                                Id_factura = (int)reader["Id_factura"],
                                Id_Empleado = (int)reader["Id_Empleado"],
                                Id_pedido = (int)reader["Id_pedido"],
                                Monto_total = (int)reader["Monto_Total"],
                                Estado = reader["Estado"] != DBNull.Value && (bool)reader["Estado"],
                                NumFactura = (int)reader["NumFactura"]
                            });
                        }
                    }
                }
                return factura;
            }
        }

        public void Update(Facturas factura)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Factura SET Monto_Total = @Monto_Total, Estado = @Estado, NumFactura = @NumFactura WHERE Id_factura = @Id_factura", connection);
                command.Parameters.AddWithValue("@Monto_total", factura.Monto_total);
                command.Parameters.AddWithValue("@Estado", factura.Estado);
                command.Parameters.AddWithValue("@NumFactura", factura.NumFactura);
                command.ExecuteNonQuery();
            }
        }
    }
}
