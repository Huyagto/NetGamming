using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    [Serializable]
    class PayManagement
    {
        private List<Pay> listPay = new List<Pay>();
        private List<Customer> listcustomer = new List<Customer>();
        public PayManagement() { 
            DataSource dataSource = DataSource.Init();
            this.listPay = dataSource.GetPays();
            this.listcustomer = dataSource.GetCustomers();
        }
        public PayManagement(List<Pay> listPay)
        {
            this.listPay = listPay;
        }
        public List<Pay> GetPays() {
            if (this.listPay == null)
            {
                MessageBox.Show("Danh sách thanh toán chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Pay>();
            }
            return listPay;
        }
        public List<Customer> GetCustomers()
        {
            if (this.listcustomer == null)
            {
                MessageBox.Show("Danh sách khách hàng chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Customer>();
            }
            return listcustomer;
        }
        public bool samePay(string id)
        {

            foreach (Pay pay in listPay)
            {
                if (pay.SoHoaDon.Equals(id))
                {
                    MessageBox.Show("ID Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public void AddPay(Pay pay)
        {
            if (samePay(pay.SoHoaDon))
                this.listPay.Add(pay);
        }
        public double TinhTienGio(string ma)
        {
            foreach (Customer cs in this.listcustomer)
            {
                if(cs.IDCustomer == ma)
                {
                    return cs.TinhTienGio();
                }
            }
            return 0;
        }
        public List<Pay> TimMa(string ma)
        {
            List<Pay> list = new List<Pay>();
            foreach(Pay pay in listPay)
            {
                if (pay.IDCustomer.Normalize(NormalizationForm.FormC).Equals(ma))
                {
                    list.Add(pay);
                }
            }
            return list;
        }
        public List<Pay> TimTheoHD(string ma)
        {
            List<Pay> list = new List<Pay>();
            foreach (Pay pay in listPay)
            {
                if (pay.SoHoaDon.Normalize(NormalizationForm.FormC).Equals(ma))
                {
                    list.Add(pay);
                }
            }
            return list;
        }
        public List<Pay> TimTheoNgay(DateTime time)
        {
            List<Pay> list = new List<Pay>();
            foreach (Pay pay in listPay)
            {
                if (pay.NgayLap.Equals(time))
                {
                    list.Add(pay);
                }
            }
            return list;
        }
    }
}
