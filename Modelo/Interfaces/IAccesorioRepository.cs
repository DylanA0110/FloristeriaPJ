using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IAccesorioRepository
    {
        int Add(Accesorio accesorio);
        int GetLastAccesorioId();
    }
}
