namespace UIFloristeria
{
    partial class frmEditarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarEmpleado));
            pictureBox1 = new PictureBox();
            btnEditarEpleado = new Button();
            label1 = new Label();
            btnMin = new Button();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            mtxtTelefono = new MaskedTextBox();
            label4 = new Label();
            txtPrimerNombre = new TextBox();
            txtSegundoNombre = new TextBox();
            pictureBox3 = new PictureBox();
            txtPrimerApellido = new TextBox();
            pictureBox4 = new PictureBox();
            txtSegundoApellido = new TextBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            rbMujer = new RadioButton();
            rbHombre = new RadioButton();
            txtCorreo = new TextBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // btnEditarEpleado
            // 
            btnEditarEpleado.BackColor = Color.White;
            btnEditarEpleado.FlatStyle = FlatStyle.Popup;
            btnEditarEpleado.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEpleado.Location = new Point(325, 342);
            btnEditarEpleado.Name = "btnEditarEpleado";
            btnEditarEpleado.Size = new Size(142, 27);
            btnEditarEpleado.TabIndex = 97;
            btnEditarEpleado.Text = "Editar";
            btnEditarEpleado.UseVisualStyleBackColor = false;
            btnEditarEpleado.Click += btnEditarEpleado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 36);
            label1.TabIndex = 93;
            label1.Text = "Editar empleado";
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
            btnMin.Location = new Point(729, 5);
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
            btnClose.Location = new Point(756, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 91;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(12, 129);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 94;
            pictureBox2.TabStop = false;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.BackColor = Color.FromArgb(222, 151, 54);
            mtxtTelefono.BorderStyle = BorderStyle.None;
            mtxtTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefono.ForeColor = Color.White;
            mtxtTelefono.Location = new Point(253, 213);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(78, 20);
            mtxtTelefono.TabIndex = 95;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(222, 151, 54);
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(253, 177);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 96;
            label4.Text = "Telefono:";
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.BackColor = Color.FromArgb(222, 151, 54);
            txtPrimerNombre.BorderStyle = BorderStyle.None;
            txtPrimerNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrimerNombre.ForeColor = Color.White;
            txtPrimerNombre.Location = new Point(12, 103);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(186, 20);
            txtPrimerNombre.TabIndex = 98;
            txtPrimerNombre.Text = "Primer Nombre";
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.BackColor = Color.FromArgb(222, 151, 54);
            txtSegundoNombre.BorderStyle = BorderStyle.None;
            txtSegundoNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSegundoNombre.ForeColor = Color.White;
            txtSegundoNombre.Location = new Point(209, 103);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(186, 20);
            txtSegundoNombre.TabIndex = 101;
            txtSegundoNombre.Text = "Segundo Nombre";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(209, 129);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 100;
            pictureBox3.TabStop = false;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.BackColor = Color.FromArgb(222, 151, 54);
            txtPrimerApellido.BorderStyle = BorderStyle.None;
            txtPrimerApellido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrimerApellido.ForeColor = Color.White;
            txtPrimerApellido.Location = new Point(401, 103);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(186, 20);
            txtPrimerApellido.TabIndex = 103;
            txtPrimerApellido.Text = "Primer Apellido";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox4.Image = Properties.Resources.Loading;
            pictureBox4.Location = new Point(401, 129);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(186, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 102;
            pictureBox4.TabStop = false;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.BackColor = Color.FromArgb(222, 151, 54);
            txtSegundoApellido.BorderStyle = BorderStyle.None;
            txtSegundoApellido.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSegundoApellido.ForeColor = Color.White;
            txtSegundoApellido.Location = new Point(593, 103);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(186, 20);
            txtSegundoApellido.TabIndex = 105;
            txtSegundoApellido.Text = "Segundo Apellido";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox5.Image = Properties.Resources.Loading;
            pictureBox5.Location = new Point(593, 129);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(186, 22);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 104;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(222, 151, 54);
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 177);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 108;
            label2.Text = "Es Aprobado:";
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.BackColor = Color.FromArgb(222, 151, 54);
            rbMujer.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMujer.ForeColor = Color.White;
            rbMujer.Location = new Point(35, 226);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(45, 21);
            rbMujer.TabIndex = 107;
            rbMujer.TabStop = true;
            rbMujer.Text = "No";
            rbMujer.UseVisualStyleBackColor = false;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.BackColor = Color.FromArgb(222, 151, 54);
            rbHombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbHombre.ForeColor = Color.White;
            rbHombre.Location = new Point(35, 201);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(35, 21);
            rbHombre.TabIndex = 106;
            rbHombre.TabStop = true;
            rbHombre.Text = "Si";
            rbHombre.UseVisualStyleBackColor = false;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(222, 151, 54);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(401, 189);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(186, 20);
            txtCorreo.TabIndex = 110;
            txtCorreo.Text = "Correo ";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox6.Image = Properties.Resources.Loading;
            pictureBox6.Location = new Point(401, 215);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(186, 22);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 109;
            pictureBox6.TabStop = false;
            // 
            // frmEditarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(789, 430);
            Controls.Add(txtCorreo);
            Controls.Add(pictureBox6);
            Controls.Add(label2);
            Controls.Add(rbMujer);
            Controls.Add(rbHombre);
            Controls.Add(txtSegundoApellido);
            Controls.Add(pictureBox5);
            Controls.Add(txtPrimerApellido);
            Controls.Add(pictureBox4);
            Controls.Add(txtSegundoNombre);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrimerNombre);
            Controls.Add(btnEditarEpleado);
            Controls.Add(label4);
            Controls.Add(mtxtTelefono);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEditarEmpleado";
            Load += frmEditarEmpleado_Load;
            MouseDown += frmEditarEmpleado_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEditarEpleado;
        private Label label1;
        private Button btnMin;
        private Button btnClose;
        private PictureBox pictureBox2;
        private MaskedTextBox mtxtTelefono;
        private Label label4;
        private TextBox txtPrimerNombre;
        private TextBox txtSegundoNombre;
        private PictureBox pictureBox3;
        private TextBox txtPrimerApellido;
        private PictureBox pictureBox4;
        private TextBox txtSegundoApellido;
        private PictureBox pictureBox5;
        private Label label2;
        private RadioButton rbMujer;
        private RadioButton rbHombre;
        private TextBox txtCorreo;
        private PictureBox pictureBox6;
    }
}