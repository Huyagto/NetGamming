using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLíTiệmNet
{
    [Serializable]
    class TaiKhoanManagement
    {
        private List<TaiKhoan> taiKhoan;
        public TaiKhoanManagement()
        {
            taiKhoan = new List<TaiKhoan>();
            DataSource datasource = DataSource.Init();
            this.taiKhoan = datasource.GetTaiKhoans();
        }
        public TaiKhoanManagement(List<TaiKhoan> taiKhoan)
        {
            this.taiKhoan = taiKhoan;
        }

        public List<TaiKhoan> GetTaiKhoans()
        {
            return taiKhoan;
        }
        public string TimTentk(string tentk)
        {
            foreach (TaiKhoan tk in taiKhoan )
            {
                if (tk.TenTaiKhoan == tentk ) { return tk.TenTaiKhoan ; }
            }
            return null;
        }
        public string TimMK(string mk)
        {
            foreach (TaiKhoan tk in taiKhoan)
            {
                if (tk.MatKhau  == mk){ return tk.MatKhau; }
            }
            return null;
        }
    }
}
