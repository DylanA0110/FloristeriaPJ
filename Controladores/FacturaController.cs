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

        public FacturaController(IFacturaRepository facturaRepository)
        {
            _facturaRepository = facturaRepository;
        }
        public IEnumerable<Factura> GetAllFactura() => _facturaRepository.GetAll();

        public Factura GetFacturaById(int id) => _facturaRepository.GetById(id);

        public void AddFactura(Factura factura) => _facturaRepository.Add(factura);

        public void UpdateFactura(Factura factura) => _facturaRepository.Update(factura);

        public void DeleteFactura(int id) => _facturaRepository.Delete(id);

        public IEnumerable<Factura> SearchFactura(string searchTerm) => _facturaRepository.Search(searchTerm);

    }
}
