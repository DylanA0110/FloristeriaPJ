using Controladores;
using Modelo.Entidades;
using Modelo.Interfaces;
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
        private readonly PagoController _pagoController;
        private readonly TipoDePagoController _tipoDePagoController;
       
        //Constructor mierda
        public Factura()
        {
            InitializeComponent();
            _facturaController = new FacturaController(new FacturaRepository());
            _pedidoController = new PedidoController(new PedidosRepository());
         
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
            if (dgvFactura.Columns.Count > 0)
            {
                dgvFactura.Columns[0].Visible = false;
            }
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            TxtNumeroPedido.Enabled = rbFactura.Checked;
        }
        

        private void BtnInsertarFactura_Click(object sender, EventArgs e)
        {
            var facturas = new Facturas
            {
                Id_pedido = int.Parse(TxtNumeroPedido.Text),
                NumFactura = int.Parse(TxtNumFactura.Text),
                Estado = Convert.ToBoolean(rbFactura.Checked),
                Monto_total = int.Parse(TxtMontoTotal.Text),
            };
            _facturaController.AddFactura(facturas);
       


            var Pago = new Pago
            {
                Monto = Convert.ToInt64(TxtMontoNeto)
            };
            _pagoController.AddPago(Pago);

            var TipoPago = new TipoDePago
            {
                Tipo = CboTipoDePago.Text,
            };
            _tipoDePagoController.AddPago(TipoPago);

           
        }
    }
}
