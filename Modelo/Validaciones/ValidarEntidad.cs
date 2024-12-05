using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Validaciones
{
    public static class ValidadorEntidad
    {
        public static List<string> Validar<T>(T entidad) where T : class
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(entidad, serviceProvider: null, items: null);

            bool esValido = Validator.TryValidateObject(entidad, contexto, resultados, true);

            var errores = new List<string>();
            if (!esValido)
            {
                foreach (var error in resultados)
                {
                    errores.Add(error.ErrorMessage);
                }
            }

            return errores;
        }
    }
}
