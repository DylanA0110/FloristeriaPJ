using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Detalle_Proveedor
    {
        [Key]
        public int Id_Detalle_proveedor { get; set; }

        public int? Id_Accesorio { get; set; }
        public int? Id_Flor { get; set; }
        public int? Id_Proveedor { get; set; }
    }
}
