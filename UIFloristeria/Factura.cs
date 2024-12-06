using Controladores;
using Modelo.Entidades;
using Modelo.Interfaces;
using Modelo.Repositories;
using Modelo.Validaciones;
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
            // Validar que los campos obligatorios estén completos y sean válidos
            if (!int.TryParse(txtPedido.Text, out int idPedido))
            {
                MessageBox.Show("Por favor ingrese un ID de pedido válido.");
                return;
            }

            int numFactura = 0;
            if (rbFactura.Checked && !int.TryParse(TxtNumFactura.Text, out numFactura))
            {
                MessageBox.Show("Por favor ingrese un número de factura válido.");
                return;
            }

            if (!decimal.TryParse(TxtMontoTotal.Text, out decimal montoTotal))
            {
                MessageBox.Show("Por favor ingrese un monto total válido.");
                return;
            }

            // Crear la factura
            var factura = new Facturas
            {
                Id_pedido = idPedido,
                NumFactura = numFactura,
                Monto_total = montoTotal,
            };
            // Validar la factura
            var erroresFactura = ValidadorEntidad.Validar(factura);
            if (erroresFactura.Count > 0)
            {
                // Mostrar los errores de validación
                MessageBox.Show(string.Join("\n", erroresFactura), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insertar factura
            _facturaController.AddFactura(factura);

            // Obtener ID de la factura recién creada
            var nuevaFactura = _facturaController.GetAllFactura().Last();

            // Crear el tipo de pago
            var tipoPago = new TipoDePago
            {
                Tipo = CboTipoDePago.Text
            };

            // Validar el tipo de pago
            var erroresTipoPago = ValidadorEntidad.Validar(tipoPago);
            if (erroresTipoPago.Count > 0)
            {
                // Mostrar los errores de validación
                MessageBox.Show(string.Join("\n", erroresTipoPago), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insertar tipo de pago
            _tipoDePagoController.AddPago(tipoPago);

            // Obtener ID del tipo de pago recién creado
            var nuevoTipoPago = _tipoDePagoController.GetAll().Last();

            // Crear el pago
            var pago = new Pago
            {
                Id_factura = nuevaFactura.Id_factura,
                Monto = decimal.Parse(TxtMontoNeto.Text),
                Fecha_pago = dtpFechaPago.Value.Date,
                Id_Tipo_Pago = nuevoTipoPago.Id_Tipo_pago
            };

            // Validar el pago
            var erroresPago = ValidadorEntidad.Validar(pago);
            if (erroresPago.Count > 0)
            {
                // Mostrar los errores de validación
                MessageBox.Show(string.Join("\n", erroresPago), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insertar pago relacionado con la factura
            _pagoController.AddPago(pago);

            // Recargar el DataGridView
            LoadFacturas();

            // Limpiar los campos de texto
            ResetTextBox(txtPedido, "Pedido");
            ResetTextBox(TxtNumFactura, "Numero Factura");
            ResetTextBox(TxtMontoTotal, "Monto total");
            ResetTextBox(TxtMontoNeto, "Monto Neto");

            Limpiar();
        }

        private void Limpiar()
        {
            // Limpiar los campos de texto
            ResetTextBox(txtPedido, "Pedido");
            ResetTextBox(TxtNumFactura, "Numero Factura");
            ResetTextBox(TxtMontoTotal, "Monto total");
            ResetTextBox(TxtMontoNeto, "Monto Neto");

            // Resetear el ComboBox de Tipo de Pago
            CboTipoDePago.SelectedIndex = -1;

            // Limpiar la fecha de pago
            dtpFechaPago.Value = DateTime.Now;

            // Desmarcar el RadioButton y deshabilitar el TextBox
            rbFactura.Checked = false;
            TxtNumFactura.Enabled = false;
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
