namespace UIFloristeria
{
    partial class AgregarAccesorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAccesorio));
            pictureBox1 = new PictureBox();
            TxtNombreAccesorio = new TextBox();
            BtnAgregarAcc = new Button();
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
            pictureBox1.Location = new Point(98, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 108;
            pictureBox1.TabStop = false;
            // 
            // TxtNombreAccesorio
            // 
            TxtNombreAccesorio.BackColor = Color.FromArgb(222, 151, 54);
            TxtNombreAccesorio.BorderStyle = BorderStyle.None;
            TxtNombreAccesorio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNombreAccesorio.ForeColor = Color.White;
            TxtNombreAccesorio.Location = new Point(98, 155);
            TxtNombreAccesorio.Name = "TxtNombreAccesorio";
            TxtNombreAccesorio.Size = new Size(186, 20);
            TxtNombreAccesorio.TabIndex = 107;
            TxtNombreAccesorio.Text = "Nombre Acceosrio";
            // 
            // BtnAgregarAcc
            // 
            BtnAgregarAcc.BackColor = Color.White;
            BtnAgregarAcc.FlatStyle = FlatStyle.Popup;
            BtnAgregarAcc.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarAcc.ForeColor = SystemColors.ControlText;
            BtnAgregarAcc.Location = new Point(353, 176);
            BtnAgregarAcc.Name = "BtnAgregarAcc";
            BtnAgregarAcc.Size = new Size(142, 27);
            BtnAgregarAcc.TabIndex = 106;
            BtnAgregarAcc.Text = "Agregar";
            BtnAgregarAcc.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(98, 181);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 105;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 40);
            label1.Name = "label1";
            label1.Size = new Size(283, 36);
            label1.TabIndex = 104;
            label1.Text = "Agregar Accesorio";
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
            btnMin.Location = new Point(531, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 103;
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
            btnClose.Location = new Point(558, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 102;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // AgregarAccesorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(591, 254);
            Controls.Add(pictureBox1);
            Controls.Add(TxtNombreAccesorio);
            Controls.Add(BtnAgregarAcc);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.NoControl;
            Name = "AgregarAccesorio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarAccesorio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TxtNombreAccesorio;
        private Button BtnAgregarAcc;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnMin;
        private Button btnClose;
    }
}