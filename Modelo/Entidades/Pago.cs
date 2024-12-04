using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dto
{
    public class Pago
    {
        [Key]
        public int Id_pago { get; set; }

        [Required(ErrorMessage = "El ID de la factura es requerido.")]
        public int Id_factura { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Range(0.01, 9999999.99, ErrorMessage = "El monto debe estar entre 0.01 y 9999999.99.")]
        public decimal Monto { get; set; }

        [Required(ErrorMessage = "La fecha de pago es requerida.")]
        public DateTime Fecha_pago { get; set; }

        [Required(ErrorMessage = "El ID del tipo de pago es requerido.")]
        public int Id_Tipo_Pago { get; set; }
    }
}
