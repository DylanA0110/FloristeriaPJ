﻿namespace UIFloristeria
{
    partial class frmArreglo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArreglo));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnAggArreglo = new Button();
            label1 = new Label();
            BtnAccesorio = new Button();
            TxtCantidad = new TextBox();
            pictureBox5 = new PictureBox();
            TxtNombreArreglo = new TextBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            cmbAccesorio = new ComboBox();
            BtnAgregarFlor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(296, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(54, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(590, 180);
            dataGridView1.TabIndex = 69;
            // 
            // btnAggArreglo
            // 
            btnAggArreglo.Anchor = AnchorStyles.Bottom;
            btnAggArreglo.BackColor = Color.White;
            btnAggArreglo.FlatStyle = FlatStyle.Popup;
            btnAggArreglo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggArreglo.Image = (Image)resources.GetObject("btnAggArreglo.Image");
            btnAggArreglo.ImageAlign = ContentAlignment.MiddleLeft;
            btnAggArreglo.Location = new Point(613, 149);
            btnAggArreglo.Name = "btnAggArreglo";
            btnAggArreglo.Size = new Size(220, 36);
            btnAggArreglo.TabIndex = 68;
            btnAggArreglo.Text = "Agregar Arreglo";
            btnAggArreglo.UseVisualStyleBackColor = false;
            btnAggArreglo.Click += btnAggArreglo_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(222, 151, 54);
            label1.Location = new Point(379, 19);
            label1.Name = "label1";
            label1.Size = new Size(131, 36);
            label1.TabIndex = 67;
            label1.Text = "Arreglos";
            // 
            // BtnAccesorio
            // 
            BtnAccesorio.Anchor = AnchorStyles.Bottom;
            BtnAccesorio.BackColor = Color.White;
            BtnAccesorio.FlatStyle = FlatStyle.Popup;
            BtnAccesorio.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAccesorio.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAccesorio.Location = new Point(54, 454);
            BtnAccesorio.Name = "BtnAccesorio";
            BtnAccesorio.Size = new Size(196, 36);
            BtnAccesorio.TabIndex = 71;
            BtnAccesorio.Text = "Agregar Accesorios";
            BtnAccesorio.UseVisualStyleBackColor = false;
            BtnAccesorio.Click += BtnAccesorio_Click;
            // 
            // TxtCantidad
            // 
            TxtCantidad.Anchor = AnchorStyles.Top;
            TxtCantidad.BackColor = Color.FromArgb(22, 58, 55);
            TxtCantidad.BorderStyle = BorderStyle.None;
            TxtCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtCantidad.ForeColor = Color.White;
            TxtCantidad.Location = new Point(256, 133);
            TxtCantidad.Name = "TxtCantidad";
            TxtCantidad.Size = new Size(186, 20);
            TxtCantidad.TabIndex = 117;
            TxtCantidad.Text = "Cantidad";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top;
            pictureBox5.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox5.Image = Properties.Resources.Loading;
            pictureBox5.Location = new Point(256, 159);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(186, 22);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 116;
            pictureBox5.TabStop = false;
            // 
            // TxtNombreArreglo
            // 
            TxtNombreArreglo.Anchor = AnchorStyles.Top;
            TxtNombreArreglo.BackColor = Color.FromArgb(22, 58, 55);
            TxtNombreArreglo.BorderStyle = BorderStyle.None;
            TxtNombreArreglo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNombreArreglo.ForeColor = Color.White;
            TxtNombreArreglo.Location = new Point(54, 133);
            TxtNombreArreglo.Name = "TxtNombreArreglo";
            TxtNombreArreglo.Size = new Size(186, 20);
            TxtNombreArreglo.TabIndex = 115;
            TxtNombreArreglo.Text = "Descripcion del Arreglo";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox4.Image = Properties.Resources.Loading;
            pictureBox4.Location = new Point(54, 159);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(186, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 114;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(22, 58, 55);
            label6.Font = new Font("Century Gothic", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(457, 135);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 130;
            label6.Text = "Accesorios:";
            // 
            // cmbAccesorio
            // 
            cmbAccesorio.FormattingEnabled = true;
            cmbAccesorio.Location = new Point(457, 159);
            cmbAccesorio.Name = "cmbAccesorio";
            cmbAccesorio.Size = new Size(121, 23);
            cmbAccesorio.TabIndex = 129;
            // 
            // BtnAgregarFlor
            // 
            BtnAgregarFlor.Anchor = AnchorStyles.Bottom;
            BtnAgregarFlor.BackColor = Color.White;
            BtnAgregarFlor.FlatStyle = FlatStyle.Popup;
            BtnAgregarFlor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregarFlor.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarFlor.Location = new Point(278, 454);
            BtnAgregarFlor.Name = "BtnAgregarFlor";
            BtnAgregarFlor.Size = new Size(196, 36);
            BtnAgregarFlor.TabIndex = 131;
            BtnAgregarFlor.Text = "Agregar Flores";
            BtnAgregarFlor.UseVisualStyleBackColor = false;
            // 
            // frmArreglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(900, 532);
            Controls.Add(BtnAgregarFlor);
            Controls.Add(label6);
            Controls.Add(cmbAccesorio);
            Controls.Add(TxtCantidad);
            Controls.Add(pictureBox5);
            Controls.Add(TxtNombreArreglo);
            Controls.Add(pictureBox4);
            Controls.Add(BtnAccesorio);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAggArreglo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmArreglo";
            Text = "frmArreglos";
            Load += frmArreglos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button btnAggArreglo;
        private Label label1;
        private Button BtnAccesorio;
        private TextBox TxtCantidad;
        private PictureBox pictureBox5;
        private TextBox TxtNombreArreglo;
        private PictureBox pictureBox4;
        private Label label6;
        private ComboBox cmbAccesorio;
        private Button BtnAgregarFlor;
    }
}