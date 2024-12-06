namespace UIFloristeria
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            dgvClientes = new DataGridView();
            btnAggCliente = new Button();
            label1 = new Label();
            btnEditarCliente = new Button();
            label2 = new Label();
            txtBusquedaCliente = new TextBox();
            btnSeleccionar = new Button();
            btnMin = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(28, 75, 68);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(354, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 75;
            pictureBox1.TabStop = false;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(227, 210);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowTemplate.Height = 40;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(485, 193);
            dgvClientes.TabIndex = 74;
            // 
            // btnAggCliente
            // 
            btnAggCliente.Anchor = AnchorStyles.Bottom;
            btnAggCliente.BackColor = Color.White;
            btnAggCliente.FlatStyle = FlatStyle.Popup;
            btnAggCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggCliente.Image = (Image)resources.GetObject("btnAggCliente.Image");
            btnAggCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnAggCliente.Location = new Point(361, 475);
            btnAggCliente.Name = "btnAggCliente";
            btnAggCliente.Size = new Size(220, 36);
            btnAggCliente.TabIndex = 73;
            btnAggCliente.Text = "Agregar Cliente";
            btnAggCliente.UseVisualStyleBackColor = false;
            btnAggCliente.Click += btnAggCliente_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(222, 151, 54);
            label1.Location = new Point(431, 36);
            label1.Name = "label1";
            label1.Size = new Size(129, 36);
            label1.TabIndex = 72;
            label1.Text = "Clientes";
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Anchor = AnchorStyles.Bottom;
            btnEditarCliente.BackColor = Color.White;
            btnEditarCliente.FlatStyle = FlatStyle.Popup;
            btnEditarCliente.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarCliente.Image = (Image)resources.GetObject("btnEditarCliente.Image");
            btnEditarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarCliente.Location = new Point(81, 475);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(220, 36);
            btnEditarCliente.TabIndex = 76;
            btnEditarCliente.Text = "Editar Cliente";
            btnEditarCliente.UseVisualStyleBackColor = false;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(222, 151, 54);
            label2.Location = new Point(540, 129);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 80;
            label2.Text = "Busqueda:";
            // 
            // txtBusquedaCliente
            // 
            txtBusquedaCliente.Anchor = AnchorStyles.Top;
            txtBusquedaCliente.Location = new Point(540, 151);
            txtBusquedaCliente.Name = "txtBusquedaCliente";
            txtBusquedaCliente.Size = new Size(161, 23);
            txtBusquedaCliente.TabIndex = 79;
            txtBusquedaCliente.TextChanged += txtBusquedaCliente_TextChanged;
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
            btnSeleccionar.Location = new Point(617, 475);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(173, 36);
            btnSeleccionar.TabIndex = 84;
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
            btnMin.Location = new Point(830, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 161;
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
            btnClose.Location = new Point(857, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 160;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 75, 68);
            ClientSize = new Size(900, 532);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(btnSeleccionar);
            Controls.Add(label2);
            Controls.Add(txtBusquedaCliente);
            Controls.Add(btnEditarCliente);
            Controls.Add(pictureBox1);
            Controls.Add(dgvClientes);
            Controls.Add(btnAggCliente);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCliente";
            Text = "frmCliente";
            Load += frmCliente_Load;
            MouseDown += frmCliente_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private DataGridView dgvClientes;
        private Button btnAggCliente;
        private Label label1;
        private Button btnEditarCliente;
        private Label label2;
        private TextBox txtBusquedaCliente;
        private Button btnSeleccionar;
        private Button btnMin;
        private Button btnClose;
    }
}