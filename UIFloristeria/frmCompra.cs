using Controladores;
using Microsoft.Win32;
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
    public partial class frmCompra : Form
    {
        private readonly CompraController _compraController;
        public frmCompra()
        {
            InitializeComponent();
            _compraController = new CompraController(new CompraRepository());
        }


        private void btnAggCompra_Click(object sender, EventArgs e)
        {
            frmAgregarCompra frmAgg = new frmAgregarCompra(_compraController);

            if (frmAgg.ShowDialog() == DialogResult.OK)
            {
                LoadCompras();
            }
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            LoadCompras();
        }

        private void LoadCompras()
        {

            var Compras = _compraController.GetAllCompras();
            dgvCompra.DataSource = Compras.ToList();

            dgvCompra.CurrentCell = null;
            dgvCompra.ClearSelection();
            if (dgvCompra.Columns.Count > 0)
            {
                dgvCompra.Columns[0].Visible = false;
            }
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                var row = dgvCompra.SelectedRows[0];

                // Verifica si el valor del ID del empleado es válido
                if (row.Cells["Id_Compra"].Value != null)
                {
                    int idCompra;
                    bool success = int.TryParse(row.Cells["Id_Compra"].Value.ToString(), out idCompra);

                    if (success)
                    {
                        // Crea una instancia del formulario de edición y pasa el ID y el controlador
                        frmEditarCompra formulario = new frmEditarCompra(idCompra, _compraController);
                        if (formulario.ShowDialog() == DialogResult.OK)
                        {
                            // Recarga los empleados después de editar
                            LoadCompras();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID de la compra no es un número válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID de la compra está vacío.");
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
                    var empleados = _compraController.SearchCompra(searchTerm);
                    if (empleados.Any())
                    {
                        dgvCompra.DataSource = empleados.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvCompra.DataSource = null;
                    }
                }
                else
                {
                    LoadCompras();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
