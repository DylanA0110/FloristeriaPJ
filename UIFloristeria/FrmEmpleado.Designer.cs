namespace UIFloristeria
{
    partial class FrmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            PrimerNombre = new DataGridViewTextBoxColumn();
            SegundoNombre = new DataGridViewTextBoxColumn();
            PrimerApellido = new DataGridViewTextBoxColumn();
            SegundoApellido = new DataGridViewTextBoxColumn();
            FechaInicioSession = new DataGridViewTextBoxColumn();
            FechaCierreSession = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            FechaDeNac = new DataGridViewTextBoxColumn();
            EsAprobado = new DataGridViewCheckBoxColumn();
            Rol = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 75, 68);
            label1.Location = new Point(397, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 1;
            label1.Text = "Empleado";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, FechaInicioSession, FechaCierreSession, Sexo, Correo, Telefono, FechaDeNac, EsAprobado, Rol });
            dataGridView1.Location = new Point(12, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(876, 274);
            dataGridView1.TabIndex = 2;
            // 
            // PrimerNombre
            // 
            PrimerNombre.HeaderText = "Primer Nombre";
            PrimerNombre.Name = "PrimerNombre";
            // 
            // SegundoNombre
            // 
            SegundoNombre.HeaderText = "Segundo Nombre";
            SegundoNombre.Name = "SegundoNombre";
            // 
            // PrimerApellido
            // 
            PrimerApellido.HeaderText = "Primer Apellido";
            PrimerApellido.Name = "PrimerApellido";
            // 
            // SegundoApellido
            // 
            SegundoApellido.HeaderText = "Segundo Apellido";
            SegundoApellido.Name = "SegundoApellido";
            // 
            // FechaInicioSession
            // 
            FechaInicioSession.HeaderText = "Fecha InicioS ession";
            FechaInicioSession.Name = "FechaInicioSession";
            // 
            // FechaCierreSession
            // 
            FechaCierreSession.HeaderText = "Fecha Cierre Session";
            FechaCierreSession.Name = "FechaCierreSession";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // FechaDeNac
            // 
            FechaDeNac.HeaderText = "Fecha de nacimiento";
            FechaDeNac.Name = "FechaDeNac";
            // 
            // EsAprobado
            // 
            EsAprobado.HeaderText = "UsuarioAprobado";
            EsAprobado.Name = "EsAprobado";
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 532);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(28, 75, 68);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmEmpleado";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PrimerNombre;
        private DataGridViewTextBoxColumn SegundoNombre;
        private DataGridViewTextBoxColumn PrimerApellido;
        private DataGridViewTextBoxColumn SegundoApellido;
        private DataGridViewTextBoxColumn FechaInicioSession;
        private DataGridViewTextBoxColumn FechaCierreSession;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn FechaDeNac;
        private DataGridViewCheckBoxColumn EsAprobado;
        private DataGridViewCheckBoxColumn Rol;
    }
}