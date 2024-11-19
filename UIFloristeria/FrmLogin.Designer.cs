namespace UIFloristeria
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnLogin = new Button();
            linkRegister = new LinkLabel();
            pictureBox6 = new PictureBox();
            btnClose = new Button();
            btnMin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(27, 73, 69);
            pictureBox1.Image = Properties.Resources.LOGIN;
            pictureBox1.Location = new Point(413, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(27, 73, 69);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Century Gothic", 12F);
            txtUser.ForeColor = SystemColors.ScrollBar;
            txtUser.Location = new Point(413, 171);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(278, 20);
            txtUser.TabIndex = 2;
            txtUser.Text = "Username";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(27, 73, 69);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 12F);
            txtPassword.ForeColor = SystemColors.ScrollBar;
            txtPassword.Location = new Point(413, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(278, 20);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(27, 73, 69);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(398, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(27, 73, 69);
            pictureBox3.Image = Properties.Resources.Loading;
            pictureBox3.Location = new Point(398, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(27, 73, 69);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(27, 73, 69);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Image = Properties.Resources.Component_1;
            btnLogin.Location = new Point(383, 365);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 30);
            btnLogin.TabIndex = 1;
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // linkRegister
            // 
            linkRegister.ActiveLinkColor = Color.White;
            linkRegister.AutoSize = true;
            linkRegister.BackColor = Color.FromArgb(27, 73, 69);
            linkRegister.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegister.LinkColor = Color.FromArgb(242, 157, 53);
            linkRegister.Location = new Point(502, 326);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(98, 17);
            linkRegister.TabIndex = 4;
            linkRegister.TabStop = true;
            linkRegister.Text = "Registrese aquí";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(27, 73, 69);
            pictureBox6.Image = Properties.Resources.Logo;
            pictureBox6.Location = new Point(470, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(145, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(27, 73, 69);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(27, 73, 69);
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.x;
            btnClose.Location = new Point(776, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.FromArgb(27, 73, 69);
            btnMin.FlatAppearance.BorderColor = Color.FromArgb(27, 73, 69);
            btnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = Properties.Resources.menos1;
            btnMin.Location = new Point(739, 2);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 11;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LOGIN_2;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(pictureBox6);
            Controls.Add(linkRegister);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            MouseDown += FrmLogin_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnLogin;
        private LinkLabel linkRegister;
        private PictureBox pictureBox6;
        private Button btnClose;
        private Button btnMin;
    }
}