using System.Drawing;

namespace QuảnLíTiệmNet
{
    partial class FormService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormService));
            this.lbidCustomer = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.idMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbotenLoai = new System.Windows.Forms.ComboBox();
            this.lbloaiMon = new System.Windows.Forms.Label();
            this.lbsoLuong = new System.Windows.Forms.Label();
            this.txtsoLuong = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.dgvService2 = new System.Windows.Forms.DataGridView();
            this.lbCustomer = new System.Windows.Forms.Label();
            this.btnxacNhan = new System.Windows.Forms.Button();
            this.btnhoanThanh = new System.Windows.Forms.Button();
            this.IDCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meumon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbidCustomer
            // 
            this.lbidCustomer.AutoSize = true;
            this.lbidCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbidCustomer.Location = new System.Drawing.Point(12, 20);
            this.lbidCustomer.Name = "lbidCustomer";
            this.lbidCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.lbidCustomer.Size = new System.Drawing.Size(114, 29);
            this.lbidCustomer.TabIndex = 27;
            this.lbidCustomer.Text = "ID Customer";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(195, 22);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(121, 21);
            this.cboCustomer.TabIndex = 43;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // dgvService
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMon,
            this.tenMon,
            this.donViTinh,
            this.donGia});
            this.dgvService.EnableHeadersVisualStyles = false;
            this.dgvService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvService.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvService.Location = new System.Drawing.Point(193, 70);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(445, 150);
            this.dgvService.TabIndex = 44;
            this.dgvService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellClick);
            // 
            // idMon
            // 
            this.idMon.DataPropertyName = "idMon";
            this.idMon.HeaderText = "Mã Món";
            this.idMon.Name = "idMon";
            // 
            // tenMon
            // 
            this.tenMon.DataPropertyName = "tenMon";
            this.tenMon.HeaderText = "Tên Món";
            this.tenMon.Name = "tenMon";
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            this.donViTinh.HeaderText = "Đơn Vị Tính";
            this.donViTinh.Name = "donViTinh";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.Name = "donGia";
            // 
            // cbotenLoai
            // 
            this.cbotenLoai.FormattingEnabled = true;
            this.cbotenLoai.Location = new System.Drawing.Point(684, 20);
            this.cbotenLoai.Name = "cbotenLoai";
            this.cbotenLoai.Size = new System.Drawing.Size(121, 21);
            this.cbotenLoai.TabIndex = 46;
            this.cbotenLoai.SelectedIndexChanged += new System.EventHandler(this.cbotenLoai_SelectedIndexChanged);
            // 
            // lbloaiMon
            // 
            this.lbloaiMon.AutoSize = true;
            this.lbloaiMon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbloaiMon.Location = new System.Drawing.Point(564, 19);
            this.lbloaiMon.Name = "lbloaiMon";
            this.lbloaiMon.Padding = new System.Windows.Forms.Padding(5);
            this.lbloaiMon.Size = new System.Drawing.Size(89, 29);
            this.lbloaiMon.TabIndex = 45;
            this.lbloaiMon.Text = "Loại Món";
            // 
            // lbsoLuong
            // 
            this.lbsoLuong.AutoSize = true;
            this.lbsoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbsoLuong.Location = new System.Drawing.Point(239, 251);
            this.lbsoLuong.Name = "lbsoLuong";
            this.lbsoLuong.Padding = new System.Windows.Forms.Padding(5);
            this.lbsoLuong.Size = new System.Drawing.Size(97, 29);
            this.lbsoLuong.TabIndex = 47;
            this.lbsoLuong.Text = "Số Lượng";
            // 
            // txtsoLuong
            // 
            this.txtsoLuong.Location = new System.Drawing.Point(358, 252);
            this.txtsoLuong.Name = "txtsoLuong";
            this.txtsoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtsoLuong.TabIndex = 48;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnChon.Location = new System.Drawing.Point(502, 249);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 49;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // dgvService2
            // 
            this.dgvService2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvService2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvService2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvService2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCustomer,
            this.meumon,
            this.SoLuong,
            this.gia,
            this.TongTienDichVu,
            this.Tien,
            this.TongTien,
            this.trangThai});
            this.dgvService2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dgvService2.Location = new System.Drawing.Point(12, 309);
            this.dgvService2.Name = "dgvService2";
            this.dgvService2.Size = new System.Drawing.Size(847, 150);
            this.dgvService2.TabIndex = 50;
            this.dgvService2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService2_CellClick);
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomer.Location = new System.Drawing.Point(132, 23);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(57, 20);
            this.lbCustomer.TabIndex = 51;
            this.lbCustomer.Text = "label1";
            // 
            // btnxacNhan
            // 
            this.btnxacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnxacNhan.Location = new System.Drawing.Point(12, 491);
            this.btnxacNhan.Name = "btnxacNhan";
            this.btnxacNhan.Size = new System.Drawing.Size(95, 39);
            this.btnxacNhan.TabIndex = 52;
            this.btnxacNhan.Text = "Xác Nhận";
            this.btnxacNhan.UseVisualStyleBackColor = false;
            this.btnxacNhan.Click += new System.EventHandler(this.btnxacNhan_Click);
            // 
            // btnhoanThanh
            // 
            this.btnhoanThanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.btnhoanThanh.Location = new System.Drawing.Point(756, 491);
            this.btnhoanThanh.Name = "btnhoanThanh";
            this.btnhoanThanh.Size = new System.Drawing.Size(103, 39);
            this.btnhoanThanh.TabIndex = 53;
            this.btnhoanThanh.Text = "Hoàn Thành";
            this.btnhoanThanh.UseVisualStyleBackColor = false;
            this.btnhoanThanh.Click += new System.EventHandler(this.btnhoanThanh_Click);
            // 
            // IDCustomer
            // 
            this.IDCustomer.DataPropertyName = "IDCustomer";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IDCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            this.IDCustomer.HeaderText = "IDCustomer";
            this.IDCustomer.Name = "IDCustomer";
            // 
            // meumon
            // 
            this.meumon.DataPropertyName = "IDMon";
            this.meumon.HeaderText = "ID Món";
            this.meumon.Name = "meumon";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "DonGia";
            this.gia.HeaderText = "Đơn Giá";
            this.gia.Name = "gia";
            // 
            // TongTienDichVu
            // 
            this.TongTienDichVu.DataPropertyName = "TongTienDichVu";
            this.TongTienDichVu.HeaderText = "Tổng Tiền Dịch Vụ";
            this.TongTienDichVu.Name = "TongTienDichVu";
            // 
            // Tien
            // 
            this.Tien.DataPropertyName = "TienCustomer";
            this.Tien.HeaderText = "Số Tiền Hiện Có";
            this.Tien.Name = "Tien";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Số Tiền Còn Lại";
            this.TongTien.Name = "TongTien";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "TrangThai";
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.Name = "trangThai";
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(979, 601);
            this.Controls.Add(this.btnhoanThanh);
            this.Controls.Add(this.btnxacNhan);
            this.Controls.Add(this.lbCustomer);
            this.Controls.Add(this.dgvService2);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.txtsoLuong);
            this.Controls.Add(this.lbsoLuong);
            this.Controls.Add(this.cbotenLoai);
            this.Controls.Add(this.lbloaiMon);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.lbidCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormService";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbidCustomer;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.ComboBox cbotenLoai;
        private System.Windows.Forms.Label lbloaiMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.Label lbsoLuong;
        private System.Windows.Forms.TextBox txtsoLuong;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridView dgvService2;
        private System.Windows.Forms.Label lbCustomer;
        private System.Windows.Forms.Button btnxacNhan;
        private System.Windows.Forms.Button btnhoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn meumon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}