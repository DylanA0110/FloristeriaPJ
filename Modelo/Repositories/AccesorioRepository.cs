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
    }
}