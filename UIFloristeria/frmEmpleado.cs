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
    public partial class frmEmpleado : Form
    {
        private readonly EmpleadoController _empleadoController;

        public frmEmpleado()
        {
            InitializeComponent();
            _empleadoController = new EmpleadoController(new EmpleadoRepository());
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            LoadEmpleados();
           
        }

        private void LoadEmpleados()
        {
            var empleados = _empleadoController.GetAllEmpleados();
            dgvEmpleados.DataSource = empleados.ToList();
            dgvEmpleados.CurrentCell = null;
            dgvEmpleados.ClearSelection();
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                var row = dgvEmpleados.SelectedRows[0];

                // Verifica si el valor del ID del empleado es válido
                if (row.Cells["Id_Empleado"].Value != null)
                {
                    int idEmpleado;
                    bool success = int.TryParse(row.Cells["Id_Empleado"].Value.ToString(), out idEmpleado);

                    if (success)
                    {
                        // Crea una instancia del formulario de edición y pasa el ID y el controlador
                        frmEditarEmpleado formulario = new frmEditarEmpleado(idEmpleado, _empleadoController);
                        if (formulario.ShowDialog() == DialogResult.OK)
                        {
                            // Recarga los empleados después de editar
                            LoadEmpleados();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El ID del empleado no es un número válido.");
                    }
                }
                else
                {
                    MessageBox.Show("El ID del empleado está vacío.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.");
            }

        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoriaEmpleado frmEditar = new frmAuditoriaEmpleado();
            frmEditar.ShowDialog();
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.ShowDialog();
            //Si Mando exito
            if (register.ShowDialog() == DialogResult.OK)
            {
                // Recarga los empleados
                LoadEmpleados();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtBusqueda.Text.Trim();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    var empleados = _empleadoController.SearchEmpleados(searchTerm);
                    if (empleados.Any())
                    {
                        dgvEmpleados.DataSource = empleados.ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron resultados.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvEmpleados.DataSource = null;
                    }
                }
                else
                {
                    LoadEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
        }
    }
