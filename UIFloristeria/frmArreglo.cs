﻿using Controladores;
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
            string query = "SELECT TOP 10 * FROM Arreglo"; // Cambia esta consulta según tu necesidad

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
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }
    }
}
