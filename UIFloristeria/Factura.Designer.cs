namespace UIFloristeria
{
    partial class Factura
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
            TxtPrimerNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtSegundoNombre = new TextBox();
            label4 = new Label();
            TxtSegundoApellido = new TextBox();
            label5 = new Label();
            TxtPrimerApellido = new TextBox();
            label6 = new Label();
            TxtMontoTotal = new TextBox();
            label7 = new Label();
            TxtNumeroFactura = new TextBox();
            CboTipoDePago = new ComboBox();
            label8 = new Label();
            BtnPreliminar = new Button();
            DtgFacturas = new DataGridView();
            BtnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)DtgFacturas).BeginInit();
            SuspendLayout();
            // 
            // TxtPrimerNombre
            // 
            TxtPrimerNombre.BackColor = Color.FromArgb(22, 58, 55);
            TxtPrimerNombre.BorderStyle = BorderStyle.None;
            TxtPrimerNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtPrimerNombre.Location = new Point(76, 121);
            TxtPrimerNombre.Name = "TxtPrimerNombre";
            TxtPrimerNombre.Size = new Size(140, 20);
            TxtPrimerNombre.TabIndex = 0;
            TxtPrimerNombre.Text = "_________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 84);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 1;
            label1.Text = "Primer nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(365, 25);
            label2.Name = "label2";
            label2.Size = new Size(113, 32);
            label2.TabIndex = 2;
            label2.Text = "Factura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(267, 84);
            label3.Name = "label3";
            label3.Size = new Size(145, 19);
            label3.TabIndex = 5;
            label3.Text = "Segundo nombre";
            // 
            // TxtSegundoNombre
            // 
            TxtSegundoNombre.BackColor = Color.FromArgb(22, 58, 55);
            TxtSegundoNombre.BorderStyle = BorderStyle.None;
            TxtSegundoNombre.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtSegundoNombre.Location = new Point(267, 121);
            TxtSegundoNombre.Name = "TxtSegundoNombre";
            TxtSegundoNombre.Size = new Size(140, 20);
            TxtSegundoNombre.TabIndex = 4;
            TxtSegundoNombre.Text = "_________________________________________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(647, 84);
            label4.Name = "label4";
            label4.Size = new Size(149, 19);
            label4.TabIndex = 9;
            label4.Text = "Segundo Apellido";
            // 
            // TxtSegundoApellido
            // 
            TxtSegundoApellido.BackColor = Color.FromArgb(22, 58, 55);
            TxtSegundoApellido.BorderStyle = BorderStyle.None;
            TxtSegundoApellido.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtSegundoApellido.Location = new Point(647, 121);
            TxtSegundoApellido.Name = "TxtSegundoApellido";
            TxtSegundoApellido.Size = new Size(140, 20);
            TxtSegundoApellido.TabIndex = 8;
            TxtSegundoApellido.Text = "_________________________________________________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(456, 84);
            label5.Name = "label5";
            label5.Size = new Size(128, 19);
            label5.TabIndex = 7;
            label5.Text = "Primer Apellido";
            // 
            // TxtPrimerApellido
            // 
            TxtPrimerApellido.BackColor = Color.FromArgb(22, 58, 55);
            TxtPrimerApellido.BorderStyle = BorderStyle.None;
            TxtPrimerApellido.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtPrimerApellido.Location = new Point(456, 121);
            TxtPrimerApellido.Name = "TxtPrimerApellido";
            TxtPrimerApellido.Size = new Size(140, 20);
            TxtPrimerApellido.TabIndex = 6;
            TxtPrimerApellido.Text = "_________________________________________________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(456, 188);
            label6.Name = "label6";
            label6.Size = new Size(97, 19);
            label6.TabIndex = 13;
            label6.Text = "Monto Total";
            // 
            // TxtMontoTotal
            // 
            TxtMontoTotal.BackColor = Color.FromArgb(22, 58, 55);
            TxtMontoTotal.BorderStyle = BorderStyle.None;
            TxtMontoTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtMontoTotal.Location = new Point(456, 225);
            TxtMontoTotal.Name = "TxtMontoTotal";
            TxtMontoTotal.Size = new Size(140, 20);
            TxtMontoTotal.TabIndex = 12;
            TxtMontoTotal.Text = "_________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(265, 188);
            label7.Name = "label7";
            label7.Size = new Size(160, 19);
            label7.TabIndex = 11;
            label7.Text = "Numero de Factura";
            // 
            // TxtNumeroFactura
            // 
            TxtNumeroFactura.BackColor = Color.FromArgb(22, 58, 55);
            TxtNumeroFactura.BorderStyle = BorderStyle.None;
            TxtNumeroFactura.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            TxtNumeroFactura.Location = new Point(265, 225);
            TxtNumeroFactura.Name = "TxtNumeroFactura";
            TxtNumeroFactura.Size = new Size(140, 20);
            TxtNumeroFactura.TabIndex = 10;
            TxtNumeroFactura.Text = "_________________________________________________________________________";
            // 
            // CboTipoDePago
            // 
            CboTipoDePago.FormattingEnabled = true;
            CboTipoDePago.Items.AddRange(new object[] { "Credito", "Transferencia", "Tarjeta de Credito", "Efectivo" });
            CboTipoDePago.Location = new Point(76, 222);
            CboTipoDePago.Name = "CboTipoDePago";
            CboTipoDePago.Size = new Size(121, 23);
            CboTipoDePago.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(73, 179);
            label8.Name = "label8";
            label8.Size = new Size(111, 19);
            label8.TabIndex = 15;
            label8.Text = "Tipo de Pago";
            // 
            // BtnPreliminar
            // 
            BtnPreliminar.BackColor = Color.White;
            BtnPreliminar.BackgroundImageLayout = ImageLayout.Center;
            BtnPreliminar.FlatAppearance.BorderSize = 0;
            BtnPreliminar.FlatStyle = FlatStyle.Flat;
            BtnPreliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnPreliminar.ForeColor = Color.Black;
            BtnPreliminar.Location = new Point(647, 188);
            BtnPreliminar.Name = "BtnPreliminar";
            BtnPreliminar.Size = new Size(132, 31);
            BtnPreliminar.TabIndex = 17;
            BtnPreliminar.Text = "Preliminar";
            BtnPreliminar.TextAlign = ContentAlignment.BottomCenter;
            BtnPreliminar.UseVisualStyleBackColor = false;
            // 
            // DtgFacturas
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(222, 151, 54);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DtgFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DtgFacturas.BackgroundColor = Color.White;
            DtgFacturas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DtgFacturas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 75, 68);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DtgFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DtgFacturas.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(152, 100, 20);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 8.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(152, 100, 20);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DtgFacturas.DefaultCellStyle = dataGridViewCellStyle3;
            DtgFacturas.EnableHeadersVisualStyles = false;
            DtgFacturas.Location = new Point(76, 289);
            DtgFacturas.Name = "DtgFacturas";
            DtgFacturas.RowHeadersVisible = false;
            DtgFacturas.RowTemplate.Height = 40;
            DtgFacturas.Size = new Size(720, 193);
            DtgFacturas.TabIndex = 101;
            // 
            // BtnImprimir
            // 
            BtnImprimir.BackColor = Color.White;
            BtnImprimir.BackgroundImageLayout = ImageLayout.Center;
            BtnImprimir.FlatAppearance.BorderSize = 0;
            BtnImprimir.FlatStyle = FlatStyle.Flat;
            BtnImprimir.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            BtnImprimir.ForeColor = Color.Black;
            BtnImprimir.Location = new Point(647, 241);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(132, 31);
            BtnImprimir.TabIndex = 102;
            BtnImprimir.Text = "Imprimir";
            BtnImprimir.TextAlign = ContentAlignment.BottomCenter;
            BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // Factura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 58, 55);
            ClientSize = new Size(877, 507);
            Controls.Add(BtnImprimir);
            Controls.Add(DtgFacturas);
            Controls.Add(BtnPreliminar);
            Controls.Add(label8);
            Controls.Add(CboTipoDePago);
            Controls.Add(label6);
            Controls.Add(TxtMontoTotal);
            Controls.Add(label7);
            Controls.Add(TxtNumeroFactura);
            Controls.Add(label4);
            Controls.Add(TxtSegundoApellido);
            Controls.Add(label5);
            Controls.Add(TxtPrimerApellido);
            Controls.Add(label3);
            Controls.Add(TxtSegundoNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPrimerNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Factura";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            Load += Factura_Load_1;
            ((System.ComponentModel.ISupportInitialize)DtgFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPrimerNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtSegundoNombre;
        private Label label4;
        private TextBox TxtSegundoApellido;
        private Label label5;
        private TextBox TxtPrimerApellido;
        private Label label6;
        private TextBox TxtMontoTotal;
        private Label label7;
        private TextBox TxtNumeroFactura;
        private ComboBox CboTipoDePago;
        private Label label8;
        private Button BtnPreliminar;
        private DataGridView DtgFacturas;
        private Button BtnImprimir;
    }
}