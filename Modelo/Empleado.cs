using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Empleado
    {
        [Key]
        public int Id_Empleado { get; set; }

        [Required(ErrorMessage = "El primer nombre es requerido.")]
        [StringLength(50, ErrorMessage = "El primer nombre debe tener un máximo de 50 caracteres.")]
        public string PrimerNombre { get; set; }

        [StringLength(50, ErrorMessage = "El segundo nombre debe tener un máximo de 50 caracteres.")]
        public string SegundoNombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es requerido.")]
        [StringLength(50, ErrorMessage = "El primer apellido debe tener un máximo de 50 caracteres.")]
        public string PrimerApellido { get; set; }

        [StringLength(50, ErrorMessage = "El segundo apellido debe tener un máximo de 50 caracteres.")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "El sexo es requerido.")]
        [RegularExpression(@"^[MF]{1}$", ErrorMessage = "El sexo debe ser 'M' o 'F'.")]
        public char Sexo { get; set; }

        public DateTime? FechaInicioSesion { get; set; }
        public DateTime? FechaCierreSesion { get; set; }

        [Required(ErrorMessage = "El correo es requerido.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        [StringLength(50, ErrorMessage = "El correo debe tener un máximo de 50 caracteres.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        [StringLength(50, ErrorMessage = "El nombre de usuario debe tener un máximo de 50 caracteres.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        [StringLength(50, ErrorMessage = "La contraseña debe tener un máximo de 50 caracteres.")]
        public string Contrasena { get; set; }

        [StringLength(20, ErrorMessage = "El teléfono debe tener un máximo de 20 caracteres.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es requerida.")]
        public DateTime FechaDeNac { get; set; }

        public bool? EsAprobado { get; set; }

        [Required(ErrorMessage = "El rol del empleado es requerido.")]
        public int RolId { get; set; }
    }
}
