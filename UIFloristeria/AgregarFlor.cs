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
    public partial class AgregarFlor : Form
    {

        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private readonly FlorController _florController;
        public int? id_flor { get; set; }

        public AgregarFlor()
        {
            InitializeComponent();
        }

        private void AgregarFlor_Load(object sender, EventArgs e)
        {

        }

        private void TxtNombreFlor_Leave(object sender, EventArgs e)
        {

        }
    }
}
