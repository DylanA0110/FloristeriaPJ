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
using Controladores;
using Modelo.Repositories;
using System.Runtime.InteropServices;

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

        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }

        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            txtNombreCliente.Text = NombreCliente;
            mtxtTelefono.Text = TelefonoCliente;
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Si se agregó con éxito
            this.Close();
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


