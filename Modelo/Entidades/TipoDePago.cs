using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Dto
{
    public class TipoDePago
    {
        [Key]
        public int Id_Tipo_pago { get; set; }

        [Required(ErrorMessage = "El tipo de pago es requerido.")]
        [StringLength(100, ErrorMessage = "El tipo de pago debe tener un máximo de 100 caracteres.")]
        public string Tipo { get; set; }
    }
}
