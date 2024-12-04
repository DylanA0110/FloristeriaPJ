using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Rol
    {
        [Key]
        public int IdROl { get; set; }

        [Required(ErrorMessage = "El nombre del rol es requerido.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre del rol debe tener entre 2 y 50 caracteres.")]
        public string Nombre { get; set; }
    }


}
