﻿using System;
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
    public partial class FrmRegister : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtPrimerNombre_Enter(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "Primer Nombre")
            {
                txtPrimerNombre.Text = "";
            }
        }

        private void txtPrimerNombre_Leave(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "")
            {
                txtPrimerNombre.Text = "Primer Nombre";
            }
        }

        private void txtSegundoNombre_Enter(object sender, EventArgs e)
        {
            if (txtSegundoNombre.Text == "Segundo Nombre")
            {
                txtSegundoNombre.Text = "";
            }
        }

        private void txtSegundoNombre_Leave(object sender, EventArgs e)
        {
            if (txtSegundoNombre.Text == "")
            {
                txtSegundoNombre.Text = "Segundo Nombre";
            }
        }

        private void txtPrimerApellido_Enter(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "Primer Apellido")
            {
                txtPrimerApellido.Text = "";
            }
        }

        private void txtPrimerApellido_Leave(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "")
            {
                txtPrimerApellido.Text = "Primer Apellido";
            }
        }

        private void txtSegundoApellido_Enter(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "Segundo Apellido")
            {
                txtSegundoApellido.Text = "";
            }
        }

        private void txtSegundoApellido_Leave(object sender, EventArgs e)
        {
            if (txtSegundoApellido.Text == "")
            {
                txtSegundoApellido.Text = "Segundo Apellido";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
            }
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "Username")
            {
                txtPrimerNombre.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "")
            {
                txtPrimerNombre.Text = "Username";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true; // Oculta el texto como contraseña
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false; // Muestra el texto predeterminado como visible
            }
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

    }
}
