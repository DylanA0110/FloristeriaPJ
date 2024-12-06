using Controladores;
using Modelo.Entidades;
using Modelo.Validaciones;
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
    public partial class frmEditarPedido : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private readonly PedidoController _pedidoController;
        private readonly int _idPedidoEditar;
        public frmEditarPedido(int idPedidoEditar, PedidoController pedidoController)
        {
            InitializeComponent();
            _pedidoController = pedidoController;
            _idPedidoEditar = idPedidoEditar;
        }

        private void frmEditarPedido_Load(object sender, EventArgs e)
        {
            var pedido = _pedidoController.GetPedidoById(_idPedidoEditar);
            if (pedido != null)
            {
                TxtEnviarseA.Text = pedido.Enviarse_A;
                dtpFechaEntrega.Value = (DateTime)pedido.Fecha_entrega;
                DtpSolicitud.Value = pedido.Fecha_solicitud;
                TxtDescripcion.Text = pedido.Descripcion.ToString();
                txtCantidad.Text = pedido.Cantidad.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el objeto compra con los valores ingresados
                var pedido = new Pedido
                {
                    Id_pedido = _idPedidoEditar,
                    Cantidad = int.Parse(txtCantidad.Text), // Convertir a int
                    Fecha_entrega = dtpFechaEntrega.Value, // Obtener valor del DateTimePicker
                    Fecha_solicitud = DtpSolicitud.Value,
                    Descripcion = TxtDescripcion.Text,
                    Enviarse_A = TxtEnviarseA.Text // Capturar el valor del texto
                };

                // Validar los datos ingresados
                var errores = ValidadorEntidad.Validar(pedido);
                if (errores.Count > 0)
                {
                    // Mostrar errores de validación
                    MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar la compra a través del controlador
                _pedidoController.UpdatePedido(pedido);

                MessageBox.Show("Compra actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Indicar que la edición fue exitosa
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmEditarPedido_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TxtEnviarseA_Leave(object sender, EventArgs e)
        {
            if (TxtEnviarseA.Text == "Enviarse a")
            {
                TxtEnviarseA.Text = "";
            }
        }

        private void TxtEnviarseA_Enter(object sender, EventArgs e)
        {
            if (TxtEnviarseA.Text == "")
            {
                TxtEnviarseA.Text = "Enviarse a";
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

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.Text = "";
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "Cantidad";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
