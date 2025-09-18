    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    public partial class FormService : Form
    {
        private MenuMonManagement menuMon;
        private ServiceManagement serviceManagement;
        private CustomerManagerment customerManagerment;
        public FormService(Customer customer = null)
        {
            string filePathCustomer = GetFilePathInTepFileCustomer();
            string filePathMenu = GetFilePathInTepFileMenu();
            string filePathService = GetFilePathInTepFileService();
            List<Customer> customers = DataSource.ReadCustomersFromFile(filePathCustomer);
            List<MenuMons> menuMons = DataSource.ReadMenuMonsFromFile(filePathMenu);
            List<Service> services = DataSource.ReadServicesFromFile(filePathService, menuMons);
            InitializeComponent();
            serviceManagement = new ServiceManagement(services);
            customerManagerment = new CustomerManagerment(customers);
            if (customer != null)
            {
                lbCustomer.Text = customer.IDCustomer;
                cboCustomer.Visible = true;
                btnhoanThanh.Visible = false;
                List<Service> dskq = new List<Service>();
                dskq = serviceManagement.TimMa(customer.IDCustomer);
                if (dskq != null)
                {
                    HienThiDanhSachService(dgvService2, dskq);
                }
                List<Customer> list = customerManagerment.TimTheoMa(customer.IDCustomer);
                if(list != null)
                {
                    HienThiComboBoxNguoiDung(cboCustomer, list);

                }
            }
            else
            {
                lbCustomer.Visible = false;
                cboCustomer.Visible = true;
                btnxacNhan.Visible = false;
                HienThiComboBoxNguoiDung(cboCustomer, customerManagerment.GetCustomers());
            }
        }
        private string GetFilePathInTepFileService()
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string tepFileDirectory = Path.Combine(projectDirectory, "TepFile");
            if (!Directory.Exists(tepFileDirectory))
            {
                Directory.CreateDirectory(tepFileDirectory);
            }
            return Path.Combine(tepFileDirectory, "Service.txt");
        }
        private string GetFilePathInTepFileMenu()
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string tepFileDirectory = Path.Combine(projectDirectory, "TepFile");
            if (!Directory.Exists(tepFileDirectory))
            {
                Directory.CreateDirectory(tepFileDirectory);
            }
            return Path.Combine(tepFileDirectory, "Menu.txt");
        }
        private string GetFilePathInTepFileCustomer()
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string tepFileDirectory = Path.Combine(projectDirectory, "TepFile");
            if (!Directory.Exists(tepFileDirectory))
            {
                Directory.CreateDirectory(tepFileDirectory);
            }
            return Path.Combine(tepFileDirectory, "Customer.txt");
        }
        private void HienThiDanhSachMenu(DataGridView dgv, List<MenuMons> ds)
        {
            dgv.DataSource = null;
            dgv.DataSource = ds;
            dgv.Refresh();
        }
        private void HienThiDanhSachService(DataGridView dgv, List<Service> ds)
        {
            dgv.DataSource = null;
            dgv.DataSource = ds;
            dgv.Refresh();
        }
        private void HienThiComboBoxNguoiDung(ComboBox cbo, List<Customer> ds)
        {

            cbo.DisplayMember = "idCustomer";
            cbo.ValueMember = "nameCustomer";
            cbo.DataSource = ds;
        }
        private void HienThiComboBox(ComboBox cbo, List<string> ds)
        {
            cbo.DataSource = null;
            cbo.DataSource = ds;
        }

        private void cbotenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MenuMons> list = DataSource.ReadMenuMonsFromFile("Menu.txt");
            list = menuMon.TimMonTheoLoai(cbotenLoai.Text);
            HienThiDanhSachMenu(dgvService, list);
           

        }
        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiDanhSachService(dgvService2, serviceManagement.TimMa(cboCustomer.Text));
        }
        private void FormService_Load(object sender, EventArgs e)
        {
            string filePathCustomer =GetFilePathInTepFileCustomer();
            string filePathMenu = GetFilePathInTepFileMenu();
            string filePathService = GetFilePathInTepFileService();
            List<Customer> customers = DataSource.ReadCustomersFromFile(filePathCustomer);
            List<MenuMons> menuMons = DataSource.ReadMenuMonsFromFile(filePathMenu);
            List<Service> services = DataSource.ReadServicesFromFile(filePathService, menuMons);
            try
            {
                menuMon = new MenuMonManagement(menuMons);
                serviceManagement = new ServiceManagement(services);
                customerManagerment = new CustomerManagerment(customers);
                var menuData = menuMon.GetMenuMons();
                var serviceData = serviceManagement.GetServices();
                if (menuData == null || menuData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong danh sách món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    HienThiDanhSachMenu(dgvService, menuData);
                }

                if (serviceData == null || serviceData.Count == 0)
                {
                    MessageBox.Show("Không có dịch vụ nào để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    HienThiDanhSachService(dgvService2, serviceData);
                }
                HienThiComboBox(cbotenLoai, menuMon.GetUniqueLoaiMons());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private MenuMons monDangChon = null;
        private int viTri = -1;
        private void btnChon_Click(object sender, EventArgs e)
        {
            string filePathCustomer = GetFilePathInTepFileCustomer();
            string filePathService = GetFilePathInTepFileService();
            string trangThai = "Chưa Hoàn Thành";
            int soLuong = int.Parse(txtsoLuong.Text);
            Customer customer = customerManagerment.TimKhachHangTheoMa(cboCustomer.Text);
            double Tien = customer.tien;
            Service service = new Service(cboCustomer.Text, monDangChon, Tien, soLuong, trangThai);
            if (service.TongTien < 0)
            {
                MessageBox.Show("Bạn Không Đủ Tiền Vui Lòng Nạp Thêm ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                serviceManagement.addService(service);
                HienThiDanhSachService(dgvService2, serviceManagement.GetServices());
                List<Customer> customers = DataSource.ReadCustomersFromFile(filePathCustomer);
                Customer customerToUpdate = customers.FirstOrDefault(c => c.idCustomer == customer.idCustomer);
                if (customerToUpdate != null)
                {
                    customerToUpdate.tien =service.TongTien;
                }
                DataSource.WriteCustomersToFile(filePathCustomer, customers);
            }
            DataSource.WriteServicesToFile(filePathService, serviceManagement.GetServices());
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                viTri = e.RowIndex;
                DataGridViewRow row = new DataGridViewRow();
                row = dgvService.CurrentRow;
                string idMon = row.Cells[0].Value.ToString();
                if(idMon == null)
                {
                    MessageBox.Show("Hàng được chọn không hợp lệ hoặc không chứa dữ liệu.");
                    return;
                }
                monDangChon = menuMon.TimMonTheoMa(idMon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chọn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Service srchon = null;
        private void dgvService2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    viTri2 = e.RowIndex;
                    DataGridViewRow row = dgvService2.Rows[viTri2];

                    if (row.Cells[0].Value == null)
                    {
                        MessageBox.Show("Hàng được chọn không hợp lệ hoặc không chứa dữ liệu.");
                        return;
                    }

                    string IDCustomer = row.Cells[0].Value.ToString();
                    srchon = serviceManagement.Tim(IDCustomer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi chọn dịch vụ: {ex.Message}");
            }
        }


        private void btnhoanThanh_Click(object sender, EventArgs e)
        {
            try
            {
                if (viTri2 >= 0) 
                {
                    var selectedService = serviceManagement.GetServices()[viTri2];

                    if (selectedService != null)
                    {
                        selectedService.TrangThai = "Hoàn Thành";
                        dgvService2.DataSource = serviceManagement.GetServices();
                        DataSource.WriteServicesToFile("Service.txt", serviceManagement.GetServices());
                        MessageBox.Show("Đã Hoàn Thành!","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dịch vụ để hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int viTri2 = -1;
        private void btnxacNhan_Click(object sender, EventArgs e)
        {
            string filePathService = GetFilePathInTepFileService();
            DialogResult ketqua = MessageBox.Show("Bạn Muốn Xác Nhận?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketqua == DialogResult.Yes)
            {
                DataSource.WriteServicesToFile(filePathService, serviceManagement.GetServices());
            }
        }

      
    }
}
