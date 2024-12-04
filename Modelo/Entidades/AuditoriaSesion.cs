using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class AuditoriaSesion
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El empleado es requerido.")]
        public int Id_Empleado { get; set; }

        [Required(ErrorMessage = "La acción es requerida.")]
        [StringLength(50, ErrorMessage = "La acción debe tener un máximo de 50 caracteres.")]
        public string Accion { get; set; }

        [Required(ErrorMessage = "La fecha de la acción es requerida.")]
        public DateTime FechaAccion { get; set; }
    }

}
