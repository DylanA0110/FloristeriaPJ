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
using Modelo.Repositories;


namespace UIFloristeria
{
    public partial class frmCliente : Form
    {
        private readonly ClienteController _clienteController;

        public frmCliente()
        {
            InitializeComponent();
            _clienteController = new ClienteController(new ClienteRepository());
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            LoadClientes();
        }

        private void LoadClientes()
        {
            var clientes = _clienteController.GetAllClientes();
            dataGridView1.DataSource = clientes.ToList();
        }

        private void btnAggCliente_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor frmAgregar = new frmAgregarProveedor();

            // Abrir el formulario como cuadro de diálogo
            frmAgregar.ShowDialog();
            LoadClientes();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}