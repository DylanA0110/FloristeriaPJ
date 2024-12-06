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
            _pagoController = new PagoController(new PagoRepository());
            _tipoDePagoController = new TipoDePagoController(new TipoDePagoRepository());

        }


        private void Factura_Load(object sender, EventArgs e)
        {
            LoadFacturas();
        }

        private void LoadFacturas()
        {
            var factura = _facturaController.GetAllFactura();
            dgvFactura.DataSource = factura.ToList();
            dgvFactura.CurrentCell = null;
            dgvFactura.ClearSelection();
            if (dgvFactura.Columns.Count > 0)
            {
                dgvFactura.Columns[0].Visible = false;
            }
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            TxtNumFactura.Enabled = rbFactura.Checked;
        }


        private void BtnInsertarFactura_Click(object sender, EventArgs e)
        {
            var facturas = new Facturas
            {
              Id_pedido = int.Parse(txtPedido.Text),
                NumFactura = int.Parse(TxtNumFactura.Text),
                Estado = Convert.ToBoolean(rbFactura.Checked),
                Monto_total = int.Parse(TxtMontoTotal.Text),
            };
            _facturaController.AddFactura(facturas);



            var Pago = new Pago
            {
                Monto = Convert.ToDecimal(TxtMontoNeto.Text),
                Fecha_pago = dtpFechaPago.Value.Date,

            };

            _pagoController.AddPago(Pago);

            var TipoPago = new TipoDePago
            {
                Tipo = CboTipoDePago.Text,
            };
            _tipoDePagoController.AddPago(TipoPago);


        }

       

        private void TxtMontoNeto_Leave(object sender, EventArgs e)
        {
            if (TxtMontoNeto.Text == "")
            {
                TxtMontoNeto.Text = "Monto Neto";
            }
        }

        private void TxtMontoNeto_Enter(object sender, EventArgs e)
        {
            if (TxtMontoNeto.Text == "Monto Neto")
            {
                TxtMontoNeto.Text = "";
            }
        }

        private void TxtMontoTotal_Leave(object sender, EventArgs e)
        {
            if (TxtMontoTotal.Text == "")
            {
                TxtMontoTotal.Text = "Monto total";
            }
        }

        private void TxtMontoTotal_Enter(object sender, EventArgs e)
        {
            if (TxtMontoTotal.Text == "Monto total")
            {
                TxtMontoTotal.Text = "";
            }
        }

        private void TxtNumFactura_Leave(object sender, EventArgs e)
        {
            if (TxtNumFactura.Text == "")
            {
                TxtNumFactura.Text = "Numero Factura";
            }
        }

        private void TxtNumFactura_Enter(object sender, EventArgs e)
        {
            if (TxtNumFactura.Text == "Numero Factura")
            {
                TxtNumFactura.Text = "";
            }
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            frmVerPedidos frmver = new frmVerPedidos();
            if (frmver.ShowDialog() == DialogResult.OK)
            {
                txtPedido.Text = frmver.PedidoSeleccionado; // Recibir el proveedor seleccionado.
            }
        }
    }
}
