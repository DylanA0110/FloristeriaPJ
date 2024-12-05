using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidades;

namespace Modelo.Interfaces
{
    public interface ITipoPagoRepository
    {
        void Add(TipoDePago TipoPago);
        void Update(TipoDePago TipoPago);
        void Delete(int id);
    }
}
