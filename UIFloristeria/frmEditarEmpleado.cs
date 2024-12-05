using Controladores;
using Modelo.Entidades;
using Modelo.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFloristeria
{

    public partial class frmEditarEmpleado : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly EmpleadoController _empleadoController;
        private readonly int _idEmpleadoEditar;

        public frmEditarEmpleado(int idEmpleadoEditar, EmpleadoController empleadoController)
        {
            InitializeComponent();
            _idEmpleadoEditar = idEmpleadoEditar;
            _empleadoController = empleadoController;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmEditarEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            var empleado = _empleadoController.GetEmpleadoById(_idEmpleadoEditar);
            if (empleado != null)
            {
                txtPrimerNombre.Text = empleado.PrimerNombre;
                txtSegundoNombre.Text = empleado.SegundoNombre;
                txtPrimerApellido.Text = empleado.PrimerApellido;
                txtSegundoApellido.Text = empleado.SegundoApellido;
                txtCorreo.Text = empleado.Correo;
                mtxtTelefono.Text = empleado.Telefono;
                txtPass.Text = empleado.Contrasena;
                rbHombre.Checked = empleado.Sexo.Trim() == "M";
                rbMujer.Checked = empleado.Sexo.Trim() == "F";
                rbSi.Checked = empleado.EsAprobado;
                rbNo.Checked = !empleado.EsAprobado;
                dtpFechaNac.Value = (DateTime)empleado.FechaDeNac;
                txtUserName.Text = empleado.UserName;
            }
            else
            {
                MessageBox.Show("No se encontró el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            string nuevaContrasena = null; // Variable para la nueva contraseña
            if (chkCambiarPass.Checked)
            {
                if (txtPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                nuevaContrasena = txtPass.Text; // Asigna la nueva contraseña
            }

            var empleado = new Empleado
            {
                Id_Empleado = _idEmpleadoEditar,
                PrimerNombre = txtPrimerNombre.Text,
                SegundoNombre = txtSegundoNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                Sexo = rbHombre.Checked ? "M" : "F",
                Correo = txtCorreo.Text,
                Telefono = mtxtTelefono.Text,
                Contrasena = nuevaContrasena ?? txtPass.Text, // Usa la nueva contraseña o conserva la actual
                EsAprobado = rbSi.Checked,
                UserName = txtUserName.Text,
                FechaDeNac = (DateTime)dtpFechaNac.Value,
                RolId = 0


            };
            // Validar empleado
            var errores = ValidadorEntidad.Validar(empleado);

            if (errores.Count > 0)
            {
                // Mostrar errores en un MessageBox
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _empleadoController.UpdateEmpleado(empleado);
                MessageBox.Show("Empleado actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NoVer_Click(object sender, EventArgs e)
        {
            NoVer.Visible = false;
            Ver.Visible = true;
            txtPass.UseSystemPasswordChar = false;
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            NoVer.Visible = true;
            Ver.Visible = false;
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtConfirmPass_Enter(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "Confirmar Contraseña")
            {
                txtConfirmPass.Text = "";
                txtConfirmPass.UseSystemPasswordChar = true; // Oculta el texto como contraseña
            }
        }

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == "")
            {
                txtConfirmPass.Text = "Confirmar Contraseña";
                txtConfirmPass.UseSystemPasswordChar = false; // Muestra el texto predeterminado como visible
            }
        }

        private void chkCambiarPass_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitar = chkCambiarPass.Checked;
            txtPass.Enabled = habilitar;
            txtConfirmPass.Enabled = habilitar;

            // Limpia los campos si se desactiva el CheckBox
            if (!habilitar)
            {
                txtPass.Text = string.Empty;
                txtConfirmPass.Text = string.Empty;
            }
        }
    }
}
