using Microsoft.Data.SqlClient;
using Modelo.Contexto;
using Modelo.Entidades;
using Modelo.Interfaces;
using System.Collections.Generic;

namespace Modelo.Repositories
{
    public class AccesorioRepository : IAccesorioRepository
    {
        private readonly DbContext _dbContext;

        public AccesorioRepository()
        {
            _dbContext = new DbContext();
        }

        public int Add(Accesorio accesorio)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Accesorio (Nombre_Accesorio) OUTPUT INSERTED.Id_Accesorio VALUES (@Nombre_Accesorio)", connection);
                command.Parameters.AddWithValue("@Nombre_Accesorio", accesorio.Nombre_Accesorio);
                return (int)command.ExecuteScalar(); // Retorna el ID recién insertado
            }
        }

        public IEnumerable<Accesorio> GetAll()
        {
            var accesorio = new List<Accesorio>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Accesorio", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accesorio.Add(new Accesorio
                        {
                            
                            Id_Accesorio = (int)reader["Id_Accesorio"], 
                            Id_Arreglo = (int)reader["Id_Arreglo"],
                            Nombre_Accesorio = reader["Nombre_Accesorio"]?.ToString()
                        });
                    }
                }
            }
            return accesorio;
        }

        public Accesorio GetById(int id)
        {
            Accesorio accesorio = new Accesorio();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Accesorio WHERE Id_Accesorio = @Id_Accesorio", connection);
                command.Parameters.AddWithValue("@Id_Accesorio", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        accesorio = new Accesorio
                        {
                            Id_Accesorio = (int)reader["Id_Accesorio"],
                            Id_Arreglo = (int)reader["Id_Arreglo"],
                            Nombre_Accesorio = reader["Nombre_Accesorio"]?.ToString()
                        };
                    }
                }
            }
            return accesorio;
        }

        public int GetLastAccesorioId()
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT MAX(Id_Accesorio) FROM Accesorio", connection);
                var result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0; // Devuelve 0 si no hay registros
            }
        }

        public IEnumerable<Accesorio> Search(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public void Update(Accesorio accesorio)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Accesorio SET Nombre_Accesorio = @Nombre_Accesorio, WHERE Id_Accesorio = @Id_Accesorio", connection);
                command.Parameters.AddWithValue("@Nombre_Accesorio", accesorio.Nombre_Accesorio);
                command.ExecuteNonQuery();
            }
        }
    }
}