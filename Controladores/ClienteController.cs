using Modelo.Entidades;
using Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class ClienteController
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetAllClientes() => _clienteRepository.GetAll();

        public Cliente GetClienteById(int id) => _clienteRepository.GetById(id);

        public void AddCliente(Cliente cliente) => _clienteRepository.Add(cliente);

        public void UpdateCliente(Cliente cliente) => _clienteRepository.Update(cliente);

        public void DeleteCliente(int id) => _clienteRepository.Delete(id);

        public IEnumerable<Cliente> SearchClientes(string searchTerm) => _clienteRepository.Search(searchTerm);
    }
}