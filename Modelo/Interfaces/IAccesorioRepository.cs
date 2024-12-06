using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IAccesorioRepository
    {
        
        void Add(Accesorio accesorio);
        int GetLastAccesorioId();
        IEnumerable<Accesorio> GetAll();
        Accesorio GetById(int id);
        IEnumerable<Accesorio> Search(string searchTerm);
        void Update(Accesorio accesorio);


    }
}
