namespace UIFloristeria
{
    partial class frmAgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCliente));
            pictureBox1 = new PictureBox();
            txtNombreCliente = new TextBox();
            btnAggCliente = new Button();
            label4 = new Label();
            mtxtTelefono = new MaskedTextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnMin = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(104, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.FromArgb(222, 151, 54);
            txtNombreCliente.BorderStyle = BorderStyle.None;
            txtNombreCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCliente.ForeColor = Color.White;
            txtNombreCliente.Location = new Point(108, 107);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(186, 20);
            txtNombreCliente.TabIndex = 96;
            txtNombreCliente.Text = "Nombre Cliente";
            txtNombreCliente.Enter += txtNombreCliente_Enter;
            txtNombreCliente.Leave += txtNombreCliente_Leave;
            // 
            // btnAggCliente
            // 
            btnAggCliente.BackColor = Color.White;
            btnAggCliente.FlatStyle = FlatStyle.Popup;
            btnAggCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggCliente.Location = new Point(222, 277);
            btnAggCliente.Name = "btnAggCliente";
            btnAggCliente.Size = new Size(142, 27);
            btnAggCliente.TabIndex = 95;
            btnAggCliente.Text = "Agregar";
            btnAggCliente.UseVisualStyleBackColor = false;
            btnAggCliente.Click += btnAggCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(222, 151, 54);
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(363, 97);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 94;
            label4.Text = "Telefono:";
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.BackColor = Color.FromArgb(222, 151, 54);
            mtxtTelefono.BorderStyle = BorderStyle.None;
            mtxtTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefono.ForeColor = Color.White;
            mtxtTelefono.Location = new Point(363, 133);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(78, 20);
            mtxtTelefono.TabIndex = 93;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(108, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 92;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(183, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 36);
            label1.TabIndex = 91;
            label1.Text = "Agregar Cliente";
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
            btnMin.Location = new Point(534, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 99;
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
            btnClose.Location = new Point(561, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 98;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(591, 334);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombreCliente);
            Controls.Add(btnAggCliente);
            Controls.Add(label4);
            Controls.Add(mtxtTelefono);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgregarCliente";
            MouseDown += frmAgregarCliente_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNombreCliente;
        private Button btnAggCliente;
        private Label label4;
        private MaskedTextBox mtxtTelefono;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnMin;
        private Button btnClose;
    }
}