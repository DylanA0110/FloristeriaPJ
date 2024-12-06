using Controladores;
using Modelo.Repositories;
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
    public partial class frmVerPedidos : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public string? PedidoSeleccionado { get; set; }
        private readonly PedidoController _pedidoController;
        public frmVerPedidos()
        {
            InitializeComponent();
            _pedidoController = new PedidoController(new PedidosRepository());
        }

        private void frmVerPedidos_Load(object sender, EventArgs e)
        {
            LoadPedidos();
        }

        private void LoadPedidos()
        {
            var pedidos = _pedidoController.GetAllPedido();
            dgvPedidos.DataSource = pedidos.ToList();
            dgvPedidos.CurrentCell = null;
            dgvPedidos.ClearSelection();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                // Asignar el nombre del proveedor seleccionado al campo ProveedorSeleccionado
                PedidoSeleccionado = dgvPedidos.SelectedRows[0].Cells["id_Pedido"].Value.ToString();

                // Indicar que el formulario se cerrará con un resultado satisfactorio
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un pedido.");
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtBusqueda.Text.Trim();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    var pedidos = _pedidoController.SearchPedido(searchTerm);
                    if (pedidos.Any())
                    {
                        dgvPedidos.DataSource = pedidos.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvPedidos.DataSource = null;
                    }
                }
                else
                {
                    LoadPedidos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVerPedidos_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
