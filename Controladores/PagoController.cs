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
    public class PagoController
    {
        //pago de meirda
        private readonly IPagoRepository? _pagoRepository;

        public PagoController(IPagoRepository? pagoRepository)
        {
            _pagoRepository = pagoRepository;
        }
        public void AddPago(Pago pago) => _pagoRepository.Add(pago);

        public void UpdatePago(Pago pago) => _pagoRepository.Update(pago);

        public void DeletePago(int id) => _pagoRepository.Delete(id);
    }
}
