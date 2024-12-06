using Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFloristeria
{
    public partial class frmArreglo : Form
    {
        public frmArreglo()
        {
            InitializeComponent();
        }



        private void btnAggArreglo_Click(object sender, EventArgs e)
        {
            frmAgregarArreglo frmAgregar = new frmAgregarArreglo();

            // Abrir el formulario como cuadro de diálogo
            frmAgregar.ShowDialog();
        }

        private void frmArreglos_Load(object sender, EventArgs e)
        {

        }

        private void BtnAccesorio_Click(object sender, EventArgs e)
        {

        }
    }
}
