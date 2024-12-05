
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IEmpleadoRepository
    {
        IEnumerable<Empleado> GetAll();
        IEnumerable<Empleado> Search(string searchTerm);
        void Add(Empleado empleado);
        void Update(Empleado empleado);
        Empleado GetById(int id);
        void Delete(int id);

        Empleado Authenticate(string username, string password);
    }
}
