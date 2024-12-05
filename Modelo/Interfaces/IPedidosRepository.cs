using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IPedidosRepository
    {
        IEnumerable<Pedido> GetaAll();
        IEnumerable<Pedido> Search(string searchTerm);
        void Add(Pedido pedido);
        void Update(Pedido pedido);
        Pedido GetById(int id);
        void Delete(int id);
    }
}
