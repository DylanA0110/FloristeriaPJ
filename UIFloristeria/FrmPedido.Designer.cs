﻿namespace UIFloristeria
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TxtCantidad = new TextBox();
            pictureBox5 = new PictureBox();
            TxtDescripcion = new TextBox();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            dtpFechaSoli = new DateTimePicker();
            label1 = new Label();
            dtpFechaEntrega = new DateTimePicker();
            label2 = new Label();
            BtnAgregarRemision = new Button();
            BtnPreliminar = new Button();
            pictureBox2 = new PictureBox();
            TxtEnviarseA = new TextBox();
            txtCliente = new TextBox();
            btnBuscarCliente = new Button();
            label4 = new Label();
            dgvPedidos = new DataGridView();
            BtnEditar = new Button();
            BtnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // TxtCantidad
            // 
            TxtCantidad.Anchor = AnchorStyles.Top;
            TxtCantidad.BackColor = Color.FromArgb(22, 58, 55);
            TxtCantidad.BorderStyle = BorderStyle.None;
            TxtCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCantidad.ForeColor = Color.White;
            TxtCantidad.Location = new Point(722, 147);
            TxtCantidad.Margin = new Padding(3, 4, 3, 4);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(213, 25);
            TxtCantidad.TabIndex = 113;
            TxtCantidad.Text = "Cantidad";
            TxtCantidad.Enter += TxtCantidad_Enter;
            TxtCantidad.Leave += TxtCantidad_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top;
            pictureBox5.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox5.Image = Properties.Resources.Loading;
            pictureBox5.Location = new Point(722, 181);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(213, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 112;
            pictureBox5.TabStop = false;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Anchor = AnchorStyles.Top;
            TxtDescripcion.BackColor = Color.FromArgb(22, 58, 55);
            TxtDescripcion.BorderStyle = BorderStyle.None;
            TxtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtDescripcion.ForeColor = Color.White;
            TxtDescripcion.Location = new Point(503, 147);
            TxtDescripcion.Margin = new Padding(3, 4, 3, 4);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(213, 25);
            TxtDescripcion.TabIndex = 111;
            TxtDescripcion.Text = "Descripcion";
            TxtDescripcion.Enter += TxtDescripcion_Enter;
            TxtDescripcion.Leave += TxtDescripcion_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox4.Image = Properties.Resources.Loading;
            pictureBox4.Location = new Point(503, 181);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(213, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 110;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(22, 58, 55);
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(330, 264);
            label3.Name = "label3";
            label3.Size = new Size(196, 23);
            label3.TabIndex = 115;
            label3.Text = "Fecha de solicitud:";
            label3.Click += label3_Click;
            // 
            // dtpFechaSoli
            // 
            dtpFechaSoli.Anchor = AnchorStyles.Top;
            dtpFechaSoli.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaSoli.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            dtpFechaSoli.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            dtpFechaSoli.Format = DateTimePickerFormat.Short;
            dtpFechaSoli.Location = new Point(345, 308);
            dtpFechaSoli.Margin = new Padding(3, 4, 3, 4);
            dtpFechaSoli.Name = "dtpFechaSoli";
            dtpFechaSoli.Size = new Size(138, 27);
            dtpFechaSoli.TabIndex = 114;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(22, 58, 55);
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(526, 264);
            label1.Name = "label1";
            label1.Size = new Size(188, 23);
            label1.TabIndex = 117;
            label1.Text = "Fecha de Entrega:";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Anchor = AnchorStyles.Top;
            dtpFechaEntrega.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaEntrega.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            dtpFechaEntrega.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(541, 308);
            dtpFechaEntrega.Margin = new Padding(3, 4, 3, 4);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(138, 27);
            dtpFechaEntrega.TabIndex = 116;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(22, 58, 55);
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(222, 151, 54);
            label2.Location = new Point(362, 41);
            label2.Name = "label2";
            label2.Size = new Size(336, 44);
            label2.TabIndex = 118;
            label2.Text = "Agregar Remision";
            // 
            // BtnAgregarRemision
            // 
            BtnAgregarRemision.Anchor = AnchorStyles.Bottom;
            BtnAgregarRemision.BackColor = Color.White;
            BtnAgregarRemision.FlatStyle = FlatStyle.Popup;
            BtnAgregarRemision.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarRemision.Location = new Point(121, 585);
            BtnAgregarRemision.Margin = new Padding(3, 4, 3, 4);
            BtnAgregarRemision.Name = "BtnAgregarRemision";
            BtnAgregarRemision.Size = new Size(169, 41);
            BtnAgregarRemision.TabIndex = 120;
            BtnAgregarRemision.Text = "Agregar Pedido ";
            BtnAgregarRemision.UseVisualStyleBackColor = false;
            BtnAgregarRemision.Click += BtnAgregarRemision_Click;
            // 
            // BtnPreliminar
            // 
            BtnPreliminar.Anchor = AnchorStyles.Bottom;
            BtnPreliminar.BackColor = Color.White;
            BtnPreliminar.FlatStyle = FlatStyle.Popup;
            BtnPreliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPreliminar.Location = new Point(510, 585);
            BtnPreliminar.Margin = new Padding(3, 4, 3, 4);
            BtnPreliminar.Name = "BtnPreliminar";
            BtnPreliminar.Size = new Size(169, 41);
            BtnPreliminar.TabIndex = 126;
            BtnPreliminar.Text = "Preliminar";
            BtnPreliminar.UseVisualStyleBackColor = false;
            BtnPreliminar.Click += BtnPreliminar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(21, 181);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 106;
            pictureBox2.TabStop = false;
            // 
            // TxtEnviarseA
            // 
            TxtEnviarseA.Anchor = AnchorStyles.Top;
            TxtEnviarseA.BackColor = Color.FromArgb(22, 58, 55);
            TxtEnviarseA.BorderStyle = BorderStyle.None;
            TxtEnviarseA.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtEnviarseA.ForeColor = Color.White;
            TxtEnviarseA.Location = new Point(21, 147);
            TxtEnviarseA.Margin = new Padding(3, 4, 3, 4);
            TxtEnviarseA.Name = "TxtEnviarseA";
            TxtEnviarseA.Size = new Size(213, 25);
            TxtEnviarseA.TabIndex = 107;
            TxtEnviarseA.Text = "Enviarse a";
            TxtEnviarseA.Enter += TxtEnviarseA_Enter;
            TxtEnviarseA.Leave += TxtEnviarseA_Leave;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top;
            txtCliente.Enabled = false;
            txtCliente.Location = new Point(256, 180);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(151, 27);
            txtCliente.TabIndex = 132;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Anchor = AnchorStyles.Top;
            btnBuscarCliente.BackColor = Color.FromArgb(22, 58, 55);
            btnBuscarCliente.FlatAppearance.BorderSize = 0;
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarCliente.Location = new Point(415, 169);
            btnBuscarCliente.Margin = new Padding(3, 4, 3, 4);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(48, 44);
            btnBuscarCliente.TabIndex = 131;
            btnBuscarCliente.UseVisualStyleBackColor = false;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(256, 145);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 130;
            label4.Text = "Cliente";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPedidos.BackgroundColor = Color.White;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPedidos.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(22, 58, 55);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPedidos.EditMode = DataGridViewEditMode.EditOnF2;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.Location = new Point(101, 361);
            dgvPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.RowTemplate.Height = 40;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(784, 168);
            dgvPedidos.TabIndex = 133;
            // 
            // BtnEditar
            // 
            BtnEditar.Anchor = AnchorStyles.Bottom;
            BtnEditar.BackColor = Color.White;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.Location = new Point(314, 585);
            BtnEditar.Margin = new Padding(3, 4, 3, 4);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(169, 41);
            BtnEditar.TabIndex = 134;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnImprimir
            // 
            BtnImprimir.Anchor = AnchorStyles.Bottom;
            BtnImprimir.BackColor = Color.White;
            BtnImprimir.FlatStyle = FlatStyle.Popup;
            BtnImprimir.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnImprimir.Location = new Point(701, 585);
            BtnImprimir.Margin = new Padding(3, 4, 3, 4);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(169, 41);
            BtnImprimir.TabIndex = 135;
            BtnImprimir.Text = "Imprimir";
            BtnImprimir.UseVisualStyleBackColor = false;
            BtnImprimir.Click += BtnImprimir_Click;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(974, 664);
            Controls.Add(BtnImprimir);
            Controls.Add(BtnEditar);
            Controls.Add(dgvPedidos);
            Controls.Add(txtCliente);
            Controls.Add(btnBuscarCliente);
            Controls.Add(label4);
            Controls.Add(BtnPreliminar);
            Controls.Add(BtnAgregarRemision);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(label3);
            Controls.Add(dtpFechaSoli);
            Controls.Add(TxtCantidad);
            Controls.Add(pictureBox5);
            Controls.Add(TxtDescripcion);
            Controls.Add(pictureBox4);
            Controls.Add(TxtEnviarseA);
            Controls.Add(pictureBox2);
            ForeColor = Color.FromArgb(22, 58, 55);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += FrmPedido_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCantidad;
        private PictureBox pictureBox5;
        private TextBox TxtDescripcion;
        private PictureBox pictureBox4;
        private TextBox txtPrimerNombre;
        private Label label3;
        private DateTimePicker dtpFechaSoli;
        private Label label1;
        private DateTimePicker dtpFechaEntrega;
        private Label label2;
        private Button BtnPreliminar;
        private Button BtnAgregarRemision;
        private PictureBox pictureBox2;
        private TextBox TxtEnviarseA;
        private TextBox txtCliente;
        private Button btnBuscarCliente;
        private Label label4;
        private DataGridView dgvPedidos;
        private Button BtnEditar;
        private Button BtnImprimir;
    }
}