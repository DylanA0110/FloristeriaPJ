using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Detalle_Compra
    {
        [Key]
        public int Id_Detalle_Compra { get; set; }

        [Required(ErrorMessage = "El ID de la compra es requerido.")]
        public int Id_Compra { get; set; }

        [Required(ErrorMessage = "El ID del proveedor es requerido.")]
        public int Id_Proveedor { get; set; }

        public int? Id_Flor { get; set; }
        public int? Id_Accesorio { get; set; }
    }
}
