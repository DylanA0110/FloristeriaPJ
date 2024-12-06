using Microsoft.Data.SqlClient;
using Modelo.Contexto;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IFacturaRepository
    {
        IEnumerable<Facturas> GetAll();
        Facturas GetById(int id);
        void Add(Facturas factura);
        void Update(Facturas factura);
        void Delete(int id);
        IEnumerable<Facturas> Search(string searchTerm);

        public IEnumerable<Facturas> GetAllWithPago()
        {
            var dbContext = new DbContext();
            var facturas = new List<Facturas>();

            using (var connection = dbContext.GetConnection())
            {
                connection.Open();
                var query = @"
        SELECT 
            f.Id_factura, 
            f.Id_pedido, 
            f.Monto_total, 
            f.Estado, 
            f.Id_Empleado, 
            f.NumFactura, 
            p.Monto AS MontoPago,
            tp.Tipo AS TipoDePago,
            p.Fecha_pago AS FechaPago
        FROM Factura f
        LEFT JOIN Pago p ON f.Id_factura = p.Id_factura
        LEFT JOIN TipoDePago tp ON p.Id_Tipo_Pago = tp.Id_Tipo_pago";

                var command = new SqlCommand(query, connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        facturas.Add(new Facturas
                        {
                            Id_factura = reader["Id_factura"] != DBNull.Value ? (int)reader["Id_factura"] : 0, // Default value if null
                            Id_pedido = reader["Id_pedido"] != DBNull.Value ? (int)reader["Id_pedido"] : 0,
                            Monto_total = reader["Monto_total"] != DBNull.Value ? (decimal)reader["Monto_total"] : 0,
                            Estado = reader["Estado"] != DBNull.Value && (bool)reader["Estado"],
                            Id_Empleado = reader["Id_Empleado"] != DBNull.Value ? (int?)reader["Id_Empleado"] : null,
                            NumFactura = reader["NumFactura"] != DBNull.Value ? (int)reader["NumFactura"] : 0,
                            TipoDePago = reader["TipoDePago"] != DBNull.Value ? reader["TipoDePago"].ToString() : null,
                            MontoPago = reader["MontoPago"] as decimal?, // Asignar el monto de pago
                            FechaPago = reader["FechaPago"] != DBNull.Value ? (DateTime)reader["FechaPago"] : DateTime.MinValue // Asignar la fecha de pago
                        });
                    }
                }
            }

            return facturas;
        }
    }
}