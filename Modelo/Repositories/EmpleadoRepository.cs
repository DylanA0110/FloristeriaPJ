using Modelo.Contexto;
using Modelo.Interfaces;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Modelo.Entidades;
using System.Data;

namespace Modelo.Repositories
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly DbContext _dbContext;

        public EmpleadoRepository()
        {
            _dbContext = new DbContext();
        }

        public IEnumerable<Empleado> GetAll()
        {
            var empleados = new List<Empleado>();
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Empleado", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        empleados.Add(new Empleado
                        {
                            Id_Empleado = (int)reader["Id_Empleado"],
                            PrimerNombre = reader["PrimerNombre"]?.ToString(),
                            SegundoNombre = reader["SegundoNombre"]?.ToString(),
                            PrimerApellido = reader["PrimerApellido"]?.ToString(),
                            SegundoApellido = reader["SegundoApellido"]?.ToString(),
                            Sexo = reader["Sexo"] != DBNull.Value ? reader["Sexo"].ToString() : string.Empty,// Asignar un valor por defecto
                            FechaInicioSesion = reader["FechaInicioSesion"] as DateTime?,
                            FechaCierreSesion = reader["FechaCierreSesion"] as DateTime?,
                            Correo = reader["Correo"]?.ToString(),
                            UserName = reader["UserName"]?.ToString(),
                            Contrasena = reader["Contrasena"]?.ToString(),
                            Telefono = reader["Telefono"]?.ToString(),
                            FechaDeNac = (DateTime)reader["FechaDeNac"],
                            EsAprobado = reader["EsAprobado"] != DBNull.Value && (bool)reader["EsAprobado"],
                            RolId = reader["RolId"] != DBNull.Value ? (int)reader["RolId"] : 0 // Asignar un valor por defecto
                        });
                    }
                }
            }
            return empleados;
        }

        public Empleado GetById(int id)
        {
            Empleado empleado = null;
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Empleado WHERE Id_Empleado = @Id_Empleado", connection);
                command.Parameters.AddWithValue("@Id_Empleado", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        empleado = new Empleado
                        {
                            Id_Empleado = (int)reader["Id_Empleado"],
                            PrimerNombre = reader["PrimerNombre"]?.ToString(),
                            SegundoNombre = reader["SegundoNombre"]?.ToString(),
                            PrimerApellido = reader["PrimerApellido"]?.ToString(),
                            SegundoApellido = reader["SegundoApellido"]?.ToString(),
                            Sexo = reader["Sexo"] != DBNull.Value ? reader["Sexo"].ToString() : string.Empty,
                            FechaInicioSesion = reader["FechaInicioSesion"] as DateTime?,
                            FechaCierreSesion = reader["FechaCierreSesion"] as DateTime?,
                            Correo = reader["Correo"]?.ToString(),
                            UserName = reader["UserName"]?.ToString(),
                            Contrasena = reader["Contrasena"]?.ToString(),
                            Telefono = reader["Telefono"]?.ToString(),
                            FechaDeNac = (DateTime)reader["FechaDeNac"],
                            EsAprobado = reader["EsAprobado"] != DBNull.Value && (bool)reader["EsAprobado"],
                            RolId = reader["RolId"] != DBNull.Value ? (int)reader["RolId"] : 0
                        };
                    }
                }
            }
            return empleado;
        }

        public void Add(Empleado empleado)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand(
    "INSERT INTO Empleado (PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Sexo, Correo, Contrasena, Telefono, FechaDeNac, UserName) " +
    "VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Sexo, @Correo, @Contrasena, @Telefono, @FechaDeNac, @UserName)",
    connection
);

                command.Parameters.AddWithValue("@PrimerNombre", empleado.PrimerNombre);
                command.Parameters.AddWithValue("@SegundoNombre", empleado.SegundoNombre);
                command.Parameters.AddWithValue("@PrimerApellido", empleado.PrimerApellido);
                command.Parameters.AddWithValue("@SegundoApellido", empleado.SegundoApellido);
                command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                command.Parameters.AddWithValue("@Correo", empleado.Correo);
                command.Parameters.AddWithValue("@UserName", empleado.UserName);
                command.Parameters.AddWithValue("@Contrasena", empleado.Contrasena);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@FechaDeNac", empleado.FechaDeNac);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Empleado empleado)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Empleado SET PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Sexo = @Sexo, Correo = @Correo, UserName = @UserName, Contrasena = @Contrasena, Telefono = @Telefono, FechaDeNac = @FechaDeNac, EsAprobado = @EsAprobado WHERE Id_Empleado = @Id_Empleado", connection);
                command.Parameters.AddWithValue("@Id_Empleado", empleado.Id_Empleado);
                command.Parameters.AddWithValue("@PrimerNombre", empleado.PrimerNombre);
                command.Parameters.AddWithValue("@SegundoNombre", empleado.SegundoNombre);
                command.Parameters.AddWithValue("@PrimerApellido", empleado.PrimerApellido);
                command.Parameters.AddWithValue("@SegundoApellido", empleado.SegundoApellido);
                command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                command.Parameters.AddWithValue("@Correo", empleado.Correo);
                command.Parameters.AddWithValue("@UserName", empleado.UserName);
                command.Parameters.AddWithValue("@Contrasena", empleado.Contrasena);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@FechaDeNac", empleado.FechaDeNac);
                command.Parameters.AddWithValue("@EsAprobado", empleado.EsAprobado);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Empleado WHERE Id_Empleado = @Id_Empleado", connection);
                command.Parameters.AddWithValue("@Id_Empleado", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Empleado> Search(string searchTerm)
        {
            var empleados = new List<Empleado>();

            using (var connection = _dbContext.GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand("BuscarEmpleados", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Condicion", searchTerm);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleados.Add(new Empleado
                            {
                                Id_Empleado = (int)reader["Id_Empleado"],
                                PrimerNombre = reader["PrimerNombre"]?.ToString(),
                                SegundoNombre = reader["SegundoNombre"]?.ToString(),
                                PrimerApellido = reader["PrimerApellido"]?.ToString(),
                                SegundoApellido = reader["SegundoApellido"]?.ToString(),
                                Sexo = reader["Sexo"] != DBNull.Value ? reader["Sexo"].ToString() : string.Empty,// Asignar un valor por defecto
                                FechaInicioSesion = reader["FechaInicioSesion"] as DateTime?,
                                FechaCierreSesion = reader["FechaCierreSesion"] as DateTime?,
                                Correo = reader["Correo"]?.ToString(),
                                UserName = reader["UserName"]?.ToString(),
                                Contrasena = reader["Contrasena"]?.ToString(),
                                Telefono = reader["Telefono"]?.ToString(),
                                FechaDeNac = (DateTime)reader["FechaDeNac"],
                                EsAprobado = reader["EsAprobado"] != DBNull.Value && (bool)reader["EsAprobado"],
                                RolId = reader["RolId"] != DBNull.Value ? (int)reader["RolId"] : 0
                            });
                        }
                    }
                }
            }

            return empleados;
        }
    }
}
