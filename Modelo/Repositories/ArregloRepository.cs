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
    public class ArregloRepository: IArregloRepository
    {
        private readonly DbContext _dbContext;

        public ArregloRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Arreglo arreglo)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Arreglo (Id_Categoria, Nombre_Arreglo, Cantidad, Url_Imagen) VALUES (@Id_Categoria, @Nombre_Arreglo, @Cantidad, @Url_Imagen WHERE Id_Arreglo = @Id_Arreglo)", connection);
                command.Parameters.AddWithValue("@Id_Categoria", arreglo.Id_Categoria);
                command.Parameters.AddWithValue("@Nombre_Arreglo", arreglo.Nombre_Arreglo);
                command.Parameters.AddWithValue("@Cantidad", arreglo.Cantidad);
                command.Parameters.AddWithValue("@Url_Imagen", arreglo.Url_Imagen);
                command.ExecuteNonQuery();
            }
        }

        public void AddArregloAccesorio(Arreglo_Accesorio arregloAccesorio)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Arreglo_Accesorio (Id_Arreglo_Accesorio, Id_Accesorio, Id_Arreglo) VALUES ( @Id_ArregloAccesorio, @Id_Accesorio, @Id_Arreglo)", connection);
                command.Parameters.AddWithValue("@Id_Arreglo_Accesorio", (object)arregloAccesorio.Id_Arreglo_Accesorio ?? DBNull.Value);
                command.Parameters.AddWithValue("@Id_Accesorio", (object)arregloAccesorio.Id_Accesorio ?? DBNull.Value);
                command.Parameters.AddWithValue("@Id_Arreglo", (object)arregloAccesorio.Id_Arreglo ?? DBNull.Value);
                command.ExecuteNonQuery();
            }
        }

        public void AddArregloFlor(Arreglo_Flor ArregloFlor)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO Arreglo_Flor (Id_Arreglo_Flor, Id_Arreglo, Id_Flor) VALUES (@Id_Arreglo_Flor, @IdArreglo, @IdFlor)", connection);
                command.Parameters.AddWithValue("@Id_Arreglo_Flor", ArregloFlor.Id_Arreglo_Flor);
                command.Parameters.AddWithValue("@IdArreglo", ArregloFlor.Id_Arreglo);
                command.Parameters.AddWithValue("@IdFlor", (object)ArregloFlor.Id_Flor ?? DBNull.Value);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Arreglo WHERE Id_Arreglo = @Id_Arreglo", connection);
                command.Parameters.AddWithValue("@Id_Arreglo", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Arreglo> GetAll()
        {
            var arreglo = new List<Arreglo>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Arreglo", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        arreglo.Add(new Arreglo
                        {
                            Id_Arreglo = (int)reader["Id_Arreglo"],
                            Id_Categoria = (int)reader["Id_Categoria"],
                            Nombre_Arreglo = reader["Nombre_Arreglo"]?.ToString(),
                            Cantidad = (int)reader["Cantidad"],
                            Url_Imagen = reader["NumFactura"]?.ToString()
                        });
                    }
                }
            }
            return arreglo;
        }

        public IEnumerable<Arreglo_Accesorio> GetArreglosConAccesorios()
        {
            var ArreglosConAccesorios = new List<Arreglo_Accesorio>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(@"
                    SELECT 
                        A.Id_Arreglo AS IdArreglo, 
                        A.Nombre_Arreglo AS NombreArreglo,
                        a.Nombre_Accesorio AS Accesorio
                    FROM Arreglo A
                    LEFT JOIN Accesorio a ON dc.Id_Accesorio = a.Id_Accesorio", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ArreglosConAccesorios.Add(new Arreglo_Accesorio
                        {
                            Id_Arreglo_Accesorio = (int)reader["IdArregloAccesorio"],
                            Accesorio = reader["Accesorio"] as string
                        });
                    }
                }
            }
            return ArreglosConAccesorios;
        }

        public Arreglo GetById(int id)
        {
            Arreglo arreglo = new Arreglo();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Arreglo WHERE Id_Arreglo = @Id_Arreglo", connection);
                command.Parameters.AddWithValue("@Id_Arreglo", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        arreglo = new Arreglo
                        {
                            Id_Arreglo = (int)reader["Id_Arreglo"],
                            Id_Categoria = (int)reader["Id_Categoria"],
                            Nombre_Arreglo = reader["Nombre_Arreglo"]?.ToString(),
                            Cantidad = (int)reader["Cantidad"],
                            Url_Imagen = reader["NumFactura"]?.ToString()
                        };
                    }
                }
            }
            return arreglo;
        }

        public IEnumerable<Arreglo> Search(string searchTerm)
        {
            var arreglo = new List<Arreglo>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("BuscarArreglo", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CondicionArreglo", searchTerm);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            arreglo.Add(new Arreglo
                            {
                                Id_Arreglo = (int)reader["Id_Arreglo"],
                                Id_Categoria = (int)reader["Id_Categoria"],
                                Nombre_Arreglo = reader["Nombre_Arreglo"]?.ToString(),
                                Cantidad = (int)reader["Cantidad"],
                                Url_Imagen = reader["Url_Imagen"]?.ToString()
                            });
                        }
                    }
                }
                return arreglo;
            }
        }

        public void Update(Arreglo arreglo)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Arreglo SET Id_Categoria = @Id_Categoria, Nombre_Arreglo = @Nombre_Arreglo, Cantidad = @Cantidad, Url_Imagen = @Url_Imagen WHERE Id_Arreglo = @Id_Arreglo ", connection);
                
                command.Parameters.AddWithValue("@Id_Categoria", arreglo.Id_Categoria);
                command.Parameters.AddWithValue("@Nombre_Arreglo", arreglo.Nombre_Arreglo);
                command.Parameters.AddWithValue("@Cantidad", arreglo.Cantidad);
                command.Parameters.AddWithValue("@Url_Cantidad", arreglo.Url_Imagen);
                command.ExecuteNonQuery();
            }
        }
    }
}
