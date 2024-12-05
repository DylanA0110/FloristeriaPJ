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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label2 = new Label();
            CboTipoDePago = new ComboBox();
            label8 = new Label();
            BtnPreliminar = new Button();
            BtnImprimir = new Button();
            dgvFactura = new DataGridView();
            rbFactura = new RadioButton();
            BtnInsertarFactura = new Button();
            pictureBox2 = new PictureBox();
            TxtNumeroPedido = new TextBox();
            pictureBox1 = new PictureBox();
            TxtMontoNeto = new TextBox();
            pictureBox3 = new PictureBox();
            TxtNumFactura = new TextBox();
            pictureBox4 = new PictureBox();
            TxtMontoTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            // CboTipoDePago
            // 
            CboTipoDePago.FormattingEnabled = true;
            CboTipoDePago.Items.AddRange(new object[] { "Credito", "Transferencia", "Tarjeta de Credito", "Efectivo" });
            CboTipoDePago.Location = new Point(445, 133);
            CboTipoDePago.Name = "CboTipoDePago";
            CboTipoDePago.Size = new Size(121, 23);
            CboTipoDePago.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(445, 107);
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvFactura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFactura.BackgroundColor = Color.White;
            dgvFactura.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvFactura.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvFactura.ColumnHeadersHeight = 45;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvFactura.DefaultCellStyle = dataGridViewCellStyle6;
            dgvFactura.EnableHeadersVisualStyles = false;
            dgvFactura.Location = new Point(66, 275);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dgvFactura.RowHeadersVisible = false;
            dgvFactura.RowTemplate.Height = 40;
            dgvFactura.Size = new Size(750, 193);
            dgvFactura.TabIndex = 103;
            // 
            // rbFactura
            // 
            rbFactura.AutoSize = true;
            rbFactura.BackColor = Color.FromArgb(24, 64, 57);
            rbFactura.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFactura.ForeColor = Color.White;
            rbFactura.Location = new Point(248, 196);
            rbFactura.Name = "rbFactura";
            rbFactura.Size = new Size(175, 21);
            rbFactura.TabIndex = 107;
            rbFactura.TabStop = true;
            rbFactura.Text = "Tiene Numero Factura?";
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(29, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 113;
            pictureBox2.TabStop = false;
            // 
            // TxtNumeroPedido
            // 
            TxtNumeroPedido.BackColor = Color.FromArgb(24, 64, 57);
            TxtNumeroPedido.BorderStyle = BorderStyle.None;
            TxtNumeroPedido.Font = new Font("Century Gothic", 12F);
            TxtNumeroPedido.ForeColor = Color.White;
            TxtNumeroPedido.Location = new Point(29, 107);
            TxtNumeroPedido.Name = "TxtNumeroPedido";
            TxtNumeroPedido.Size = new Size(186, 20);
            TxtNumeroPedido.TabIndex = 112;
            TxtNumeroPedido.Text = "Numero Del Pedido";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox1.Image = Properties.Resources.Loading;
            pictureBox1.Location = new Point(237, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 115;
            pictureBox1.TabStop = false;
            // 
            // TxtMontoNeto
            // 
            TxtMontoNeto.BackColor = Color.FromArgb(24, 64, 57);
            TxtMontoNeto.BorderStyle = BorderStyle.None;
            TxtMontoNeto.Font = new Font("Century Gothic", 12F);
            TxtMontoNeto.ForeColor = Color.White;
            TxtMontoNeto.Location = new Point(237, 107);
            TxtMontoNeto.Name = "TxtMontoNeto";
            TxtMontoNeto.Size = new Size(186, 20);
            TxtMontoNeto.TabIndex = 114;
            TxtMontoNeto.Text = "Monto Neto";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(445, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 117;
            pictureBox3.TabStop = false;
            // 
            // TxtNumFactura
            // 
            TxtNumFactura.BackColor = Color.FromArgb(24, 64, 57);
            TxtNumFactura.BorderStyle = BorderStyle.None;
            TxtNumFactura.Font = new Font("Century Gothic", 12F);
            TxtNumFactura.ForeColor = Color.White;
            TxtNumFactura.Location = new Point(451, 188);
            TxtNumFactura.Name = "TxtNumFactura";
            TxtNumFactura.Size = new Size(186, 20);
            TxtNumFactura.TabIndex = 116;
            TxtNumFactura.Text = "Numero Factura";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox4.Image = Properties.Resources.Loading;
            pictureBox4.Location = new Point(29, 220);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(186, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 119;
            pictureBox4.TabStop = false;
            // 
            // TxtMontoTotal
            // 
            TxtMontoTotal.BackColor = Color.FromArgb(24, 64, 57);
            TxtMontoTotal.BorderStyle = BorderStyle.None;
            TxtMontoTotal.Font = new Font("Century Gothic", 12F);
            TxtMontoTotal.ForeColor = Color.White;
            TxtMontoTotal.Location = new Point(29, 194);
            TxtMontoTotal.Name = "TxtMontoTotal";
            TxtMontoTotal.Size = new Size(186, 20);
            TxtMontoTotal.TabIndex = 118;
            TxtMontoTotal.Text = "Monto total";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(877, 507);
            Controls.Add(pictureBox4);
            Controls.Add(TxtMontoTotal);
            Controls.Add(pictureBox3);
            Controls.Add(TxtNumFactura);
            Controls.Add(pictureBox1);
            Controls.Add(TxtMontoNeto);
            Controls.Add(pictureBox2);
            Controls.Add(TxtNumeroPedido);
            Controls.Add(BtnInsertarFactura);
            Controls.Add(rbFactura);
            Controls.Add(dgvFactura);
            Controls.Add(BtnImprimir);
            Controls.Add(BtnPreliminar);
            Controls.Add(label8);
            Controls.Add(CboTipoDePago);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Factura";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            Load += Factura_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox CboTipoDePago;
        private Label label8;
        private Button BtnPreliminar;
        private Button BtnImprimir;
        private DataGridView dgvFactura;
        private RadioButton rbFactura;
        private Button BtnInsertarFactura;
        private PictureBox pictureBox2;
        private TextBox TxtNumeroPedido;
        private PictureBox pictureBox1;
        private TextBox TxtMontoNeto;
        private PictureBox pictureBox3;
        private TextBox TxtNumFactura;
        private PictureBox pictureBox4;
        private TextBox TxtMontoTotal;
    }
}