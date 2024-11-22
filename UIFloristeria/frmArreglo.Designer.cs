namespace UIFloristeria
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnAggArreglo = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Ellipse_1;
            pictureBox3.Location = new Point(717, 375);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(192, 162);
            pictureBox3.TabIndex = 71;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(28, 75, 68);
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(177, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(498, 204);
            dataGridView1.TabIndex = 69;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre del Proveedor";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "Número de télefono";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // btnAggArreglo
            // 
            btnAggArreglo.BackColor = Color.White;
            btnAggArreglo.FlatStyle = FlatStyle.Popup;
            btnAggArreglo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggArreglo.Image = (Image)resources.GetObject("btnAggArreglo.Image");
            btnAggArreglo.ImageAlign = ContentAlignment.MiddleLeft;
            btnAggArreglo.Location = new Point(343, 425);
            btnAggArreglo.Name = "btnAggArreglo";
            btnAggArreglo.Size = new Size(220, 36);
            btnAggArreglo.TabIndex = 68;
            btnAggArreglo.Text = "Agregar Arreglo";
            btnAggArreglo.UseVisualStyleBackColor = false;
            btnAggArreglo.Click += btnAggArreglo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(222, 151, 54);
            label1.Location = new Point(373, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 36);
            label1.TabIndex = 67;
            label1.Text = "Arreglos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-60, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(260, 188);
            pictureBox2.TabIndex = 72;
            pictureBox2.TabStop = false;
            // 
            // frmArreglo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 75, 68);
            ClientSize = new Size(900, 532);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAggArreglo);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmArreglo";
            Text = "frmArreglos";
            Load += frmArreglos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnAggArreglo;
        private Label label1;
        private PictureBox pictureBox2;
    }
}