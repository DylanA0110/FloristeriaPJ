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
            btnEditarEmpleado = new Button();
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
            rbNo = new RadioButton();
            rbSi = new RadioButton();
            txtCorreo = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox9 = new PictureBox();
            txtConfirmPass = new TextBox();
            pictureBox8 = new PictureBox();
            txtPass = new TextBox();
            label3 = new Label();
            rbMujer = new RadioButton();
            rbHombre = new RadioButton();
            Ver = new PictureBox();
            NoVer = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            chkCambiarPass = new CheckBox();
            cmbRol = new ComboBox();
            label5 = new Label();
            dtpFechaNac = new DateTimePicker();
            txtUserName = new TextBox();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ver).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NoVer).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
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
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.BackColor = Color.White;
            btnEditarEmpleado.FlatStyle = FlatStyle.Popup;
            btnEditarEmpleado.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEmpleado.Location = new Point(320, 460);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(142, 27);
            btnEditarEmpleado.TabIndex = 97;
            btnEditarEmpleado.Text = "Editar";
            btnEditarEmpleado.UseVisualStyleBackColor = false;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
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
            mtxtTelefono.Location = new Point(413, 213);
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
            label4.Location = new Point(413, 177);
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
            label2.Location = new Point(63, 177);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 108;
            label2.Text = "Es Aprobado:";
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.BackColor = Color.FromArgb(222, 151, 54);
            rbNo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbNo.ForeColor = Color.White;
            rbNo.Location = new Point(14, 29);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(45, 21);
            rbNo.TabIndex = 107;
            rbNo.TabStop = true;
            rbNo.Text = "No";
            rbNo.UseVisualStyleBackColor = false;
            // 
            // rbSi
            // 
            rbSi.AutoSize = true;
            rbSi.BackColor = Color.FromArgb(222, 151, 54);
            rbSi.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbSi.ForeColor = Color.White;
            rbSi.Location = new Point(14, 4);
            rbSi.Name = "rbSi";
            rbSi.Size = new Size(35, 21);
            rbSi.TabIndex = 106;
            rbSi.TabStop = true;
            rbSi.Text = "Si";
            rbSi.UseVisualStyleBackColor = false;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(222, 151, 54);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(552, 187);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(186, 20);
            txtCorreo.TabIndex = 110;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox6.Image = Properties.Resources.Loading;
            pictureBox6.Location = new Point(552, 213);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(186, 22);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 109;
            pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox9.Image = Properties.Resources.Loading;
            pictureBox9.Location = new Point(458, 309);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(186, 22);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 114;
            pictureBox9.TabStop = false;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BackColor = Color.FromArgb(222, 151, 54);
            txtConfirmPass.BorderStyle = BorderStyle.None;
            txtConfirmPass.Font = new Font("Century Gothic", 12F);
            txtConfirmPass.ForeColor = Color.White;
            txtConfirmPass.Location = new Point(458, 283);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(186, 20);
            txtConfirmPass.TabIndex = 113;
            txtConfirmPass.Text = "Confirmar Contraseña";
            txtConfirmPass.Enter += txtConfirmPass_Enter;
            txtConfirmPass.Leave += txtConfirmPass_Leave;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox8.Image = Properties.Resources.Loading;
            pictureBox8.Location = new Point(209, 309);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(186, 22);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 112;
            pictureBox8.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(222, 151, 54);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 12F);
            txtPass.ForeColor = Color.White;
            txtPass.Location = new Point(209, 283);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(186, 20);
            txtPass.TabIndex = 111;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(222, 151, 54);
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(272, 175);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 117;
            label3.Text = "Sexo:";
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.BackColor = Color.FromArgb(222, 151, 54);
            rbMujer.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMujer.ForeColor = Color.White;
            rbMujer.Location = new Point(17, 36);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(60, 21);
            rbMujer.TabIndex = 116;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = false;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.BackColor = Color.FromArgb(222, 151, 54);
            rbHombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbHombre.ForeColor = Color.White;
            rbHombre.Location = new Point(17, 9);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(78, 21);
            rbHombre.TabIndex = 115;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = false;
            // 
            // Ver
            // 
            Ver.Image = (Image)resources.GetObject("Ver.Image");
            Ver.Location = new Point(401, 309);
            Ver.Name = "Ver";
            Ver.Size = new Size(25, 22);
            Ver.TabIndex = 118;
            Ver.TabStop = false;
            Ver.Click += Ver_Click;
            // 
            // NoVer
            // 
            NoVer.Image = (Image)resources.GetObject("NoVer.Image");
            NoVer.Location = new Point(401, 309);
            NoVer.Name = "NoVer";
            NoVer.Size = new Size(25, 22);
            NoVer.TabIndex = 119;
            NoVer.TabStop = false;
            NoVer.Click += NoVer_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbNo);
            panel1.Controls.Add(rbSi);
            panel1.Location = new Point(49, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(65, 62);
            panel1.TabIndex = 120;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbMujer);
            panel2.Controls.Add(rbHombre);
            panel2.Location = new Point(236, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 72);
            panel2.TabIndex = 121;
            // 
            // chkCambiarPass
            // 
            chkCambiarPass.AutoSize = true;
            chkCambiarPass.Location = new Point(41, 312);
            chkCambiarPass.Name = "chkCambiarPass";
            chkCambiarPass.Size = new Size(142, 19);
            chkCambiarPass.TabIndex = 122;
            chkCambiarPass.Text = "¿Cambiar contraseña?";
            chkCambiarPass.UseVisualStyleBackColor = true;
            chkCambiarPass.CheckedChanged += chkCambiarPass_CheckedChanged;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(77, 380);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 123;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(222, 151, 54);
            label5.Font = new Font("Century Gothic", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(320, 355);
            label5.Name = "label5";
            label5.Size = new Size(181, 21);
            label5.TabIndex = 125;
            label5.Text = "Fecha de nacimiento:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNac.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            dtpFechaNac.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(343, 382);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(121, 23);
            dtpFechaNac.TabIndex = 124;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(222, 151, 54);
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(573, 355);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(186, 20);
            txtUserName.TabIndex = 127;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox7.Image = Properties.Resources.Loading;
            pictureBox7.Location = new Point(573, 381);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(186, 22);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 126;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(222, 151, 54);
            label6.Font = new Font("Century Gothic", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(77, 356);
            label6.Name = "label6";
            label6.Size = new Size(37, 21);
            label6.TabIndex = 128;
            label6.Text = "Rol:";
            // 
            // frmEditarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(789, 499);
            Controls.Add(label6);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox7);
            Controls.Add(label5);
            Controls.Add(dtpFechaNac);
            Controls.Add(cmbRol);
            Controls.Add(chkCambiarPass);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(NoVer);
            Controls.Add(Ver);
            Controls.Add(label3);
            Controls.Add(pictureBox9);
            Controls.Add(txtConfirmPass);
            Controls.Add(pictureBox8);
            Controls.Add(txtPass);
            Controls.Add(txtCorreo);
            Controls.Add(pictureBox6);
            Controls.Add(label2);
            Controls.Add(txtSegundoApellido);
            Controls.Add(pictureBox5);
            Controls.Add(txtPrimerApellido);
            Controls.Add(pictureBox4);
            Controls.Add(txtSegundoNombre);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrimerNombre);
            Controls.Add(btnEditarEmpleado);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ver).EndInit();
            ((System.ComponentModel.ISupportInitialize)NoVer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEditarEmpleado;
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
        private RadioButton rbNo;
        private RadioButton rbSi;
        private TextBox txtCorreo;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private TextBox txtConfirmPass;
        private PictureBox pictureBox8;
        private TextBox txtPass;
        private Label label3;
        private RadioButton rbMujer;
        private RadioButton rbHombre;
        private PictureBox Ver;
        private PictureBox NoVer;
        private Panel panel1;
        private Panel panel2;
        private CheckBox chkCambiarPass;
        private ComboBox cmbRol;
        private Label label5;
        private DateTimePicker dtpFechaNac;
        private TextBox txtUserName;
        private PictureBox pictureBox7;
        private Label label6;
    }
}