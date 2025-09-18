using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    public partial class FormCustomer : Form
    {
        private CustomerManagerment customerManagerment;
        private int IDCustomerNumber;
        public FormCustomer(Customer customer = null)
        {
            InitializeComponent();
            if (customer != null)
            {
                txtidCustomer.ReadOnly = true;
                txtnameCustomer.ReadOnly = true;
                txtdiaChi.ReadOnly = true;
                txtemail.ReadOnly = true;
                txtdienThoai.ReadOnly = true;
                dtngaySinh.Enabled = false;
                dtthoiGianDK.Enabled = false;
                grgioiTinh.Enabled = false;
                grtrangThai.Enabled = false;
                grTim.Visible = false;
                dgvCustomer.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
                btntimKiem.Visible = false;
                txttimKiem.Visible = false;
                btnthanhToan.Visible = false;
                txtidCustomer.Text = customer.IDCustomer;
                txtnameCustomer.Text = customer.NameCustomer;
                txtdiaChi.Text = customer.DiaChi;
                txtdienThoai.Text = customer.DienThoai.ToString();
                txtemail.Text = customer.Email;
                dtngaySinh.Value = customer.NgaySinh;
                dtthoiGianDK.Value = customer.ThoiGianDK;
                txtTenTaiKhoan.ReadOnly = true;
                txtTenTaiKhoan.Text = customer.TenTK;
                if (customer.TrangThai == "Thường") { rbthuong.Checked = true; } else { rbVIP.Checked = true; }
                if (customer.GioiTinh == "Nữ") { rbnu.Checked = true; } else { rbnam.Checked = true; }
                txtsoGio.ReadOnly = true;
                btnluu.Visible = true;
            }
        }
        private string GetFilePathInTepFile()
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string tepFileDirectory = Path.Combine(projectDirectory, "TepFile");
            if (!Directory.Exists(tepFileDirectory))
            {
                Directory.CreateDirectory(tepFileDirectory);
            }
            return Path.Combine(tepFileDirectory, "Customer.txt");
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();   
            List<Customer> customers = DataSource.ReadCustomersFromFile(filePath);
            customerManagerment = new CustomerManagerment(customers);
            PopulateDataGrid(dgvCustomer, customerManagerment.GetCustomers());
            List<Customer> customer = customerManagerment.GetCustomers();
            if(customer.Count > 0)
            
                {
                IDCustomerNumber = customer.Max(p => int.Parse(p.idCustomer.Substring(2))) + 1;
                }
            else
                {
                IDCustomerNumber = 1;
                }
        }
        private void PopulateDataGrid(DataGridView dgv, List<Customer> customer)
        {
            dgv.DataSource = null;
            dgv.DataSource = customer;

            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Khách Hàng Chưa Được Thêm Hoặc Rỗng!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgv.Refresh();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            if (string.IsNullOrEmpty(txtidCustomer.Text))
            {
                MessageBox.Show("ID không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text)||string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Tài Khoản & Mật Khẩu không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string idCustomer = $"ID{IDCustomerNumber:D3}";
            Customer customer = new Customer(
               idCustomer,
                txtnameCustomer.Text,
                decimal.Parse(txtdienThoai.Text),
                txtdiaChi.Text,
                txtemail.Text,
                dtngaySinh.Value,
                dtthoiGianDK.Value,
                customerManagerment.GetSelectedValue(rbthuong, rbVIP),
                customerManagerment.GetSelectedValue(rbnu, rbnam),
                double.Parse(txtsoGio.Text),
                txtTenTaiKhoan.Text, 
                txtMatKhau.Text
            );
            customerManagerment.addCustomer(customer);
            PopulateDataGrid(dgvCustomer, customerManagerment.GetCustomers());
            IDCustomerNumber++;
            txtidCustomer.Text = $"ID{IDCustomerNumber:D3}";
            DataSource.WriteCustomersToFile(filePath, customerManagerment.GetCustomers());
        }
        private void btntimKiem_Click(object sender, EventArgs e)
        {
            List<Customer> dsketqua = new List<Customer>();
            string ketqua = null;
            if (rbtimTheoMa.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = customerManagerment.TimTheoMa(ketqua);
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvCustomer, dsketqua);
            }
            else if (rbtimTheoTen.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = customerManagerment.TimTheoTen(ketqua);
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvCustomer, dsketqua);
            }
            else if (rbtimTheoDienThoai.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = customerManagerment.TimTheoDienThoai(decimal.Parse(ketqua));
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvCustomer, dsketqua);
            }  
            else MessageBox.Show("Bạn Chưa Chọn Phương Thức Tìm Kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnhienThiTatCa.Visible = true;
        }
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvCustomer.Rows.Count)
            {
                return;
            }
            DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
            txtidCustomer.Text = row.Cells["idCustomer"]?.Value?.ToString() ?? "";
            txtnameCustomer.Text = row.Cells["nameCustomer"]?.Value?.ToString() ?? "";
            txtdienThoai.Text = row.Cells["dienThoai"]?.Value?.ToString() ?? "";
            txtdiaChi.Text = row.Cells["diaChi"]?.Value?.ToString() ?? "";
            txtemail.Text = row.Cells["email"]?.Value?.ToString() ?? "";
            dtngaySinh.Value = row.Cells["ngaySinh"]?.Value != null
                ? Convert.ToDateTime(row.Cells["ngaySinh"].Value)
                : DateTime.Now;
            dtthoiGianDK.Value = row.Cells["thoiGianDK"]?.Value != null
                ? Convert.ToDateTime(row.Cells["thoiGianDK"].Value)
                : DateTime.Now;
            string trangThai = row.Cells["trangThai"]?.Value?.ToString()?.Trim() ?? "";
            trangThai = trangThai.Normalize(NormalizationForm.FormC);
            rbthuong.Checked = false; 
            rbVIP.Checked = false;

            if (trangThai == "Thường")
            {
                rbthuong.Checked = true;
            }
            else if (trangThai == "VIP")
            {
                rbVIP.Checked = true;
            }
            string gioiTinh = row.Cells["gioiTinh"]?.Value?.ToString() ?? "";
            gioiTinh = gioiTinh.Normalize(NormalizationForm.FormC);
            rbnam.Checked = gioiTinh == "Nam";
            rbnu.Checked = gioiTinh == "Nữ";
            txtsoGio.Text = row.Cells[9]?.Value?.ToString() ?? "";
            txtTenTaiKhoan.Text = row.Cells[10]?.Value?.ToString() ?? "";
            txtMatKhau.Text = row.Cells[11]?.Value?.ToString() ?? "";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            if (string.IsNullOrEmpty(txtidCustomer.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Customer updatedCustomer = new Customer(
                txtidCustomer.Text,
                txtnameCustomer.Text,
                decimal.Parse(txtdienThoai.Text),
                txtdiaChi.Text,
                txtemail.Text,
                dtngaySinh.Value,
                dtthoiGianDK.Value,
                customerManagerment.GetSelectedValue(rbthuong, rbVIP),
                customerManagerment.GetSelectedValue(rbnu, rbnam),
                double.Parse(txtsoGio.Text), txtTenTaiKhoan.Text, 
                txtMatKhau.Text
            );
            customerManagerment.repairCustomer(updatedCustomer);
            PopulateDataGrid(dgvCustomer, customerManagerment.GetCustomers());
            DataSource.WriteCustomersToFile(filePath, customerManagerment.GetCustomers());
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            if (string.IsNullOrEmpty(txtidCustomer.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa khách hàng này?",
                "Xác Nhận Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                customerManagerment.removeCustomer(txtidCustomer.Text);
                PopulateDataGrid(dgvCustomer, customerManagerment.GetCustomers());
                DataSource.WriteCustomersToFile("Customer.txt", customerManagerment.GetCustomers());
            }
        }
        private void btnthanhToan_Click(object sender, EventArgs e)
        {
            Customer customer = customerManagerment.TimKhachHangTheoMa(txtidCustomer.Text);
            FormPay formPay = new FormPay(customer);
            formPay.ShowDialog();
            this.Hide();
        }
        private void btnhienThiTatCa_Click(object sender, EventArgs e)
        {
            PopulateDataGrid(dgvCustomer,customerManagerment.GetCustomers());
            btnhienThiTatCa.Visible = false;
        }
    }
}
