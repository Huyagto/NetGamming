namespace QuảnLíTiệmNet
{
    partial class FormPay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPay));
            this.lbsoHoaDon = new System.Windows.Forms.Label();
            this.lbidCustomer = new System.Windows.Forms.Label();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.SoHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsoHoaDon = new System.Windows.Forms.TextBox();
            this.lbngayLap = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb = new System.Windows.Forms.Label();
            this.txttienDangCo = new System.Windows.Forms.TextBox();
            this.btncash = new System.Windows.Forms.Button();
            this.btnmomo = new System.Windows.Forms.Button();
            this.btnpayooqr = new System.Windows.Forms.Button();
            this.btnpayoocard = new System.Windows.Forms.Button();
            this.btnbank = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txttienNap = new System.Windows.Forms.TextBox();
            this.lbtienNap = new System.Windows.Forms.Label();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.btnhienThiTatCa = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.btnhienThi = new System.Windows.Forms.Button();
            this.btntimKiem = new System.Windows.Forms.Button();
            this.txttimKiem = new System.Windows.Forms.TextBox();
            this.grTim = new System.Windows.Forms.GroupBox();
            this.rbtimTheoNgay = new System.Windows.Forms.RadioButton();
            this.rbtimKiemTheoHD = new System.Windows.Forms.RadioButton();
            this.rbtimTheoMa = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.grTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbsoHoaDon
            // 
            this.lbsoHoaDon.AutoSize = true;
            this.lbsoHoaDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbsoHoaDon.Location = new System.Drawing.Point(15, 18);
            this.lbsoHoaDon.Name = "lbsoHoaDon";
            this.lbsoHoaDon.Padding = new System.Windows.Forms.Padding(5);
            this.lbsoHoaDon.Size = new System.Drawing.Size(112, 29);
            this.lbsoHoaDon.TabIndex = 44;
            this.lbsoHoaDon.Text = "Số Hóa Đơn";
            // 
            // lbidCustomer
            // 
            this.lbidCustomer.AutoSize = true;
            this.lbidCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbidCustomer.Location = new System.Drawing.Point(13, 100);
            this.lbidCustomer.Name = "lbidCustomer";
            this.lbidCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.lbidCustomer.Size = new System.Drawing.Size(114, 29);
            this.lbidCustomer.TabIndex = 46;
            this.lbidCustomer.Text = "ID Customer";
            // 
            // dgvPay
            // 
            this.dgvPay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHoaDon,
            this.ngayLap,
            this.idCustomer,
            this.tien,
            this.TienNap,
            this.HinhThuc,
            this.TongTien});
            this.dgvPay.Location = new System.Drawing.Point(10, 286);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.RowHeadersWidth = 51;
            this.dgvPay.Size = new System.Drawing.Size(756, 186);
            this.dgvPay.TabIndex = 48;
            this.dgvPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellClick);
            // 
            // SoHoaDon
            // 
            this.SoHoaDon.DataPropertyName = "soHoadon";
            this.SoHoaDon.HeaderText = "Số Hóa Đơn";
            this.SoHoaDon.Name = "SoHoaDon";
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "ngayLap";
            this.ngayLap.HeaderText = "Ngày Lập Đơn";
            this.ngayLap.Name = "ngayLap";
            // 
            // idCustomer
            // 
            this.idCustomer.DataPropertyName = "idCustomer";
            this.idCustomer.HeaderText = "IDCustomer";
            this.idCustomer.Name = "idCustomer";
            // 
            // tien
            // 
            this.tien.DataPropertyName = "TienGio";
            this.tien.HeaderText = "Tiền Giờ";
            this.tien.Name = "tien";
            // 
            // TienNap
            // 
            this.TienNap.DataPropertyName = "TienNap";
            this.TienNap.HeaderText = "Tiền Nạp";
            this.TienNap.Name = "TienNap";
            // 
            // HinhThuc
            // 
            this.HinhThuc.DataPropertyName = "HinhThuc";
            this.HinhThuc.HeaderText = "Hình Thức";
            this.HinhThuc.Name = "HinhThuc";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // txtsoHoaDon
            // 
            this.txtsoHoaDon.Location = new System.Drawing.Point(133, 21);
            this.txtsoHoaDon.Name = "txtsoHoaDon";
            this.txtsoHoaDon.Size = new System.Drawing.Size(173, 20);
            this.txtsoHoaDon.TabIndex = 50;
            this.txtsoHoaDon.Text = "HD001";
            // 
            // lbngayLap
            // 
            this.lbngayLap.AutoSize = true;
            this.lbngayLap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbngayLap.Location = new System.Drawing.Point(16, 57);
            this.lbngayLap.Name = "lbngayLap";
            this.lbngayLap.Padding = new System.Windows.Forms.Padding(5);
            this.lbngayLap.Size = new System.Drawing.Size(92, 29);
            this.lbngayLap.TabIndex = 56;
            this.lbngayLap.Text = "Ngày Lập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 57;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lb.Location = new System.Drawing.Point(5, 147);
            this.lb.Name = "lb";
            this.lb.Padding = new System.Windows.Forms.Padding(5);
            this.lb.Size = new System.Drawing.Size(123, 29);
            this.lb.TabIndex = 58;
            this.lb.Text = "Tiền Đang Có";
            // 
            // txttienDangCo
            // 
            this.txttienDangCo.Location = new System.Drawing.Point(135, 147);
            this.txttienDangCo.Name = "txttienDangCo";
            this.txttienDangCo.Size = new System.Drawing.Size(173, 20);
            this.txttienDangCo.TabIndex = 59;
            // 
            // btncash
            // 
            this.btncash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btncash.Image = ((System.Drawing.Image)(resources.GetObject("btncash.Image")));
            this.btncash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncash.Location = new System.Drawing.Point(10, 193);
            this.btncash.Name = "btncash";
            this.btncash.Size = new System.Drawing.Size(107, 56);
            this.btncash.TabIndex = 62;
            this.btncash.Text = "Cash";
            this.btncash.UseVisualStyleBackColor = false;
            this.btncash.Click += new System.EventHandler(this.btncash_Click);
            // 
            // btnmomo
            // 
            this.btnmomo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnmomo.Image = ((System.Drawing.Image)(resources.GetObject("btnmomo.Image")));
            this.btnmomo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmomo.Location = new System.Drawing.Point(135, 193);
            this.btnmomo.Name = "btnmomo";
            this.btnmomo.Size = new System.Drawing.Size(107, 56);
            this.btnmomo.TabIndex = 63;
            this.btnmomo.Text = "MoMo";
            this.btnmomo.UseVisualStyleBackColor = false;
            this.btnmomo.Click += new System.EventHandler(this.btnmomo_Click);
            // 
            // btnpayooqr
            // 
            this.btnpayooqr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnpayooqr.Image = ((System.Drawing.Image)(resources.GetObject("btnpayooqr.Image")));
            this.btnpayooqr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpayooqr.Location = new System.Drawing.Point(260, 193);
            this.btnpayooqr.Name = "btnpayooqr";
            this.btnpayooqr.Size = new System.Drawing.Size(108, 56);
            this.btnpayooqr.TabIndex = 64;
            this.btnpayooqr.Text = "      Payoo QR";
            this.btnpayooqr.UseVisualStyleBackColor = false;
            this.btnpayooqr.Click += new System.EventHandler(this.btnpayooqr_Click);
            // 
            // btnpayoocard
            // 
            this.btnpayoocard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnpayoocard.Image = ((System.Drawing.Image)(resources.GetObject("btnpayoocard.Image")));
            this.btnpayoocard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpayoocard.Location = new System.Drawing.Point(384, 193);
            this.btnpayoocard.Name = "btnpayoocard";
            this.btnpayoocard.Size = new System.Drawing.Size(107, 56);
            this.btnpayoocard.TabIndex = 65;
            this.btnpayoocard.Text = "         PayooCard";
            this.btnpayoocard.UseVisualStyleBackColor = false;
            this.btnpayoocard.Click += new System.EventHandler(this.btnpayoocard_Click);
            // 
            // btnbank
            // 
            this.btnbank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnbank.Image = ((System.Drawing.Image)(resources.GetObject("btnbank.Image")));
            this.btnbank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbank.Location = new System.Drawing.Point(508, 193);
            this.btnbank.Name = "btnbank";
            this.btnbank.Size = new System.Drawing.Size(107, 56);
            this.btnbank.TabIndex = 66;
            this.btnbank.Text = "Bank";
            this.btnbank.UseVisualStyleBackColor = false;
            this.btnbank.Click += new System.EventHandler(this.btnbank_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(643, 193);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 56);
            this.btnThoat.TabIndex = 67;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txttienNap
            // 
            this.txttienNap.Location = new System.Drawing.Point(467, 147);
            this.txttienNap.Name = "txttienNap";
            this.txttienNap.Size = new System.Drawing.Size(173, 20);
            this.txttienNap.TabIndex = 69;
            this.txttienNap.Text = "0";
            // 
            // lbtienNap
            // 
            this.lbtienNap.AutoSize = true;
            this.lbtienNap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbtienNap.Location = new System.Drawing.Point(337, 147);
            this.lbtienNap.Name = "lbtienNap";
            this.lbtienNap.Padding = new System.Windows.Forms.Padding(5);
            this.lbtienNap.Size = new System.Drawing.Size(121, 29);
            this.lbtienNap.TabIndex = 68;
            this.lbtienNap.Text = "Tiền Nạp Vào";
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnInBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInBaoCao.Location = new System.Drawing.Point(615, 82);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(107, 56);
            this.btnInBaoCao.TabIndex = 70;
            this.btnInBaoCao.Text = "In báo cáo ";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // btnhienThiTatCa
            // 
            this.btnhienThiTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnhienThiTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnhienThiTatCa.Image")));
            this.btnhienThiTatCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhienThiTatCa.Location = new System.Drawing.Point(10, 255);
            this.btnhienThiTatCa.Name = "btnhienThiTatCa";
            this.btnhienThiTatCa.Size = new System.Drawing.Size(131, 32);
            this.btnhienThiTatCa.TabIndex = 71;
            this.btnhienThiTatCa.Text = "Hiển Thị Tất Cả";
            this.btnhienThiTatCa.UseVisualStyleBackColor = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ID.Location = new System.Drawing.Point(133, 98);
            this.ID.Name = "ID";
            this.ID.Padding = new System.Windows.Forms.Padding(5);
            this.ID.Size = new System.Drawing.Size(10, 29);
            this.ID.TabIndex = 72;
            // 
            // btnhienThi
            // 
            this.btnhienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnhienThi.Location = new System.Drawing.Point(669, 18);
            this.btnhienThi.Name = "btnhienThi";
            this.btnhienThi.Size = new System.Drawing.Size(103, 23);
            this.btnhienThi.TabIndex = 76;
            this.btnhienThi.Text = "Hiển Thị Tất Cả";
            this.btnhienThi.UseVisualStyleBackColor = false;
            this.btnhienThi.Visible = false;
            this.btnhienThi.Click += new System.EventHandler(this.btnhienThiTatCa_Click);
            // 
            // btntimKiem
            // 
            this.btntimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btntimKiem.Location = new System.Drawing.Point(585, 19);
            this.btntimKiem.Name = "btntimKiem";
            this.btntimKiem.Size = new System.Drawing.Size(75, 23);
            this.btntimKiem.TabIndex = 75;
            this.btntimKiem.Text = "Tìm";
            this.btntimKiem.UseVisualStyleBackColor = false;
            this.btntimKiem.Click += new System.EventHandler(this.btntimKiem_Click);
            // 
            // txttimKiem
            // 
            this.txttimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.txttimKiem.Location = new System.Drawing.Point(589, 48);
            this.txttimKiem.Name = "txttimKiem";
            this.txttimKiem.Size = new System.Drawing.Size(121, 20);
            this.txttimKiem.TabIndex = 74;
            // 
            // grTim
            // 
            this.grTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.grTim.Controls.Add(this.rbtimTheoNgay);
            this.grTim.Controls.Add(this.rbtimKiemTheoHD);
            this.grTim.Controls.Add(this.rbtimTheoMa);
            this.grTim.Location = new System.Drawing.Point(404, 12);
            this.grTim.Name = "grTim";
            this.grTim.Size = new System.Drawing.Size(191, 124);
            this.grTim.TabIndex = 73;
            this.grTim.TabStop = false;
            this.grTim.Text = "Tìm Kiếm";
            // 
            // rbtimTheoNgay
            // 
            this.rbtimTheoNgay.AutoSize = true;
            this.rbtimTheoNgay.Location = new System.Drawing.Point(28, 89);
            this.rbtimTheoNgay.Name = "rbtimTheoNgay";
            this.rbtimTheoNgay.Size = new System.Drawing.Size(98, 17);
            this.rbtimTheoNgay.TabIndex = 2;
            this.rbtimTheoNgay.TabStop = true;
            this.rbtimTheoNgay.Text = "Tìm Theo Ngày";
            this.rbtimTheoNgay.UseVisualStyleBackColor = true;
            // 
            // rbtimKiemTheoHD
            // 
            this.rbtimKiemTheoHD.AutoSize = true;
            this.rbtimKiemTheoHD.Location = new System.Drawing.Point(28, 53);
            this.rbtimKiemTheoHD.Name = "rbtimKiemTheoHD";
            this.rbtimKiemTheoHD.Size = new System.Drawing.Size(116, 17);
            this.rbtimKiemTheoHD.TabIndex = 1;
            this.rbtimKiemTheoHD.TabStop = true;
            this.rbtimKiemTheoHD.Text = "Tìm Theo Hóa Đơn";
            this.rbtimKiemTheoHD.UseVisualStyleBackColor = true;
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
            // FormPay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(814, 503);
            this.Controls.Add(this.btnhienThi);
            this.Controls.Add(this.btntimKiem);
            this.Controls.Add(this.txttimKiem);
            this.Controls.Add(this.grTim);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btnhienThiTatCa);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.txttienNap);
            this.Controls.Add(this.lbtienNap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnbank);
            this.Controls.Add(this.btnpayoocard);
            this.Controls.Add(this.btnpayooqr);
            this.Controls.Add(this.btnmomo);
            this.Controls.Add(this.btncash);
            this.Controls.Add(this.txttienDangCo);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbngayLap);
            this.Controls.Add(this.txtsoHoaDon);
            this.Controls.Add(this.dgvPay);
            this.Controls.Add(this.lbidCustomer);
            this.Controls.Add(this.lbsoHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPay";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FormPay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.grTim.ResumeLayout(false);
            this.grTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbsoHoaDon;
        private System.Windows.Forms.Label lbidCustomer;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.TextBox txtsoHoaDon;
        private System.Windows.Forms.Label lbngayLap;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txttienDangCo;
        private System.Windows.Forms.Button btncash;
        private System.Windows.Forms.Button btnmomo;
        private System.Windows.Forms.Button btnpayooqr;
        private System.Windows.Forms.Button btnpayoocard;
        private System.Windows.Forms.Button btnbank;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txttienNap;
        private System.Windows.Forms.Label lbtienNap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNap;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Button btnhienThiTatCa;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button btnhienThi;
        private System.Windows.Forms.Button btntimKiem;
        private System.Windows.Forms.TextBox txttimKiem;
        private System.Windows.Forms.GroupBox grTim;
        private System.Windows.Forms.RadioButton rbtimTheoNgay;
        private System.Windows.Forms.RadioButton rbtimKiemTheoHD;
        private System.Windows.Forms.RadioButton rbtimTheoMa;
    }
}