namespace QuảnLíTiệmNet
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnComputer.ForeColor = System.Drawing.Color.White;
            this.btnComputer.Image = ((System.Drawing.Image)(resources.GetObject("btnComputer.Image")));
            this.btnComputer.Location = new System.Drawing.Point(-143, -15);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(344, 98);
            this.btnComputer.TabIndex = 2;
            this.btnComputer.Text = "                                                   Quản Lý Máy Tính";
            this.btnComputer.UseVisualStyleBackColor = false;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.Location = new System.Drawing.Point(-146, -25);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(344, 98);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "                                                 Quản Lí Khách Hàng";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(-146, -23);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(344, 98);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "                                                Menu món ăn";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.Location = new System.Drawing.Point(-146, -22);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(344, 98);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "                                      Hóa Đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(-182, -36);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(406, 129);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "                                       Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 33);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "NET GAMING MANAGER";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(32, 27);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 0;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 33);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(45, 716);
            this.sidebar.TabIndex = 8;
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.menuContainer.Controls.Add(this.panel9);
            this.menuContainer.Controls.Add(this.panel2);
            this.menuContainer.Controls.Add(this.panel3);
            this.menuContainer.Controls.Add(this.panel4);
            this.menuContainer.Controls.Add(this.panel6);
            this.menuContainer.Location = new System.Drawing.Point(3, 3);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(207, 61);
            this.menuContainer.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.home);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(161, 62);
            this.panel9.TabIndex = 11;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(-128, -34);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(293, 129);
            this.home.TabIndex = 6;
            this.home.Text = "                                       HOME";
            this.home.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnComputer);
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 64);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCustomer);
            this.panel3.Location = new System.Drawing.Point(3, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 49);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMenu);
            this.panel4.Location = new System.Drawing.Point(3, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 54);
            this.panel4.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnHoaDon);
            this.panel6.Location = new System.Drawing.Point(3, 256);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 55);
            this.panel6.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDangXuat);
            this.panel5.Location = new System.Drawing.Point(3, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(161, 64);
            this.panel5.TabIndex = 10;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1206, 749);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1206, 749);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
       //     this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

