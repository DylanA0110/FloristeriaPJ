using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dto
{
    public class Compra
    {
        [Key]
        public int Id_Compra { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El precio unitario es requerido.")]
        [Range(0.01, 9999999.99, ErrorMessage = "El precio unitario debe estar entre 0.01 y 9999999.99.")]
        public decimal Precio_Unitario { get; set; }

        [Required(ErrorMessage = "La fecha de compra es requerida.")]
        public DateTime FechaCompra { get; set; }
    }
}
