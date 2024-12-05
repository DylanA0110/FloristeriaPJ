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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            btnAbrirfrmAgg = new Button();
            label1 = new Label();
            dgvProveedores = new DataGridView();
            pictureBox1 = new PictureBox();
            btnEditarProveedor = new Button();
            label2 = new Label();
            txtBusquedaCliente = new TextBox();
            btnSeleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAbrirfrmAgg
            // 
            btnAbrirfrmAgg.Anchor = AnchorStyles.Bottom;
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
            label1.Anchor = AnchorStyles.Top;
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
            // dgvProveedores
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvProveedores.ColumnHeadersHeight = 45;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle6;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.Location = new Point(238, 179);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowTemplate.Height = 40;
            dgvProveedores.Size = new Size(485, 193);
            dgvProveedores.TabIndex = 63;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(22, 58, 55);
            pictureBox1.Image = Properties.Resources.Buying;
            pictureBox1.Location = new Point(300, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.Anchor = AnchorStyles.Bottom;
            btnEditarProveedor.BackColor = Color.White;
            btnEditarProveedor.FlatAppearance.BorderSize = 0;
            btnEditarProveedor.FlatStyle = FlatStyle.Popup;
            btnEditarProveedor.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarProveedor.Image = Properties.Resources.Add_Shopping_Cart;
            btnEditarProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarProveedor.Location = new Point(96, 440);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(220, 36);
            btnEditarProveedor.TabIndex = 65;
            btnEditarProveedor.Text = "Editar Proveedor";
            btnEditarProveedor.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(222, 151, 54);
            label2.Location = new Point(559, 116);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 82;
            label2.Text = "Busqueda:";
            // 
            // txtBusquedaCliente
            // 
            txtBusquedaCliente.Anchor = AnchorStyles.Top;
            txtBusquedaCliente.Location = new Point(559, 138);
            txtBusquedaCliente.Name = "txtBusquedaCliente";
            txtBusquedaCliente.Size = new Size(161, 23);
            txtBusquedaCliente.TabIndex = 81;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = AnchorStyles.Bottom;
            btnSeleccionar.BackColor = Color.White;
            btnSeleccionar.FlatAppearance.BorderSize = 0;
            btnSeleccionar.FlatStyle = FlatStyle.Popup;
            btnSeleccionar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionar.Image = (Image)resources.GetObject("btnSeleccionar.Image");
            btnSeleccionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeleccionar.Location = new Point(706, 440);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(173, 36);
            btnSeleccionar.TabIndex = 83;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(900, 532);
            Controls.Add(btnSeleccionar);
            Controls.Add(label2);
            Controls.Add(txtBusquedaCliente);
            Controls.Add(btnEditarProveedor);
            Controls.Add(pictureBox1);
            Controls.Add(dgvProveedores);
            Controls.Add(btnAbrirfrmAgg);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProveedor";
            Load += frmProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAbrirfrmAgg;
        private Label label1;
        private DataGridView dgvProveedores;
        private PictureBox pictureBox1;
        private Button btnEditarProveedor;
        private Label label2;
        private TextBox txtBusquedaCliente;
        private Button btnSeleccionar;
    }
}