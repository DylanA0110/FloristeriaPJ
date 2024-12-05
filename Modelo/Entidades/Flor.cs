using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Flor
    {
        [Key]
        public int Id_flor { get; set; }

        public int? Id_Arreglo { get; set; }

        [Required(ErrorMessage = "El nombre de la flor es requerido.")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "El nombre de la flor debe tener entre 2 y 15 caracteres.")]
        public string ?Nombre_Flor { get; set; }

        [StringLength(200, ErrorMessage = "La URL de la imagen no puede exceder los 200 caracteres.")]
        public string ?Url_Imagen { get; set; }
    }
}
