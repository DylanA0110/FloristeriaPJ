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
    public class ProveedorRepository: IProveedoresRepository
    {
        private readonly DbContext _dbContext;

        public ProveedorRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Proveedor proveedor)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Proveedor (Nombre_Proveedor, Telefono) VALUES (@Nombre_Proveedor, @Telefono)", connection);
                command.Parameters.AddWithValue("@Nombre_Proveedor", proveedor.Nombre_Proveedor);
                command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Proveedor WHERE Id_Proveedor = @Id_Proveedor", connection);
                command.Parameters.AddWithValue("@Id_Proveedor", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Proveedor> GetAll()
        {
            var proveedor = new List<Proveedor>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Proveedor", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        proveedor.Add(new Proveedor
                        {
                            Id_Proveedor = (int)reader["Id_Proveedor"],
                            Telefono = reader["Telefono"]?.ToString(),
                            Nombre_Proveedor = reader["Nombre_Proveedor"]?.ToString(),
                        });
                    }
                }
            }
            return proveedor;
        }

        public Proveedor GetById(int id)
        {
            Proveedor proveedor = null;
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Proveedor WHERE Id_Proveedor = @Id_Proveedor", connection);
                command.Parameters.AddWithValue("@Id_Proveedor", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        proveedor = new Proveedor
                        {
                            Id_Proveedor = (int)reader["Id_Proveedor"],
                            Telefono = reader["Telefono"]?.ToString(),
                            Nombre_Proveedor = reader["Nombre_Proveedor"]?.ToString(),
                        };
                    }
                }
            }
            return proveedor;
        }

        public IEnumerable<Proveedor> Search(string searchTerm)
        {
            var proveedor = new List<Proveedor>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("BuscarProveedor", connection);
                command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        proveedor.Add(new Proveedor
                        {
                            Id_Proveedor = (int)reader["Id_Proveedor"],
                            Telefono = reader["Telefono"]?.ToString(),
                            Nombre_Proveedor = reader["Nombre_Proveedor"]?.ToString(),
                        });
                    }
                }
                return proveedor;
            }
         
        }

        public void Update(Proveedor proveedor)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Proveedor SET Nombre_Proveedor = @Nombre_Proveedor, Telefono = @Telefono", connection);
                command.Parameters.AddWithValue("@Nombre_Proveedor", proveedor.Nombre_Proveedor);
                command.Parameters.AddWithValue("@Telefonno", proveedor.Telefono);
                command.ExecuteNonQuery();
            }
        }
    }
}
