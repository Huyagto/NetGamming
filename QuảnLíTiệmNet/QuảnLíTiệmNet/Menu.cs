using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLíTiệmNet
{
    [Serializable]
    class MenuMons
    {
        public string idMon;
        public string tenMon;
        public string donViTinh;
        public double donGia;
        public string loai;
        public MenuMons() { }
        public MenuMons(string idMon, string tenMon, string donViTinh, double donGia, string loai)
        {
            this.idMon = idMon;
            this.tenMon = tenMon;
            this.donViTinh = donViTinh;
            this.donGia = donGia;
            this.loai = loai;
        }
        public string IDMon { get { return this.idMon; } set { this.idMon = value; } } 
        public string TenMon { get {return this.tenMon; } set {this.tenMon = value; } }   
        public string DonViTinh { get { return this.donViTinh; } set { this.donViTinh = value; } }
        public double DonGia { get { return this.donGia; } set { this.donGia = value; } }
        public string Loai { get { return this.loai; } set { this.loai = value; } }
    }
}
