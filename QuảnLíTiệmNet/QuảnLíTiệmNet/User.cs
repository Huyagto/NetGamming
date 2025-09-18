using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLíTiệmNet
{
    [Serializable]
    class User
    {
        private string idMay;
        private string tenKhach;
        private double giaMay;
        private double soGioConLai;
        public User() { }
        public User(string idMay, string tenKhach,double giaMay, double soGioConLai)
        {
            this.idMay = idMay;
            this.tenKhach = tenKhach;
            this.giaMay = giaMay;
            this.soGioConLai = soGioConLai;
        }
        public string IdMay { get { return this.idMay; } set { this.idMay = value; } }
        public string TenKhach { get { return this.tenKhach; }set{ this.tenKhach = value; }}
        public double GiaMay { get {return this.giaMay; }set{this.giaMay = value; } }
        public double SoGioConLai { get { return this.soGioConLai; } set { this.soGioConLai = value; } }
    }
}
