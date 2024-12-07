using Controladores;
using Modelo.Entidades;
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
    public partial class frmArreglo : Form
    {
        private readonly CategoryController _categoriaController;
        private readonly ArregloController _arregloController;
        private readonly AccesorioController _accesorioController;
        public frmArreglo()
        {
            InitializeComponent();
            _categoriaController = new CategoryController(new CategoryRepository());
            _arregloController = new ArregloController(new ArregloRepository(), new AccesorioRepository());
            _accesorioController = new AccesorioController(new AccesorioRepository());
        }



        private void btnAggArreglo_Click(object sender, EventArgs e)
        {
            frmAgregarArreglo frmAgregar = new frmAgregarArreglo(_arregloController, _categoriaController);

            // Abrir el formulario como cuadro de diálogo
            frmAgregar.ShowDialog();
            if (frmAgregar.ShowDialog() == DialogResult.OK)
            {
                // Recarga los empleados después de editar
                loadArreglos();
            }
        }

        private void frmArreglos_Load(object sender, EventArgs e)
        {
            loadArreglos();

        }

        private void loadArreglos()
        {
            var arreglos = _arregloController.GetAllArreglo();
            dataGridView1.DataSource = arreglos;
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[4].Visible = false;
            }
        }

        private void BtnAccesorio_Click(object sender, EventArgs e)
        {
            AgregarAccesorio frm = new AgregarAccesorio(_accesorioController);

            // Abrir el formulario como cuadro de diálogo
            frm.ShowDialog();
        }

        
    }
}
