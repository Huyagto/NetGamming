using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    [Serializable]
    class CustomerManagerment
    {
        private List<Customer> listcustomer = new List<Customer>();

        public CustomerManagerment()
        {
            DataSource dataSource = DataSource.Init();
            this.listcustomer = dataSource.GetCustomers();
        }
        public CustomerManagerment(List<Customer> listcustomer)
        {
            this.listcustomer = listcustomer;
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

        public bool sameCustomer(string id)
        {

            foreach (Customer customer in listcustomer)
            {
                if (customer.IDCustomer.Equals(id))
                {
                   
                    return false;
                }
            }
            return true;
        }
        public void addCustomer(Customer customer)
        {
            if (sameCustomer(customer.IDCustomer))
            {
                listcustomer.Add(customer);
                MessageBox.Show("Đã Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Tổng số khách hàng: " + listcustomer.Count());
            }
            else {
                 MessageBox.Show("ID Trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
            }
        }
        public Customer Find(string id)
        {
            foreach (Customer customer in listcustomer)
                if (customer.IDCustomer.Equals(id))
                {
                    return customer;
                }
            return null;
        }
        public void removeCustomer(string id)
        {
            foreach (Customer customer in listcustomer)
            {
                if (customer.IDCustomer.Equals(id))
                {
                    listcustomer.Remove(customer);
                    MessageBox.Show("Đã Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
        public void repairCustomer(Customer customer)
        {
            Customer result = Find(customer.IDCustomer);
            if (result != null)
            {
                result.NameCustomer = customer.NameCustomer;
                result.DienThoai = customer.DienThoai;
                result.DiaChi = customer.DiaChi;
                result.Email = customer.Email;
                result.NgaySinh = customer.NgaySinh;
                result.ThoiGianDK = customer.ThoiGianDK;
                result.TrangThai = customer.TrangThai;
                result.Tien = customer.Tien;
                result.TenTK = customer.TenTK;
                result.MK = customer.MK;
                MessageBox.Show("Đã Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public string GetSelectedValue(params RadioButton[] radioButtons)
        {
            foreach (var rb in radioButtons)
            {
                if (rb.Checked)
                {
                    return rb.Text; 
                }
            }
            return "Chưa có lựa chọn."; 
        }
        public List<Customer> TimTheoMa(string ma)
        {
            List<Customer> dsTim = new List<Customer>();
            foreach (Customer c in listcustomer)
            {
                if (c.IDCustomer.Trim().Equals(ma.Trim(), StringComparison.OrdinalIgnoreCase)) { dsTim.Add(c); }
            }
            return dsTim;
        }
        public List<Customer> TimTheoTen(string ten)
        {
            List<Customer> dsTim = new List<Customer>();
            foreach (Customer c in listcustomer)
            {
                if (c.TachTen().Trim().Equals(ten.Trim(), StringComparison.OrdinalIgnoreCase)) { dsTim.Add(c); }
            }
            return dsTim;
        }
        public List<Customer> TimTheoDienThoai(decimal dienThoai)
        {
            List<Customer> dsTim = new List<Customer>();
            foreach (Customer c in listcustomer)
            {
                if (c.DienThoai.Equals(dienThoai)) { dsTim.Add(c); }
            }
            return dsTim;
        }
        public List<Customer> TimTheoSoGio(double soTien)
        {
            List<Customer> dsTim = new List<Customer>();
            foreach (Customer c in listcustomer)
            {
                if (c.Tien.Equals(soTien)) { dsTim.Add(c); }
            }
            return dsTim;
        }
        public Customer Authenticate(string username, string password)
        {
            foreach (Customer customer in listcustomer)
            {
                Console.WriteLine($"Checking: {customer.TenTK} vs {username}, {customer.MK} vs {password}");

                if (customer.TenTK.Equals(username, StringComparison.OrdinalIgnoreCase)
                    && customer.MK == password)
                {
                    return customer;
                }
            }
            return null;
        }
        public Customer TimKhachHangTheoMa(string id)
        {
            foreach (Customer cs in listcustomer)
            {
                if (cs.IDCustomer.Equals(id))
                {
                    return cs;
                }
            }
            return null;
        }
        public void CapNhatGio(string id, double tien)
        {

            foreach (Customer customer in listcustomer)
            {
                if (customer.IDCustomer.Equals(id))
                {
                    customer.Tien += tien;
                }
            }

        }
        public void CapNhatTienDichVu(string id, double tien)
        {
            foreach (Customer customer in listcustomer)
            {
                if (customer.IDCustomer.Equals(id))
                {
                    customer.Tien = tien;
                }
            }
        }
        public Customer TimKhachHangTheoTenTK(string id)
        {
            foreach(Customer customer in listcustomer)
            {
                if (customer.tenTK.Equals(id))
                {
                    return customer;
                }
            }
            return null;
        }
        public Customer TimKhachHangTheoMK(string id)
        {
            foreach( Customer customer in listcustomer)
            {
                if (customer.MK.Equals(id))
                {
                    return customer;
                }
            }
            return null;
        }
    }
}
