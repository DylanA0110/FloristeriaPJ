
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IPagoRepository
    {
        void Add(Pago pago);
        void Update(Pago pago);
        void Delete(int id);
    }
}
