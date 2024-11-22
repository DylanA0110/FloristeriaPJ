namespace UIFloristeria
{
    partial class frmProveedor
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnAbrirfrmAgg = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnAbrirfrmAgg
            // 
            btnAbrirfrmAgg.BackColor = Color.White;
            btnAbrirfrmAgg.FlatAppearance.BorderSize = 0;
            btnAbrirfrmAgg.FlatStyle = FlatStyle.Popup;
            btnAbrirfrmAgg.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbrirfrmAgg.Image = Properties.Resources.Add_Shopping_Cart;
            btnAbrirfrmAgg.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirfrmAgg.Location = new Point(347, 440);
            btnAbrirfrmAgg.Name = "btnAbrirfrmAgg";
            btnAbrirfrmAgg.Size = new Size(220, 36);
            btnAbrirfrmAgg.TabIndex = 37;
            btnAbrirfrmAgg.Text = "Agregar Proveedor";
            btnAbrirfrmAgg.UseVisualStyleBackColor = false;
            btnAbrirfrmAgg.Click += btnAgregarProveedor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(222, 151, 54);
            label1.Location = new Point(377, 35);
            label1.Name = "label1";
            label1.Size = new Size(192, 36);
            label1.TabIndex = 36;
            label1.Text = "Proveedores";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridView1.Location = new Point(236, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(485, 193);
            dataGridView1.TabIndex = 63;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(28, 75, 68);
            pictureBox1.Image = Properties.Resources.Buying;
            pictureBox1.Location = new Point(300, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Subtract;
            pictureBox2.Location = new Point(-66, -51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 262);
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Ellipse_1;
            pictureBox3.Location = new Point(716, 376);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(192, 162);
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            // 
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 75, 68);
            ClientSize = new Size(900, 532);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAbrirfrmAgg);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProveedor";
            Load += frmProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAbrirfrmAgg;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}