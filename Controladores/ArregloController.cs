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
        public IEnumerable<Arreglo> GetAllArreglo() => _arregloRepository.GetAll();

        public Arreglo GetArregloById(int id) => _arregloRepository.GetById(id);

        public void AddArreglo(Arreglo arreglo) => _arregloRepository.Add(arreglo);

        public void UpdateArreglo(Arreglo arreglo) => _arregloRepository.Update(arreglo);

        public void DeleteArreglo(int id) => _arregloRepository.Delete(id);

        public IEnumerable<Arreglo> SearchArreglo(string searchTerm) => _arregloRepository.Search(searchTerm);
    }


}
