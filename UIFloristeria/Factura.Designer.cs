namespace UIFloristeria
{
    partial class Factura
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label6 = new Label();
            TxtMontoTotal = new TextBox();
            label7 = new Label();
            TxtNumeroFactura = new TextBox();
            CboTipoDePago = new ComboBox();
            label8 = new Label();
            BtnPreliminar = new Button();
            BtnImprimir = new Button();
            dgvFactura = new DataGridView();
            TxtPedido = new TextBox();
            label1 = new Label();
            rbFactura = new RadioButton();
            BtnInsertarFactura = new Button();
            RbEstado = new RadioButton();
            label3 = new Label();
            TxtMontoNeto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(222, 151, 54);
            label2.Location = new Point(365, 25);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 2;
            label2.Text = "Factura";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(491, 98);
            label6.Name = "label6";
            label6.Size = new Size(97, 19);
            label6.TabIndex = 13;
            label6.Text = "Monto Neto";
            // 
            // TxtMontoTotal
            // 
            TxtMontoTotal.BackColor = Color.FromArgb(22, 58, 55);
            TxtMontoTotal.BorderStyle = BorderStyle.None;
            TxtMontoTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtMontoTotal.Location = new Point(480, 226);
            TxtMontoTotal.Name = "TxtMontoTotal";
            TxtMontoTotal.Size = new Size(140, 20);
            TxtMontoTotal.TabIndex = 12;
            TxtMontoTotal.Text = "_________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(290, 98);
            label7.Name = "label7";
            label7.Size = new Size(160, 19);
            label7.TabIndex = 11;
            label7.Text = "Numero de Factura";
            // 
            // TxtNumeroFactura
            // 
            TxtNumeroFactura.BackColor = Color.FromArgb(22, 58, 55);
            TxtNumeroFactura.BorderStyle = BorderStyle.None;
            TxtNumeroFactura.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtNumeroFactura.Location = new Point(290, 135);
            TxtNumeroFactura.Name = "TxtNumeroFactura";
            TxtNumeroFactura.Size = new Size(140, 20);
            TxtNumeroFactura.TabIndex = 10;
            TxtNumeroFactura.Text = "_________________________________________________________________________";
            // 
            // CboTipoDePago
            // 
            CboTipoDePago.FormattingEnabled = true;
            CboTipoDePago.Items.AddRange(new object[] { "Credito", "Transferencia", "Tarjeta de Credito", "Efectivo" });
            CboTipoDePago.Location = new Point(293, 226);
            CboTipoDePago.Name = "CboTipoDePago";
            CboTipoDePago.Size = new Size(121, 23);
            CboTipoDePago.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(290, 183);
            label8.Name = "label8";
            label8.Size = new Size(111, 19);
            label8.TabIndex = 15;
            label8.Text = "Tipo de Pago";
            // 
            // BtnPreliminar
            // 
            BtnPreliminar.BackColor = Color.White;
            BtnPreliminar.BackgroundImageLayout = ImageLayout.Center;
            BtnPreliminar.FlatAppearance.BorderSize = 0;
            BtnPreliminar.FlatStyle = FlatStyle.Flat;
            BtnPreliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnPreliminar.ForeColor = Color.Black;
            BtnPreliminar.Location = new Point(662, 171);
            BtnPreliminar.Name = "BtnPreliminar";
            BtnPreliminar.Size = new Size(154, 31);
            BtnPreliminar.TabIndex = 17;
            BtnPreliminar.Text = "Preliminar";
            BtnPreliminar.TextAlign = ContentAlignment.BottomCenter;
            BtnPreliminar.UseVisualStyleBackColor = false;
            // 
            // BtnImprimir
            // 
            BtnImprimir.BackColor = Color.White;
            BtnImprimir.BackgroundImageLayout = ImageLayout.Center;
            BtnImprimir.FlatAppearance.BorderSize = 0;
            BtnImprimir.FlatStyle = FlatStyle.Flat;
            BtnImprimir.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnImprimir.ForeColor = Color.Black;
            BtnImprimir.Location = new Point(662, 124);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(154, 31);
            BtnImprimir.TabIndex = 102;
            BtnImprimir.Text = "Imprimir";
            BtnImprimir.TextAlign = ContentAlignment.BottomCenter;
            BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // dgvFactura
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvFactura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFactura.BackgroundColor = Color.White;
            dgvFactura.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFactura.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvFactura.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFactura.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFactura.EnableHeadersVisualStyles = false;
            dgvFactura.Location = new Point(66, 275);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dgvFactura.RowHeadersVisible = false;
            dgvFactura.RowTemplate.Height = 40;
            dgvFactura.Size = new Size(750, 193);
            dgvFactura.TabIndex = 103;
            // 
            // TxtPedido
            // 
            TxtPedido.BackColor = Color.FromArgb(22, 58, 55);
            TxtPedido.BorderStyle = BorderStyle.None;
            TxtPedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtPedido.Location = new Point(74, 220);
            TxtPedido.Name = "TxtPedido";
            TxtPedido.Size = new Size(140, 20);
            TxtPedido.TabIndex = 105;
            TxtPedido.Text = "_________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 183);
            label1.Name = "label1";
            label1.Size = new Size(158, 19);
            label1.TabIndex = 106;
            label1.Text = "Numero de pedido";
            // 
            // rbFactura
            // 
            rbFactura.AutoSize = true;
            rbFactura.BackColor = Color.FromArgb(24, 64, 57);
            rbFactura.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFactura.ForeColor = Color.White;
            rbFactura.Location = new Point(40, 99);
            rbFactura.Name = "rbFactura";
            rbFactura.Size = new Size(192, 21);
            rbFactura.TabIndex = 107;
            rbFactura.TabStop = true;
            rbFactura.Text = "Tiene numero de factura?";
            rbFactura.UseVisualStyleBackColor = false;
            rbFactura.CheckedChanged += rbFactura_CheckedChanged;
            // 
            // BtnInsertarFactura
            // 
            BtnInsertarFactura.BackColor = Color.White;
            BtnInsertarFactura.BackgroundImageLayout = ImageLayout.Center;
            BtnInsertarFactura.FlatAppearance.BorderSize = 0;
            BtnInsertarFactura.FlatStyle = FlatStyle.Flat;
            BtnInsertarFactura.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnInsertarFactura.ForeColor = Color.Black;
            BtnInsertarFactura.Location = new Point(662, 220);
            BtnInsertarFactura.Name = "BtnInsertarFactura";
            BtnInsertarFactura.Size = new Size(154, 31);
            BtnInsertarFactura.TabIndex = 108;
            BtnInsertarFactura.Text = "Insertar Factura";
            BtnInsertarFactura.TextAlign = ContentAlignment.BottomCenter;
            BtnInsertarFactura.UseVisualStyleBackColor = false;
            BtnInsertarFactura.Click += BtnInsertarFactura_Click;
            // 
            // RbEstado
            // 
            RbEstado.AutoSize = true;
            RbEstado.BackColor = Color.FromArgb(24, 64, 57);
            RbEstado.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RbEstado.ForeColor = Color.White;
            RbEstado.Location = new Point(40, 136);
            RbEstado.Name = "RbEstado";
            RbEstado.Size = new Size(108, 21);
            RbEstado.TabIndex = 109;
            RbEstado.TabStop = true;
            RbEstado.Text = "Cancelado?";
            RbEstado.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(491, 192);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 111;
            label3.Text = "Monto Total";
            // 
            // TxtMontoNeto
            // 
            TxtMontoNeto.BackColor = Color.FromArgb(22, 58, 55);
            TxtMontoNeto.BorderStyle = BorderStyle.None;
            TxtMontoNeto.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtMontoNeto.Location = new Point(480, 135);
            TxtMontoNeto.Name = "TxtMontoNeto";
            TxtMontoNeto.Size = new Size(140, 20);
            TxtMontoNeto.TabIndex = 110;
            TxtMontoNeto.Text = "_________________________________________________________________________";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(877, 507);
            Controls.Add(label3);
            Controls.Add(TxtMontoNeto);
            Controls.Add(RbEstado);
            Controls.Add(BtnInsertarFactura);
            Controls.Add(rbFactura);
            Controls.Add(label1);
            Controls.Add(TxtPedido);
            Controls.Add(dgvFactura);
            Controls.Add(BtnImprimir);
            Controls.Add(BtnPreliminar);
            Controls.Add(label8);
            Controls.Add(CboTipoDePago);
            Controls.Add(label6);
            Controls.Add(TxtMontoTotal);
            Controls.Add(label7);
            Controls.Add(TxtNumeroFactura);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Factura";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label6;
        private TextBox TxtMontoTotal;
        private Label label7;
        private TextBox TxtNumeroFactura;
        private ComboBox CboTipoDePago;
        private Label label8;
        private Button BtnPreliminar;
        private Button BtnImprimir;
        private DataGridView dgvFactura;
        private TextBox TxtPedido;
        private Label label1;
        private RadioButton rbFactura;
        private Button BtnInsertarFactura;
        private RadioButton RbEstado;
        private Label label3;
        private TextBox TxtMontoNeto;
    }
}