using Controladores;
using Modelo.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFloristeria
{
    public partial class frmCompra : Form
    {
        private readonly CompraController _compraController;
        public frmCompra()
        {
            InitializeComponent();
            _compraController = new CompraController(new CompraRepository());
        }


        private void btnAggCompra_Click(object sender, EventArgs e)
        {
            frmAgregarCompra frmAgg = new frmAgregarCompra(_compraController);
            frmAgg.ShowDialog();
        }

    }
}
