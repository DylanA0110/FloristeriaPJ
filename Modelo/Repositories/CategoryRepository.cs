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
    public class CategoryRepository: ICategoriaRepository
    {
        private readonly DbContext _dbContext;

        public CategoryRepository()
        {
            _dbContext = new DbContext(); // Inicializa el contexto de base de datos
        }
        /// <summary>
        /// Agrega una nueva categoría en la base de datos.
        /// </summary>
        public void Add(Categoria categoria)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var query = @"
                INSERT INTO Categoria (Id_Ocasion, Nombre_Categoria, Descripcion)
                VALUES (@IdOcasion, @NombreCategoria, @Descripcion)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdOcasion", (object)categoria.Id_Ocasion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@NombreCategoria", categoria.Nombre_Categoria);
                    command.Parameters.AddWithValue("@Descripcion", (object)categoria.Descripcion ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Obtiene todas las categorías de la base de datos.
        /// </summary>
        public IEnumerable<Categoria> GetAll()
        {
            var categorias = new List<Categoria>();

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var query = "SELECT * FROM Categoria";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(new Categoria
                            {
                                Id_categoria = (int)reader["Id_categoria"],
                                Id_Ocasion = reader["Id_Ocasion"] as int?,
                                Nombre_Categoria = reader["Nombre_Categoria"]?.ToString(),
                                Descripcion = reader["Descripcion"]?.ToString()
                            });
                        }
                    }
                }
            }

            return categorias;
        }

        /// <summary>
        /// Actualiza una categoría existente en la base de datos.
        /// </summary>
        public void Update(Categoria categoria)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var query = @"
                UPDATE Categoria
                SET Id_Ocasion = @IdOcasion,
                    Nombre_Categoria = @NombreCategoria,
                    Descripcion = @Descripcion
                WHERE Id_categoria = @IdCategoria";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdCategoria", categoria.Id_categoria);
                    command.Parameters.AddWithValue("@IdOcasion", (object)categoria.Id_Ocasion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@NombreCategoria", categoria.Nombre_Categoria);
                    command.Parameters.AddWithValue("@Descripcion", (object)categoria.Descripcion ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
