using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Factura
    {
        [Key]
        public int Id_factura { get; set; }

        [Required(ErrorMessage = "El pedido es requerido.")]
        public int Id_pedido { get; set; }

        [Required(ErrorMessage = "El monto total es requerido.")]
        [Range(0.01, 9999999.99, ErrorMessage = "El monto debe ser mayor a 0.")]
        public decimal Monto_total { get; set; }

        [Required(ErrorMessage = "El estado de la factura es requerido.")]
        public bool Estado { get; set; }

        public int? Id_Empleado { get; set; }

        [Required(ErrorMessage = "El número de factura es requerido.")]
        public int NumFactura { get; set; }
    }
}
