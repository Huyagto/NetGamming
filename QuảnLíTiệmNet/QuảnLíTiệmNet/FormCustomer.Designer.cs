using System.Drawing;

namespace QuảnLíTiệmNet
{
    partial class FormCustomer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.txtidCustomer = new System.Windows.Forms.TextBox();
            this.lbidCustomer = new System.Windows.Forms.Label();
            this.lbnameKH = new System.Windows.Forms.Label();
            this.lbdienThoai = new System.Windows.Forms.Label();
            this.lbdiaChi = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbngaySinh = new System.Windows.Forms.Label();
            this.lbthoiGianDK = new System.Windows.Forms.Label();
            this.txtnameCustomer = new System.Windows.Forms.TextBox();
            this.txtdienThoai = new System.Windows.Forms.TextBox();
            this.txtdiaChi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dtthoiGianDK = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtngaySinh = new System.Windows.Forms.DateTimePicker();
            this.nbgio = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBoxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.lbtenTK = new System.Windows.Forms.Label();
            this.grgioiTinh = new System.Windows.Forms.GroupBox();
            this.rbnam = new System.Windows.Forms.RadioButton();
            this.rbnu = new System.Windows.Forms.RadioButton();
            this.txtsoGio = new System.Windows.Forms.TextBox();
            this.grtrangThai = new System.Windows.Forms.GroupBox();
            this.rbVIP = new System.Windows.Forms.RadioButton();
            this.rbthuong = new System.Windows.Forms.RadioButton();
            this.lbsoTien = new System.Windows.Forms.Label();
            this.btntimKiem = new System.Windows.Forms.Button();
            this.txttimKiem = new System.Windows.Forms.TextBox();
            this.grTim = new System.Windows.Forms.GroupBox();
            this.rbtimTheoDienThoai = new System.Windows.Forms.RadioButton();
            this.rbtimTheoTen = new System.Windows.Forms.RadioButton();
            this.rbtimTheoMa = new System.Windows.Forms.RadioButton();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthanhToan = new System.Windows.Forms.Button();
            this.btnhienThiTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbgio)).BeginInit();
            this.groupBoxCustomerInfo.SuspendLayout();
            this.grgioiTinh.SuspendLayout();
            this.grtrangThai.SuspendLayout();
            this.grTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidCustomer
            // 
            this.txtidCustomer.Location = new System.Drawing.Point(140, 27);
            this.txtidCustomer.Name = "txtidCustomer";
            this.txtidCustomer.Size = new System.Drawing.Size(200, 20);
            this.txtidCustomer.TabIndex = 29;
            this.txtidCustomer.Text = "ID001";
            // 
            // lbidCustomer
            // 
            this.lbidCustomer.AutoSize = true;
            this.lbidCustomer.Location = new System.Drawing.Point(20, 30);
            this.lbidCustomer.Name = "lbidCustomer";
            this.lbidCustomer.Size = new System.Drawing.Size(65, 13);
            this.lbidCustomer.TabIndex = 28;
            this.lbidCustomer.Text = "ID Customer";
            // 
            // lbnameKH
            // 
            this.lbnameKH.AutoSize = true;
            this.lbnameKH.Location = new System.Drawing.Point(20, 60);
            this.lbnameKH.Name = "lbnameKH";
            this.lbnameKH.Size = new System.Drawing.Size(89, 13);
            this.lbnameKH.TabIndex = 30;
            this.lbnameKH.Text = "Tên Khách Hàng";
            // 
            // lbdienThoai
            // 
            this.lbdienThoai.AutoSize = true;
            this.lbdienThoai.Location = new System.Drawing.Point(20, 90);
            this.lbdienThoai.Name = "lbdienThoai";
            this.lbdienThoai.Size = new System.Drawing.Size(75, 13);
            this.lbdienThoai.TabIndex = 31;
            this.lbdienThoai.Text = "Số Điện Thoại";
            // 
            // lbdiaChi
            // 
            this.lbdiaChi.AutoSize = true;
            this.lbdiaChi.Location = new System.Drawing.Point(20, 120);
            this.lbdiaChi.Name = "lbdiaChi";
            this.lbdiaChi.Size = new System.Drawing.Size(41, 13);
            this.lbdiaChi.TabIndex = 32;
            this.lbdiaChi.Text = "Địa Chỉ";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(20, 150);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(32, 13);
            this.lbemail.TabIndex = 33;
            this.lbemail.Text = "Email";
            // 
            // lbngaySinh
            // 
            this.lbngaySinh.AutoSize = true;
            this.lbngaySinh.Location = new System.Drawing.Point(20, 180);
            this.lbngaySinh.Name = "lbngaySinh";
            this.lbngaySinh.Size = new System.Drawing.Size(56, 13);
            this.lbngaySinh.TabIndex = 34;
            this.lbngaySinh.Text = "Ngày Sinh";
            // 
            // lbthoiGianDK
            // 
            this.lbthoiGianDK.AutoSize = true;
            this.lbthoiGianDK.Location = new System.Drawing.Point(20, 210);
            this.lbthoiGianDK.Name = "lbthoiGianDK";
            this.lbthoiGianDK.Size = new System.Drawing.Size(97, 13);
            this.lbthoiGianDK.TabIndex = 35;
            this.lbthoiGianDK.Text = "Thời Gian Đăng Ký";
            // 
            // txtnameCustomer
            // 
            this.txtnameCustomer.Location = new System.Drawing.Point(140, 57);
            this.txtnameCustomer.Name = "txtnameCustomer";
            this.txtnameCustomer.Size = new System.Drawing.Size(200, 20);
            this.txtnameCustomer.TabIndex = 39;
            this.txtnameCustomer.Text = "Gia Huy";
            // 
            // txtdienThoai
            // 
            this.txtdienThoai.Location = new System.Drawing.Point(140, 87);
            this.txtdienThoai.Name = "txtdienThoai";
            this.txtdienThoai.Size = new System.Drawing.Size(200, 20);
            this.txtdienThoai.TabIndex = 40;
            this.txtdienThoai.Text = "0123456789";
            // 
            // txtdiaChi
            // 
            this.txtdiaChi.Location = new System.Drawing.Point(140, 117);
            this.txtdiaChi.Name = "txtdiaChi";
            this.txtdiaChi.Size = new System.Drawing.Size(200, 20);
            this.txtdiaChi.TabIndex = 41;
            this.txtdiaChi.Text = "244A Lê Văn Lương, Tân Hưng, Quận 7";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(140, 147);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 20);
            this.txtemail.TabIndex = 42;
            this.txtemail.Text = "giahuynguyen9700@gmail.com";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 0;
            // 
            // dtthoiGianDK
            // 
            this.dtthoiGianDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtthoiGianDK.Location = new System.Drawing.Point(140, 207);
            this.dtthoiGianDK.Name = "dtthoiGianDK";
            this.dtthoiGianDK.Size = new System.Drawing.Size(200, 20);
            this.dtthoiGianDK.TabIndex = 44;
            // 
            // dgvCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCustomer,
            this.nameCustomer,
            this.dienThoai,
            this.diaChi,
            this.Email,
            this.ngaySinh,
            this.thoiGianDK,
            this.trangThai,
            this.gioiTinh,
            this.soTien,
            this.tentk,
            this.mk});
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Location = new System.Drawing.Point(432, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(1381, 300);
            this.dgvCustomer.TabIndex = 1;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // idCustomer
            // 
            this.idCustomer.DataPropertyName = "IDCustomer";
            this.idCustomer.HeaderText = "ID";
            this.idCustomer.MinimumWidth = 6;
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.ReadOnly = true;
            this.idCustomer.Width = 50;
            // 
            // nameCustomer
            // 
            this.nameCustomer.DataPropertyName = "NameCustomer";
            this.nameCustomer.HeaderText = "Tên Khách Hàng";
            this.nameCustomer.MinimumWidth = 6;
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.ReadOnly = true;
            this.nameCustomer.Width = 125;
            // 
            // dienThoai
            // 
            this.dienThoai.DataPropertyName = "dienThoai";
            this.dienThoai.HeaderText = "Số Điện Thoại";
            this.dienThoai.MinimumWidth = 6;
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.ReadOnly = true;
            this.dienThoai.Width = 125;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa Chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày Sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            this.ngaySinh.Width = 125;
            // 
            // thoiGianDK
            // 
            this.thoiGianDK.DataPropertyName = "thoiGianDK";
            this.thoiGianDK.HeaderText = "Thời Gian Đăng Ký";
            this.thoiGianDK.MinimumWidth = 6;
            this.thoiGianDK.Name = "thoiGianDK";
            this.thoiGianDK.ReadOnly = true;
            this.thoiGianDK.Width = 125;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 125;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.ReadOnly = true;
            // 
            // soTien
            // 
            this.soTien.DataPropertyName = "Tien";
            this.soTien.HeaderText = "Số Tiền";
            this.soTien.MinimumWidth = 6;
            this.soTien.Name = "soTien";
            this.soTien.ReadOnly = true;
            this.soTien.Width = 125;
            // 
            // tentk
            // 
            this.tentk.DataPropertyName = "TenTK";
            this.tentk.HeaderText = "Tên Tài Khoản";
            this.tentk.Name = "tentk";
            this.tentk.ReadOnly = true;
            // 
            // mk
            // 
            this.mk.DataPropertyName = "MK";
            this.mk.HeaderText = "Mât Khẩu";
            this.mk.Name = "mk";
            this.mk.ReadOnly = true;
            // 
            // dtngaySinh
            // 
            this.dtngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaySinh.Location = new System.Drawing.Point(140, 177);
            this.dtngaySinh.Name = "dtngaySinh";
            this.dtngaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtngaySinh.TabIndex = 43;
            this.dtngaySinh.Value = new System.DateTime(2004, 11, 18, 0, 0, 0, 0);
            // 
            // nbgio
            // 
            this.nbgio.Location = new System.Drawing.Point(140, 280);
            this.nbgio.Name = "nbgio";
            this.nbgio.Size = new System.Drawing.Size(120, 20);
            this.nbgio.TabIndex = 48;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(706, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 58);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(567, 330);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 58);
            this.btnSua.TabIndex = 52;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(422, 330);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 58);
            this.btnThem.TabIndex = 53;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBoxCustomerInfo
            // 
            this.groupBoxCustomerInfo.Controls.Add(this.txtMatKhau);
            this.groupBoxCustomerInfo.Controls.Add(this.txtTenTaiKhoan);
            this.groupBoxCustomerInfo.Controls.Add(this.lbMK);
            this.groupBoxCustomerInfo.Controls.Add(this.lbtenTK);
            this.groupBoxCustomerInfo.Controls.Add(this.grgioiTinh);
            this.groupBoxCustomerInfo.Controls.Add(this.txtsoGio);
            this.groupBoxCustomerInfo.Controls.Add(this.grtrangThai);
            this.groupBoxCustomerInfo.Controls.Add(this.lbsoTien);
            this.groupBoxCustomerInfo.Controls.Add(this.lbidCustomer);
            this.groupBoxCustomerInfo.Controls.Add(this.txtidCustomer);
            this.groupBoxCustomerInfo.Controls.Add(this.lbnameKH);
            this.groupBoxCustomerInfo.Controls.Add(this.txtnameCustomer);
            this.groupBoxCustomerInfo.Controls.Add(this.lbdienThoai);
            this.groupBoxCustomerInfo.Controls.Add(this.txtdienThoai);
            this.groupBoxCustomerInfo.Controls.Add(this.lbdiaChi);
            this.groupBoxCustomerInfo.Controls.Add(this.txtdiaChi);
            this.groupBoxCustomerInfo.Controls.Add(this.lbemail);
            this.groupBoxCustomerInfo.Controls.Add(this.txtemail);
            this.groupBoxCustomerInfo.Controls.Add(this.lbngaySinh);
            this.groupBoxCustomerInfo.Controls.Add(this.dtngaySinh);
            this.groupBoxCustomerInfo.Controls.Add(this.lbthoiGianDK);
            this.groupBoxCustomerInfo.Controls.Add(this.dtthoiGianDK);
            this.groupBoxCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            this.groupBoxCustomerInfo.Size = new System.Drawing.Size(400, 413);
            this.groupBoxCustomerInfo.TabIndex = 0;
            this.groupBoxCustomerInfo.TabStop = false;
            this.groupBoxCustomerInfo.Text = "Thông Tin Khách Hàng";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(138, 381);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(100, 20);
            this.txtMatKhau.TabIndex = 58;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(138, 345);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(100, 20);
            this.txtTenTaiKhoan.TabIndex = 57;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Location = new System.Drawing.Point(25, 381);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(53, 13);
            this.lbMK.TabIndex = 56;
            this.lbMK.Text = "Mật Khẩu";
            // 
            // lbtenTK
            // 
            this.lbtenTK.AutoSize = true;
            this.lbtenTK.Location = new System.Drawing.Point(25, 353);
            this.lbtenTK.Name = "lbtenTK";
            this.lbtenTK.Size = new System.Drawing.Size(78, 13);
            this.lbtenTK.TabIndex = 55;
            this.lbtenTK.Text = "Tên Tài Khoản";
            // 
            // grgioiTinh
            // 
            this.grgioiTinh.Controls.Add(this.rbnam);
            this.grgioiTinh.Controls.Add(this.rbnu);
            this.grgioiTinh.Location = new System.Drawing.Point(25, 276);
            this.grgioiTinh.Name = "grgioiTinh";
            this.grgioiTinh.Size = new System.Drawing.Size(315, 26);
            this.grgioiTinh.TabIndex = 54;
            this.grgioiTinh.TabStop = false;
            this.grgioiTinh.Text = "Giới Tính";
            // 
            // rbnam
            // 
            this.rbnam.AutoSize = true;
            this.rbnam.Location = new System.Drawing.Point(222, 6);
            this.rbnam.Name = "rbnam";
            this.rbnam.Size = new System.Drawing.Size(47, 17);
            this.rbnam.TabIndex = 1;
            this.rbnam.TabStop = true;
            this.rbnam.Text = "Nam";
            this.rbnam.UseVisualStyleBackColor = true;
            // 
            // rbnu
            // 
            this.rbnu.AutoSize = true;
            this.rbnu.Location = new System.Drawing.Point(115, 6);
            this.rbnu.Name = "rbnu";
            this.rbnu.Size = new System.Drawing.Size(39, 17);
            this.rbnu.TabIndex = 0;
            this.rbnu.TabStop = true;
            this.rbnu.Text = "Nữ";
            this.rbnu.UseVisualStyleBackColor = true;
            // 
            // txtsoGio
            // 
            this.txtsoGio.Location = new System.Drawing.Point(138, 318);
            this.txtsoGio.Name = "txtsoGio";
            this.txtsoGio.Size = new System.Drawing.Size(62, 20);
            this.txtsoGio.TabIndex = 54;
            this.txtsoGio.Text = "20000";
            // 
            // grtrangThai
            // 
            this.grtrangThai.Controls.Add(this.rbVIP);
            this.grtrangThai.Controls.Add(this.rbthuong);
            this.grtrangThai.Location = new System.Drawing.Point(23, 244);
            this.grtrangThai.Name = "grtrangThai";
            this.grtrangThai.Size = new System.Drawing.Size(315, 26);
            this.grtrangThai.TabIndex = 53;
            this.grtrangThai.TabStop = false;
            this.grtrangThai.Text = "Trạng Thái";
            // 
            // rbVIP
            // 
            this.rbVIP.AutoSize = true;
            this.rbVIP.Location = new System.Drawing.Point(222, 6);
            this.rbVIP.Name = "rbVIP";
            this.rbVIP.Size = new System.Drawing.Size(42, 17);
            this.rbVIP.TabIndex = 1;
            this.rbVIP.TabStop = true;
            this.rbVIP.Text = "VIP";
            this.rbVIP.UseVisualStyleBackColor = true;
            // 
            // rbthuong
            // 
            this.rbthuong.AutoSize = true;
            this.rbthuong.Location = new System.Drawing.Point(115, 6);
            this.rbthuong.Name = "rbthuong";
            this.rbthuong.Size = new System.Drawing.Size(62, 17);
            this.rbthuong.TabIndex = 0;
            this.rbthuong.TabStop = true;
            this.rbthuong.Text = "Thường";
            this.rbthuong.UseVisualStyleBackColor = true;
            // 
            // lbsoTien
            // 
            this.lbsoTien.AutoSize = true;
            this.lbsoTien.Location = new System.Drawing.Point(25, 321);
            this.lbsoTien.Name = "lbsoTien";
            this.lbsoTien.Size = new System.Drawing.Size(44, 13);
            this.lbsoTien.TabIndex = 50;
            this.lbsoTien.Text = "Số Tiền";
            // 
            // btntimKiem
            // 
            this.btntimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btntimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimKiem.Image")));
            this.btntimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimKiem.Location = new System.Drawing.Point(706, 449);
            this.btntimKiem.Name = "btntimKiem";
            this.btntimKiem.Size = new System.Drawing.Size(101, 51);
            this.btntimKiem.TabIndex = 56;
            this.btntimKiem.Text = "Tìm";
            this.btntimKiem.UseVisualStyleBackColor = false;
            this.btntimKiem.Click += new System.EventHandler(this.btntimKiem_Click);
            // 
            // txttimKiem
            // 
            this.txttimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttimKiem.Location = new System.Drawing.Point(567, 449);
            this.txttimKiem.Multiline = true;
            this.txttimKiem.Name = "txttimKiem";
            this.txttimKiem.Size = new System.Drawing.Size(121, 51);
            this.txttimKiem.TabIndex = 55;
            // 
            // grTim
            // 
            this.grTim.Controls.Add(this.rbtimTheoDienThoai);
            this.grTim.Controls.Add(this.rbtimTheoTen);
            this.grTim.Controls.Add(this.rbtimTheoMa);
            this.grTim.Location = new System.Drawing.Point(12, 440);
            this.grTim.Name = "grTim";
            this.grTim.Size = new System.Drawing.Size(540, 60);
            this.grTim.TabIndex = 54;
            this.grTim.TabStop = false;
            this.grTim.Text = "Tìm Kiếm";
            // 
            // rbtimTheoDienThoai
            // 
            this.rbtimTheoDienThoai.AutoSize = true;
            this.rbtimTheoDienThoai.Location = new System.Drawing.Point(245, 19);
            this.rbtimTheoDienThoai.Name = "rbtimTheoDienThoai";
            this.rbtimTheoDienThoai.Size = new System.Drawing.Size(141, 17);
            this.rbtimTheoDienThoai.TabIndex = 2;
            this.rbtimTheoDienThoai.TabStop = true;
            this.rbtimTheoDienThoai.Text = "Tìm Theo Số Điện Thoại";
            this.rbtimTheoDienThoai.UseVisualStyleBackColor = true;
            // 
            // rbtimTheoTen
            // 
            this.rbtimTheoTen.AutoSize = true;
            this.rbtimTheoTen.Location = new System.Drawing.Point(138, 19);
            this.rbtimTheoTen.Name = "rbtimTheoTen";
            this.rbtimTheoTen.Size = new System.Drawing.Size(92, 17);
            this.rbtimTheoTen.TabIndex = 1;
            this.rbtimTheoTen.TabStop = true;
            this.rbtimTheoTen.Text = "Tìm Theo Tên";
            this.rbtimTheoTen.UseVisualStyleBackColor = true;
            // 
            // rbtimTheoMa
            // 
            this.rbtimTheoMa.AutoSize = true;
            this.rbtimTheoMa.Location = new System.Drawing.Point(28, 19);
            this.rbtimTheoMa.Name = "rbtimTheoMa";
            this.rbtimTheoMa.Size = new System.Drawing.Size(88, 17);
            this.rbtimTheoMa.TabIndex = 0;
            this.rbtimTheoMa.TabStop = true;
            this.rbtimTheoMa.Text = "Tìm Theo Mã";
            this.rbtimTheoMa.UseVisualStyleBackColor = true;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(845, 330);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(130, 58);
            this.btnluu.TabIndex = 57;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Visible = false;
            // 
            // btnthanhToan
            // 
            this.btnthanhToan.BackColor = System.Drawing.Color.IndianRed;
            this.btnthanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnthanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnthanhToan.Image")));
            this.btnthanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthanhToan.Location = new System.Drawing.Point(996, 326);
            this.btnthanhToan.Name = "btnthanhToan";
            this.btnthanhToan.Size = new System.Drawing.Size(193, 66);
            this.btnthanhToan.TabIndex = 64;
            this.btnthanhToan.Text = "Thanh Toán";
            this.btnthanhToan.UseVisualStyleBackColor = false;
            this.btnthanhToan.Click += new System.EventHandler(this.btnthanhToan_Click);
            // 
            // btnhienThiTatCa
            // 
            this.btnhienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnhienThiTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnhienThiTatCa.Image")));
            this.btnhienThiTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhienThiTatCa.Location = new System.Drawing.Point(829, 449);
            this.btnhienThiTatCa.Name = "btnhienThiTatCa";
            this.btnhienThiTatCa.Size = new System.Drawing.Size(101, 51);
            this.btnhienThiTatCa.TabIndex = 65;
            this.btnhienThiTatCa.Text = "Hiển Thị Tất Cả";
            this.btnhienThiTatCa.UseVisualStyleBackColor = false;
            this.btnhienThiTatCa.Visible = false;
            this.btnhienThiTatCa.Click += new System.EventHandler(this.btnhienThiTatCa_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1846, 536);
            this.Controls.Add(this.btnhienThiTatCa);
            this.Controls.Add(this.btnthanhToan);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btntimKiem);
            this.Controls.Add(this.txttimKiem);
            this.Controls.Add(this.grTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.groupBoxCustomerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCustomer";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbgio)).EndInit();
            this.groupBoxCustomerInfo.ResumeLayout(false);
            this.groupBoxCustomerInfo.PerformLayout();
            this.grgioiTinh.ResumeLayout(false);
            this.grgioiTinh.PerformLayout();
            this.grtrangThai.ResumeLayout(false);
            this.grtrangThai.PerformLayout();
            this.grTim.ResumeLayout(false);
            this.grTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtidCustomer;
        private System.Windows.Forms.Label lbidCustomer;
        private System.Windows.Forms.Label lbnameKH;
        private System.Windows.Forms.Label lbdienThoai;
        private System.Windows.Forms.Label lbdiaChi;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbngaySinh;
        private System.Windows.Forms.Label lbthoiGianDK;
        private System.Windows.Forms.TextBox txtnameCustomer;
        private System.Windows.Forms.TextBox txtdienThoai;
        private System.Windows.Forms.TextBox txtdiaChi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dtthoiGianDK;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.NumericUpDown nbgio;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dtngaySinh;
        private System.Windows.Forms.GroupBox groupBoxCustomerInfo;
        private System.Windows.Forms.Label lbsoTien;
        private System.Windows.Forms.GroupBox grtrangThai;
        private System.Windows.Forms.RadioButton rbVIP;
        private System.Windows.Forms.RadioButton rbthuong;
        private System.Windows.Forms.TextBox txtsoGio;
        private System.Windows.Forms.Button btntimKiem;
        private System.Windows.Forms.TextBox txttimKiem;
        private System.Windows.Forms.GroupBox grTim;
        private System.Windows.Forms.RadioButton rbtimTheoDienThoai;
        private System.Windows.Forms.RadioButton rbtimTheoTen;
        private System.Windows.Forms.RadioButton rbtimTheoMa;
        private System.Windows.Forms.GroupBox grgioiTinh;
        private System.Windows.Forms.RadioButton rbnam;
        private System.Windows.Forms.RadioButton rbnu;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Label lbtenTK;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentk;
        private System.Windows.Forms.DataGridViewTextBoxColumn mk;
        private System.Windows.Forms.Button btnthanhToan;
        private System.Windows.Forms.Button btnhienThiTatCa;
    }
}
