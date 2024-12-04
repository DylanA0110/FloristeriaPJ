namespace UIFloristeria
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dgvEmpleados = new DataGridView();
            btnEditarEmpleado = new Button();
            label1 = new Label();
            btnAuditoria = new Button();
            btnAgregarEmp = new Button();
            txtBusqueda = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // dgvEmpleados
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(225, 214);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowTemplate.Height = 40;
            dgvEmpleados.Size = new Size(485, 193);
            dgvEmpleados.TabIndex = 69;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Anchor = AnchorStyles.Bottom;
            btnEditarEmpleado.BackColor = Color.White;
            btnEditarEmpleado.FlatStyle = FlatStyle.Popup;
            btnEditarEmpleado.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnEditarEmpleado.Image = (Image)resources.GetObject("btnEditarEmpleado.Image");
            btnEditarEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarEmpleado.Location = new Point(92, 460);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(188, 36);
            btnEditarEmpleado.TabIndex = 68;
            btnEditarEmpleado.Text = "Editar Empleado";
            btnEditarEmpleado.UseVisualStyleBackColor = false;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(222, 151, 54);
            label1.Location = new Point(441, 33);
            label1.Name = "label1";
            label1.Size = new Size(172, 36);
            label1.TabIndex = 67;
            label1.Text = "Empleados";
            label1.Click += label1_Click;
            // 
            // btnAuditoria
            // 
            btnAuditoria.Anchor = AnchorStyles.Bottom;
            btnAuditoria.BackColor = Color.White;
            btnAuditoria.FlatStyle = FlatStyle.Popup;
            btnAuditoria.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAuditoria.Image = (Image)resources.GetObject("btnAuditoria.Image");
            btnAuditoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.Location = new Point(659, 460);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(141, 36);
            btnAuditoria.TabIndex = 72;
            btnAuditoria.Text = "Auditoria";
            btnAuditoria.UseVisualStyleBackColor = false;
            btnAuditoria.Click += btnAuditoria_Click;
            // 
            // btnAgregarEmp
            // 
            btnAgregarEmp.Anchor = AnchorStyles.Bottom;
            btnAgregarEmp.BackColor = Color.White;
            btnAgregarEmp.FlatStyle = FlatStyle.Popup;
            btnAgregarEmp.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAgregarEmp.Image = (Image)resources.GetObject("btnAgregarEmp.Image");
            btnAgregarEmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarEmp.Location = new Point(361, 460);
            btnAgregarEmp.Name = "btnAgregarEmp";
            btnAgregarEmp.Size = new Size(198, 36);
            btnAgregarEmp.TabIndex = 73;
            btnAgregarEmp.Text = "Agregar Empleado";
            btnAgregarEmp.UseVisualStyleBackColor = false;
            btnAgregarEmp.Click += btnAgregarEmp_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top;
            txtBusqueda.Location = new Point(549, 152);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(161, 23);
            txtBusqueda.TabIndex = 77;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(222, 151, 54);
            label2.Location = new Point(549, 130);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 78;
            label2.Text = "Busqueda:";
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(900, 532);
            Controls.Add(label2);
            Controls.Add(txtBusqueda);
            Controls.Add(btnAgregarEmp);
            Controls.Add(btnAuditoria);
            Controls.Add(pictureBox1);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnEditarEmpleado);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpleado";
            Text = "frmEmpleado";
            Load += frmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dgvEmpleados;
        private Button btnEditarEmpleado;
        private Label label1;
        private Button btnAuditoria;
        private Button btnAgregarEmp;
        private TextBox txtBusqueda;
        private Label label2;
    }
}