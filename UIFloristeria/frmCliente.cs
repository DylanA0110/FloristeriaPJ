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
            dgvClientes.DataSource = clientes.ToList();
        }

        private void btnAggCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregar = new frmAgregarCliente();

            // Abrir el formulario como cuadro de diálogo
            frmAgregar.ShowDialog();

        }


        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Obtén los valores de las columnas seleccionadas
                string nombreCliente = dgvClientes.SelectedRows[0].Cells["Nombre_Cliente"].Value.ToString();
                string telefonoCliente = dgvClientes.SelectedRows[0].Cells["Telefono"].Value?.ToString();

                // Crea una instancia del formulario de edición y pasa los datos
                frmEditarCliente frmEditar = new frmEditarCliente
                {
                    NombreCliente = nombreCliente,
                    TelefonoCliente = telefonoCliente
                };

                // Abre el formulario de edición como diálogo
                if (frmEditar.ShowDialog() == DialogResult.OK)
                {
                    LoadClientes(); // Recarga los datos si se realizaron cambios
                }
            }
        }


        private void txtBusquedaCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtBusquedaCliente.Text.Trim();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    var clientes = _clienteController.SearchClientes(searchTerm); // Busca clientes por término
                    if (clientes.Any())
                    {
                        dgvClientes.DataSource = clientes.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvClientes.DataSource = null;
                    }
                }
                else
                {
                    LoadClientes(); // Carga todos los clientes si no hay texto de búsqueda
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar clientes: {ex.Message}", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

