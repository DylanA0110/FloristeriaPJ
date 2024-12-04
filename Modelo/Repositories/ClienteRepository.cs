using Microsoft.Data.SqlClient;
using Modelo.Contexto;
using Modelo.Dto;
using Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DbContext _dbContext;

        public ClienteRepository()
        {
            _dbContext = new DbContext();
        }

        public IEnumerable<Cliente> GetAll()
        {
            var clientes = new List<Cliente>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Cliente", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Cliente
                        {
                            Id_cliente = (int)reader["Id_cliente"],
                            Telefono = reader["Telefono"]?.ToString(),
                            Nombre_Cliente = reader["Nombre_Cliente"]?.ToString(),
                        });
                    }
                }
            }
            return clientes;
        }

        public Cliente GetById(int id)
        {
            Cliente cliente = null;
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Cliente WHERE Id_cliente = @Id_cliente", connection);
                command.Parameters.AddWithValue("@Id_cliente", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente
                        {
                            Id_cliente = (int)reader["Id_cliente"],
                            Telefono = reader["Telefono"]?.ToString(),
                            Nombre_Cliente = reader["Nombre_Cliente"]?.ToString(),
                        };
                    }
                }
            }
            return cliente;
        }

        public void Add(Cliente cliente)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Cliente (Telefono, Nombre_Cliente) VALUES (@Telefono, @Nombre_Cliente)", connection);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Nombre_Cliente", cliente.Nombre_Cliente);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Cliente cliente)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Cliente SET Telefono = @Telefono, Nombre_Cliente = @Nombre_Cliente WHERE Id_cliente = @Id_cliente", connection);
                command.Parameters.AddWithValue("@Id_cliente", cliente.Id_cliente);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Nombre_Cliente", cliente.Nombre_Cliente);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Cliente WHERE Id_cliente = @Id_cliente", connection);
                command.Parameters.AddWithValue("@Id_cliente", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Cliente> Search(string searchTerm)
        {
            var clientes = new List<Cliente>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Cliente WHERE Nombre_Cliente LIKE @searchTerm OR Telefono LIKE @searchTerm", connection);
                command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientes.Add(new Cliente
                        {
                            Id_cliente = (int)reader["Id_cliente"],
                            Telefono = reader["Telefono"]?.ToString(),
                            Nombre_Cliente = reader["Nombre_Cliente"]?.ToString(),
                        });
                    }
                }
            }
            return clientes;
        }
    }
}