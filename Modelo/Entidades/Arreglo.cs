using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Arreglo
    {
        [Key]
        public int Id_Arreglo { get; set; }

        public int? Id_Categoria { get; set; }

        [Required(ErrorMessage = "El nombre del arreglo es requerido.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre del arreglo debe tener entre 2 y 100 caracteres.")]
        public string Nombre_Arreglo { get; set; }

        public int? Cantidad { get; set; }
    }

}
