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
    public class FacturaController
    {
        public readonly IFacturaRepository _facturaRepository;
        private readonly IPagoRepository _pagoRepository;
        private readonly ITipoPagoRepository _tipoPagoRepository;

        public FacturaController(IFacturaRepository facturaRepository, IPagoRepository pagoRepository, ITipoPagoRepository tipoPagoRepository)
        {
            _facturaRepository = facturaRepository;
            _pagoRepository = pagoRepository;
            _tipoPagoRepository = tipoPagoRepository;
        }
        public IEnumerable<Facturas> GetAllFactura() => _facturaRepository.GetAll();

        public Facturas GetFacturaById(int id) => _facturaRepository.GetById(id);

        public void AddFactura(Facturas factura) => _facturaRepository.Add(factura);

        public void UpdateFactura(Facturas factura) => _facturaRepository.Update(factura);

        public void DeleteFactura(int id) => _facturaRepository.Delete(id);

        public IEnumerable<Facturas> SearchFactura(string searchTerm) => _facturaRepository.Search(searchTerm);

        public IEnumerable<Facturas> GetAllFacturasWithPago() => _facturaRepository.GetAllWithPago();

    }
}
