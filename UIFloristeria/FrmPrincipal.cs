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
    public partial class FrmPrincipal : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public FrmPrincipal()
        {
            InitializeComponent();

        }


        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 99)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }

            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 37)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();


        }


        private void AbrirFormularioEnPanel(Form formulario)
        {
            // Limpiar el panel antes de cargar un nuevo formulario
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls[0].Dispose();

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill; // Esto asegura que el formulario hijo llene el panel
            this.panelContenedor.Controls.Add(formulario);
            this.panelContenedor.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();

        }




        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 38)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 201)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btHamn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCerrarSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmEmpleado frmEmpleado = new frmEmpleado();
            AbrirFormularioEnPanel(frmEmpleado);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmCompra frmCompra = new frmCompra();
            AbrirFormularioEnPanel(frmCompra);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            AbrirFormularioEnPanel(factura);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido = new FrmPedido();
            AbrirFormularioEnPanel(frmPedido);
        }

        private void btnArreglos_Click(object sender, EventArgs e)
        {
            frmArreglo frmArreglo = new frmArreglo();
            AbrirFormularioEnPanel(frmArreglo);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            AbrirFormularioEnPanel(frmCliente);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            frmCompra frmCompra = new frmCompra();
            AbrirFormularioEnPanel(frmCompra);
        }
    }
}
