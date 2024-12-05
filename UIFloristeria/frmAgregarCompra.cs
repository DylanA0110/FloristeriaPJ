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
    public partial class frmAgregarCompra : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly CompraController _compraController;
        public frmAgregarCompra(CompraController compraController)
        {
            InitializeComponent();
            _compraController = compraController;
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {

            // Validar y convertir la cantidad
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si la conversión falla
            }

            // Validar y convertir el precio unitario
            if (!decimal.TryParse(txtPrecio.Text, out decimal precioUnitario))
            {
                MessageBox.Show("El precio unitario ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si la conversión falla
            }

            // Crear el objeto Compra con los valores convertidos
            var nuevaCompra = new Compra
            {
                Cantidad = cantidad, // Usar la cantidad convertida
                FechaCompra = dtpFechaCompra.Value, // Acceder al valor del DateTimePicker
                Precio_Unitario = precioUnitario // Usar el precio unitario convertido
            };

            // Aquí puedes agregar el código para guardar la compra, etc.



            // Validar empleado
            var errores = ValidadorEntidad.Validar(nuevaCompra);

            if (errores.Count > 0)
            {
                // Mostrar errores en un MessageBox
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Agregar empleado a través del controlador
                _compraController.AddCompra(nuevaCompra);

                MessageBox.Show("Compra registrado con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmProveedor frmProveedor = new frmProveedor();
            if (frmProveedor.ShowDialog() == DialogResult.OK)
            {
                txtProveedor.Text = frmProveedor.ProveedorSeleccionado; // Recibir el proveedor seleccionado.
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmAgregarCompra_MouseDown(object sender, MouseEventArgs e)
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
                txtPrecio.Text = "Precio unitario";
            }
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "Precio unitario")
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

    }
}
