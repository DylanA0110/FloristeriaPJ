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
        IEnumerable<TipoDePago> GetAll();
        void Add(TipoDePago TipoPago);
        void Update(TipoDePago TipoPago);
        void Delete(int id);
    }
}
