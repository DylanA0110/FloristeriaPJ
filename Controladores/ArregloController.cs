using Modelo.Entidades;
using Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ArregloController
    {
        private readonly IArregloRepository _arregloRepository;

        public ArregloController(IArregloRepository arregloRepository)
        {
            _arregloRepository = arregloRepository;
        }
        public IEnumerable<Arreglo> GetAllProveedor() => _arregloRepository.GetAll();

        public Arreglo GetProveedorById(int id) => _arregloRepository.GetById(id);

        public void AddProveedor(Arreglo arreglo) => _arregloRepository.Add(arreglo);

        public void UpdateProveedor(Arreglo arreglo) => _arregloRepository.Update(arreglo);

        public void DeleteProveedor(int id) => _arregloRepository.Delete(id);

        public IEnumerable<Arreglo> SearchProveedor(string searchTerm) => _arregloRepository.Search(searchTerm);
    }


}
