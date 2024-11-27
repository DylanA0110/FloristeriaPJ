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
    public partial class frmAgregarProveedor : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public frmAgregarProveedor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAggProveedor_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Si se agregó con éxito
            this.Close();
        }

        private void frmAgregarProveedor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtNombreProveedor_Enter(object sender, EventArgs e)
        {
            if (txtNombreProveedor.Text == "Nombre Proveedor")
            {
                txtNombreProveedor.Text = "";
            }
        }


        private void txtNombreProveedor_Leave(object sender, EventArgs e)
        {

            if (txtNombreProveedor.Text == "")
            {
                txtNombreProveedor.Text = "Nombre Proveedor";
            }
        }

       
    }
}
