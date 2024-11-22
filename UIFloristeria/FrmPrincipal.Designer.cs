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
            button2 = new Button();
            button4 = new Button();
            button8 = new Button();
            button5 = new Button();
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
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button8);
            sidebar.Controls.Add(button5);
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
            menuContainer.BackColor = Color.FromArgb(28, 76, 56);
            menuContainer.Controls.Add(btnProveedor);
            menuContainer.Controls.Add(btnMenu);
            menuContainer.Controls.Add(btnEmpleado);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(213, 37);
            menuContainer.TabIndex = 2;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = Color.FromArgb(50, 84, 68);
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
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(216, 40);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.FromArgb(50, 84, 68);
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
            // button2
            // 
            button2.BackColor = Color.FromArgb(28, 75, 68);
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 46);
            button2.Name = "button2";
            button2.Size = new Size(201, 37);
            button2.TabIndex = 4;
            button2.Text = "Factura";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(28, 75, 68);
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 89);
            button4.Name = "button4";
            button4.Size = new Size(201, 37);
            button4.TabIndex = 5;
            button4.Text = "Arreglos";
            button4.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(28, 75, 68);
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 129);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(201, 37);
            button8.TabIndex = 9;
            button8.Text = "Clientes";
            button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(28, 75, 68);
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 169);
            button5.Name = "button5";
            button5.Size = new Size(198, 37);
            button5.TabIndex = 6;
            button5.Text = "Pedido";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 222);
            panel2.TabIndex = 5;
            // 
            // btnCerrarSession
            // 
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
        private Button button4;
        private Button button2;
        private Button button5;
        private Button button8;
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