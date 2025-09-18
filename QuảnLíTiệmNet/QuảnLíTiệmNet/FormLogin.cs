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
    public partial class FormLogin : Form
    {
        public Point mouseLocation;
        private TaiKhoanManagement taiKhoanManagement;
        private CustomerManagerment customerManagerment;
        private ComputerManagement computerManagement;
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnDangNhap;
            string filePathComputer = GetFilePathInTepFileCompuer();
            string filePathCustomer = GetFilePathInTepFileCustomer();
            string filePathAdmin = GetFilePathInTepFileAdmin();
            List<TaiKhoan> taiKhoans = DataSource.ReadAdminFromFile(filePathAdmin);
            List<Computer> computers = DataSource.ReadComputersFromFile(filePathComputer);
            List<Customer> customers = DataSource.ReadCustomersFromFile(filePathCustomer);
            taiKhoanManagement = new TaiKhoanManagement(taiKhoans);
            customerManagerment = new CustomerManagerment(customers);
            computerManagement = new ComputerManagement(computers);
        }
        private string GetFilePathInTepFileCompuer()
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string tepFileDirectory = Path.Combine(projectDirectory, "TepFile");
            if (!Directory.Exists(tepFileDirectory))
            {
                Directory.CreateDirectory(tepFileDirectory);
            }
            return Path.Combine(tepFileDirectory, "Computer.txt");
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
        private string GetFilePathInTepFileAdmin()
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string tepFileDirectory = Path.Combine(projectDirectory, "TepFile");
            if (!Directory.Exists(tepFileDirectory))
            {
                Directory.CreateDirectory(tepFileDirectory);
            }
            return Path.Combine(tepFileDirectory, "Admin.txt");
        }
        private void HienThiComboBox(ComboBox comboBox, List<Computer> computers)
        {
            comboBox.Items.Clear(); 
            foreach (var computer in computers)
            {
                comboBox.Items.Add(computer.idComputer); 
            }

            if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }
        private int countWrong = 3;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == taiKhoanManagement.TimTentk(txtTaiKhoan.Text.Trim()) && txtMatKhau.Text.Trim() ==taiKhoanManagement.TimMK(txtMatKhau.Text))
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                Customer customer = customerManagerment.Authenticate(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
                    if (customer != null)
                    {
                        string idcomputer = cbosoMay.Text.Trim();
                         Computer selectedComputer = computerManagement.TimMaComputer(idcomputer);
                        FormUser frmuser = new FormUser(customer, selectedComputer);
                        frmuser.Show();
                        this.Hide();
                    }
                else
                {
                   countWrong--;
                    MessageBox.Show($"Tên tài khoản hoặc mật khẩu không đúng! Bạn còn {countWrong} lần nhập.",
                                    "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (countWrong == 0)
                    {
                        MessageBox.Show("Bạn đã nhập sai quá số lần cho phép. Ứng dụng sẽ đóng.",
                        "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            HienThiComboBox(cbosoMay, computerManagement.TimTheoTinhTrang("Trống"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation=new Point(-e.X, -e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePose=Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location=mousePose;
            }
        }
    }
}

