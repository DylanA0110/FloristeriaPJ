namespace UIFloristeria
{
    partial class AgregarFlor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFlor));
            DgvFlor = new DataGridView();
            pictureBox1 = new PictureBox();
            TxtNombreFlor = new TextBox();
            BtnAgregarFlor = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnMin = new Button();
            btnClose = new Button();
            BtnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvFlor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // DgvFlor
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DgvFlor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DgvFlor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgvFlor.BackgroundColor = Color.White;
            DgvFlor.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DgvFlor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DgvFlor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DgvFlor.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DgvFlor.DefaultCellStyle = dataGridViewCellStyle3;
            DgvFlor.EnableHeadersVisualStyles = false;
            DgvFlor.Location = new Point(94, 226);
            DgvFlor.Name = "DgvFlor";
            DgvFlor.RowHeadersVisible = false;
            DgvFlor.RowTemplate.Height = 40;
            DgvFlor.Size = new Size(398, 119);
            DgvFlor.TabIndex = 117;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 116;
            pictureBox1.TabStop = false;
            // 
            // TxtNombreFlor
            // 
            TxtNombreFlor.BackColor = Color.FromArgb(222, 151, 54);
            TxtNombreFlor.BorderStyle = BorderStyle.None;
            TxtNombreFlor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNombreFlor.ForeColor = Color.White;
            TxtNombreFlor.Location = new Point(95, 141);
            TxtNombreFlor.Name = "TxtNombreFlor";
            TxtNombreFlor.Size = new Size(186, 20);
            TxtNombreFlor.TabIndex = 115;
            TxtNombreFlor.Text = "Nombre Flor";
            TxtNombreFlor.Leave += TxtNombreFlor_Leave;
            // 
            // BtnAgregarFlor
            // 
            BtnAgregarFlor.BackColor = Color.White;
            BtnAgregarFlor.FlatStyle = FlatStyle.Popup;
            BtnAgregarFlor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarFlor.ForeColor = SystemColors.ControlText;
            BtnAgregarFlor.Location = new Point(340, 117);
            BtnAgregarFlor.Name = "BtnAgregarFlor";
            BtnAgregarFlor.Size = new Size(142, 27);
            BtnAgregarFlor.TabIndex = 114;
            BtnAgregarFlor.Text = "Agregar";
            BtnAgregarFlor.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox2.Image = Properties.Resources.Loading;
            pictureBox2.Location = new Point(95, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 113;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 37);
            label1.Name = "label1";
            label1.Size = new Size(187, 36);
            label1.TabIndex = 112;
            label1.Text = "Agregar Flor";
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
            btnMin.TabIndex = 111;
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
            btnClose.TabIndex = 110;
            btnClose.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            BtnEditar.BackColor = Color.White;
            BtnEditar.FlatStyle = FlatStyle.Popup;
            BtnEditar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditar.ForeColor = SystemColors.ControlText;
            BtnEditar.Location = new Point(340, 167);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(142, 27);
            BtnEditar.TabIndex = 118;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = false;
            // 
            // AgregarFlor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(591, 357);
            Controls.Add(BtnEditar);
            Controls.Add(DgvFlor);
            Controls.Add(pictureBox1);
            Controls.Add(TxtNombreFlor);
            Controls.Add(BtnAgregarFlor);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarFlor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarFlor";
            Load += AgregarFlor_Load;
            ((System.ComponentModel.ISupportInitialize)DgvFlor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvFlor;
        private PictureBox pictureBox1;
        private TextBox TxtNombreFlor;
        private Button BtnAgregarFlor;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnMin;
        private Button btnClose;
        private Button BtnEditar;
    }
}