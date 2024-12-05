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
    public class PedidosRepository : IPedidosRepository
    {
        private readonly DbContext _dbContext;

        public PedidosRepository()
        {
            _dbContext = new DbContext();
        }

        public void Add(Pedido pedido)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Pedido (Descripcion, Cantidad, Fecha_Solicitud, Fecha_Entrega, Enviarse_A)", connection);
                command.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                command.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                command.Parameters.AddWithValue("@Fecha_Solicitud", pedido.Fecha_solicitud);
                command.Parameters.AddWithValue("@Fecha_Entrega", pedido.Fecha_entrega);
                command.Parameters.AddWithValue("@Enviarse_A", pedido.Enviarse_A);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetaAll()
        {
            var pedido = new List<Pedido>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Pedido", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pedido.Add(new Pedido
                        {
                            Id_pedido = (int)reader["Id_Pedido"],
                            Id_cliente = (int)reader["Id_Cliente"],
                            Descripcion = reader["Descripcion"]?.ToString(),
                            Cantidad = (int)reader["Cantidad"],
                            Fecha_solicitud = (DateTime)reader["Fecha_Solitud"],
                            Fecha_entrega = (DateTime)reader["Fecha_Entrega"],
                            Enviarse_A = reader["Enviarse_A"]?.ToString()
                        });
                    }
                }
            }
            return pedido;
        }

        public Pedido GetById(int id)
        {
            Pedido pedido = new Pedido();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Pedido WHERE Id_Cliente = @Id_Cliente", connection);
                command.Parameters.AddWithValue("@Id_Cliente", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pedido = new Pedido
                        {
                            Id_pedido = (int)reader["Id_Pedido"],
                            Id_cliente = (int)reader["Id_Cliente"],
                            Descripcion = reader["Descripcion"]?.ToString(),
                            Cantidad = (int)reader["Cantidad"],
                            Fecha_solicitud = (DateTime)reader["Fecha_Solitud"],
                            Fecha_entrega = (DateTime)reader["Fecha_Entrega"],
                            Enviarse_A = reader["Enviarse_A"]?.ToString()
                        };
                    }
                }
            }
            return pedido;
        }

        public IEnumerable<Pedido> Search(string searchTerm)
        {
            var pedido = new List<Pedido>();
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
                            pedido.Add(new Pedido
                            {
                                Id_pedido = (int)reader["Id_Pedido"],
                                Id_cliente = (int)reader["Id_Cliente"],
                                Descripcion = reader["Descripcion"]?.ToString(),
                                Cantidad = (int)reader["Cantidad"],
                                Fecha_solicitud = (DateTime)reader["Fecha_Solitud"],
                                Fecha_entrega = (DateTime)reader["Fecha_Entrega"],
                                Enviarse_A = reader["Enviarse_A"]?.ToString()
                            });
                        }
                        while (reader.Read())
                        {
                            cliente.Add(new Cliente
                            {
                                Nombre_Cliente = reader["Nombre_Cliente"]?.ToString()
                            });
                        }
                    }
                }
                return pedido;   
            }
        }

        public void Update(Pedido pedido)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Pedido SET Descripcion = @Descripcion, Cantidad = @Cantidad, Fecha_Solicitud = @Fecha_Solicitud, Fecha_Entrega = @Fecha_Entrega, Enviarse_A = @Enviarse_A", connection);
                command.Parameters.AddWithValue("@Descripcion", pedido.Descripcion);
                command.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                command.Parameters.AddWithValue("@Fecha_Solicitud", pedido.Fecha_solicitud);
                command.Parameters.AddWithValue("@Fecha_Entrega", pedido.Fecha_entrega);
                command.Parameters.AddWithValue("@Enviarse_A", pedido.Enviarse_A);
                command.ExecuteNonQuery();
            }
        }
    }
}
