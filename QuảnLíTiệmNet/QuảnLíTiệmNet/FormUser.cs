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
    public partial class FormUser : Form
    {
        private Timer countdownTimer;
        private TimeSpan remainingTime;
        public Customer currentCustomer;
        private Computer currentComputer;

        public FormUser(Customer customer = null, Computer computer = null)
        {
            InitializeComponent();
            this.currentCustomer = customer;
            this.currentComputer = computer;

            if (customer != null && computer != null)
            {
                lblComputerInfo.Visible = true;
                lblCountdown.Visible = true;
                lblWelcome.Visible = true;
                lblWelcome.Text = $"Welcome, {currentCustomer.NameCustomer}";
                lblComputerInfo.Text = $"Using Computer {currentComputer.idComputer} (Số Tiền Máy: {currentComputer.Price} /1 giờ)";
                double hours = currentCustomer.Tien / currentComputer.Price;
                remainingTime = TimeSpan.FromHours(hours);
                countdownTimer = new Timer();
                countdownTimer.Tick += CountdownTimer_Tick;
                countdownTimer.Interval = 1000;
                countdownTimer.Start();
                UpdateCountdownLabel();
                if(currentCustomer.tien - currentComputer.Price < 0)
                {
                    countdownTimer.Stop();
                    MessageBox.Show("Thời gian đã hết!", "Thông báo");
                    Application.Restart();
                }
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
        private void FormUser_Load(object sender, EventArgs e)
        {
            string filePathCustomer = GetFilePathInTepFileCustomer();
            List<Customer> ds = DataSource.ReadCustomersFromFile(filePathCustomer);
        }
        private void FormUser_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            string filePathCustomer = GetFilePathInTepFileCustomer();
            double tongsoGiay = remainingTime.TotalSeconds;
            double soGio = tongsoGiay / 3600; 
            currentCustomer.tien = soGio * currentComputer.Price; 
            List<Customer> customers = DataSource.ReadCustomersFromFile(filePathCustomer);
            Customer customerToUpdate = customers.FirstOrDefault(c => c.idCustomer == currentCustomer.idCustomer);
            if (customerToUpdate != null)
            {
                customerToUpdate.tien = currentCustomer.tien;
            }
            DataSource.WriteCustomersToFile(filePathCustomer, customers);
        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                UpdateCountdownLabel();
            }
            else
            {
                countdownTimer.Stop();
                MessageBox.Show("Your time is up!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (currentCustomer != null && currentComputer != null)
                {
                    currentCustomer.Tien = 0;
                }
            }
        }
        private void UpdateCountdownLabel()
        {
            lblCountdown.Text = $"Remaining Time: {remainingTime.Hours:D2}:{remainingTime.Minutes:D2}:{remainingTime.Seconds:D2}";
        }

        private void btnchonDichVu_Click(object sender, EventArgs e)
        {
           
            FormService formService = new FormService(currentCustomer);
            formService.Show();
            
        }
        private void btnsuaMK_Click(object sender, EventArgs e)
        {
            FormCustomer customer = new FormCustomer(currentCustomer); 
            customer.ShowDialog(this);
        }
        private void btndangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       
    }
}
