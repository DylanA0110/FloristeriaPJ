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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            btnAbrirfrmAgg = new Button();
            label1 = new Label();
            dgvProveedores = new DataGridView();
            pictureBox1 = new PictureBox();
            btnEditarProveedor = new Button();
            label2 = new Label();
            txtBusqueda = new TextBox();
            btnSeleccionar = new Button();
            btnMin = new Button();
            btnClose = new Button();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProveedores.BackgroundColor = Color.White;
            dgvProveedores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProveedores.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.Location = new Point(238, 179);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersVisible = false;
            dgvProveedores.RowTemplate.Height = 40;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            btnEditarProveedor.Click += btnEditarProveedor_Click;
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
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top;
            txtBusqueda.Location = new Point(559, 138);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(161, 23);
            txtBusqueda.TabIndex = 81;
            txtBusqueda.TextChanged += txtBusquedaProveedor_TextChanged;
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
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.FlatAppearance.BorderColor = Color.FromArgb(27, 73, 69);
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnMin.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = Properties.Resources.menos1;
            btnMin.Location = new Point(833, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 117;
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
            btnClose.Location = new Point(860, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 116;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(900, 532);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(btnSeleccionar);
            Controls.Add(label2);
            Controls.Add(txtBusqueda);
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
            MouseDown += frmProveedor_MouseDown;
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
        private TextBox txtBusqueda;
        private Button btnSeleccionar;
        private Button btnMin;
        private Button btnClose;
    }
}