using Controladores;
using Modelo.Entidades;
using Modelo.Repositories;
using Modelo.Validaciones;
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
        private int ClienteSeleccionado;

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
                Fecha_entrega = DateTime.Parse(dtpFechaEntrega.Text),
                Id_cliente = ClienteSeleccionado
            };

            var errores = ValidadorEntidad.Validar(pedidos);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _pedidoController.AddPedido(pedidos);
                MessageBox.Show("Pedido registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void LimpiarCampos()
        {
            TxtCantidad.Clear();
            TxtDescripcion.Clear();
            txtPrimerNombre.Clear();
            TxtEnviarseA.Text = string.Empty;
            txtCliente.Clear();
            dtpFechaSoli.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;
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
                ClienteSeleccionado = frmCliente.idClienteSeleccionado;
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
                TxtEnviarseA.Text = "Enviarse a";
            }
        }

        private void TxtEnviarseA_Enter(object sender, EventArgs e)
        {
            if (TxtEnviarseA.Text == "Enviarse a")
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
            if (TxtCantidad.Text == "Cantidad")
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
