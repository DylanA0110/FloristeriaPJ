using Modelo.Entidades;
using Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class CategoryController
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoryController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        /// <summary>
        /// Obtener todas las categorías de la base de datos.
        /// </summary>
        public IEnumerable<Categoria> GetAllCategorias()
        {
            return _categoriaRepository.GetAll();
        }

        /// <summary>
        /// Agregar una nueva categoría.
        /// </summary>
        public void AddCategoria(Categoria categoria)
        {
            _categoriaRepository.Add(categoria);
        }

        /// <summary>
        /// Actualizar una categoría existente.
        /// </summary>
        public void UpdateCategoria(Categoria categoria)
        {
            _categoriaRepository.Update(categoria);
        }

        /// <summary>
        /// Obtener las categorías estáticas para el ComboBox.
        /// </summary>
        public List<string> GetCategoriasEstaticas()
        {
            // Estas categorías son fijas y no se extraen de la base de datos.
            return new List<string>
        {
            "14 de Febrero",
            "Día de las Madres",
            "Funebre",
            "Variados"
        };
        }
    }
}
