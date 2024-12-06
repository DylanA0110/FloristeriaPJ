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
    public class TipoDePagoRepository : ITipoPagoRepository
    {
        private readonly DbContext _dbContext;

        public TipoDePagoRepository()
        {
            _dbContext = new DbContext();
        }


        public void Add(TipoDePago TipoPago)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO TipoDePago (Tipo) VALUES (@Tipo)", connection);
                command.Parameters.AddWithValue("@Tipo", TipoPago.Tipo);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM TipoDePago WHERE Id_Tipo_pago = @Id_Tipo_pago", connection);
                command.Parameters.AddWithValue("@Id_Tipo_pago", id);
                command.ExecuteNonQuery();
            }
        }

        public void Update(TipoDePago TipoPago)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE TipoDePago SET Tipo WHERE Id_Tipo_pago = @Id_Tipo_pago", connection);
                command.Parameters.AddWithValue("@Tipo", TipoPago.Tipo);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TipoDePago> GetAll()
        {
            var tiposDePago = new List<TipoDePago>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM TipoDePago", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposDePago.Add(new TipoDePago
                        {
                            Id_Tipo_pago = (int)reader["Id_Tipo_pago"],
                            Tipo = reader["Tipo"].ToString()
                        });
                    }
                }
            }
            return tiposDePago;
        }



    }
}
