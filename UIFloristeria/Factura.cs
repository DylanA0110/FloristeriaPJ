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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void TxtNumeroFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Factura_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Pedido";
            try
            {
                using (SqlConnection connection = CONECTA.GetConnection())
                {
                    connection.Open();

                    // Ejecutar la consulta
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos de la consulta
                    dataAdapter.Fill(dataTable);

                    // Asignar el DataTable como origen de datos del DataGridView
                    DtgFacturas.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }

        }
    }
}
