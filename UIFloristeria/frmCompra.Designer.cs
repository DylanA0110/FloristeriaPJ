namespace UIFloristeria
{
    partial class frmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            txtBusquedaCliente = new TextBox();
            btnEditarCompra = new Button();
            pictureBox1 = new PictureBox();
            dgvCompra = new DataGridView();
            btnAggCompra = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(222, 151, 54);
            label2.Location = new Point(545, 115);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 87;
            label2.Text = "Busqueda:";
            // 
            // txtBusquedaCliente
            // 
            txtBusquedaCliente.Anchor = AnchorStyles.Top;
            txtBusquedaCliente.Location = new Point(545, 137);
            txtBusquedaCliente.Name = "txtBusquedaCliente";
            txtBusquedaCliente.Size = new Size(161, 23);
            txtBusquedaCliente.TabIndex = 86;
            txtBusquedaCliente.TextChanged += txtBusquedaCliente_TextChanged;
            // 
            // btnEditarCompra
            // 
            btnEditarCompra.Anchor = AnchorStyles.Bottom;
            btnEditarCompra.BackColor = Color.White;
            btnEditarCompra.FlatStyle = FlatStyle.Popup;
            btnEditarCompra.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCompra.Image = (Image)resources.GetObject("btnEditarCompra.Image");
            btnEditarCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarCompra.Location = new Point(86, 461);
            btnEditarCompra.Name = "btnEditarCompra";
            btnEditarCompra.Size = new Size(220, 36);
            btnEditarCompra.TabIndex = 85;
            btnEditarCompra.Text = "Editar Compra";
            btnEditarCompra.UseVisualStyleBackColor = false;
            btnEditarCompra.Click += btnEditarCompra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // dgvCompra
            // 
            dgvCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCompra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompra.BackgroundColor = Color.White;
            dgvCompra.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCompra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCompra.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCompra.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCompra.EnableHeadersVisualStyles = false;
            dgvCompra.Location = new Point(232, 196);
            dgvCompra.MultiSelect = false;
            dgvCompra.Name = "dgvCompra";
            dgvCompra.ReadOnly = true;
            dgvCompra.RowHeadersVisible = false;
            dgvCompra.RowTemplate.Height = 40;
            dgvCompra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompra.Size = new Size(485, 193);
            dgvCompra.TabIndex = 83;
            // 
            // btnAggCompra
            // 
            btnAggCompra.Anchor = AnchorStyles.Bottom;
            btnAggCompra.BackColor = Color.White;
            btnAggCompra.FlatStyle = FlatStyle.Popup;
            btnAggCompra.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggCompra.Image = (Image)resources.GetObject("btnAggCompra.Image");
            btnAggCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnAggCompra.Location = new Point(366, 461);
            btnAggCompra.Name = "btnAggCompra";
            btnAggCompra.Size = new Size(220, 36);
            btnAggCompra.TabIndex = 82;
            btnAggCompra.Text = "Agregar Compra";
            btnAggCompra.UseVisualStyleBackColor = false;
            btnAggCompra.Click += btnAggCompra_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(222, 151, 54);
            label1.Location = new Point(436, 22);
            label1.Name = "label1";
            label1.Size = new Size(144, 36);
            label1.TabIndex = 81;
            label1.Text = "Compras";
            // 
            // frmCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(900, 532);
            Controls.Add(label2);
            Controls.Add(txtBusquedaCliente);
            Controls.Add(btnEditarCompra);
            Controls.Add(pictureBox1);
            Controls.Add(dgvCompra);
            Controls.Add(btnAggCompra);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCompra";
            Text = "frmCompras";
            Load += frmCompra_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtBusquedaCliente;
        private Button btnEditarCompra;
        private PictureBox pictureBox1;
        private DataGridView dgvCompra;
        private Button btnAggCompra;
        private Label label1;
    }
}