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

    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }


        private void frmProveedor_Load(object sender, EventArgs e)
        {
            

            AdjustDatagridViewHeihgt();
        }


        private void AdjustDatagridViewHeihgt()
        {
            /* var height = dataGridView1.ColumnHeadersHeight;
             foreach (DataGridViewRow row in dataGridView1.Rows)
             {
                 height += row.Height;
             }
             dataGridView1.Height = height;*/
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            frmAgregarProveedor frmAgregar = new frmAgregarProveedor();

            // Abrir el formulario como cuadro de diálogo
            frmAgregar.ShowDialog();
        }
    }
}
