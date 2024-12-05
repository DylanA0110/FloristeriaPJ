using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public static class EmpleadoAutenticado
    {
        public static int EmpleadoId { get; set; }
        public static string? PrimerNombre { get; set; }
        public static string? PrimerApellido { get; set; }
        public static int RolId { get; set; }

        public static string? password { get; set; }

    }
}
