namespace UIFloristeria
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            txtPrimerNombre = new TextBox();
            pictureBox1 = new PictureBox();
            txtSegundoNombre = new TextBox();
            pictureBox3 = new PictureBox();
            txtPrimerApellido = new TextBox();
            pictureBox4 = new PictureBox();
            txtSegundoApellido = new TextBox();
            pictureBox5 = new PictureBox();
            txtCorreo = new TextBox();
            rbHombre = new RadioButton();
            rbMujer = new RadioButton();
            label2 = new Label();
            dtpFechaNac = new DateTimePicker();
            label3 = new Label();
            mtxtTelefono = new MaskedTextBox();
            pictureBox7 = new PictureBox();
            txtUser = new TextBox();
            pictureBox8 = new PictureBox();
            txtPass = new TextBox();
            pictureBox9 = new PictureBox();
            txtConfirmPass = new TextBox();
            label4 = new Label();
            button1 = new Button();
            btnMin = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(24, 64, 57);
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(320, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 36);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(12, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.BackColor = Color.FromArgb(24, 64, 57);
            txtPrimerNombre.BorderStyle = BorderStyle.None;
            txtPrimerNombre.Font = new Font("Century Gothic", 12F);
            txtPrimerNombre.ForeColor = Color.White;
            txtPrimerNombre.Location = new Point(12, 101);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(186, 20);
            txtPrimerNombre.TabIndex = 3;
            txtPrimerNombre.Text = "Primer Nombre";
            txtPrimerNombre.Enter += txtPrimerNombre_Enter;
            txtPrimerNombre.Leave += txtPrimerNombre_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox1.Image = Properties.Resources.Loading;
            pictureBox1.Location = new Point(218, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.BackColor = Color.FromArgb(24, 64, 57);
            txtSegundoNombre.BorderStyle = BorderStyle.None;
            txtSegundoNombre.Font = new Font("Century Gothic", 12F);
            txtSegundoNombre.ForeColor = Color.White;
            txtSegundoNombre.Location = new Point(218, 101);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.Size = new Size(186, 20);
            txtSegundoNombre.TabIndex = 6;
            txtSegundoNombre.Text = "Segundo Nombre";
            txtSegundoNombre.Enter += txtSegundoNombre_Enter;
            txtSegundoNombre.Leave += txtSegundoNombre_Leave;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(421, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(186, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.BackColor = Color.FromArgb(24, 64, 57);
            txtPrimerApellido.BorderStyle = BorderStyle.None;
            txtPrimerApellido.Font = new Font("Century Gothic", 12F);
            txtPrimerApellido.ForeColor = Color.White;
            txtPrimerApellido.Location = new Point(421, 101);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(186, 20);
            txtPrimerApellido.TabIndex = 8;
            txtPrimerApellido.Text = "Primer Apellido";
            txtPrimerApellido.Enter += txtPrimerApellido_Enter;
            txtPrimerApellido.Leave += txtPrimerApellido_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox4.Image = Properties.Resources.Loading;
            pictureBox4.Location = new Point(613, 127);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(186, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.BackColor = Color.FromArgb(24, 64, 57);
            txtSegundoApellido.BorderStyle = BorderStyle.None;
            txtSegundoApellido.Font = new Font("Century Gothic", 12F);
            txtSegundoApellido.ForeColor = Color.White;
            txtSegundoApellido.Location = new Point(613, 101);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(186, 20);
            txtSegundoApellido.TabIndex = 10;
            txtSegundoApellido.Text = "Segundo Apellido";
            txtSegundoApellido.Enter += txtSegundoApellido_Enter;
            txtSegundoApellido.Leave += txtSegundoApellido_Leave;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox5.Image = Properties.Resources.Loading;
            pictureBox5.Location = new Point(540, 206);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(186, 22);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(24, 64, 57);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Century Gothic", 12F);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(540, 180);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(186, 20);
            txtCorreo.TabIndex = 18;
            txtCorreo.Text = "Correo";
            txtCorreo.Enter += txtCorreo_Enter;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // rbHombre
            // 
            rbHombre.AutoSize = true;
            rbHombre.BackColor = Color.FromArgb(24, 64, 57);
            rbHombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbHombre.ForeColor = Color.White;
            rbHombre.Location = new Point(10, 199);
            rbHombre.Name = "rbHombre";
            rbHombre.Size = new Size(78, 21);
            rbHombre.TabIndex = 20;
            rbHombre.TabStop = true;
            rbHombre.Text = "Hombre";
            rbHombre.UseVisualStyleBackColor = false;
            // 
            // rbMujer
            // 
            rbMujer.AutoSize = true;
            rbMujer.BackColor = Color.FromArgb(24, 64, 57);
            rbMujer.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbMujer.ForeColor = Color.White;
            rbMujer.Location = new Point(10, 224);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(60, 21);
            rbMujer.TabIndex = 21;
            rbMujer.TabStop = true;
            rbMujer.Text = "Mujer";
            rbMujer.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(24, 64, 57);
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(6, 179);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 22;
            label2.Text = "Sexo:";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.CalendarFont = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaNac.CalendarMonthBackground = Color.FromArgb(24, 64, 57);
            dtpFechaNac.CalendarTitleBackColor = Color.FromArgb(24, 64, 57);
            dtpFechaNac.Format = DateTimePickerFormat.Short;
            dtpFechaNac.Location = new Point(155, 205);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(121, 23);
            dtpFechaNac.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(24, 64, 57);
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(132, 178);
            label3.Name = "label3";
            label3.Size = new Size(181, 21);
            label3.TabIndex = 24;
            label3.Text = "Fecha de nacimiento:";
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.BackColor = Color.FromArgb(24, 64, 57);
            mtxtTelefono.BorderStyle = BorderStyle.None;
            mtxtTelefono.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtTelefono.ForeColor = Color.White;
            mtxtTelefono.Location = new Point(347, 208);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(182, 20);
            mtxtTelefono.TabIndex = 25;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox7.Image = Properties.Resources.Loading;
            pictureBox7.Location = new Point(6, 298);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(186, 22);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(24, 64, 57);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century Gothic", 12F);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(6, 272);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(186, 20);
            txtUser.TabIndex = 26;
            txtUser.Text = "Username";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox8.Image = Properties.Resources.Loading;
            pictureBox8.Location = new Point(238, 298);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(186, 22);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 29;
            pictureBox8.TabStop = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(24, 64, 57);
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Century Gothic", 12F);
            txtPass.ForeColor = Color.White;
            txtPass.Location = new Point(238, 272);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(186, 20);
            txtPass.TabIndex = 28;
            txtPass.Text = "Contraseña";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(24, 64, 57);
            pictureBox9.Image = Properties.Resources.Loading;
            pictureBox9.Location = new Point(442, 298);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(186, 22);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BackColor = Color.FromArgb(24, 64, 57);
            txtConfirmPass.BorderStyle = BorderStyle.None;
            txtConfirmPass.Font = new Font("Century Gothic", 12F);
            txtConfirmPass.ForeColor = Color.White;
            txtConfirmPass.Location = new Point(442, 272);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(186, 20);
            txtConfirmPass.TabIndex = 30;
            txtConfirmPass.Text = "Confirmar Contraseña";
            txtConfirmPass.Enter += txtConfirmPass_Enter;
            txtConfirmPass.Leave += txtSegundoApellido_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(24, 64, 57);
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(333, 179);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 32;
            label4.Text = "Telefono:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(347, 411);
            button1.Name = "button1";
            button1.Size = new Size(142, 27);
            button1.TabIndex = 2;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.FromArgb(24, 64, 57);
            btnMin.FlatAppearance.BorderColor = Color.FromArgb(27, 73, 69);
            btnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = Properties.Resources.menos1;
            btnMin.Location = new Point(740, 9);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 35;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click_1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(24, 64, 57);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(27, 73, 69);
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(767, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 34;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login__Community___1_;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(pictureBox9);
            Controls.Add(txtConfirmPass);
            Controls.Add(pictureBox8);
            Controls.Add(txtPass);
            Controls.Add(pictureBox7);
            Controls.Add(txtUser);
            Controls.Add(mtxtTelefono);
            Controls.Add(label3);
            Controls.Add(dtpFechaNac);
            Controls.Add(label2);
            Controls.Add(rbMujer);
            Controls.Add(rbHombre);
            Controls.Add(pictureBox5);
            Controls.Add(txtCorreo);
            Controls.Add(pictureBox4);
            Controls.Add(txtSegundoApellido);
            Controls.Add(pictureBox3);
            Controls.Add(txtPrimerApellido);
            Controls.Add(pictureBox1);
            Controls.Add(txtSegundoNombre);
            Controls.Add(pictureBox2);
            Controls.Add(txtPrimerNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRegister";
            MouseDown += FrmRegister_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txtPrimerNombre;
        private PictureBox pictureBox1;
        private TextBox txtSegundoNombre;
        private PictureBox pictureBox3;
        private TextBox txtPrimerApellido;
        private PictureBox pictureBox4;
        private TextBox txtSegundoApellido;
        private PictureBox pictureBox5;
        private TextBox txtCorreo;
        private RadioButton rbHombre;
        private RadioButton rbMujer;
        private Label label2;
        private DateTimePicker dtpFechaNac;
        private Label label3;
        private MaskedTextBox mtxtTelefono;
        private PictureBox pictureBox7;
        private TextBox txtUser;
        private PictureBox pictureBox8;
        private TextBox txtPass;
        private PictureBox pictureBox9;
        private TextBox txtConfirmPass;
        private Label label4;
        private Button button1;
        private Button btnMin;
        private Button btnClose;
    }
}