using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetById(int id);
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
        IEnumerable<Cliente> Search(string searchTerm);
    }
}