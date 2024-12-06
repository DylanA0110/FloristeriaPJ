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
    public class AccesorioController
    {
        private readonly IAccesorioRepository _accesorioRepository;

        public AccesorioController(IAccesorioRepository accesorioRepository)
        {
            _accesorioRepository = accesorioRepository;
        }
        public IEnumerable<Accesorio> GetAllArreglo() => _accesorioRepository.GetAll();

        public Accesorio GetAccesorioById(int id) => _accesorioRepository.GetById(id);

        public void AddAccesorio(Accesorio accesorio) => _accesorioRepository.Add(accesorio);

        public void UpdateAccesorio(Accesorio accesorio) => _accesorioRepository.Update(accesorio);

        public IEnumerable<Accesorio> SearchArreglo(string searchTerm) => _accesorioRepository.Search(searchTerm);
    }
}
