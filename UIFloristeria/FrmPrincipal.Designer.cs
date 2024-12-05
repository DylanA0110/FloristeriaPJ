namespace UIFloristeria
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            btHamn = new PictureBox();
            sidebar = new FlowLayoutPanel();
            menuContainer = new Panel();
            btnProveedor = new Button();
            btnMenu = new Button();
            btnEmpleado = new Button();
            btnFactura = new Button();
            btnArreglos = new Button();
            btnClientes = new Button();
            btnPedidos = new Button();
            panel2 = new Panel();
            btnCerrarSession = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btHamn).BeginInit();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(btHamn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 34);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FloristeriaSacuanjocheLogo_removebg_preview;
            pictureBox1.Location = new Point(28, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(914, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // btHamn
            // 
            btHamn.Image = (Image)resources.GetObject("btHamn.Image");
            btHamn.Location = new Point(3, 10);
            btHamn.Name = "btHamn";
            btHamn.Size = new Size(19, 18);
            btHamn.SizeMode = PictureBoxSizeMode.StretchImage;
            btHamn.TabIndex = 1;
            btHamn.TabStop = false;
            btHamn.Click += btHamn_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(28, 75, 68);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(btnFactura);
            sidebar.Controls.Add(btnArreglos);
            sidebar.Controls.Add(btnClientes);
            sidebar.Controls.Add(btnPedidos);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnCerrarSession);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 34);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(201, 498);
            sidebar.TabIndex = 1;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(22, 58, 55);
            menuContainer.Controls.Add(btnProveedor);
            menuContainer.Controls.Add(btnMenu);
            menuContainer.Controls.Add(btnEmpleado);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(213, 37);
            menuContainer.TabIndex = 2;
//            menuContainer.Paint += this.menuContainer_Paint;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.FromArgb(22, 58, 55);
            btnProveedor.FlatAppearance.BorderColor = Color.Black;
            btnProveedor.FlatAppearance.BorderSize = 0;
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProveedor.ForeColor = Color.White;
            btnProveedor.Image = (Image)resources.GetObject("btnProveedor.Image");
            btnProveedor.ImageAlign = ContentAlignment.MiddleLeft;
            btnProveedor.Location = new Point(0, 71);
            btnProveedor.Margin = new Padding(0);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(216, 37);
            btnProveedor.TabIndex = 8;
            btnProveedor.Text = "Proveedor";
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(28, 75, 68);
            btnMenu.FlatAppearance.BorderColor = Color.Black;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(-3, -4);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(216, 41);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.FromArgb(22, 58, 55);
            btnEmpleado.FlatAppearance.BorderColor = Color.Black;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleado.ForeColor = Color.White;
            btnEmpleado.Image = Properties.Resources.Employee1;
            btnEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.Location = new Point(0, 34);
            btnEmpleado.Margin = new Padding(0);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(213, 37);
            btnEmpleado.TabIndex = 0;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.FromArgb(28, 75, 68);
            btnFactura.FlatAppearance.BorderColor = Color.Black;
            btnFactura.FlatAppearance.BorderSize = 0;
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnFactura.ForeColor = Color.White;
            btnFactura.Image = (Image)resources.GetObject("btnFactura.Image");
            btnFactura.ImageAlign = ContentAlignment.MiddleLeft;
            btnFactura.Location = new Point(3, 46);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(201, 37);
            btnFactura.TabIndex = 4;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnArreglos
            // 
            btnArreglos.BackColor = Color.FromArgb(28, 75, 68);
            btnArreglos.FlatAppearance.BorderColor = Color.Black;
            btnArreglos.FlatAppearance.BorderSize = 0;
            btnArreglos.FlatStyle = FlatStyle.Flat;
            btnArreglos.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnArreglos.ForeColor = Color.White;
            btnArreglos.Image = (Image)resources.GetObject("btnArreglos.Image");
            btnArreglos.ImageAlign = ContentAlignment.MiddleLeft;
            btnArreglos.Location = new Point(3, 89);
            btnArreglos.Name = "btnArreglos";
            btnArreglos.Size = new Size(201, 37);
            btnArreglos.TabIndex = 5;
            btnArreglos.Text = "Arreglos";
            btnArreglos.UseVisualStyleBackColor = false;
            btnArreglos.Click += btnArreglos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(28, 75, 68);
            btnClientes.FlatAppearance.BorderColor = Color.Black;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 129);
            btnClientes.Margin = new Padding(0);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(201, 37);
            btnClientes.TabIndex = 9;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(28, 75, 68);
            btnPedidos.FlatAppearance.BorderColor = Color.Black;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnPedidos.ForeColor = Color.White;
            btnPedidos.Image = (Image)resources.GetObject("btnPedidos.Image");
            btnPedidos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPedidos.Location = new Point(3, 169);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(198, 37);
            btnPedidos.TabIndex = 6;
            btnPedidos.Text = "Pedido";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Location = new Point(3, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 222);
            panel2.TabIndex = 5;
            // 
            // btnCerrarSession
            // 
            btnCerrarSession.Anchor = AnchorStyles.None;
            btnCerrarSession.BackColor = Color.FromArgb(28, 75, 68);
            btnCerrarSession.FlatAppearance.BorderColor = Color.Black;
            btnCerrarSession.FlatAppearance.BorderSize = 0;
            btnCerrarSession.FlatStyle = FlatStyle.Flat;
            btnCerrarSession.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnCerrarSession.ForeColor = Color.White;
            btnCerrarSession.Image = (Image)resources.GetObject("btnCerrarSession.Image");
            btnCerrarSession.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSession.Location = new Point(0, 437);
            btnCerrarSession.Margin = new Padding(0);
            btnCerrarSession.Name = "btnCerrarSession";
            btnCerrarSession.Size = new Size(199, 53);
            btnCerrarSession.TabIndex = 4;
            btnCerrarSession.Text = "Cerrar Session";
            btnCerrarSession.UseVisualStyleBackColor = false;
            btnCerrarSession.Click += btnCerrarSession_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(201, 34);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(852, 498);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1053, 532);
            Controls.Add(panelContenedor);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            MouseDown += FrmPrincipal_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btHamn).EndInit();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btHamn;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel sidebar;
        private Panel menuContainer;
        private Button btnEmpleado;
        private Button button3;
        private Button btnArreglos;
        private Button btnFactura;
        private Button btnPedidos;
        private Button btnClientes;
        private Button btnProveedor;
        private Button btnMenu;
        private Button btnCerrarSession;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panelContenedor;
    }
}