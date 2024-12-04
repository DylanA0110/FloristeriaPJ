using Controladores;
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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            string query = "SELECT TOP 10 * FROM Empleado"; // Cambia esta consulta según tu necesidad

            try
            {
                using (SqlConnection connection = CONECTA.GetConnection())
                {
                    connection.Open();

                    // Ejecutar la consulta
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable como origen de datos del DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }

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

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Busqueda")
            {
                txtBusqueda.Text = "";
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                txtBusqueda.Text = "Busqueda";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
