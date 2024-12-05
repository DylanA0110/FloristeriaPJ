using Controladores;
using Microsoft.Win32;
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

    public partial class frmProveedor : Form
    {
        public string ProveedorSeleccionado { get; set; }
        private readonly ProveedorController _proveedorController;

        public frmProveedor()
        {
            InitializeComponent();
            _proveedorController = new ProveedorController(new ProveedorRepository());
        }


        private void frmProveedor_Load(object sender, EventArgs e)
        {

            Loadproveedores();
            AdjustDatagridViewHeihgt();
        }

        private void Loadproveedores()
        {
            var proveedores = _proveedorController.GetAllProveedor();
            dgvProveedores.DataSource = proveedores.ToList();
            dgvProveedores.CurrentCell = null;
            dgvProveedores.ClearSelection();
            if (dgvProveedores.Columns.Count > 0)
            {
                dgvProveedores.Columns[0].Visible = false;
            }
        }

        private void AdjustDatagridViewHeihgt()
        {
            /* var height = dataGridView1.ColumnHeadersHeight;
             foreach (DataGridViewRow row in dataGridView1.Rows)
             {
                 height += row.Height;
             }
             dataGridView1.Height = height;*/
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor frmAgregar = new frmAgregarProveedor(_proveedorController);

            // Abrir el formulario como cuadro de diálogo
            frmAgregar.ShowDialog();

            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                Loadproveedores();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                // Asignar el nombre del proveedor seleccionado al campo ProveedorSeleccionado
                ProveedorSeleccionado = dgvProveedores.SelectedRows[0].Cells["Nombre_Proveedor"].Value.ToString();

                // Indicar que el formulario se cerrará con un resultado satisfactorio
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor.");
            }
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                var row = dgvProveedores.SelectedRows[0];

                // Verifica si el valor del ID del empleado es válido
                if (row.Cells["Id_proveedor"].Value != null)
                {
                    int idProveedor;
                    bool success = int.TryParse(row.Cells["Id_Proveedor"].Value.ToString(), out idProveedor);

                    if (success)
                    {
                        // Crea una instancia del formulario de edición y pasa el ID y el controlador
                        frmEditarProveedor formulario = new frmEditarProveedor(idProveedor, _proveedorController);
                        if (formulario.ShowDialog() == DialogResult.OK)
                        {
                            // Recarga los empleados después de editar
                            Loadproveedores();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID del proveedor no es un número válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del proveedor está vacío.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }
        }


        private void txtBusquedaProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtBusqueda.Text.Trim();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    var empleados = _proveedorController.SearchProveedor(searchTerm);
                    if (empleados.Any())
                    {
                        dgvProveedores.DataSource = empleados.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvProveedores.DataSource = null;
                    }
                }
                else
                {
                    Loadproveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
