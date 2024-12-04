using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Ocasion
    {
        [Key]
        public int Id_Ocasion { get; set; }

        [Required(ErrorMessage = "El nombre de la ocasión es requerido.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "El nombre de la ocasión debe tener entre 2 y 15 caracteres.")]
        public string Nombre_Ocasion { get; set; }
    }
}
