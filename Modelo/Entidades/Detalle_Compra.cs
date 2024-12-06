using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class Detalle_Compra
    {
        [Key]
        public int Id_Detalle_Compra { get; set; }

        [Required(ErrorMessage = "El ID de la compra es requerido.")]
        public int Id_Compra { get; set; }

        [Required(ErrorMessage = "El ID del proveedor es requerido.")]
        public int Id_Proveedor { get; set; }

       
        public int? Id_Flor { get; set; }
        public int? Id_Accesorio { get; set; }

        //pa los join
        public string Proveedor { get; set; }
        public string Flor { get; set; }
        public string Accesorio { get; set; }

        // el calcular
        public decimal Total { get; set; }

        
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
