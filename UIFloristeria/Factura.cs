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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            _facturaController = new FacturaController(
        new FacturaRepository(),  // Implementación de IFacturaRepository
        new PagoRepository(),     // Implementación de IPagoRepository
        new TipoDePagoRepository()); // Implementación de ITipoPagoRepository

            _tipoDePagoController = new TipoDePagoController(new TipoDePagoRepository());  // Inicializa correctamente
            _pagoController = new PagoController(new PagoRepository());
            _pedidoController = new PedidoController(new PedidosRepository());

        }


        private void Factura_Load(object sender, EventArgs e)
        {
            LoadFacturas();
            TxtNumFactura.Enabled = false;
        }

        private void LoadFacturas()
        {
            /*var factura = _facturaController.GetAllFactura();
            dgvFactura.DataSource = factura.ToList();
            dgvFactura.CurrentCell = null;
            dgvFactura.ClearSelection();
            if (dgvFactura.Columns.Count > 0)
            {
                dgvFactura.Columns[0].Visible = false;
            }*/

            var facturas = _facturaController.GetAllFacturasWithPago();
            dgvFactura.DataSource = facturas.ToList();

            if (dgvFactura.Columns.Count > 0)
            {
                dgvFactura.Columns["Id_factura"].Visible = false; // Oculta columnas innecesarias
               dgvFactura.Columns["Id_pedido"].Visible = true;
                dgvFactura.Columns["Id_Empleado"].Visible = false;
                dgvFactura.Columns["Estado"].Visible = false; // Oculta la columna Estado

                dgvFactura.Columns["MontoPago"].HeaderText = "Monto Pago";
                dgvFactura.Columns["Id_pedido"].HeaderText = "Número de Pedido";
                dgvFactura.Columns["MontoPago"].DefaultCellStyle.Format = "C2";

                dgvFactura.Columns["FechaPago"].HeaderText = "Fecha de Pago";

                // Reordenar las columnas (de arriba hacia abajo según tu preferencia)
                dgvFactura.Columns["Id_pedido"].DisplayIndex = 0;  // Número de Pedido
                dgvFactura.Columns["NumFactura"].DisplayIndex = 1; // Número de Factura
                dgvFactura.Columns["MontoPago"].DisplayIndex = 2;  // Monto Pago
                dgvFactura.Columns["Monto_total"].DisplayIndex = 3; // Monto Total
                dgvFactura.Columns["TipoDePago"].DisplayIndex = 4; // Tipo de Pago
                dgvFactura.Columns["FechaPago"].DisplayIndex = 5;  // Fecha de Pago

            }
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            TxtNumFactura.Enabled = rbFactura.Checked;
        }


        private void ResetTextBox(System.Windows.Forms.TextBox textBox, string defaultText)
        {
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == defaultText)
            {
                textBox.Text = defaultText;
            }
        }


        private void BtnInsertarFactura_Click(object sender, EventArgs e)
        {
            if (rbFactura.Checked && string.IsNullOrEmpty(TxtNumFactura.Text))
            {
                MessageBox.Show("Por favor, ingrese un número de factura.");
                return;
            }

            // Insertar factura
            var factura = new Facturas
            {
                Id_pedido = int.Parse(txtPedido.Text),
                // Si el RadioButton está marcado, se utiliza el número de factura ingresado, si no, se deja vacío
                NumFactura = rbFactura.Checked ? int.Parse(TxtNumFactura.Text) : 0,
                //Mont = rbFactura.Checked,
                Monto_total = decimal.Parse(TxtMontoTotal.Text),
             
            };
            _facturaController.AddFactura(factura);

            // Obtener ID de la factura recién creada
            var nuevaFactura = _facturaController.GetAllFactura().Last();

            // Insertar tipo de pago
            var tipoPago = new TipoDePago
            {
                Tipo = CboTipoDePago.Text
            };
            _tipoDePagoController.AddPago(tipoPago);

            // Obtener ID del tipo de pago recién creado
            var nuevoTipoPago = _tipoDePagoController.GetAll().Last();

            // Insertar pago relacionado con la factura
            var pago = new Pago
            {
                Id_factura = nuevaFactura.Id_factura,
                Monto = decimal.Parse(TxtMontoNeto.Text),
                Fecha_pago = dtpFechaPago.Value.Date,
                Id_Tipo_Pago = nuevoTipoPago.Id_Tipo_pago
            };
            _pagoController.AddPago(pago);

            // Recargar el DataGridView
            LoadFacturas();

            // Limpiar los campos de texto
            ResetTextBox(txtPedido, "Pedido");
            ResetTextBox(TxtNumFactura, "Numero Factura");
            ResetTextBox(TxtMontoTotal, "Monto total");
            ResetTextBox(TxtMontoNeto, "Monto Neto");

            CboTipoDePago.SelectedIndex = -1; // Si es un ComboBox, también puedes resetear su selección

            // Limpiar la fecha de pago
            dtpFechaPago.Value = DateTime.Now;

            // Desmarcar el RadioButton y deshabilitar el TextBox
            rbFactura.Checked = false;
            TxtNumFactura.Enabled = false;



            /*var facturas = new Facturas
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
            _tipoDePagoController.AddPago(TipoPago);*/


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
