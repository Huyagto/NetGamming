using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLíTiệmNet
{
    [Serializable]
    class Service 
    {
        private string idCustomer;
        private MenuMons menuMons;
        private double tienCustomer;
        private int soLuong;
        private string trangThai;
        public Service() {
            this.idCustomer = null;
            this.menuMons = null;
            this.soLuong = 0;
            this.tienCustomer = 0;
            this.trangThai = "Chưa Hoàn Thành";
        }
        public Service(string idCustomer, MenuMons menuMons, double tienCustomer, int soLuong, string trangThai)
        {
            this.idCustomer = idCustomer;
            this.menuMons = menuMons;
            this.soLuong= soLuong;
            this.tienCustomer = tienCustomer;
            this.trangThai = trangThai;
        }
        public string IDCustomer {  get { return this.idCustomer; } set { this.idCustomer = value; } }
        public string IDMon { get { return this.menuMons.idMon; } }
        public double DonGia { get { return this.menuMons.donGia; } }
        public int SoLuong {  get { return this.soLuong;} set { this.soLuong = value; } }
        public double TinhTongTienDichVu()
        {
            return  this.menuMons.donGia * soLuong;
        }
        public double TongTienDichVu
        {
            get { return this.TinhTongTienDichVu(); }
        }
        public double TongTienThanhToan()
        {
            return this.tienCustomer - this.TinhTongTienDichVu();  
        }
        public double TienCustomer { get { return this.tienCustomer; } set { this.tienCustomer = value; } }
        public double TongTien
        {
            get { return TongTienThanhToan(); }
        }
        public string TrangThai { get { return this.trangThai; } set { this.trangThai = value; } }
       
    }
}
