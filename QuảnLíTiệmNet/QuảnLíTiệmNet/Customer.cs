using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLíTiệmNet
{
    [Serializable]
    public class Customer
    {
        public string idCustomer;
        public string nameCustomer;
        public decimal dienThoai;
        public string diaChi;
        public string email;
        public DateTime ngaySinh;
        public DateTime thoiGianDK;
        public string trangThai;
        public string gioiTinh;
        public double tien;
        public string tenTK;
        public string mk;
        public Customer()
        {
            this.idCustomer = null;
            this.nameCustomer = null;
            this.dienThoai = 0;
            this.diaChi = null;
            this.email = null;
            this.ngaySinh = DateTime.Now;
            this.thoiGianDK = DateTime.Now;
            this.trangThai = null;
            this.gioiTinh =null;
            this.tien = 0;
            this.tenTK = null;
            this.mk = null;
           
        }
        public Customer(string idCustomer, string nameCustomer, decimal dienThoai, string diaChi, string email, DateTime ngaySinh, DateTime thoiGianDK, string trangThai,string gioiTinh, double tien, string tenTK, string mk)
      
        {
            this.idCustomer = idCustomer;
            this.nameCustomer = nameCustomer;
            this.dienThoai = dienThoai;
            this.diaChi = diaChi;
            this.email = email;
            this.ngaySinh = ngaySinh;
            this.thoiGianDK = thoiGianDK;
            this.trangThai = trangThai;
            this.gioiTinh=gioiTinh;
            this.tien=tien;
            this.tenTK = tenTK;
            this.mk = mk;
        }
        private double RemainingTime { get; set; } 

        public string IDCustomer
        {
            get { return this.idCustomer; }
            set { this.idCustomer = value; }
        }
        public string NameCustomer
        {
            get { return this.nameCustomer; }
            set { this.nameCustomer = value; }
        }
        public decimal DienThoai
        {
            get { return this.dienThoai; }
            set { this.dienThoai = value; }
        }
        public string DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public DateTime NgaySinh
        {
            get { return this.ngaySinh; }
            set { this.ngaySinh = value; }
        }
        public DateTime ThoiGianDK
        {
            get { return this.thoiGianDK; }
            set { this.thoiGianDK = value;}
        }
        public string TrangThai
        {
            get { return this.trangThai; }
            set { this.trangThai = value; }
        }
        public string GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public double Tien
        {
            get { return Math.Round(this.tien, 0); } 
            set { this.tien = value; }
        }

        public string TenTK
        {
            get { return this.tenTK; }
            set { this.tenTK = value; }
        }
        public string MK
        {
            get { return this.mk; }
            set { this.mk = value; }
        }
     
        public double TinhTienGio()
        {
            return this.tien ;
        }
        public string TachTen()
        {
            string ten = null;
            int viTriKhoangTrangCuoi = this.nameCustomer.Trim().LastIndexOf(" ");
            ten = this.nameCustomer.Substring(viTriKhoangTrangCuoi + 1);
            return ten;
        }
    }
}
