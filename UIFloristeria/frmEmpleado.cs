using Controladores;
using Modelo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFloristeria
{
    public partial class frmEmpleado : Form
    {
        private readonly EmpleadoController _empleadoController;
        public frmEmpleado()
        {
            InitializeComponent();
            _empleadoController = new EmpleadoController(new EmpleadoRepository());
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            LoadEmpleados();
        }

        private void LoadEmpleados()
        {
            var empleados = _empleadoController.GetAllEmpleados();
            dgvEmpleados.DataSource = empleados.ToList();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado frmEditar = new frmEditarEmpleado();

            // Abrir el formulario como cuadro de diálogo
            frmEditar.ShowDialog();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoriaEmpleado frmEditar = new frmAuditoriaEmpleado();

            // Abrir el formulario como cuadro de diálogo
            frmEditar.ShowDialog();
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtBusqueda.Text.Trim();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    var empleados = _empleadoController.SearchEmpleados(searchTerm);
                    if (empleados.Any())
                    {
                        dgvEmpleados.DataSource = empleados.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvEmpleados.DataSource = null; 
                    }
                }
                else
                {
                    LoadEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      }
}
