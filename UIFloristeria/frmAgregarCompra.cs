using Controladores;
using Microsoft.Data.SqlClient;
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
        private int selectedProveedorId;
        private readonly CompraController _compraController;
        private int lastFlorId = -1; // Inicializa en -1 para indicar que no hay ID
        private int lastAccesorioId = -1; // Inicializa en -1 para indicar que no hay ID
        public frmAgregarCompra(CompraController compraController)
        {
            InitializeComponent();
            _compraController = compraController;
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {

            // Validar la cantidad ingresada
            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el precio unitario ingresado
            if (!decimal.TryParse(txtPrecio.Text, out decimal precioUnitario))
            {
                MessageBox.Show("El precio unitario ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya seleccionado un proveedor
            if (selectedProveedorId <= 0)
            {
                MessageBox.Show("Debes seleccionar un proveedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que se haya seleccionado un producto
            if (cboProducto.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el nombre del producto no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una nueva compra
            var nuevaCompra = new Compra
            {
                Cantidad = cantidad,
                FechaCompra = dtpFechaCompra.Value,
                Precio_Unitario = precioUnitario
            };

            // Validar la nueva compra
            var errores = ValidadorEntidad.Validar(nuevaCompra);
            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Agregar la compra y obtener el ID
                int idCompra = _compraController.AddCompra(nuevaCompra);

                // Crear el detalle de la compra
                Detalle_Compra detalleCompra = new Detalle_Compra
                {
                    Id_Compra = idCompra,
                    Id_Proveedor = selectedProveedorId,
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario
                };

                // Asignar el ID del producto correspondiente
                string productoSeleccionado = cboProducto.SelectedItem.ToString();
                if (productoSeleccionado == "Flor")
                {
                    detalleCompra.Id_Flor = lastFlorId; // Usar el último ID de flor
                    detalleCompra.Id_Accesorio = null; // No se utiliza
                }
                else if (productoSeleccionado == "Accesorio")
                {
                    detalleCompra.Id_Accesorio = lastAccesorioId; // Usar el último ID de accesorio
                    detalleCompra.Id_Flor = null; // No se utiliza
                }

                // Agregar el detalle de la compra
                _compraController.AddDetalleCompra(detalleCompra);
                // Crear y agregar el detalle del proveedor
                Detalle_Proveedor detalleProveedor = new Detalle_Proveedor
                {
                    Id_Proveedor = selectedProveedorId,
                    Id_Flor = detalleCompra.Id_Flor,
                    Id_Accesorio = detalleCompra.Id_Accesorio
                };

                _compraController.AddDetalleProveedor(detalleProveedor); // Asegúrate de que este método esté implementado en tu controlador
                MessageBox.Show("Compra registrada con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de base de datos: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtProveedor.Text = frmProveedor.ProveedorSeleccionado;

                // Asegúrate de que el ID del proveedor no sea DBNull
                if (frmProveedor.IdProveedorSeleccionado != null)
                {
                    selectedProveedorId = (int)frmProveedor.IdProveedorSeleccionado;
                }
                else
                {
                    MessageBox.Show("No se seleccionó un proveedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = cboProducto.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (productoSeleccionado == "Flor")
                {
                    var flor = new Flor { Nombre_Flor = txtNombreProducto.Text };
                    _compraController.AddFlor(flor);
                    lastFlorId = _compraController.GetLastFlorId();
                    MessageBox.Show("Flor agregada con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (productoSeleccionado == "Accesorio")
                {
                    var accesorio = new Accesorio { Nombre_Accesorio = txtNombreProducto.Text };
                    _compraController.AddAccesorio(accesorio);
                    lastAccesorioId = _compraController.GetLastAccesorioId();
                    MessageBox.Show("Accesorio agregado con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnAgregarCompra.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
