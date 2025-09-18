using System.Drawing;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    partial class FormComputer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComputer));
            this.lbIDComputer = new System.Windows.Forms.Label();
            this.rbTrong = new System.Windows.Forms.RadioButton();
            this.rbloaiThuong = new System.Windows.Forms.RadioButton();
            this.rbloaiVip = new System.Windows.Forms.RadioButton();
            this.rbloaiTrungBinh = new System.Windows.Forms.RadioButton();
            this.rbBaoTri = new System.Windows.Forms.RadioButton();
            this.rbDangSuDung = new System.Windows.Forms.RadioButton();
            this.dgvComputer = new System.Windows.Forms.DataGridView();
            this.idComputer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtidComputer = new System.Windows.Forms.TextBox();
            this.rbphongCouple = new System.Windows.Forms.RadioButton();
            this.rbphongStream = new System.Windows.Forms.RadioButton();
            this.rbphongVIP = new System.Windows.Forms.RadioButton();
            this.rbphongThuong = new System.Windows.Forms.RadioButton();
            this.lbHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.grTim = new System.Windows.Forms.GroupBox();
            this.rbtimTheoGia = new System.Windows.Forms.RadioButton();
            this.rbtimTheoPhong = new System.Windows.Forms.RadioButton();
            this.rbtimTheoLoai = new System.Windows.Forms.RadioButton();
            this.rbtimTheoTinhTrang = new System.Windows.Forms.RadioButton();
            this.rbtimTheoMa = new System.Windows.Forms.RadioButton();
            this.txttimKiem = new System.Windows.Forms.TextBox();
            this.btntimKiem = new System.Windows.Forms.Button();
            this.btnhienThiTatCa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIDComputer
            // 
            this.lbIDComputer.AutoSize = true;
            this.lbIDComputer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbIDComputer.Location = new System.Drawing.Point(12, 0);
            this.lbIDComputer.Name = "lbIDComputer";
            this.lbIDComputer.Padding = new System.Windows.Forms.Padding(5);
            this.lbIDComputer.Size = new System.Drawing.Size(115, 29);
            this.lbIDComputer.TabIndex = 0;
            this.lbIDComputer.Text = "ID Computer";
            // 
            // rbTrong
            // 
            this.rbTrong.AutoSize = true;
            this.rbTrong.Location = new System.Drawing.Point(31, 19);
            this.rbTrong.Name = "rbTrong";
            this.rbTrong.Size = new System.Drawing.Size(53, 17);
            this.rbTrong.TabIndex = 13;
            this.rbTrong.TabStop = true;
            this.rbTrong.Text = "Trống";
            this.rbTrong.UseVisualStyleBackColor = true;
            // 
            // rbloaiThuong
            // 
            this.rbloaiThuong.AutoSize = true;
            this.rbloaiThuong.Location = new System.Drawing.Point(23, 23);
            this.rbloaiThuong.Name = "rbloaiThuong";
            this.rbloaiThuong.Size = new System.Drawing.Size(62, 17);
            this.rbloaiThuong.TabIndex = 14;
            this.rbloaiThuong.TabStop = true;
            this.rbloaiThuong.Text = "Thường";
            this.rbloaiThuong.UseVisualStyleBackColor = true;
            // 
            // rbloaiVip
            // 
            this.rbloaiVip.AutoSize = true;
            this.rbloaiVip.Location = new System.Drawing.Point(23, 69);
            this.rbloaiVip.Name = "rbloaiVip";
            this.rbloaiVip.Size = new System.Drawing.Size(42, 17);
            this.rbloaiVip.TabIndex = 15;
            this.rbloaiVip.TabStop = true;
            this.rbloaiVip.Text = "VIP";
            this.rbloaiVip.UseVisualStyleBackColor = true;
            // 
            // rbloaiTrungBinh
            // 
            this.rbloaiTrungBinh.AutoSize = true;
            this.rbloaiTrungBinh.Location = new System.Drawing.Point(23, 46);
            this.rbloaiTrungBinh.Name = "rbloaiTrungBinh";
            this.rbloaiTrungBinh.Size = new System.Drawing.Size(77, 17);
            this.rbloaiTrungBinh.TabIndex = 16;
            this.rbloaiTrungBinh.TabStop = true;
            this.rbloaiTrungBinh.Text = "Trung Bình";
            this.rbloaiTrungBinh.UseVisualStyleBackColor = true;
            // 
            // rbBaoTri
            // 
            this.rbBaoTri.AutoSize = true;
            this.rbBaoTri.Location = new System.Drawing.Point(31, 65);
            this.rbBaoTri.Name = "rbBaoTri";
            this.rbBaoTri.Size = new System.Drawing.Size(59, 17);
            this.rbBaoTri.TabIndex = 15;
            this.rbBaoTri.TabStop = true;
            this.rbBaoTri.Text = "Bảo Trì";
            this.rbBaoTri.UseVisualStyleBackColor = true;
            // 
            // rbDangSuDung
            // 
            this.rbDangSuDung.AutoSize = true;
            this.rbDangSuDung.Location = new System.Drawing.Point(31, 42);
            this.rbDangSuDung.Name = "rbDangSuDung";
            this.rbDangSuDung.Size = new System.Drawing.Size(96, 17);
            this.rbDangSuDung.TabIndex = 14;
            this.rbDangSuDung.TabStop = true;
            this.rbDangSuDung.Text = "Đang Sử Dụng";
            this.rbDangSuDung.UseVisualStyleBackColor = true;
            // 
            // dgvComputer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvComputer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComputer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvComputer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComputer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComputer,
            this.status,
            this.kind,
            this.room,
            this.price});
            this.dgvComputer.EnableHeadersVisualStyles = false;
            this.dgvComputer.Location = new System.Drawing.Point(143, 298);
            this.dgvComputer.Name = "dgvComputer";
            this.dgvComputer.Size = new System.Drawing.Size(545, 150);
            this.dgvComputer.TabIndex = 19;
            this.dgvComputer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComputer_CellClick);
            // 
            // idComputer
            // 
            this.idComputer.DataPropertyName = "idComputer";
            this.idComputer.HeaderText = "ID Computer";
            this.idComputer.Name = "idComputer";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Tình Trạng";
            this.status.Name = "status";
            // 
            // kind
            // 
            this.kind.DataPropertyName = "kind";
            this.kind.HeaderText = "Loại Máy";
            this.kind.Name = "kind";
            // 
            // room
            // 
            this.room.DataPropertyName = "room";
            this.room.HeaderText = "Phòng";
            this.room.Name = "room";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(429, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "         Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(429, 95);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 39);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "      Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(429, 154);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 42);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "       Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtidComputer
            // 
            this.txtidComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.txtidComputer.Location = new System.Drawing.Point(132, 6);
            this.txtidComputer.Name = "txtidComputer";
            this.txtidComputer.Size = new System.Drawing.Size(100, 20);
            this.txtidComputer.TabIndex = 26;
            this.txtidComputer.Text = "M001";
            // 
            // rbphongCouple
            // 
            this.rbphongCouple.AutoSize = true;
            this.rbphongCouple.Location = new System.Drawing.Point(23, 69);
            this.rbphongCouple.Name = "rbphongCouple";
            this.rbphongCouple.Size = new System.Drawing.Size(58, 17);
            this.rbphongCouple.TabIndex = 17;
            this.rbphongCouple.TabStop = true;
            this.rbphongCouple.Text = "Couple";
            this.rbphongCouple.UseVisualStyleBackColor = true;
            // 
            // rbphongStream
            // 
            this.rbphongStream.AutoSize = true;
            this.rbphongStream.Location = new System.Drawing.Point(23, 46);
            this.rbphongStream.Name = "rbphongStream";
            this.rbphongStream.Size = new System.Drawing.Size(58, 17);
            this.rbphongStream.TabIndex = 16;
            this.rbphongStream.TabStop = true;
            this.rbphongStream.Text = "Stream";
            this.rbphongStream.UseVisualStyleBackColor = true;
            // 
            // rbphongVIP
            // 
            this.rbphongVIP.AutoSize = true;
            this.rbphongVIP.Location = new System.Drawing.Point(23, 92);
            this.rbphongVIP.Name = "rbphongVIP";
            this.rbphongVIP.Size = new System.Drawing.Size(42, 17);
            this.rbphongVIP.TabIndex = 15;
            this.rbphongVIP.TabStop = true;
            this.rbphongVIP.Text = "VIP";
            this.rbphongVIP.UseVisualStyleBackColor = true;
            // 
            // rbphongThuong
            // 
            this.rbphongThuong.AutoSize = true;
            this.rbphongThuong.Location = new System.Drawing.Point(23, 23);
            this.rbphongThuong.Name = "rbphongThuong";
            this.rbphongThuong.Size = new System.Drawing.Size(62, 17);
            this.rbphongThuong.TabIndex = 14;
            this.rbphongThuong.TabStop = true;
            this.rbphongThuong.Text = "Thường";
            this.rbphongThuong.UseVisualStyleBackColor = true;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbHeader.Location = new System.Drawing.Point(150, 10);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(100, 23);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Quản Lý Tiệm Net";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.groupBox1.Controls.Add(this.rbphongCouple);
            this.groupBox1.Controls.Add(this.rbphongVIP);
            this.groupBox1.Controls.Add(this.rbphongThuong);
            this.groupBox1.Controls.Add(this.rbphongStream);
            this.groupBox1.Location = new System.Drawing.Point(25, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 123);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.groupBox2.Controls.Add(this.rbloaiTrungBinh);
            this.groupBox2.Controls.Add(this.rbloaiVip);
            this.groupBox2.Controls.Add(this.rbloaiThuong);
            this.groupBox2.Location = new System.Drawing.Point(206, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 100);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Máy";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.groupBox3.Controls.Add(this.rbBaoTri);
            this.groupBox3.Controls.Add(this.rbTrong);
            this.groupBox3.Controls.Add(this.rbDangSuDung);
            this.groupBox3.Location = new System.Drawing.Point(16, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 100);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình Trạng";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.groupBox4.Controls.Add(this.txtprice);
            this.groupBox4.Location = new System.Drawing.Point(206, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 100);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giá/1 Giờ";
            // 
            // txtprice
            // 
            this.txtprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Location = new System.Drawing.Point(26, 44);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 13);
            this.txtprice.TabIndex = 5;
            this.txtprice.Text = "5000";
            // 
            // grTim
            // 
            this.grTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.grTim.Controls.Add(this.rbtimTheoGia);
            this.grTim.Controls.Add(this.rbtimTheoPhong);
            this.grTim.Controls.Add(this.rbtimTheoLoai);
            this.grTim.Controls.Add(this.rbtimTheoTinhTrang);
            this.grTim.Controls.Add(this.rbtimTheoMa);
            this.grTim.Location = new System.Drawing.Point(535, 42);
            this.grTim.Name = "grTim";
            this.grTim.Size = new System.Drawing.Size(191, 185);
            this.grTim.TabIndex = 31;
            this.grTim.TabStop = false;
            this.grTim.Text = "Tìm Kiếm";
            // 
            // rbtimTheoGia
            // 
            this.rbtimTheoGia.AutoSize = true;
            this.rbtimTheoGia.Location = new System.Drawing.Point(28, 158);
            this.rbtimTheoGia.Name = "rbtimTheoGia";
            this.rbtimTheoGia.Size = new System.Drawing.Size(89, 17);
            this.rbtimTheoGia.TabIndex = 4;
            this.rbtimTheoGia.TabStop = true;
            this.rbtimTheoGia.Text = "Tìm Theo Gia";
            this.rbtimTheoGia.UseVisualStyleBackColor = true;
            // 
            // rbtimTheoPhong
            // 
            this.rbtimTheoPhong.AutoSize = true;
            this.rbtimTheoPhong.Location = new System.Drawing.Point(28, 123);
            this.rbtimTheoPhong.Name = "rbtimTheoPhong";
            this.rbtimTheoPhong.Size = new System.Drawing.Size(104, 17);
            this.rbtimTheoPhong.TabIndex = 3;
            this.rbtimTheoPhong.TabStop = true;
            this.rbtimTheoPhong.Text = "Tìm Theo Phòng";
            this.rbtimTheoPhong.UseVisualStyleBackColor = true;
            // 
            // rbtimTheoLoai
            // 
            this.rbtimTheoLoai.AutoSize = true;
            this.rbtimTheoLoai.Location = new System.Drawing.Point(28, 89);
            this.rbtimTheoLoai.Name = "rbtimTheoLoai";
            this.rbtimTheoLoai.Size = new System.Drawing.Size(93, 17);
            this.rbtimTheoLoai.TabIndex = 2;
            this.rbtimTheoLoai.TabStop = true;
            this.rbtimTheoLoai.Text = "Tìm Theo Loại";
            this.rbtimTheoLoai.UseVisualStyleBackColor = true;
            // 
            // rbtimTheoTinhTrang
            // 
            this.rbtimTheoTinhTrang.AutoSize = true;
            this.rbtimTheoTinhTrang.Location = new System.Drawing.Point(28, 53);
            this.rbtimTheoTinhTrang.Name = "rbtimTheoTinhTrang";
            this.rbtimTheoTinhTrang.Size = new System.Drawing.Size(125, 17);
            this.rbtimTheoTinhTrang.TabIndex = 1;
            this.rbtimTheoTinhTrang.TabStop = true;
            this.rbtimTheoTinhTrang.Text = "Tìm Theo Tình Trạng";
            this.rbtimTheoTinhTrang.UseVisualStyleBackColor = true;
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
            // txttimKiem
            // 
            this.txttimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.txttimKiem.Location = new System.Drawing.Point(546, 233);
            this.txttimKiem.Name = "txttimKiem";
            this.txttimKiem.Size = new System.Drawing.Size(121, 20);
            this.txttimKiem.TabIndex = 32;
            // 
            // btntimKiem
            // 
            this.btntimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btntimKiem.Location = new System.Drawing.Point(673, 233);
            this.btntimKiem.Name = "btntimKiem";
            this.btntimKiem.Size = new System.Drawing.Size(75, 23);
            this.btntimKiem.TabIndex = 33;
            this.btntimKiem.Text = "Tìm";
            this.btntimKiem.UseVisualStyleBackColor = false;
            this.btntimKiem.Click += new System.EventHandler(this.btntimKiem_Click);
            // 
            // btnhienThiTatCa
            // 
            this.btnhienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnhienThiTatCa.Location = new System.Drawing.Point(662, 262);
            this.btnhienThiTatCa.Name = "btnhienThiTatCa";
            this.btnhienThiTatCa.Size = new System.Drawing.Size(103, 23);
            this.btnhienThiTatCa.TabIndex = 34;
            this.btnhienThiTatCa.Text = "Hiển Thị Tất Cả";
            this.btnhienThiTatCa.UseVisualStyleBackColor = false;
            this.btnhienThiTatCa.Visible = false;
            this.btnhienThiTatCa.Click += new System.EventHandler(this.btnhienThiTatCa_Click);
            // 
            // FormComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(835, 474);
            this.Controls.Add(this.btnhienThiTatCa);
            this.Controls.Add(this.btntimKiem);
            this.Controls.Add(this.txttimKiem);
            this.Controls.Add(this.grTim);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtidComputer);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvComputer);
            this.Controls.Add(this.lbIDComputer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComputer";
            this.Text = "ComputerManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormComputer_FormClosing);
            this.Load += new System.EventHandler(this.FormComputer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grTim.ResumeLayout(false);
            this.grTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIDComputer;
        private System.Windows.Forms.RadioButton rbTrong;
        private System.Windows.Forms.RadioButton rbloaiThuong;
        private System.Windows.Forms.RadioButton rbloaiVip;
        private System.Windows.Forms.RadioButton rbBaoTri;
        private System.Windows.Forms.RadioButton rbDangSuDung;
        private System.Windows.Forms.DataGridView dgvComputer;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtidComputer;
        private System.Windows.Forms.RadioButton rbphongStream;
        private System.Windows.Forms.RadioButton rbphongVIP;
        private System.Windows.Forms.RadioButton rbphongThuong;
        private System.Windows.Forms.RadioButton rbphongCouple;
        private System.Windows.Forms.RadioButton rbloaiTrungBinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn kind;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private Label lbHeader;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox txtprice;
        private GroupBox grTim;
        private RadioButton rbtimTheoPhong;
        private RadioButton rbtimTheoLoai;
        private RadioButton rbtimTheoTinhTrang;
        private RadioButton rbtimTheoMa;
        private RadioButton rbtimTheoGia;
        private TextBox txttimKiem;
        private Button btntimKiem;
        private Button btnhienThiTatCa;
    }
}