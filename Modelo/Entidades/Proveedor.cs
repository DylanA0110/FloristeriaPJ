using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Proveedor
    {
        [Key]
        public int Id_Proveedor { get; set; }

        [Required(ErrorMessage = "El nombre del proveedor es requerido.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre del proveedor debe tener entre 2 y 50 caracteres.")]
        public string Nombre_Proveedor { get; set; }

        [StringLength(15, ErrorMessage = "El teléfono no puede exceder los 15 caracteres.")]
        public string Telefono { get; set; }
    }
}
