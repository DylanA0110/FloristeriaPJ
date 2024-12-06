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
    public class ArregloController
    {
        private readonly IArregloRepository _arregloRepository;
        private readonly IFlorRepository _florRepository;
        private readonly IAccesorioRepository _accesorioRepository;


        public ArregloController(IArregloRepository arregloRepository, IAccesorioRepository accesorioRepository)
        {
            _arregloRepository = arregloRepository;
            //_florRepository = florRepository;
            _accesorioRepository = accesorioRepository;
        }
        public IEnumerable<Arreglo> GetAllArreglo() => _arregloRepository.GetAll();

        public Arreglo GetArregloById(int id) => _arregloRepository.GetById(id);

        public void AddArreglo(Arreglo arreglo) => _arregloRepository.Add(arreglo);

        public void UpdateArreglo(Arreglo arreglo) => _arregloRepository.Update(arreglo);

        public void DeleteArreglo(int id) => _arregloRepository.Delete(id);

        public IEnumerable<Arreglo> SearchArreglo(string searchTerm) => _arregloRepository.Search(searchTerm);

        public void AddArregloAccesorio(Arreglo_Accesorio arregloAccesorio) => _arregloRepository.AddArregloAccesorio(arregloAccesorio);

        public IEnumerable<Arreglo_Accesorio> GetArreglosConAccesorios() => _arregloRepository.GetArreglosConAccesorios();

        public void AddArregloFlor(Arreglo_Flor ArregloFlor) => _arregloRepository.AddArregloFlor(ArregloFlor);
    }


}
