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
using Modelo.Entidades;
using UIFloristeria;


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
            dgvClientes.CurrentCell = null;
            dgvClientes.ClearSelection();
        }

        private void btnAggCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente agregarCliente = new frmAgregarCliente(_clienteController);
  
            //Si Mando exito
            if (agregarCliente.ShowDialog() == DialogResult.OK)
            {
                // Recarga los clientes
                LoadClientes();
            }

        }


        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var row = dgvClientes.SelectedRows[0];

                // Verifica si el valor del ID del empleado es válido
                if (row.Cells["Id_cliente"].Value != null)
                {
                    int idCliente;
                    bool success = int.TryParse(row.Cells["Id_cliente"].Value.ToString(), out idCliente);

                    if (success)
                    {
                        // Crea una instancia del formulario de edición y pasa el ID y el controlador
                        frmEditarCliente formulario = new frmEditarCliente(idCliente, _clienteController);
                        if (formulario.ShowDialog() == DialogResult.OK)
                        {
                            // Recarga los empleados después de editar
                            LoadClientes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID del cliente no es un número válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del cliente está vacío.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
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



