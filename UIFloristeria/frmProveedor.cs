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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFloristeria
{

    public partial class frmProveedor : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public string? ProveedorSeleccionado { get; set; }
        public int? IdProveedorSeleccionado { get; private set; }
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


            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                Loadproveedores();
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                var row = dgvProveedores.SelectedRows[0];
                ProveedorSeleccionado = row.Cells["Nombre_Proveedor"].Value.ToString();

                // Verificar si el valor es DBNull antes de asignar
                if (row.Cells["Id_Proveedor"].Value != DBNull.Value)
                {
                    IdProveedorSeleccionado = Convert.ToInt32(row.Cells["Id_Proveedor"].Value);
                }
                else
                {
                    MessageBox.Show("El ID del proveedor es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir si el ID es nulo
                }

                this.DialogResult = DialogResult.OK;
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

        private void frmProveedor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
