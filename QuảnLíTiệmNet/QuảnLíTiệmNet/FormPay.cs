using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    public partial class FormPay : Form
    {
       
        private PayManagement payManagement;
        private CustomerManagerment customerManagerment;
        private int currentHoaDonNumber; 
        public FormPay(Customer customer =null)
        {
            string filePathCustomer = GetFilePathInTepFileCustomer();
            string filePathPay = GetFilePathInTepFilePay();
            List<Pay> pay = DataSource.ReadPaysFromFile(filePathPay);
            List<Customer> customers = DataSource.ReadCustomersFromFile(filePathCustomer);
            customerManagerment = new CustomerManagerment(customers);
            payManagement = new PayManagement(pay);
            InitializeComponent();
            if (customer != null)
            {
                ID.Text = customer.idCustomer;
                customer = customerManagerment.TimKhachHangTheoMa(ID.Text);
                txttienDangCo.Text = customer.Tien.ToString();
            }

        }
        private void PopulateDataGrid(DataGridView dgv, List<Pay> pays)
        {
            dgv.DataSource = null;
            dgv.DataSource = pays;
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Hóa Đơn Chưa Được Thêm Hoặc Rỗng!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgv.Refresh();
            }
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
        private string GetFilePathInTepFilePay()
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string tepFileDirectory = Path.Combine(projectDirectory, "TepFile");
            if (!Directory.Exists(tepFileDirectory))
            {
                Directory.CreateDirectory(tepFileDirectory);
            }
            return Path.Combine(tepFileDirectory, "Pay.txt");
        }
        private void FormPay_Load(object sender, EventArgs e)
        {
            string filePathCustomer = GetFilePathInTepFileCustomer();
            string filePathPay = GetFilePathInTepFilePay();
            List<Pay> pay = DataSource.ReadPaysFromFile(filePathPay);
            List<Customer> customers = DataSource.ReadCustomersFromFile(filePathCustomer);
            payManagement = new PayManagement(pay);
            customerManagerment = new CustomerManagerment(customers);
            PopulateDataGrid(dgvPay, payManagement.GetPays());
            List<Pay> pays = payManagement.GetPays();
            if (pays.Count > 0)
            {
                currentHoaDonNumber = pays.Max(p => int.Parse(p.SoHoaDon.Substring(2))) + 1; 
            }
            else
            {
                currentHoaDonNumber = 1; 
            }
        }
        private void HienThiComboBoxCustomer(ComboBox cbo, List <Customer> customers)
        {
            cbo.DisplayMember = "idCustomer";
            cbo.ValueMember = "idCustomer";
            cbo.DataSource = customers;
        }
        private void dgvPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvPay.Rows[e.RowIndex];
                    string soHoaDon = row.Cells[0].Value.ToString();
                    DateTime ngayLap = Convert.ToDateTime(row.Cells[1].Value);
                    string idCustomer = row.Cells[2].Value.ToString();
                    double tienGio = Convert.ToDouble(row.Cells[3].Value);
                    double tienNap = Convert.ToDouble(row.Cells[4].Value);
                    txtsoHoaDon.Text = soHoaDon;
                    dateTimePicker1.Value = ngayLap;
                    ID.Text = idCustomer;
                    txttienDangCo.Text = tienGio.ToString();
                    txttienNap.Text = tienNap.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HandlePaymentClick(string paymentType)
        {
            string filePathCustomer = GetFilePathInTepFileCustomer();
            string filePathPay = GetFilePathInTepFilePay();
            string idhoadon = $"HD{currentHoaDonNumber:D3}";
            DateTime ngayLap = dateTimePicker1.Value;
            List<Pay> pays = payManagement.GetPays();
            bool isDuplicate = pays.Any(p => p.SoHoaDon == idhoadon);

            if (isDuplicate)
            {
                MessageBox.Show("Số hóa đơn đã tồn tại. Vui lòng nhập số hóa đơn khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            double soTien = double.Parse(txttienNap.Text);
            Pay pay = new Pay(idhoadon,ngayLap,ID.Text,double.Parse(txttienDangCo.Text),double.Parse(txttienNap.Text),paymentType);
            payManagement.AddPay(pay);
            PopulateDataGrid(dgvPay, payManagement.GetPays());
            currentHoaDonNumber++;
            txtsoHoaDon.Text = $"HD{currentHoaDonNumber:D3}";
            txttienNap.Text = "0";
            MessageBox.Show($"Thanh toán thành công bằng {paymentType}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Customer> customers = DataSource.ReadCustomersFromFile(filePathCustomer);
            Customer customerToUpdate = customers.FirstOrDefault(c => c.idCustomer == ID.Text);
            if (customerToUpdate != null)
            {
                customerToUpdate.tien += soTien;
            }
            DataSource.WriteCustomersToFile(filePathCustomer, customers);
            DataSource.WritePaysToFile(filePathPay, payManagement.GetPays());
        }
        private void btncash_Click(object sender, EventArgs e)
        {
            HandlePaymentClick(btncash.Text);
        }
        private void btnbank_Click(object sender, EventArgs e)
        {
            HandlePaymentClick(btnbank.Text);
        }
        private void btnmomo_Click(object sender, EventArgs e)
        {
            HandlePaymentClick(btnmomo.Text);
        }
        private void btnpayooqr_Click(object sender, EventArgs e)
        {
            HandlePaymentClick(btnpayooqr.Text);
        }
        private void btnpayoocard_Click(object sender, EventArgs e)
        {
            HandlePaymentClick(btnpayoocard.Text);
        }
        private void cboidCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormCustomer customer = new FormCustomer();
            customer.Show();
            this.Hide();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            ReportPay frm=new ReportPay();
            frm.ShowDialog();
        }

        private void btntimKiem_Click(object sender, EventArgs e)
        {
            btnhienThi.Visible = true;
            List<Pay> dsketqua = new List<Pay>();
            string ketqua = null;
            if (rbtimTheoMa.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = payManagement.TimMa(ketqua);
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvPay, dsketqua);
            }
            else if (rbtimKiemTheoHD.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = payManagement.TimTheoHD(ketqua);
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvPay, dsketqua);
            }
            else if (rbtimTheoNgay.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = payManagement.TimTheoNgay(DateTime.Parse( ketqua));
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvPay, dsketqua);
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Phương Thức Tìm Kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnhienThiTatCa_Click(object sender, EventArgs e)
        {
            PopulateDataGrid(dgvPay, payManagement.GetPays());
            btnhienThi.Visible = false;
        }
    }
}
