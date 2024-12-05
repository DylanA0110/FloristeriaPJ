using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IProveedoresRepository
    {
        IEnumerable<Proveedor> GetAll();
        Proveedor GetById(int id);
        void Add(Proveedor proveedor);
        void Update(Proveedor proveedor);
        void Delete(int id);
        IEnumerable<Proveedor> Search(string searchTerm);
    }
}
