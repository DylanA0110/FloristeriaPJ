using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface ICompraRepository
    {
        IEnumerable<Compra> GetAll();
        Compra GetById(int id);
        void Add(Compra compra);
        void Update(Compra compra);
        void Delete(int id);
        IEnumerable<Compra> Search(string searchTerm);

        IEnumerable<Detalle_Compra> GetComprasConDetalles();
        void AddDetalleCompra(Detalle_Compra detalleCompra);
        void AddDetalleProveedor(Detalle_Proveedor detalleProveedor);
    }
}
