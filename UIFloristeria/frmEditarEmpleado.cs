using Controladores;
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

        private void btnEditarEpleado_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Si se agregó con éxito
            this.Close();
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

        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Indica que se realizó una edición exitosa
            this.Close();
        }
    }
}
