using System.Collections.Generic;
using Modelo.Entidades;
using Modelo.Interfaces;

namespace Controladores
{
    public class CompraController
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IFlorRepository _florRepository;
        private readonly IAccesorioRepository _accesorioRepository;

        public CompraController(ICompraRepository compraRepository, IFlorRepository florRepository, IAccesorioRepository accesorioRepository)
        {
            _compraRepository = compraRepository;
            _florRepository = florRepository;
            _accesorioRepository = accesorioRepository;
        }

        public IEnumerable<Compra> GetAllCompras() => _compraRepository.GetAll();

        public Compra GetCompraById(int id) => _compraRepository.GetById(id);

        public int AddCompra(Compra compra)
        {
            _compraRepository.Add(compra);
            return compra.Id_Compra; 
        }
        public void AddDetalleCompra(Detalle_Compra detalleCompra) =>  _compraRepository.AddDetalleCompra(detalleCompra);
        
        public void UpdateCompra(Compra compra) => _compraRepository.Update(compra);

        public void DeleteCompra(int id) => _compraRepository.Delete(id);

        public IEnumerable<Detalle_Compra> GetComprasConDetalles() => _compraRepository.GetComprasConDetalles();

        public void AddFlor(Flor flor) => _florRepository.Add(flor);

        public void AddAccesorio(Accesorio accesorio) => _accesorioRepository.Add(accesorio);

        public int GetLastFlorId() => _florRepository.GetLastFlorId();

        public int GetLastAccesorioId() => _accesorioRepository.GetLastAccesorioId();

        public IEnumerable<Compra> Search (string searchterm)=> _compraRepository.Search(searchterm);
    }
}