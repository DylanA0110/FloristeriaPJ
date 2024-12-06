namespace UIFloristeria
{
    partial class frmEditarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPedido));
            btnEditarCompra = new Button();
            TxtDescripcion = new TextBox();
            pictureBox3 = new PictureBox();
            TxtEnviarseA = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtCantidad = new TextBox();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            dtpFechaEntrega = new DateTimePicker();
            label2 = new Label();
            DtpSolicitud = new DateTimePicker();
            btnMin = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnEditarCompra
            // 
            btnEditarCompra.BackColor = Color.White;
            btnEditarCompra.FlatStyle = FlatStyle.Popup;
            btnEditarCompra.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCompra.Location = new Point(254, 264);
            btnEditarCompra.Name = "btnEditarCompra";
            btnEditarCompra.Size = new Size(142, 27);
            btnEditarCompra.TabIndex = 132;
            btnEditarCompra.Text = "Editar";
            btnEditarCompra.UseVisualStyleBackColor = false;
            btnEditarCompra.Click += btnEditarCompra_Click;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.BackColor = Color.FromArgb(222, 151, 54);
            TxtDescripcion.BorderStyle = BorderStyle.None;
            TxtDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtDescripcion.ForeColor = Color.White;
            TxtDescripcion.Location = new Point(264, 125);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(118, 20);
            TxtDescripcion.TabIndex = 149;
            TxtDescripcion.Text = "Descripcion";
            TxtDescripcion.Enter += TxtDescripcion_Enter;
            TxtDescripcion.Leave += TxtDescripcion_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(264, 151);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(118, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 148;
            pictureBox3.TabStop = false;
            // 
            // TxtEnviarseA
            // 
            TxtEnviarseA.BackColor = Color.FromArgb(222, 151, 54);
            TxtEnviarseA.BorderStyle = BorderStyle.None;
            TxtEnviarseA.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtEnviarseA.ForeColor = Color.White;
            TxtEnviarseA.Location = new Point(121, 126);
            TxtEnviarseA.Name = "TxtEnviarseA";
            TxtEnviarseA.Size = new Size(102, 20);
            TxtEnviarseA.TabIndex = 147;
            TxtEnviarseA.Text = "Enviarse a";
            TxtEnviarseA.Enter += TxtEnviarseA_Enter;
            TxtEnviarseA.Leave += TxtEnviarseA_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(121, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 146;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(185, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 151;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(264, 30);
            label1.Name = "label1";
            label1.Size = new Size(200, 36);
            label1.TabIndex = 150;
            label1.Text = "Editar Pedido";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(222, 151, 54);
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.ForeColor = Color.White;
            txtCantidad.Location = new Point(407, 126);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(102, 20);
            txtCantidad.TabIndex = 153;
            txtCantidad.Text = "Cantidad";
            txtCantidad.Enter += txtCantidad_Enter;
            txtCantidad.Leave += txtCantidad_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox5.Image = Properties.Resources.Loading;
            pictureBox5.Location = new Point(407, 152);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(102, 22);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 152;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(333, 199);
            label4.Name = "label4";
            label4.Size = new Size(146, 19);
            label4.TabIndex = 155;
            label4.Text = "Fecha de Entrega";
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaEntrega.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            dtpFechaEntrega.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            dtpFechaEntrega.Format = DateTimePickerFormat.Short;
            dtpFechaEntrega.Location = new Point(343, 221);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(121, 23);
            dtpFechaEntrega.TabIndex = 154;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(159, 199);
            label2.Name = "label2";
            label2.Size = new Size(152, 19);
            label2.TabIndex = 157;
            label2.Text = "Fecha de Solicitud";
            // 
            // DtpSolicitud
            // 
            DtpSolicitud.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DtpSolicitud.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            DtpSolicitud.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            DtpSolicitud.Format = DateTimePickerFormat.Short;
            DtpSolicitud.Location = new Point(169, 221);
            DtpSolicitud.Name = "DtpSolicitud";
            DtpSolicitud.Size = new Size(121, 23);
            DtpSolicitud.TabIndex = 156;
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
            btnMin.TabIndex = 159;
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
            btnClose.Location = new Point(637, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 158;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmEditarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(670, 347);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(DtpSolicitud);
            Controls.Add(label4);
            Controls.Add(dtpFechaEntrega);
            Controls.Add(txtCantidad);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(TxtDescripcion);
            Controls.Add(pictureBox3);
            Controls.Add(TxtEnviarseA);
            Controls.Add(pictureBox2);
            Controls.Add(btnEditarCompra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditarPedido";
            Load += frmEditarPedido_Load;
            MouseDown += frmEditarPedido_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditarCompra;
        private TextBox TxtDescripcion;
        private PictureBox pictureBox3;
        private TextBox TxtEnviarseA;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtCantidad;
        private PictureBox pictureBox5;
        private Label label4;
        private DateTimePicker dtpFechaEntrega;
        private Label label2;
        private DateTimePicker DtpSolicitud;
        private Button btnMin;
        private Button btnClose;
    }
}