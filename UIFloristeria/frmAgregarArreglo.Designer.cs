namespace UIFloristeria
{
    partial class frmAgregarArreglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarArreglo));
            pictureBox1 = new PictureBox();
            txtNombreArreglo = new TextBox();
            btnAggArreglo = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnMin = new Button();
            btnClose = new Button();
            txtCantidad = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            CbCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // txtNombreArreglo
            // 
            txtNombreArreglo.BackColor = Color.FromArgb(222, 151, 54);
            txtNombreArreglo.BorderStyle = BorderStyle.None;
            txtNombreArreglo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreArreglo.ForeColor = Color.White;
            txtNombreArreglo.Location = new Point(22, 128);
            txtNombreArreglo.Name = "txtNombreArreglo";
            txtNombreArreglo.Size = new Size(186, 20);
            txtNombreArreglo.TabIndex = 98;
            txtNombreArreglo.Text = "Nombre Arreglo";
            txtNombreArreglo.Enter += txtNombreArreglo_Enter;
            txtNombreArreglo.Leave += txtNombreArreglo_Leave;
            // 
            // btnAggArreglo
            // 
            btnAggArreglo.BackColor = Color.White;
            btnAggArreglo.FlatStyle = FlatStyle.Popup;
            btnAggArreglo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggArreglo.Location = new Point(228, 245);
            btnAggArreglo.Name = "btnAggArreglo";
            btnAggArreglo.Size = new Size(142, 27);
            btnAggArreglo.TabIndex = 97;
            btnAggArreglo.Text = "Agregar";
            btnAggArreglo.UseVisualStyleBackColor = false;
            btnAggArreglo.Click += btnAggArreglo_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(22, 154);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 94;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 14);
            label1.Name = "label1";
            label1.Size = new Size(241, 36);
            label1.TabIndex = 93;
            label1.Text = "Agregar Arreglo";
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
            btnMin.Location = new Point(525, 14);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 92;
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
            btnClose.Location = new Point(552, 14);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 91;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(222, 151, 54);
            txtCantidad.BorderStyle = BorderStyle.None;
            txtCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.ForeColor = Color.White;
            txtCantidad.Location = new Point(249, 128);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(186, 20);
            txtCantidad.TabIndex = 101;
            txtCantidad.Text = "Cantidad";
            txtCantidad.Enter += txtCantidad_Enter;
            txtCantidad.Leave += txtCantidad_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(249, 154);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 100;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(425, 129);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 135;
            label2.Text = "Categoria ";
            // 
            // CbCategoria
            // 
            CbCategoria.FormattingEnabled = true;
            CbCategoria.Location = new Point(425, 153);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(121, 23);
            CbCategoria.TabIndex = 134;
            // 
            // frmAgregarArreglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(591, 334);
            Controls.Add(label2);
            Controls.Add(CbCategoria);
            Controls.Add(txtCantidad);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombreArreglo);
            Controls.Add(btnAggArreglo);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarArreglo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarArreglo";
            Load += frmAgregarArreglo_Load;
            MouseDown += frmAgregarArreglo_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNombreArreglo;
        private Button btnAggArreglo;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnMin;
        private Button btnClose;
        private TextBox txtCantidad;
        private PictureBox pictureBox3;
        private Label label2;
        private ComboBox CbCategoria;
    }
}