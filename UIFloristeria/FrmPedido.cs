using Controladores;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Modelo.Entidades;
using Modelo.Repositories;
using Modelo.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UIFloristeria
{
    public partial class FrmPedido : Form
    {
        private readonly PedidoController _pedidoController;
        private readonly ClienteController _clienteController;
        private int ClienteSeleccionado;

        public FrmPedido()
        {
            InitializeComponent();
            _pedidoController = new PedidoController(new PedidosRepository());
            _clienteController = new ClienteController(new ClienteRepository());

        }


        private void BtnAgregarRemision_Click(object sender, EventArgs e)
        {
            // Declarar la variable para la cantidad
            int cantidad;

            // Intentar convertir el texto a entero
            if (!int.TryParse(TxtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido para la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si la conversión falla
            }

            // Crear la instancia de Pedido con la cantidad ya convertida
            var pedidos = new Pedido
            {
                Enviarse_A = TxtEnviarseA.Text,
                Descripcion = TxtDescripcion.Text,
                Cantidad = cantidad, // Usar la variable cantidad ya convertida
                Fecha_solicitud = DateTime.Parse(dtpFechaSoli.Text),
                Fecha_entrega = DateTime.Parse(dtpFechaEntrega.Text),
                Id_cliente = ClienteSeleccionado
            };
            var errores = ValidadorEntidad.Validar(pedidos);

            if (errores.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errores), "Errores de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _pedidoController.AddPedido(pedidos);
                MessageBox.Show("Pedido registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el pedido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void LimpiarCampos()
        {
            TxtCantidad.Clear();
            TxtDescripcion.Clear();
            txtCliente.Clear();
            TxtEnviarseA.Text = string.Empty;
            txtCliente.Clear();
            dtpFechaSoli.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;


        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            LoadPedido();
        }

        private void LoadPedido()
        {
            var pedido = _pedidoController.GetAllPedido();
            dgvPedidos.DataSource = pedido.ToList();
            dgvPedidos.CurrentCell = null;
            dgvPedidos.ClearSelection();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            if (frmCliente.ShowDialog() == DialogResult.OK)
            {
                txtCliente.Text = frmCliente.ClienteSeleccionado;
                ClienteSeleccionado = frmCliente.idClienteSeleccionado;
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                var row = dgvPedidos.SelectedRows[0];

                // Verifica si el valor del ID del empleado es válido
                if (row.Cells["Id_pedido"].Value != null)
                {
                    int idPedido;
                    bool success = int.TryParse(row.Cells["Id_pedido"].Value.ToString(), out idPedido);

                    if (success)
                    {
                        // Crea una instancia del formulario de edición y pasa el ID y el controlador
                        frmEditarPedido formulario = new frmEditarPedido(idPedido, _pedidoController);
                        if (formulario.ShowDialog() == DialogResult.OK)
                        {
                            // Recarga los empleados después de editar
                            LoadPedido();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID del Pedido no es un número válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del Pedido está vacío.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }

        }

        private void TxtEnviarseA_Leave(object sender, EventArgs e)
        {
            if (TxtEnviarseA.Text == "")
            {
                TxtEnviarseA.Text = "Enviarse a";
            }
        }

        private void TxtEnviarseA_Enter(object sender, EventArgs e)
        {
            if (TxtEnviarseA.Text == "Enviarse a")
            {
                TxtEnviarseA.Text = "";
            }
        }

        private void TxtDescripcion_Leave(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text == "")
            {
                TxtDescripcion.Text = "Descripcion";
            }
        }

        private void TxtDescripcion_Enter(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text == "Descripcion")
            {
                TxtDescripcion.Text = "";
            }
        }

        private void TxtCantidad_Enter(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "Cantidad")
            {
                TxtCantidad.Text = "";
            }
        }

        private void TxtCantidad_Leave(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "")
            {
                TxtCantidad.Text = "Cantidad";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnPreliminar_Click(object sender, EventArgs e)
        {
                // 1. Validar que una fila está seleccionada
                if (dgvPedidos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecciona un pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Obtener el pedido seleccionado
                var pedidoSeleccionado = dgvPedidos.SelectedRows[0].DataBoundItem as Pedido;

                if (pedidoSeleccionado == null)
                {
                    MessageBox.Show("El pedido seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    // 3. Crear y configurar ReportViewer
                    ReportViewer reportViewer = new ReportViewer
                    {
                        ProcessingMode = ProcessingMode.Local
                    };

                    // Ruta del archivo RDLC
                    string reportPath = Path.Combine(Application.StartupPath, "Reportes", "OrdenDeTrabajo.rdlc");

                    if (!File.Exists(reportPath))
                    {
                        MessageBox.Show("El archivo del informe no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    reportViewer.LocalReport.ReportPath = reportPath;

                    // 4. Establecer parámetros del reporte
                    ReportParameter[] parametros = new ReportParameter[]
                    {
            new ReportParameter("PEnviarseA", pedidoSeleccionado.Enviarse_A),
            new ReportParameter("PNombrecliente", pedidoSeleccionado.NombreCliente),
            new ReportParameter("PDescripcion", pedidoSeleccionado.Descripcion),
            new ReportParameter("PTelefonoCliente", pedidoSeleccionado.TelefonoCliente),
            new ReportParameter("PFechaEntrega",
                pedidoSeleccionado.Fecha_entrega.HasValue
                ? pedidoSeleccionado.Fecha_entrega.Value.ToString("dd/MM/yyyy")
                : "")
                    };

                    reportViewer.LocalReport.SetParameters(parametros);

                    // 5. Refrescar y preparar el reporte
                    reportViewer.RefreshReport();

                    // 6. Mostrar vista previa en lugar de imprimir
                    ShowPrintPreview(reportViewer.LocalReport);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void ShowPrintPreview(LocalReport localReport)
        {
            // Renderizar el informe como EMF
            var deviceInfo = @"<DeviceInfo>
        <OutputFormat>EMF</OutputFormat>
        <PageWidth>8.5in</PageWidth>
        <PageHeight>11in</PageHeight>
        <MarginTop>0.25in</MarginTop>
        <MarginLeft>0.25in</MarginLeft>
        <MarginRight>0.25in</MarginRight>
        <MarginBottom>0.25in</MarginBottom>
    </DeviceInfo>";

            Warning[] warnings;
            var streams = new List<Stream>();
            var currentPageIndex = 0;

            // Renderizar cada página a un flujo de memoria
            localReport.Render("Image", deviceInfo,
                (name, extension, encoding, mimeType, willSeek) =>
                {
                    var stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);

            foreach (Stream stream in streams)
                stream.Position = 0;

            PrintDocument printDoc = new PrintDocument();

            // Evento PrintPage para el PrintDocument
            printDoc.PrintPage += (sender, e) =>
            {
                if (currentPageIndex < streams.Count)
                {
                    using (Metafile pageImage = new Metafile(streams[currentPageIndex]))
                    {
                        e.Graphics.DrawImage(pageImage, e.MarginBounds);
                    }
                    currentPageIndex++;
                    e.HasMorePages = (currentPageIndex < streams.Count);
                }
                else
                {
                    e.HasMorePages = false;
                }
            };

            // Mostrar el diálogo de vista previa
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDoc,
                ClientSize = new Size(800, 600)
            };
            previewDialog.ShowDialog();

            // Limpiar recursos
            foreach (Stream stream in streams)
                stream.Dispose();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            // 1. Validar que una fila está seleccionada
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el pedido seleccionado
            var pedidoSeleccionado = dgvPedidos.SelectedRows[0].DataBoundItem as Pedido;

            if (pedidoSeleccionado == null)
            {
                MessageBox.Show("El pedido seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 3. Crear y configurar ReportViewer
                ReportViewer reportViewer = new ReportViewer
                {
                    ProcessingMode = ProcessingMode.Local
                };

                // Ruta del archivo RDLC
                string reportPath = Path.Combine(Application.StartupPath, "Reportes", "OrdenDeTrabajo.rdlc");

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("El archivo del informe no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reportViewer.LocalReport.ReportPath = reportPath;

                // 4. Establecer parámetros del reporte
                ReportParameter[] parametros = new ReportParameter[]
                {
            new ReportParameter("PEnviarseA", pedidoSeleccionado.Enviarse_A),
            new ReportParameter("PNombrecliente", pedidoSeleccionado.NombreCliente),
            new ReportParameter("PDescripcion", pedidoSeleccionado.Descripcion),
            new ReportParameter("PTelefonoCliente", pedidoSeleccionado.TelefonoCliente),
            new ReportParameter("PFechaEntrega",
                pedidoSeleccionado.Fecha_entrega.HasValue
                    ? pedidoSeleccionado.Fecha_entrega.Value.ToString("dd/MM/yyyy")
                    : "")
                };

                reportViewer.LocalReport.SetParameters(parametros);

                // 5. Refrescar y preparar el reporte
                reportViewer.RefreshReport();

                // 6. Imprimir el reporte directamente
                PrintReport(reportViewer.LocalReport);

                MessageBox.Show("El reporte se envió a la impresora correctamente.", "Impresión Exitosa",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir el informe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PrintReport(LocalReport localReport)
        {
            // Renderizar el informe como EMF
            var deviceInfo = @"<DeviceInfo>
                  <OutputFormat>EMF</OutputFormat>
                  <PageWidth>8.5in</PageWidth>
                  <PageHeight>11in</PageHeight>
                  <MarginTop>0.25in</MarginTop>
                  <MarginLeft>0.25in</MarginLeft>
                  <MarginRight>0.25in</MarginRight>
                  <MarginBottom>0.25in</MarginBottom>
               </DeviceInfo>";

            Warning[] warnings;
            var streams = new List<Stream>();
            var currentPageIndex = 0;

            // Renderizar cada página a un flujo de memoria
            localReport.Render("Image", deviceInfo,
                (name, extension, encoding, mimeType, willSeek) =>
                {
                    var stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);

            foreach (Stream stream in streams)
                stream.Position = 0;

            PrintDocument printDoc = new PrintDocument();

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.PrinterSettings = printDialog.PrinterSettings;

                    printDoc.PrintPage += (sender, e) =>
                    {
                        Metafile pageImage = new Metafile(streams[currentPageIndex]);
                        e.Graphics.DrawImage(pageImage, e.PageBounds);

                        currentPageIndex++;
                        e.HasMorePages = (currentPageIndex < streams.Count);
                    };

                    printDoc.Print();
                }
            }

            // Limpiar recursos
            foreach (Stream stream in streams)
                stream.Dispose();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // 1. Validar que una fila está seleccionada
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un pedido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Obtener el pedido seleccionado
            var pedidoSeleccionado = dgvPedidos.SelectedRows[0].DataBoundItem as Pedido;

            if (pedidoSeleccionado == null)
            {
                MessageBox.Show("El pedido seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 3. Crear y configurar el archivo Excel
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Pedido");

                    // 4. Crear encabezados
                    worksheet.Cell(1, 1).Value = "Enviarse A";
                    worksheet.Cell(1, 2).Value = "Nombre Cliente";
                    worksheet.Cell(1, 3).Value = "Descripción";
                    worksheet.Cell(1, 4).Value = "Teléfono Cliente";
                    worksheet.Cell(1, 5).Value = "Fecha de Entrega";

                    // 5. Llenar datos del pedido seleccionado
                    worksheet.Cell(2, 1).Value = pedidoSeleccionado.Enviarse_A;
                    worksheet.Cell(2, 2).Value = pedidoSeleccionado.NombreCliente;
                    worksheet.Cell(2, 3).Value = pedidoSeleccionado.Descripcion;
                    worksheet.Cell(2, 4).Value = pedidoSeleccionado.TelefonoCliente;
                    worksheet.Cell(2, 5).Value = pedidoSeleccionado.Fecha_entrega?.ToString("dd/MM/yyyy") ?? "";

                    // 6. Guardar el archivo
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                        saveFileDialog.Title = "Guardar Pedido como Excel";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                            MessageBox.Show("El pedido se exportó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
