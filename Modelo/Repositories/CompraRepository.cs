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
    public class CompraRepository : ICompraRepository
    {
        private readonly DbContext _dbContext;

        public CompraRepository()
        {
            _dbContext = new DbContext();
        }

        public void Add(Compra compra)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Compra (Cantidad, FechaCompra, Precio_Unitario) OUTPUT INSERTED.Id_Compra VALUES (@Cantidad, @FechaCompra, @Precio_Unitario)", connection);
                command.Parameters.AddWithValue("@Cantidad", compra.Cantidad);
                command.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                command.Parameters.AddWithValue("@Precio_Unitario", compra.Precio_Unitario);

                // Asignar el ID de la compra a la entidad pasada
                compra.Id_Compra = (int)command.ExecuteScalar();
            }
        }
        public void AddDetalleCompra(Detalle_Compra detalleCompra)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Detalle_Compra (Id_Compra, Id_Proveedor, Id_Flor, Id_Accesorio) VALUES (@IdCompra, @IdProveedor, @IdFlor, @IdAccesorio)", connection);
                command.Parameters.AddWithValue("@IdCompra", detalleCompra.Id_Compra);
                command.Parameters.AddWithValue("@IdProveedor", detalleCompra.Id_Proveedor);
                command.Parameters.AddWithValue("@IdFlor", (object)detalleCompra.Id_Flor ?? DBNull.Value);
                command.Parameters.AddWithValue("@IdAccesorio", (object)detalleCompra.Id_Accesorio ?? DBNull.Value);

                command.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Compra WHERE Id_Compra = @Id_Compra", connection);
                command.Parameters.AddWithValue("@Id_Compra", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Compra> GetAll()
        {
            var compra = new List<Compra>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Compra", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        compra.Add(new Compra
                        {
                            Id_Compra = (int)reader["Id_Compra"],
                            Cantidad = (int)reader["Cantidad"], // Asume que es un entero
                            Precio_Unitario = (decimal)reader["Precio_Unitario"], // Asume que es decimal
                            FechaCompra = (DateTime)reader["FechaCompra"], // Fecha como DateTime
                        });
                    }
                }
            }
            return compra;
        }

        public Compra GetById(int id)
        {
            Compra compra = null;
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Compra WHERE Id_Compra = @id_Compra", connection);
                command.Parameters.AddWithValue("@Id_Compra", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        compra = new Compra
                        {
                            Id_Compra = (int)reader["Id_Compra"],
                            Cantidad = (int)reader["Cantidad"], // Asume que es un entero
                            Precio_Unitario = (decimal)reader["Precio_Unitario"], // Asume que es decimal
                            FechaCompra = (DateTime)reader["FechaCompra"], // Fecha como DateTime
                        };
                    }
                }
            }
            return compra;
        }

        public IEnumerable<Compra> Search(string searchTerm)
        {
            var compras = new List<Compra>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Compra WHERE FechaCompra LIKE @searchTerm OR Cantidad LIKE @searchTerm OR Precio_Unitario LIKE @searchTerm", connection);
                command.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        compras.Add(new Compra
                        {
                            Id_Compra = (int)reader["Id_Compra"],
                            Cantidad = (int)reader["Cantidad"],
                            Precio_Unitario = (decimal)reader["Precio_Unitario"],
                            FechaCompra = (DateTime)reader["FechaCompra"],
                        });
                    }
                }
            }
            return compras;
        }


        public void Update(Compra compra)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Compra SET FechaCompra = @FechaCompra, Precio_Unitario = @Precio_Unitario, Cantidad =  @Cantidad WHERE Id_Compra = @Id_Compra", connection);
                command.Parameters.AddWithValue("@Id_Compra", compra.Id_Compra);
                command.Parameters.AddWithValue("@FechaCompra", compra.FechaCompra);
                command.Parameters.AddWithValue("@Precio_Unitario", compra.Precio_Unitario);
                command.Parameters.AddWithValue("@Cantidad", compra.Cantidad);
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<Detalle_Compra> GetComprasConDetalles()
        {
            var comprasConDetalles = new List<Detalle_Compra>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(@"
                    SELECT 
                        c.Id_Compra AS IdCompra, 
                        c.FechaCompra AS Fecha,
                        c.Cantidad,
                        c.Precio_Unitario AS PrecioUnitario,
                        (c.Cantidad * c.Precio_Unitario) AS Total,
                        p.Nombre_Proveedor AS Proveedor,
                        f.Nombre_Flor AS Flor,
                        a.Nombre_Accesorio AS Accesorio
                    FROM Compra c
                    INNER JOIN Detalle_Compra dc ON c.Id_Compra = dc.Id_Compra
                    INNER JOIN Proveedor p ON dc.Id_Proveedor = p.Id_Proveedor
                    LEFT JOIN Flor f ON dc.Id_Flor = f.Id_Flor
                    LEFT JOIN Accesorio a ON dc.Id_Accesorio = a.Id_Accesorio", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comprasConDetalles.Add(new Detalle_Compra
                        {
                            Id_Compra = (int)reader["IdCompra"],
                            Fecha = (DateTime)reader["Fecha"],
                            Cantidad = (int)reader["Cantidad"],
                            PrecioUnitario = (decimal)reader["PrecioUnitario"],
                            Total = (decimal)reader["Total"],
                            Proveedor = reader["Proveedor"] as string,
                            Flor = reader["Flor"] as string,
                            Accesorio = reader["Accesorio"] as string
                        });
                    }
                }
            }
            return comprasConDetalles;
        }

    }
}

