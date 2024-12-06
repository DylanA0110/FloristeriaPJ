using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Arreglo_Accesorio
    {
        [Key]
        public int Id_Arreglo_Accesorio { get; set; }

        [Required(ErrorMessage = "El ID de la Arreglo es requerido.")]
        public int Id_Accesorio { get; set; }
        [Required(ErrorMessage = "El ID de la Arrelo es requerido.")]
        public int Id_Arreglo { get; set; }

        // para los joins
        public string? Accesorio { get; set; }
    }
}
