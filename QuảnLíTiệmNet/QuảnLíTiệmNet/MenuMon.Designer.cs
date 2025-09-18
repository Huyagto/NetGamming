namespace QuảnLíTiệmNet
{
    partial class MenuMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMon));
            this.lbidMon = new System.Windows.Forms.Label();
            this.lbtenMon = new System.Windows.Forms.Label();
            this.lbdonViTinh = new System.Windows.Forms.Label();
            this.lbdonGia = new System.Windows.Forms.Label();
            this.lbloaiMon = new System.Windows.Forms.Label();
            this.txtidMon = new System.Windows.Forms.TextBox();
            this.txttenMon = new System.Windows.Forms.TextBox();
            this.txtdonViTinh = new System.Windows.Forms.TextBox();
            this.txtdonGia = new System.Windows.Forms.TextBox();
            this.txtloaiMon = new System.Windows.Forms.TextBox();
            this.dgvmenuMons = new System.Windows.Forms.DataGridView();
            this.idMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenuMons)).BeginInit();
            this.SuspendLayout();
            // 
            // lbidMon
            // 
            this.lbidMon.AutoSize = true;
            this.lbidMon.Location = new System.Drawing.Point(34, 23);
            this.lbidMon.Name = "lbidMon";
            this.lbidMon.Size = new System.Drawing.Size(62, 13);
            this.lbidMon.TabIndex = 0;
            this.lbidMon.Text = "Mã Món Ăn";
            // 
            // lbtenMon
            // 
            this.lbtenMon.AutoSize = true;
            this.lbtenMon.Location = new System.Drawing.Point(34, 52);
            this.lbtenMon.Name = "lbtenMon";
            this.lbtenMon.Size = new System.Drawing.Size(50, 13);
            this.lbtenMon.TabIndex = 1;
            this.lbtenMon.Text = "Tên Món";
            // 
            // lbdonViTinh
            // 
            this.lbdonViTinh.AutoSize = true;
            this.lbdonViTinh.Location = new System.Drawing.Point(34, 85);
            this.lbdonViTinh.Name = "lbdonViTinh";
            this.lbdonViTinh.Size = new System.Drawing.Size(65, 13);
            this.lbdonViTinh.TabIndex = 2;
            this.lbdonViTinh.Text = "Đơn Vị Tính";
            // 
            // lbdonGia
            // 
            this.lbdonGia.AutoSize = true;
            this.lbdonGia.Location = new System.Drawing.Point(34, 117);
            this.lbdonGia.Name = "lbdonGia";
            this.lbdonGia.Size = new System.Drawing.Size(46, 13);
            this.lbdonGia.TabIndex = 3;
            this.lbdonGia.Text = "Đơn Giá";
            // 
            // lbloaiMon
            // 
            this.lbloaiMon.AutoSize = true;
            this.lbloaiMon.Location = new System.Drawing.Point(34, 149);
            this.lbloaiMon.Name = "lbloaiMon";
            this.lbloaiMon.Size = new System.Drawing.Size(51, 13);
            this.lbloaiMon.TabIndex = 4;
            this.lbloaiMon.Text = "Loại Món";
            // 
            // txtidMon
            // 
            this.txtidMon.Location = new System.Drawing.Point(109, 23);
            this.txtidMon.Name = "txtidMon";
            this.txtidMon.Size = new System.Drawing.Size(100, 20);
            this.txtidMon.TabIndex = 5;
            this.txtidMon.Text = "001";
            // 
            // txttenMon
            // 
            this.txttenMon.Location = new System.Drawing.Point(109, 52);
            this.txttenMon.Name = "txttenMon";
            this.txttenMon.Size = new System.Drawing.Size(100, 20);
            this.txttenMon.TabIndex = 6;
            this.txttenMon.Text = "Cơm Gà Xối Mỡ";
            // 
            // txtdonViTinh
            // 
            this.txtdonViTinh.Location = new System.Drawing.Point(109, 85);
            this.txtdonViTinh.Name = "txtdonViTinh";
            this.txtdonViTinh.Size = new System.Drawing.Size(100, 20);
            this.txtdonViTinh.TabIndex = 7;
            this.txtdonViTinh.Text = "VND";
            // 
            // txtdonGia
            // 
            this.txtdonGia.Location = new System.Drawing.Point(109, 117);
            this.txtdonGia.Name = "txtdonGia";
            this.txtdonGia.Size = new System.Drawing.Size(100, 20);
            this.txtdonGia.TabIndex = 8;
            this.txtdonGia.Text = "35000";
            // 
            // txtloaiMon
            // 
            this.txtloaiMon.Location = new System.Drawing.Point(109, 149);
            this.txtloaiMon.Name = "txtloaiMon";
            this.txtloaiMon.Size = new System.Drawing.Size(100, 20);
            this.txtloaiMon.TabIndex = 9;
            this.txtloaiMon.Text = "Đồ Ăn No";
            // 
            // dgvmenuMons
            // 
            this.dgvmenuMons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvmenuMons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmenuMons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmenuMons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMon,
            this.tenMon,
            this.donViTinh,
            this.donGia,
            this.loai});
            this.dgvmenuMons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvmenuMons.Location = new System.Drawing.Point(12, 235);
            this.dgvmenuMons.Name = "dgvmenuMons";
            this.dgvmenuMons.Size = new System.Drawing.Size(545, 150);
            this.dgvmenuMons.TabIndex = 10;
            this.dgvmenuMons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmenuMons_CellClick);
            // 
            // idMon
            // 
            this.idMon.DataPropertyName = "idMon";
            this.idMon.HeaderText = "Mã Món";
            this.idMon.Name = "idMon";
            // 
            // tenMon
            // 
            this.tenMon.DataPropertyName = "tenMon";
            this.tenMon.HeaderText = "Tên Món";
            this.tenMon.Name = "tenMon";
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            this.donViTinh.HeaderText = "Đơn Vị Tính";
            this.donViTinh.Name = "donViTinh";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.Name = "donGia";
            // 
            // loai
            // 
            this.loai.DataPropertyName = "loai";
            this.loai.HeaderText = "Loại";
            this.loai.Name = "loai";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(322, 104);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(322, 68);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(322, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 25;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MenuMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(646, 397);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvmenuMons);
            this.Controls.Add(this.txtloaiMon);
            this.Controls.Add(this.txtdonGia);
            this.Controls.Add(this.txtdonViTinh);
            this.Controls.Add(this.txttenMon);
            this.Controls.Add(this.txtidMon);
            this.Controls.Add(this.lbloaiMon);
            this.Controls.Add(this.lbdonGia);
            this.Controls.Add(this.lbdonViTinh);
            this.Controls.Add(this.lbtenMon);
            this.Controls.Add(this.lbidMon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuMon";
            this.Text = "MenuMon";
            this.Load += new System.EventHandler(this.MenuMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmenuMons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbidMon;
        private System.Windows.Forms.Label lbtenMon;
        private System.Windows.Forms.Label lbdonViTinh;
        private System.Windows.Forms.Label lbdonGia;
        private System.Windows.Forms.Label lbloaiMon;
        private System.Windows.Forms.TextBox txtidMon;
        private System.Windows.Forms.TextBox txttenMon;
        private System.Windows.Forms.TextBox txtdonViTinh;
        private System.Windows.Forms.TextBox txtdonGia;
        private System.Windows.Forms.TextBox txtloaiMon;
        private System.Windows.Forms.DataGridView dgvmenuMons;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
    }
}