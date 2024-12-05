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

        public void Add(Factura factura)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Factura (Id_pedido,Monto_Total, Estado, NumFactura)", connection);
                command.Parameters.AddWithValue("@Id_pedido", factura.Id_pedido);               
                command.Parameters.AddWithValue("@Monto_Total", factura.Monto_total);
                command.Parameters.AddWithValue("@Estado", factura.Estado);
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

        public IEnumerable<Factura> GetAll()
        {
            var factura = new List<Factura>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Factura", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        factura.Add(new Factura
                        {
                           Id_factura = (int)reader["Id_factura"],
                           Id_Empleado= (int)reader["Id_Empleado"],
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

        public Factura GetById(int id)
        {
            Factura factura = new Factura();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Factura WHERE Id_factura = @Id_factura", connection);
                command.Parameters.AddWithValue("@Id_factura", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        factura = new Factura
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

        public IEnumerable<Factura> Search(string searchTerm)
        {
            var factura = new List<Factura>();
            var cliente = new List<Cliente>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("BuscarPedido", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CondicionPedidos", searchTerm);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            factura.Add(new Factura
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

        public void Update(Factura factura)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Factura SET Monto_Total = @Monto_Total, Estado = @Estado, NumFactura = @NumFactura", connection);
                command.Parameters.AddWithValue("@Monto_total", factura.Monto_total);
                command.Parameters.AddWithValue("@Estado", factura.Estado);
                command.Parameters.AddWithValue("@NumFactura", factura.NumFactura);
                command.ExecuteNonQuery();    
            }
        }
    }
}
