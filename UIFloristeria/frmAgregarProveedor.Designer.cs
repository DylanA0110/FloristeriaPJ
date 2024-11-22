namespace UIFloristeria
{
    partial class frmAgregarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProveedor));
            btnAggProveedor = new Button();
            label4 = new Label();
            mtxtTelefono = new MaskedTextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnMin = new Button();
            btnClose = new Button();
            txtNombreProveedor = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAggProveedor
            // 
            btnAggProveedor.BackColor = Color.White;
            btnAggProveedor.FlatStyle = FlatStyle.Popup;
            btnAggProveedor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggProveedor.Location = new Point(237, 278);
            btnAggProveedor.Name = "btnAggProveedor";
            btnAggProveedor.Size = new Size(142, 27);
            btnAggProveedor.TabIndex = 88;
            btnAggProveedor.Text = "Agregar";
            btnAggProveedor.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(222, 151, 54);
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(359, 112);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 86;
            label4.Text = "Telefono:";
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.BackColor = Color.FromArgb(222, 151, 54);
            mtxtTelefono.BorderStyle = BorderStyle.None;
            mtxtTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefono.ForeColor = Color.White;
            mtxtTelefono.Location = new Point(359, 148);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(78, 20);
            mtxtTelefono.TabIndex = 85;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(104, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 84;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(168, 12);
            label1.Name = "label1";
            label1.Size = new Size(286, 36);
            label1.TabIndex = 83;
            label1.Text = "Agregar proveedor";
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
            btnMin.Location = new Point(530, 8);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 82;
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
            btnClose.Location = new Point(557, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 81;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.BackColor = Color.FromArgb(222, 151, 54);
            txtNombreProveedor.BorderStyle = BorderStyle.None;
            txtNombreProveedor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreProveedor.ForeColor = Color.White;
            txtNombreProveedor.Location = new Point(104, 122);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(186, 20);
            txtNombreProveedor.TabIndex = 89;
            txtNombreProveedor.Text = "Nombre Proveedor";
            txtNombreProveedor.Enter += txtNombreProveedor_Enter;
            txtNombreProveedor.Leave += txtNombreProveedor_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.TabIndex = 90;
            pictureBox1.TabStop = false;
            // 
            // frmAgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Dashboard_Login;
            ClientSize = new Size(591, 334);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombreProveedor);
            Controls.Add(btnAggProveedor);
            Controls.Add(label4);
            Controls.Add(mtxtTelefono);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarProveedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAgregarProveedor";
            MouseDown += frmAgregarProveedor_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAggProveedor;
        private Label label4;
        private MaskedTextBox mtxtTelefono;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnMin;
        private Button btnClose;
        private TextBox txtNombreProveedor;
        private PictureBox pictureBox1;
    }
}