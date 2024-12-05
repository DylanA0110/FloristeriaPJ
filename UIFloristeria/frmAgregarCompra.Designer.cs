namespace UIFloristeria
{
    partial class frmAgregarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCompra));
            pictureBox1 = new PictureBox();
            txtCantidad = new TextBox();
            btnAgregarCompra = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            pictureBox3 = new PictureBox();
            cboProducto = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnBuscarProveedor = new Button();
            btnMin = new Button();
            btnClose = new Button();
            txtProveedor = new TextBox();
            dtpFechaCompra = new DateTimePicker();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(162, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 120;
            pictureBox1.TabStop = false;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(222, 151, 54);
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.ForeColor = Color.White;
            txtCantidad.Location = new Point(162, 123);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(102, 20);
            txtCantidad.TabIndex = 119;
            txtCantidad.Text = "Cantidad";
            // 
            // btnAgregarCompra
            // 
            btnAgregarCompra.BackColor = Color.White;
            btnAgregarCompra.FlatStyle = FlatStyle.Popup;
            btnAgregarCompra.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarCompra.Location = new Point(257, 280);
            btnAgregarCompra.Name = "btnAgregarCompra";
            btnAgregarCompra.Size = new Size(142, 27);
            btnAgregarCompra.TabIndex = 118;
            btnAgregarCompra.Text = "Agregar";
            btnAgregarCompra.UseVisualStyleBackColor = false;
            btnAgregarCompra.Click += btnAgregarCompra_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(162, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 115;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(241, 26);
            label1.Name = "label1";
            label1.Size = new Size(254, 36);
            label1.TabIndex = 114;
            label1.Text = "Agregar Compra";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(222, 151, 54);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(305, 122);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(118, 20);
            txtPrecio.TabIndex = 122;
            txtPrecio.Text = "Precio unitario";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(305, 148);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(118, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 121;
            pictureBox3.TabStop = false;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "Flor", "Accesorio" });
            cboProducto.Location = new Point(12, 147);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(121, 23);
            cboProducto.TabIndex = 123;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 124;
            label2.Text = "Producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(442, 122);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 125;
            label3.Text = "Proveedor:";
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Anchor = AnchorStyles.None;
            btnBuscarProveedor.BackColor = Color.White;
            btnBuscarProveedor.FlatStyle = FlatStyle.Popup;
            btnBuscarProveedor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarProveedor.Image = (Image)resources.GetObject("btnBuscarProveedor.Image");
            btnBuscarProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarProveedor.Location = new Point(604, 148);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(38, 25);
            btnBuscarProveedor.TabIndex = 126;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.FlatAppearance.BorderColor = Color.FromArgb(27, 73, 69);
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = Properties.Resources.menos1;
            btnMin.Location = new Point(615, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 128;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(27, 73, 69);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(642, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 127;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(442, 148);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(156, 23);
            txtProveedor.TabIndex = 129;
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaCompra.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            dtpFechaCompra.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            dtpFechaCompra.Format = DateTimePickerFormat.Short;
            dtpFechaCompra.Location = new Point(267, 214);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(121, 23);
            dtpFechaCompra.TabIndex = 130;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(257, 192);
            label4.Name = "label4";
            label4.Size = new Size(152, 19);
            label4.TabIndex = 131;
            label4.Text = "Fecha de Compra";
            // 
            // frmAgregarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(675, 333);
            Controls.Add(label4);
            Controls.Add(dtpFechaCompra);
            Controls.Add(txtProveedor);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(btnBuscarProveedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboProducto);
            Controls.Add(txtPrecio);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txtCantidad);
            Controls.Add(btnAgregarCompra);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarCompra";
            Text = "frmAgregarCompra";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtCantidad;
        private Button btnAgregarCompra;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtPrecio;
        private PictureBox pictureBox3;
        private ComboBox cboProducto;
        private Label label2;
        private Label label3;
        private Button btnBuscarProveedor;
        private Button btnMin;
        private Button btnClose;
        private TextBox txtProveedor;
        private DateTimePicker dtpFechaCompra;
        private Label label4;
    }
}