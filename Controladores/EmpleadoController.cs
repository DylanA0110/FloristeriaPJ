using Modelo.Entidades;
using Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controladores
{
    public class EmpleadoController
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public EmpleadoController(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public IEnumerable<Empleado> GetAllEmpleados() => _empleadoRepository.GetAll();

        public Empleado GetEmpleadoById(int id) => _empleadoRepository.GetById(id);

        public void AddEmpleado(Empleado empleado) => _empleadoRepository.Add(empleado);

        public void UpdateEmpleado(Empleado empleado) => _empleadoRepository.Update(empleado);

        public void DeleteEmpleado(int id) => _empleadoRepository.Delete(id);

        public IEnumerable<Empleado> SearchEmpleados(string searchTerm) => _empleadoRepository.Search(searchTerm);

        public Empleado Authenticate(string username, string password) => _empleadoRepository.Authenticate(username, password);


    }
}
