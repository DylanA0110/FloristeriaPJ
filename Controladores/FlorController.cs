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
    public class FlorController
    {
        private readonly IFlorRepository _florRepository;

        public FlorController(IFlorRepository florRepository)
        {
            _florRepository = florRepository;
        }
        public IEnumerable<Flor> GetAllFlor() => _florRepository.GetAll();

        public Flor GetFlorId(int id) => _florRepository.GetById(id);

        public void AddFlor(Flor flor) => _florRepository.Add(flor);

        public void UpdateFlor(Flor flor) => _florRepository.Update(flor);

        public IEnumerable<Flor> SearchArreglo(string searchTerm) => _florRepository.Search(searchTerm);
    }
}

