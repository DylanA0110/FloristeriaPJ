using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
        void Add(Categoria categoria);
        void Update(Categoria categoria);
    }
}
