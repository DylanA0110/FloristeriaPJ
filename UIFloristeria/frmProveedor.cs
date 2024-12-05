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


            AdjustDatagridViewHeihgt();
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
    }
}
