using Microsoft.Data.SqlClient;
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
        IEnumerable<Facturas> GetAll();
        Facturas GetById(int id);
        void Add(Facturas factura);
        void Update(Facturas factura);
        void Delete(int id);
        IEnumerable<Facturas> Search(string searchTerm);
        

    }
}

