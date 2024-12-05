using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class DetalleCompraDTO
    {
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Total { get; set; }
        public string Proveedor { get; set; }
        public string Flor { get; set; }
        public string Accesorio { get; set; }
    }
}
