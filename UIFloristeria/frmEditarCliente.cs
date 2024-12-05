using Controladores;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.Repositories;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Modelo.Validaciones;

namespace UIFloristeria
{
    public partial class frmEditarCliente : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly ClienteController _clienteController;
        private readonly int _idClienteEditar;

        public frmEditarCliente(int idClienteEditar, ClienteController clienteController)
        {
            InitializeComponent();
            _idClienteEditar = idClienteEditar;
            _clienteController = clienteController;
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            var cliente = _clienteController.GetClienteById(_idClienteEditar);
            if (cliente != null)
            {
                txtNombreCliente.Text = cliente.Nombre_Cliente;
                mtxtTelefono.Text = cliente.Telefono;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente
            {
             Id_cliente = _idClienteEditar,
             Nombre_Cliente = txtNombreCliente.Text,
             Telefono = mtxtTelefono.Text
            };
            var errores = ValidadorEntidad.Validar(cliente);

            if (errores.Count > 0)
            {
                // Mostrar errores en un MessageBox
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _clienteController.UpdateCliente(cliente);
                MessageBox.Show("Cliente actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Indica éxito
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmEditarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


    }
}


