using Modelo.Entidades;
using Modelo.Interfaces;
using Modelo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class TipoDePagoController
    {
        private readonly ITipoPagoRepository _TipoPagoRepository;

        public TipoDePagoController(ITipoPagoRepository tipoPagoRepository)
        {
            _TipoPagoRepository = tipoPagoRepository;
        }

        public IEnumerable<TipoDePago> GetAll() => _TipoPagoRepository.GetAll();
        public void AddPago(TipoDePago TipoPago) => _TipoPagoRepository.Add(TipoPago);

        public void UpdatePago(TipoDePago TipoPago) => _TipoPagoRepository.Update(TipoPago);

        public void DeletePago(int id) => _TipoPagoRepository.Delete(id);
    }
}
