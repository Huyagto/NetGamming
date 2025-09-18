using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLíTiệmNet
{
    [Serializable]
    class TaiKhoan
    {
        private string tenTaiKhoan;
        private string matKhau;
        public TaiKhoan() { }
        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.matKhau = matKhau;
        }
        public string TenTaiKhoan { get { return tenTaiKhoan; } set { tenTaiKhoan = value; } }
        public string MatKhau { get { return matKhau; } set { matKhau = value; } }
    }
}
