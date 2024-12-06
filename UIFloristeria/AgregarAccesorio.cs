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
    public partial class AgregarAccesorio : Form
    {
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private readonly AccesorioController _AccesorioController;

        public AgregarAccesorio(AccesorioController accesorioController)
        {
            InitializeComponent();
            _AccesorioController = accesorioController;
            LoadAccesorios();
            DgvAccesorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void LoadAccesorios()
        {
            var Accesorio = _AccesorioController.GetAllAccesorio();
            DgvAccesorio.DataSource = Accesorio.ToList();
            DgvAccesorio.CurrentCell = null;
            DgvAccesorio.ClearSelection();
        }

        private void BtnAgregarAcc_Click(object sender, EventArgs e)
        {
            var nuevoAcc = new Accesorio
            {
                Nombre_Accesorio = TxtNombreAccesorio.Text,
            };
            // Validar empleado
            var errores = ValidadorEntidad.Validar(nuevoAcc);

            if (errores.Count > 0)
            {
                // Mostrar errores en un MessageBox
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Agregar empleado a través del controlador
                _AccesorioController.AddAccesorio(nuevoAcc);

                MessageBox.Show("Accesorio registrado con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AgregarAccesorio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TxtNombreAccesorio_Leave(object sender, EventArgs e)
        {
            if (TxtNombreAccesorio.Text == "")
            {
                TxtNombreAccesorio.Text = "Nombre Accesorio";
            }
        }

        private void TxtNombreAccesorio_Enter(object sender, EventArgs e)
        {
            if (TxtNombreAccesorio.Text == "Nombre Accesorio")
            {
                TxtNombreAccesorio.Text = "";
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvAccesorio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un accesorio para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el accesorio seleccionado
            var accesorioSeleccionado = (Accesorio)DgvAccesorio.SelectedRows[0].DataBoundItem;

            // Obtener los nuevos valores desde el TextBox
            var nombreAccesorio = TxtNombreAccesorio.Text;

            if (string.IsNullOrWhiteSpace(nombreAccesorio))
            {
                MessageBox.Show("Por favor, ingresa un nombre de accesorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear el objeto de accesorio para la actualización
            var accesorio = new Accesorio
            {
                Id_Accesorio = accesorioSeleccionado.Id_Accesorio, // Usar el ID del accesorio seleccionado
                Nombre_Accesorio = nombreAccesorio
            };

            // Validar el accesorio
            var errores = ValidadorEntidad.Validar(accesorio);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Actualizar el accesorio a través del controlador
                _AccesorioController.UpdateAccesorio(accesorio);

                MessageBox.Show("Accesorio actualizado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Indica éxito
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar el accesorio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

