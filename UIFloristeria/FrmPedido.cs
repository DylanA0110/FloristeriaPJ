using Controladores;
using Modelo.Entidades;
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
    public partial class FrmPedido : Form
    {
        private readonly PedidoController _pedidoController;
        private readonly ClienteController _clienteController;

        public FrmPedido()
        {
            InitializeComponent();
            _pedidoController = new PedidoController(new PedidosRepository());
            _clienteController = new ClienteController(new ClienteRepository());
        }

        private void BtnAgregarRemision_Click(object sender, EventArgs e)
        {
            var pedidos = new Pedido
            {
                Enviarse_A = TxtEnviarseA.Text,
                Descripcion = TxtDescripcion.Text,
                Cantidad = int.Parse(TxtCantidad.Text),
                Fecha_solicitud = DateTime.Parse(dtpFechaSoli.Text),
                Fecha_entrega = DateTime.Parse(dtpFechaEntrega.Text)
            };
            _pedidoController.AddPedido(pedidos);


        }



        private void FrmPedido_Load(object sender, EventArgs e)
        {
            LoadPedido();
        }

        private void LoadPedido()
        {
            var pedido = _pedidoController.GetAllPedido();
            dgvPedidos.DataSource = pedido.ToList();
            dgvPedidos.CurrentCell = null;
            dgvPedidos.ClearSelection();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                txtCliente.Text = frmCliente.ClienteSeleccionado;
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                var row = dgvPedidos.SelectedRows[0];

                // Verifica si el valor del ID del empleado es válido
                if (row.Cells["Id_pedido"].Value != null)
                {
                    int idPedido;
                    bool success = int.TryParse(row.Cells["Id_pedido"].Value.ToString(), out idPedido);

                    if (success)
                    {
                        // Crea una instancia del formulario de edición y pasa el ID y el controlador
                        frmEditarPedido formulario = new frmEditarPedido(idPedido, _pedidoController);
                        if (formulario.ShowDialog() == DialogResult.OK)
                        {
                            // Recarga los empleados después de editar
                            LoadPedido();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID del Pedido no es un número válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del Pedido está vacío.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }

        }

        private void TxtEnviarseA_Leave(object sender, EventArgs e)
        {
            if (TxtEnviarseA.Text == "")
            {
                TxtEnviarseA.Text = "Enviarse_a";
            }
        }

        private void TxtEnviarseA_Enter(object sender, EventArgs e)
        {
            if (TxtEnviarseA.Text == "Enviarse_a")
            {
                TxtEnviarseA.Text = "";
            }
        }

        private void TxtDescripcion_Leave(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text == "")
            {
                TxtDescripcion.Text = "Descripcion";
            }
        }

        private void TxtDescripcion_Enter(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text == "Descripcion")
            {
                TxtDescripcion.Text = "";
            }
        }

        private void TxtCantidad_Enter(object sender, EventArgs e)
        {
            if(TxtCantidad.Text == "Cantidad")
            {
                TxtCantidad.Text = "";
            }
        }

        private void TxtCantidad_Leave(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "")
            {
                TxtCantidad.Text = "Cantidad";
            }
        }
    }
}
