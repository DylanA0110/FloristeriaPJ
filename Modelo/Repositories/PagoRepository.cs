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
    public class PagoRepository: IPagoRepository
    {
        private readonly DbContext _dbContext;

        public PagoRepository()
        {
            _dbContext = new DbContext();
        }

        public void Add(Pago pago)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Pago (Id_factura, Id_Tipo_Pago, Monto, Fecha_Pago) VALUES (@Id_factura, @Id_Tipo_Pago, @Monto, @Fecha_Pago)", connection);
                command.Parameters.AddWithValue("@Id_factura", pago.Id_factura);
                command.Parameters.AddWithValue("@Id_Tipo_Pago", pago.Id_Tipo_Pago);
                command.Parameters.AddWithValue("@Monto", pago.Monto);
                command.Parameters.AddWithValue("@Fecha_Pago", pago.Fecha_pago);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Pago WHERE Id_pago = @Id_pago", connection);
                command.Parameters.AddWithValue("@Id_pago", id);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Pago pago)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Pago SET Monto = @Monto, Fecha_pago = @Fecha_pago WHERE Id_pago = @Id_pago", connection);
                command.Parameters.AddWithValue("@Monto", pago.Monto);
                command.Parameters.AddWithValue("@Fecha_pago", pago.Fecha_pago);
                command.ExecuteNonQuery();
            }
        }
    }
}
