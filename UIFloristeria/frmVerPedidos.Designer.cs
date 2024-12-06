namespace UIFloristeria
{
    partial class frmVerPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerPedidos));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btnMin = new Button();
            btnClose = new Button();
            btnSeleccionar = new Button();
            label2 = new Label();
            txtBusqueda = new TextBox();
            pictureBox1 = new PictureBox();
            dgvPedidos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
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
            btnMin.Location = new Point(739, 6);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(21, 22);
            btnMin.TabIndex = 127;
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
            btnClose.Location = new Point(766, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(21, 22);
            btnClose.TabIndex = 126;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            btnSeleccionar.Location = new Point(316, 403);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(173, 36);
            btnSeleccionar.TabIndex = 125;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(22, 58, 55);
            label2.Location = new Point(470, 97);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 124;
            label2.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top;
            txtBusqueda.Location = new Point(470, 119);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(161, 23);
            txtBusqueda.TabIndex = 123;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.FromArgb(222, 151, 54);
            pictureBox1.Image = Properties.Resources.Buying;
            pictureBox1.Location = new Point(279, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 58);
            pictureBox1.TabIndex = 121;
            pictureBox1.TabStop = false;
            // 
            // dgvPedidos
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPedidos.BackgroundColor = Color.White;
            dgvPedidos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvPedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPedidos.ColumnHeadersHeight = 45;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(69, 88, 68);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Red;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.Location = new Point(150, 160);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowTemplate.Height = 40;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(484, 204);
            dgvPedidos.TabIndex = 120;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(22, 58, 55);
            label1.Location = new Point(356, 19);
            label1.Name = "label1";
            label1.Size = new Size(133, 36);
            label1.TabIndex = 118;
            label1.Text = "PEDIDOS";
            // 
            // frmVerPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 151, 54);
            ClientSize = new Size(799, 461);
            Controls.Add(btnMin);
            Controls.Add(btnClose);
            Controls.Add(btnSeleccionar);
            Controls.Add(label2);
            Controls.Add(txtBusqueda);
            Controls.Add(pictureBox1);
            Controls.Add(dgvPedidos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVerPedidos";
            Text = "frmVerPedidos";
            Load += frmVerPedidos_Load;
            MouseDown += frmVerPedidos_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMin;
        private Button btnClose;
        private Button btnSeleccionar;
        private Label label2;
        private TextBox txtBusqueda;
        private PictureBox pictureBox1;
        private DataGridView dgvPedidos;
        private Label label1;
    }
}