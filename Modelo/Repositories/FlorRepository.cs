using Microsoft.Data.SqlClient;
using Modelo.Contexto;
using Modelo.Entidades;
using Modelo.Interfaces;
using System.Collections.Generic;

namespace Modelo.Repositories
{
    public class FlorRepository : IFlorRepository
    {
        private readonly DbContext _dbContext;

        public FlorRepository()
        {
            _dbContext = new DbContext();
        }

        public int Add(Flor flor)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Flor (Nombre_Flor) OUTPUT INSERTED.Id_Flor VALUES (@Nombre_Flor)", connection);
                command.Parameters.AddWithValue("@Nombre_Flor", flor.Nombre_Flor);
                return (int)command.ExecuteScalar(); // Retorna el ID recién insertado
            }
        }

        public int GetLastFlorId()
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT MAX(Id_Flor) FROM Flor", connection);
                var result = command.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) : 0; // Cambiado para manejar el caso de no registros
            }
        }
    }
}