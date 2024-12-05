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
    public class ProveedorController
    {
        private readonly IProveedoresRepository _proveedoresRepository;

        public ProveedorController(IProveedoresRepository proveedoresRepository)
        {
            _proveedoresRepository = proveedoresRepository;
        }
        public IEnumerable<Proveedor> GetAllProveedor() => _proveedoresRepository.GetAll();

        public Proveedor GetProveedorById(int id) => _proveedoresRepository.GetById(id);

        public void AddProveedor(Proveedor proveedor) => _proveedoresRepository.Add(proveedor);

        public void UpdateProveedor(Proveedor proveedor) => _proveedoresRepository.Update(proveedor);

        public void DeleteProveedor(int id) => _proveedoresRepository.Delete(id);

        public IEnumerable<Proveedor> SearchProveedor(string searchTerm) => _proveedoresRepository.Search(searchTerm);
    }
}
