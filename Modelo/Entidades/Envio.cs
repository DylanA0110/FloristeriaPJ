using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Envio
    {
        [Key]
        public int Id_envio { get; set; }

        [Required(ErrorMessage = "El pedido es requerido.")]
        public int Id_pedido { get; set; }

        [Required(ErrorMessage = "La dirección de envío es requerida.")]
        [StringLength(100, ErrorMessage = "La dirección debe tener un máximo de 100 caracteres.")]
        public string ?Direccion { get; set; }
    }
}
