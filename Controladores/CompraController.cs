using Microsoft.Data.SqlClient;
using Modelo.Contexto;
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
    public class CompraController
    {
        private readonly ICompraRepository _compraRepository;

        public CompraController(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }

        public IEnumerable<Compra> GetAllCompras() => _compraRepository.GetAll();

        public Compra GetCompraById(int id) => _compraRepository.GetById(id);

        public void AddCompra(Compra compra) => _compraRepository.Add(compra);

        public void UpdateCompra(Compra compra) => _compraRepository.Update(compra);

        public void DeleteCompra(int id) => _compraRepository.Delete(id);

        public IEnumerable<Compra> SearchCompra(string searchTerm) => _compraRepository.Search(searchTerm);



       
    }

}



