using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dto
{
    public class Categoria
    {
        [Key]
        public int Id_categoria { get; set; }

        public int? Id_Ocasion { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es requerido.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "El nombre de la categoría debe tener entre 2 y 15 caracteres.")]
        public string Nombre_Categoria { get; set; }

        [StringLength(50, ErrorMessage = "La descripción no puede exceder los 50 caracteres.")]
        public string Descripcion { get; set; }
    }
}
