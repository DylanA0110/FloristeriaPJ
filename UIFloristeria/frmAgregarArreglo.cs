using Controladores;
using Modelo.Entidades;
using Modelo.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFloristeria
{
    public partial class frmAgregarArreglo : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly ArregloController _arregloController;
        private readonly CategoryController _categoriaController;
        public frmAgregarArreglo(ArregloController arregloController, CategoryController category)
        {
            InitializeComponent();
            _arregloController = arregloController;
            _categoriaController = category;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAggArreglo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out int Cantidad))
            {
                MessageBox.Show("Por favor ingrese una cantidad  válido.");
                return;
            }
            var nuevoArreglo = new Arreglo
            {
                Nombre_Arreglo = txtNombreArreglo.Text,
                Cantidad = Cantidad
            };


            try
            {
                // Validar selección de categoría
                if (CbCategoria.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una categoría válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear un objeto Arreglo con los datos ingresados
                nuevoArreglo.Id_Categoria = (int)CbCategoria.SelectedValue;
                MessageBox.Show($" id categoria: {nuevoArreglo.Id_Categoria}");

                // Guardar el arreglo en la base de datos usando la instancia global
                _arregloController.AddArreglo(nuevoArreglo);

                MessageBox.Show("Arreglo guardado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                // Limpiar los campos

                CbCategoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar el arreglo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Validar empleado
            var errores = ValidadorEntidad.Validar(nuevoArreglo);

            if (errores.Count > 0)
            {
                // Mostrar errores en un MessageBox
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            this.DialogResult = DialogResult.OK; // Si se agregó con éxito
            this.Close();
        }

        private void frmAgregarArreglo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtNombreArreglo_Leave(object sender, EventArgs e)
        {
            if (txtNombreArreglo.Text == "")
            {
                txtNombreArreglo.Text = "Nombre Arreglo";
            }
        }

        private void txtNombreArreglo_Enter(object sender, EventArgs e)
        {
            if (txtNombreArreglo.Text == "Nombre Arreglo")
            {
                txtNombreArreglo.Text = "";
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "Cantidad";
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.Text = "";
            }
        }

        private void frmAgregarArreglo_Load(object sender, EventArgs e)
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
                CbCategoria.ValueMember = "Id_Categoria";      // El valor asociado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
