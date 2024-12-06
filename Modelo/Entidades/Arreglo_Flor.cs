using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Arreglo_Flor
    {
        [Key]
        public int Id_Arreglo_Flor { get; set; }
        [Required (ErrorMessage = "El Id de Flor es requerido")]
        public int Id_Flor { get; set; }
        [Required(ErrorMessage = "El ID del Arreglo es requerido.")]
        public int Id_Arreglo { get; set; }

        // Joins 
        public string ?Flor { get; set; }
       

    }
}
