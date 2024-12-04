using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dto
{
    public class Detalle_Pedido
    {
        [Key]
        public int Id_Detalle_Pedido { get; set; }

        [Required(ErrorMessage = "El ID del pedido es requerido.")]
        public int Id_Pedido { get; set; }

        [Required(ErrorMessage = "El ID del arreglo es requerido.")]
        public int Id_Arreglo { get; set; }

        public int? Id_Envio { get; set; }
    }
}
