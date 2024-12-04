using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dto
{
    public class Accesorio
    {
        [Key]
        public int Id_Accesorio { get; set; }

        [Required(ErrorMessage = "El ID del arreglo es requerido.")]
        public int Id_Arreglo { get; set; }

        [Required(ErrorMessage = "El nombre del accesorio es requerido.")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "El nombre del accesorio debe tener entre 2 y 30 caracteres.")]
        public string ?Nombre_Accesorio { get; set; }
    }

}
