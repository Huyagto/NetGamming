using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    [Serializable]
    class ServiceManagement
    {
        private List<Service> listservice = new List<Service>();
        private List<Customer> customerlist = new List<Customer>();
        private List<MenuMons> MenuMons = new List<MenuMons>();
        public ServiceManagement() {
            DataSource data = DataSource.Init();
            this.listservice = data.GetServices();
            this.MenuMons = data.GetMenuMons();
            this.customerlist = data.GetCustomers();
        }
        public ServiceManagement(List<Service> listservice)
        {
            this.listservice = listservice;
        }
        public List<Service> GetServices()
        {
            if (this.listservice == null)
            {
                MessageBox.Show("Danh sách dịch vụ chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Service>();
            }
            return new List<Service>(this.listservice);
        }
        public List<Customer> GetCustomers()
        {
            {
                if (this.customerlist == null)
                {
                    MessageBox.Show("Danh sách dịch vụ chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Customer>();
                }
            }
            return customerlist;
        }
                public List<MenuMons> GetMenuMons()
        {
            if (MenuMons == null)
            {
                MessageBox.Show("Danh sách dịch vụ chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<MenuMons>();
            }
            return MenuMons;
        }
        public void addService(Service service)
        {
            
            this.listservice.Add(service);
            MessageBox.Show("Đã thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Service Tim(string ma)
        {
            foreach (Service service in this.listservice)
            {
                if (service.IDCustomer.Equals(ma))
                    return service;
            }
            return null;
        }
        public void repair(Service service)
        {
            Service kq = Tim(service.IDCustomer);
            if (kq!=null)
            {
                kq.TrangThai = service.TrangThai;
                
            }
        }
        public List<Service> TimMa(string ma)
        {
            List<Service> dsTim = new List<Service>();
            foreach(Service service in this.listservice)
            {
                if (service.IDCustomer.Equals(ma))
                {
                    dsTim.Add(service);
                }
            }
            return dsTim;
        }
    }
}
