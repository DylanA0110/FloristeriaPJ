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
    public partial class frmEditarProveedor : Form
    {

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly ProveedorController _proveedorController;
        private readonly int _idProveedorEditar;
        public frmEditarProveedor(int idProveedorEditar, ProveedorController proveedorController)
        {
            InitializeComponent();
            _idProveedorEditar = idProveedorEditar;
            _proveedorController = proveedorController;
        }


        private void frmEditarProveedor_Load(object sender, EventArgs e)
        {
            // Cargar los datos del proveedor a editar
            var proveedor = _proveedorController.GetProveedorById(_idProveedorEditar);
            if (proveedor != null)
            {
                txtNombreProveedor.Text = proveedor.Nombre_Proveedor;
                mtxtTelefono.Text = proveedor.Telefono;
            }
            else
            {
                MessageBox.Show("No se encontró el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            // Crear un objeto proveedor con los datos editados
            var proveedor = new Proveedor
            {
                Id_Proveedor = _idProveedorEditar,
                Nombre_Proveedor = txtNombreProveedor.Text.Trim(),
                Telefono = mtxtTelefono.Text
            };

            // Validar los datos del proveedor
            var errores = ValidadorEntidad.Validar(proveedor);
            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Actualizar el proveedor en la base de datos
                _proveedorController.UpdateProveedor(proveedor);
                MessageBox.Show("Proveedor actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Indica éxito
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmEditarProveedor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}

