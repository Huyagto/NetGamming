using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLíTiệmNet
{
    [Serializable]
    public class Pay
    {
        private string soHoadon;
        private DateTime ngayLap;
        private string idCustomer;
        private double tienGio;
        private double tienNap;
        private string hinhThuc;
        public Pay()
        {

        }
        public Pay(string soHoadon, DateTime ngayLap, string idCustomer, double tienGio,double tienNap, string hinhThuc)
        {
            this.soHoadon = soHoadon;
            this.ngayLap = ngayLap;
            this.idCustomer = idCustomer;
            this.tienGio = tienGio;
            this.tienNap = tienNap;
            this.hinhThuc = hinhThuc;
           
        }
        public string SoHoaDon { get { return this.soHoadon; } set { this.soHoadon = value; } }
        public DateTime NgayLap { get { return this.ngayLap; } set { this.ngayLap = value; } }
        public string IDCustomer { get { return this.idCustomer; } set { this.idCustomer = value; } }
        public double TienGio { get { return this.tienGio; } set { this.tienGio= value; } }
        public double TienNap { get { return this.tienNap; } set { this .tienNap = value; } }
        public string HinhThuc { get { return this.hinhThuc; } set { this.hinhThuc = value; } }
        public double TinhTongTien()
        {
            return this.tienNap + this.tienGio;
        }
        public double TongTien
        {
            get { return this.TinhTongTien(); }
        }
    }
}
