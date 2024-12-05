﻿using Controladores;
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
    public partial class frmAgregarCliente : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly ClienteController _clienteController;

        public frmAgregarCliente(ClienteController clienteController)
        {
            InitializeComponent();
            _clienteController = clienteController;
        }

        private void btnAggCliente_Click(object sender, EventArgs e)
        {

            var nuevoCliente = new Cliente
            {
                Nombre_Cliente = txtNombreCliente.Text,
                Telefono = mtxtTelefono.Text
            };
            // Validar empleado
            var errores = ValidadorEntidad.Validar(nuevoCliente);

            if (errores.Count > 0)
            {
                // Mostrar errores en un MessageBox
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Agregar empleado a través del controlador
                _clienteController.AddCliente(nuevoCliente);

                MessageBox.Show("Cliente registrado con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmAgregarCliente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtNombreCliente_Leave(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "")
            {
                txtNombreCliente.Text = "Nombre Cliente";
            }

        }

        private void txtNombreCliente_Enter(object sender, EventArgs e)
        {
            if (txtNombreCliente.Text == "Nombre Cliente")
            {
                txtNombreCliente.Text = "";
            }
        }
    }
}
