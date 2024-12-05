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
    public partial class frmEditarCompra : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly CompraController _compraController;
        private readonly int _idCompraEditar;

        public frmEditarCompra(int idCompraEditar, CompraController compraController)
        {
            InitializeComponent();
            _idCompraEditar = idCompraEditar;
            _compraController = compraController;
        }

        private void frmEditarCompra_Load(object sender, EventArgs e)
        {
            var compra = _compraController.GetCompraById(_idCompraEditar);
            if (compra != null)
            {
                txtCantidad.Text = compra.Cantidad.ToString();
                dtpFechaCompra.Value = compra.FechaCompra;
                txtPrecio.Text = compra.Precio_Unitario.ToString("F2"); // Formatear a 2 decimales
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el objeto compra con los valores ingresados
                var compra = new Compra
                {
                    Id_Compra = _idCompraEditar,
                    Cantidad = int.Parse(txtCantidad.Text), // Convertir a int
                    FechaCompra = dtpFechaCompra.Value, // Obtener valor del DateTimePicker
                    Precio_Unitario = decimal.Parse(txtPrecio.Text) // Convertir a decimal
                };

                // Validar los datos ingresados
                var errores = ValidadorEntidad.Validar(compra);
                if (errores.Count > 0)
                {
                    // Mostrar errores de validación
                    MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar la compra a través del controlador
                _compraController.UpdateCompra(compra);

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

        private void frmEditarCompra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "Cantidad";
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "Cantidad")
            {
                txtCantidad.Text = "";
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "Precio Unitario";
            }
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "Precio Unitario")
            {
                txtPrecio.Text = "";
            }
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "")
            {
                txtNombreProducto.Text = "Nombre producto";
            }
        }

        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text == "Nombre producto")
            {
                txtNombreProducto.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}



