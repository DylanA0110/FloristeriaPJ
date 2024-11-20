using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pedido
    {
        [Key]
        public int Id_pedido { get; set; }

        [Required(ErrorMessage = "El cliente es requerido.")]
        public int Id_cliente { get; set; }

        [StringLength(300, ErrorMessage = "La descripción debe tener un máximo de 300 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0.")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La fecha de solicitud es requerida.")]
        public DateTime Fecha_solicitud { get; set; }

        public DateTime? Fecha_entrega { get; set; }

        [StringLength(200, ErrorMessage = "La dirección de envío debe tener un máximo de 200 caracteres.")]
        public string Enviarse_A { get; set; }
    }

}
