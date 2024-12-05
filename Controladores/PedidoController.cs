using Modelo.Entidades;
using Modelo.Interfaces;
using Modelo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class PedidoController
    {
        public readonly IPedidosRepository _pedidosRepository;

        public PedidoController(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }

        public IEnumerable<Pedido> GetAllPedido() => _pedidosRepository.GetaAll();

        public Pedido GetPedidoById(int id) => _pedidosRepository.GetById(id);

        public void AddPedido(Pedido pedido) => _pedidosRepository.Add(pedido);

        public void UpdatePedido(Pedido pedido) => _pedidosRepository.Update(pedido);

        public void DeletePedido(int id) => _pedidosRepository.Delete(id);

        public IEnumerable<Pedido> SearchPedido(string searchTerm) =>   _pedidosRepository.Search(searchTerm);
    }
}
