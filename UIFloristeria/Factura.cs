using Controladores;
using Modelo.Repositories;
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
    public partial class Factura : Form
    {
        private readonly FacturaController _facturaController;
        private readonly PedidoController _pedidoController;
        public Factura()
        {
            InitializeComponent();
            _facturaController = new FacturaController(new FacturaRepository());
        }


        private void Factura_Load(object sender, EventArgs e)
        {
            LoadFacturas();
        }

        private void LoadFacturas()
        {
            var pedido = _pedidoController.GetAllPedido();
            dgvFactura.DataSource = pedido.ToList();
            dgvFactura.CurrentCell = null;
            dgvFactura.ClearSelection();
        }



    }
}
