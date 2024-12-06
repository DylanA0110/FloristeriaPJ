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
    public class AccesorioRepository : IAccesorioRepository
    {
        private readonly DbContext _dbContext;

        public AccesorioRepository()
        {
            _dbContext = new DbContext();
        }

        public void Add(Accesorio accesorio)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Accesorio (Nombre_Accesorio)" +
                    " OUTPUT INSERTED.Id_Accesorio VALUES (@Nombre_Accesorio)", connection);
                command.Parameters.AddWithValue("@Nombre_Accesorio", accesorio.Nombre_Accesorio);


                // Asignar el ID de la compra a la entidad pasada
                accesorio.Id_Accesorio = (int)command.ExecuteScalar();
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
            var accesorio = new List<Accesorio>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Accesorio WHERE Nombre_Accesorio LIKE @searchTerm", connection);
                command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accesorio.Add(new Accesorio
                        {
                            Id_Accesorio = (int)reader["Id_Accesorio"],
                            Nombre_Accesorio = reader["Nombre_Accesorio"]?.ToString()
                        });
                    }
                }
            }
            return accesorio;
        }

        public void Update(Accesorio accesorio)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Accesorio SET Nombre_Accesorio = @Nombre_Accesorio WHERE Id_Accesorio = @Id_Accesorio", connection);
                command.Parameters.AddWithValue("@Nombre_Accesorio", accesorio.Nombre_Accesorio);
                command.ExecuteNonQuery();
            }
        }
    }

    
}
    

    

