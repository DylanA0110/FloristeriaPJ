using Controladores;
using System.Data.SqlClient;
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
using Modelo.Entidades;
using Modelo.Repositories;

namespace UIFloristeria
{
    public partial class FrmLogin : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly EmpleadoController _empleadoController;

        public FrmLogin()
        {
            InitializeComponent();
            _empleadoController = new EmpleadoController(new EmpleadoRepository());
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUser.Text;
            var password = txtPassword.Text;

            var empleado = _empleadoController.Authenticate(username, password);

            if (empleado != null)
            {
                EmpleadoAutenticado.EmpleadoId = empleado.Id_Empleado;
                EmpleadoAutenticado.PrimerNombre = empleado.PrimerNombre;
                EmpleadoAutenticado.PrimerApellido = empleado.PrimerApellido;
                EmpleadoAutenticado.RolId = empleado.RolId;
                EmpleadoAutenticado.password = password;

                MessageBox.Show($"¡Bienvenido {empleado.PrimerNombre} {empleado.PrimerApellido}!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            NoVer.Visible = true;
            Ver.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void NoVer_Click(object sender, EventArgs e)
        {
            NoVer.Visible = false;
            Ver.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }
    }

}



