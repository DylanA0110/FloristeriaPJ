namespace UIFloristeria
{
    partial class frmEditarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarCompra));
            btnMin = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            btnEditarCompra = new Button();
            label1 = new Label();
            label4 = new Label();
            dtpFechaCompra = new DateTimePicker();
            txtProveedor = new TextBox();
            btnBuscarProveedor = new Button();
            label3 = new Label();
            label2 = new Label();
            cboProducto = new ComboBox();
            txtPrecio = new TextBox();
            pictureBox3 = new PictureBox();
            txtCantidad = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            btnMin.Location = new Point(610, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 141;
            btnMin.UseVisualStyleBackColor = false;
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
            btnClose.Location = new Point(637, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 140;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 133;
            pictureBox1.TabStop = false;
            // 
            // btnEditarCompra
            // 
            btnEditarCompra.BackColor = Color.White;
            btnEditarCompra.FlatStyle = FlatStyle.Popup;
            btnEditarCompra.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCompra.Location = new Point(246, 278);
            btnEditarCompra.Name = "btnEditarCompra";
            btnEditarCompra.Size = new Size(142, 27);
            btnEditarCompra.TabIndex = 131;
            btnEditarCompra.Text = "Editar";
            btnEditarCompra.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(253, 28);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 129;
            label1.Text = "Editar Compra";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(257, 190);
            label4.Name = "label4";
            label4.Size = new Size(152, 19);
            label4.TabIndex = 152;
            label4.Text = "Fecha de Compra";
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaCompra.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            dtpFechaCompra.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            dtpFechaCompra.Format = DateTimePickerFormat.Short;
            dtpFechaCompra.Location = new Point(267, 212);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(121, 23);
            dtpFechaCompra.TabIndex = 151;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(442, 146);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(156, 23);
            txtProveedor.TabIndex = 150;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Anchor = AnchorStyles.None;
            btnBuscarProveedor.BackColor = Color.White;
            btnBuscarProveedor.FlatStyle = FlatStyle.Popup;
            btnBuscarProveedor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarProveedor.Image = (Image)resources.GetObject("btnBuscarProveedor.Image");
            btnBuscarProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarProveedor.Location = new Point(604, 146);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(38, 25);
            btnBuscarProveedor.TabIndex = 149;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(442, 120);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 148;
            label3.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 147;
            label2.Text = "Producto:";
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "Flor", "Accesorio" });
            cboProducto.Location = new Point(12, 145);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(121, 23);
            cboProducto.TabIndex = 146;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(222, 151, 54);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(305, 120);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(118, 20);
            txtPrecio.TabIndex = 145;
            txtPrecio.Text = "Precio unitario";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(305, 146);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(118, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 144;
            pictureBox3.TabStop = false;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(222, 151, 54);
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.ForeColor = Color.White;
            txtCantidad.Location = new Point(162, 121);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(102, 20);
            txtCantidad.TabIndex = 143;
            txtCantidad.Text = "Cantidad";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(162, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 142;
            pictureBox2.TabStop = false;
            // 
            // frmEditarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(670, 347);
            Controls.Add(label4);
            Controls.Add(dtpFechaCompra);
            Controls.Add(txtProveedor);
            Controls.Add(btnBuscarProveedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboProducto);
            Controls.Add(txtPrecio);
            Controls.Add(pictureBox3);
            Controls.Add(txtCantidad);
            Controls.Add(pictureBox2);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(btnEditarCompra);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarCompra";
            Text = "frmEditarCompra";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMin;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button btnEditarCompra;
        private Label label1;
        private Label label4;
        private DateTimePicker dtpFechaCompra;
        private TextBox txtProveedor;
        private Button btnBuscarProveedor;
        private Label label3;
        private Label label2;
        private ComboBox cboProducto;
        private TextBox txtPrecio;
        private PictureBox pictureBox3;
        private TextBox txtCantidad;
        private PictureBox pictureBox2;
    }
}