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
    public class FlorRepository: IFlorRepository
    {
        private readonly DbContext _dbContext;

        public FlorRepository()
        {
            _dbContext = new DbContext();   
        }

        public void Add(Flor flor)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Flor (Nombre_flor)" +
                    " OUTPUT INSERTED.Id_flor VALUES (@Nombre_Accesorio)", connection);
                command.Parameters.AddWithValue("@Nombre_Flor", flor.Nombre_Flor);


                // Asignar el ID de la compra a la entidad pasada
                flor.Id_flor = (int)command.ExecuteScalar();
            }
        }

        public IEnumerable<Flor> GetAll()
        {
            var flor = new List<Flor>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Flor", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flor.Add(new Flor
                        {
                            Id_flor = (int)reader["Id_flor"],
                            Nombre_Flor = reader["Nombre_Flor"]?.ToString()
                        });
                    }
                }
            }
            return flor;
        }

        public Flor GetById(int id)
        {
            Flor flor = new Flor();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Flor WHERE Id_flor = @Id_flor", connection);
                command.Parameters.AddWithValue("@Id_flor", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        flor = new Flor
                        {
                            Id_flor = (int)reader["Id_flor"],
                            Nombre_Flor = reader["Nombre_Flor"]?.ToString()
                        };
                    }
                }
            }
            return flor;
        }

        public int GetLastFlorId()
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT MAX(Id_flor) FROM Flor", connection);
                var result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0; // Devuelve 0 si no hay registros
            }
        }

        public IEnumerable<Flor> Search(string searchTerm)
        {
            var flor = new List<Flor>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Flor WHERE Nombre_Flor LIKE @searchTerm", connection);
                command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flor.Add(new Flor
                        {
                            Id_flor = (int)reader["Id_flor"],
                            Nombre_Flor = reader["Nombre_Flor"]?.ToString()
                        });
                    }
                }
            }
            return flor;
        }

        public void Update(Flor flor)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Flor SET Nombre_Flor = @Nombre_Flor WHERE Id_flor = @Id_flor", connection);
                command.Parameters.AddWithValue("@Nombre_Flor", flor.Nombre_Flor);
                command.ExecuteNonQuery();
            }
        }
    }
}
