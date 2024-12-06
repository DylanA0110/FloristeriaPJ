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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            label2 = new Label();
            CboTipoDePago = new ComboBox();
            label8 = new Label();
            BtnPreliminar = new Button();
            BtnImprimir = new Button();
            dgvFactura = new DataGridView();
            rbFactura = new RadioButton();
            BtnInsertarFactura = new Button();
            pictureBox1 = new PictureBox();
            TxtMontoNeto = new TextBox();
            pictureBox4 = new PictureBox();
            TxtMontoTotal = new TextBox();
            label3 = new Label();
            dtpFechaPago = new DateTimePicker();
            TxtNumFactura = new TextBox();
            pictureBox3 = new PictureBox();
            txtPedido = new TextBox();
            btnBuscarPedido = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            CboTipoDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            CboTipoDePago.FormattingEnabled = true;
            CboTipoDePago.Items.AddRange(new object[] { "Credito", "Transferencia", "Tarjeta de Credito", "Efectivo" });
            CboTipoDePago.Location = new Point(463, 134);
            CboTipoDePago.Name = "CboTipoDePago";
            CboTipoDePago.Size = new Size(121, 23);
            CboTipoDePago.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(463, 108);
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
            BtnPreliminar.Location = new Point(623, 172);
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
            BtnImprimir.Location = new Point(623, 125);
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
            dgvFactura.Location = new Point(29, 311);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dgvFactura.RowHeadersVisible = false;
            dgvFactura.RowTemplate.Height = 40;
            dgvFactura.Size = new Size(736, 231);
            dgvFactura.TabIndex = 103;
            // 
            // rbFactura
            // 
            rbFactura.AutoSize = true;
            rbFactura.BackColor = Color.FromArgb(24, 64, 57);
            rbFactura.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFactura.ForeColor = Color.White;
            rbFactura.Location = new Point(29, 68);
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
            BtnInsertarFactura.Location = new Point(623, 221);
            BtnInsertarFactura.Name = "BtnInsertarFactura";
            BtnInsertarFactura.Size = new Size(154, 31);
            BtnInsertarFactura.TabIndex = 108;
            BtnInsertarFactura.Text = "Insertar Factura";
            BtnInsertarFactura.TextAlign = ContentAlignment.BottomCenter;
            BtnInsertarFactura.UseVisualStyleBackColor = false;
            BtnInsertarFactura.Click += BtnInsertarFactura_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox1.Image = Properties.Resources.Loading;
            pictureBox1.Location = new Point(255, 134);
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
            TxtMontoNeto.Location = new Point(255, 108);
            TxtMontoNeto.Name = "TxtMontoNeto";
            TxtMontoNeto.Size = new Size(186, 20);
            TxtMontoNeto.TabIndex = 114;
            TxtMontoNeto.Text = "Monto Neto";
            TxtMontoNeto.Enter += TxtMontoNeto_Enter;
            TxtMontoNeto.Leave += TxtMontoNeto_Leave;
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
            TxtMontoTotal.Enter += TxtMontoTotal_Enter;
            TxtMontoTotal.Leave += TxtMontoTotal_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(24, 64, 57);
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(463, 194);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 121;
            label3.Text = "Fecha de pago";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPago.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            dtpFechaPago.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(463, 221);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(121, 23);
            dtpFechaPago.TabIndex = 120;
            // 
            // TxtNumFactura
            // 
            TxtNumFactura.BackColor = Color.FromArgb(24, 64, 57);
            TxtNumFactura.BorderStyle = BorderStyle.None;
            TxtNumFactura.Font = new Font("Century Gothic", 12F);
            TxtNumFactura.ForeColor = Color.White;
            TxtNumFactura.Location = new Point(255, 195);
            TxtNumFactura.Name = "TxtNumFactura";
            TxtNumFactura.Size = new Size(186, 20);
            TxtNumFactura.TabIndex = 116;
            TxtNumFactura.Text = "Numero Factura";
            TxtNumFactura.Enter += TxtNumFactura_Enter;
            TxtNumFactura.Leave += TxtNumFactura_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(255, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 117;
            pictureBox3.TabStop = false;
            // 
            // txtPedido
            // 
            txtPedido.Enabled = false;
            txtPedido.Location = new Point(29, 134);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(156, 23);
            txtPedido.TabIndex = 132;
            // 
            // btnBuscarPedido
            // 
            btnBuscarPedido.BackColor = Color.FromArgb(222, 151, 54);
            btnBuscarPedido.FlatAppearance.BorderSize = 0;
            btnBuscarPedido.FlatStyle = FlatStyle.Flat;
            btnBuscarPedido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarPedido.Image = (Image)resources.GetObject("btnBuscarPedido.Image");
            btnBuscarPedido.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarPedido.Location = new Point(191, 124);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new Size(40, 32);
            btnBuscarPedido.TabIndex = 131;
            btnBuscarPedido.UseVisualStyleBackColor = false;
            btnBuscarPedido.Click += btnBuscarPedido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 108);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 130;
            label1.Text = "Pedido:";
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(929, 580);
            Controls.Add(txtPedido);
            Controls.Add(btnBuscarPedido);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dtpFechaPago);
            Controls.Add(pictureBox4);
            Controls.Add(TxtMontoTotal);
            Controls.Add(pictureBox3);
            Controls.Add(TxtNumFactura);
            Controls.Add(pictureBox1);
            Controls.Add(TxtMontoNeto);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox1;
        private TextBox TxtMontoNeto;
        private PictureBox pictureBox4;
        private TextBox TxtMontoTotal;
        private Label label3;
        private DateTimePicker dtpFechaPago;
        private TextBox TxtNumFactura;
        private PictureBox pictureBox3;
        private TextBox txtPedido;
        private Button btnBuscarPedido;
        private Label label1;
    }
}