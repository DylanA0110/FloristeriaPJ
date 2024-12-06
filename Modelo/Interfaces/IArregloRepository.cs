using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IArregloRepository
    {
        IEnumerable<Arreglo> GetAll();
        Arreglo GetById(int id);
        void Add(Arreglo arreglo);
        void Update(Arreglo arreglo);
        void Delete(int id);
        IEnumerable<Arreglo> Search(string searchTerm);


        //arregloaccesorio parametro clase de la tabla
        //arregloflor
        IEnumerable<Arreglo_Accesorio> GetArreglosConAccesorios();
        void AddArregloAccesorio(Arreglo_Accesorio arregloAccesorio);
        void AddArregloFlor(Arreglo_Flor ArregloFlor);
    }
}
