using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IFacturaRepository
    {
        IEnumerable<Factura> GetAll();
        Factura GetById(int id);
        void Add(Factura factura);
        void Update(Factura factura);
        void Delete(int id);
        IEnumerable<Factura> Search(string searchTerm);
    }
}

