﻿namespace UIFloristeria
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
            dataGridView1 = new DataGridView();
            btnEditarEmpleado = new Button();
            label1 = new Label();
            btnAuditoria = new Button();
            btnAgregarEmp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(215, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(485, 193);
            dataGridView1.TabIndex = 69;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Anchor = AnchorStyles.Bottom;
            btnEditarEmpleado.BackColor = Color.White;
            btnEditarEmpleado.FlatStyle = FlatStyle.Popup;
            btnEditarEmpleado.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnEditarEmpleado.Image = (Image)resources.GetObject("btnEditarEmpleado.Image");
            btnEditarEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarEmpleado.Location = new Point(90, 431);
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
            // 
            // btnAuditoria
            // 
            btnAuditoria.Anchor = AnchorStyles.Bottom;
            btnAuditoria.BackColor = Color.White;
            btnAuditoria.FlatStyle = FlatStyle.Popup;
            btnAuditoria.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAuditoria.Image = (Image)resources.GetObject("btnAuditoria.Image");
            btnAuditoria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAuditoria.Location = new Point(657, 431);
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
            btnAgregarEmp.Location = new Point(359, 431);
            btnAgregarEmp.Name = "btnAgregarEmp";
            btnAgregarEmp.Size = new Size(198, 36);
            btnAgregarEmp.TabIndex = 73;
            btnAgregarEmp.Text = "Agregar Empleado";
            btnAgregarEmp.UseVisualStyleBackColor = false;
            btnAgregarEmp.Click += btnAgregarEmp_Click;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(900, 532);
            Controls.Add(btnAgregarEmp);
            Controls.Add(btnAuditoria);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnEditarEmpleado);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpleado";
            Text = "frmEmpleado";
            Load += frmEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button btnEditarEmpleado;
        private Label label1;
        private Button btnAuditoria;
        private Button btnAgregarEmp;
    }
}