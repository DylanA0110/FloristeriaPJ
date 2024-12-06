using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IFlorRepository
    {
        void Add(Flor flor);
        int GetLastFlorId();
        IEnumerable<Flor> GetAll();
        Flor GetById(int id);
        IEnumerable<Flor> Search(string searchTerm);
        void Update(Flor flor);
    }
}
