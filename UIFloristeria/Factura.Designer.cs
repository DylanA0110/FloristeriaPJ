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
            label2 = new Label();
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(420, 98);
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
            TxtMontoTotal.Location = new Point(420, 135);
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
            label7.Location = new Point(229, 98);
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
            TxtNumeroFactura.Location = new Point(229, 135);
            TxtNumeroFactura.Name = "TxtNumeroFactura";
            TxtNumeroFactura.Size = new Size(140, 20);
            TxtNumeroFactura.TabIndex = 10;
            TxtNumeroFactura.Text = "_________________________________________________________________________";
            // 
            // CboTipoDePago
            // 
            CboTipoDePago.FormattingEnabled = true;
            CboTipoDePago.Items.AddRange(new object[] { "Credito", "Transferencia", "Tarjeta de Credito", "Efectivo" });
            CboTipoDePago.Location = new Point(40, 132);
            CboTipoDePago.Name = "CboTipoDePago";
            CboTipoDePago.Size = new Size(121, 23);
            CboTipoDePago.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(37, 89);
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
            BtnPreliminar.Location = new Point(585, 124);
            BtnPreliminar.Name = "BtnPreliminar";
            BtnPreliminar.Size = new Size(108, 31);
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
            BtnImprimir.Location = new Point(699, 124);
            BtnImprimir.Name = "BtnImprimir";
            BtnImprimir.Size = new Size(117, 31);
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
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Factura";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)DtgFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
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