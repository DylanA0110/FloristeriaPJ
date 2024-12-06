using Controladores;
using Modelo.Entidades;
using Modelo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFloristeria
{
    public partial class frmArreglo : Form
    {
        private readonly CategoryController _categoriaController;
        private readonly ArregloController _arregloController;
        public frmArreglo()
        {
            InitializeComponent();
            _categoriaController = new CategoryController(new CategoryRepository());
            _arregloController = new ArregloController(new ArregloRepository(), new FlorRepository(), new AccesorioRepository());
        }



        private void btnAggArreglo_Click(object sender, EventArgs e)
        {
            frmAgregarArreglo frmAgregar = new frmAgregarArreglo();

            // Abrir el formulario como cuadro de diálogo
            frmAgregar.ShowDialog();
        }

        private void frmArreglos_Load(object sender, EventArgs e)
        {
            LoadCategorias();
        }

        private void LoadCategorias()
        {
            try
            {
                // Obtener las categorías desde el controlador
                var categorias = _categoriaController.GetAllCategorias().ToList();

                // Establecer la fuente de datos del ComboBox
                CbCategoria.DataSource = categorias;
                CbCategoria.DisplayMember = "Nombre_Categoria"; // Lo que se mostrará
                CbCategoria.ValueMember = "Id_categoria";      // El valor asociado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAccesorio_Click(object sender, EventArgs e)
        {

        }

        private void BtnInsertarArreglo_Click(object sender, EventArgs e)
        {
            ImplimentarCbo();




        }
        private void ImplimentarCbo()
        {
            try
            {
                // Validar selección de categoría
                if (CbCategoria.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una categoría válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un objeto Arreglo con los datos ingresados
                var arreglo = new Arreglo
                {
                    Id_Categoria = (int)CbCategoria.SelectedValue, // Obtener la categoría seleccionada

                };

                // Guardar el arreglo en la base de datos usando la instancia global
                _arregloController.AddArreglo(arreglo);

                MessageBox.Show("Arreglo guardado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos

                CbCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el arreglo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
