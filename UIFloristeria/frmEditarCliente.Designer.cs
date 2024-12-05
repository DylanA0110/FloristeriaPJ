namespace UIFloristeria
{
    partial class frmEditarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarCliente));
            btnMin = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            txtNombreCliente = new TextBox();
            btnEditar = new Button();
            label4 = new Label();
            mtxtTelefono = new MaskedTextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnMin.Location = new Point(542, 5);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 108;
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
            btnClose.Location = new Point(569, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 107;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(123, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 106;
            pictureBox1.TabStop = false;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.FromArgb(222, 151, 54);
            txtNombreCliente.BorderStyle = BorderStyle.None;
            txtNombreCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreCliente.ForeColor = Color.White;
            txtNombreCliente.Location = new Point(127, 107);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(186, 20);
            txtNombreCliente.TabIndex = 105;
            txtNombreCliente.Text = "Nombre Cliente";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Popup;
            btnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(243, 220);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(142, 27);
            btnEditar.TabIndex = 104;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(222, 151, 54);
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(382, 97);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 103;
            label4.Text = "Telefono:";
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.BackColor = Color.FromArgb(222, 151, 54);
            mtxtTelefono.BorderStyle = BorderStyle.None;
            mtxtTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefono.ForeColor = Color.White;
            mtxtTelefono.Location = new Point(382, 133);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(78, 20);
            mtxtTelefono.TabIndex = 102;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(127, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 101;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 36);
            label1.TabIndex = 100;
            label1.Text = "Editar Cliente";
            // 
            // frmEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(600, 291);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombreCliente);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(mtxtTelefono);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditarCliente";
            Load += frmEditarCliente_Load;
            MouseDown += frmEditarCliente_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMin;
        private Button btnClose;
        private PictureBox pictureBox1;
        private TextBox txtNombreCliente;
        private Button btnEditar;
        private Label label4;
        private MaskedTextBox mtxtTelefono;
        private PictureBox pictureBox2;
        private Label label1;
    }
}