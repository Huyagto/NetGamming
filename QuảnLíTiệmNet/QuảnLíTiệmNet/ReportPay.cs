using Microsoft.Reporting.WinForms;
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
    public partial class ReportPay : Form
    {
        PayManagement pays;
        public ReportPay()
        {
            InitializeComponent();
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
        private void ReportPay_Load(object sender, EventArgs e)
        {
            string filePathPay = GetFilePathInTepFilePay();
            List<Pay> pay = DataSource.ReadPaysFromFile(filePathPay);
            pays = new PayManagement(pay);
            List<Pay> ListPay=pays.GetPays();
            if (ListPay == null || ListPay.Count == 0)
            {
                MessageBox.Show("Dữ liệu rỗng. Kiểm tra lại danh sách ListPay.");
            }
            else
            {
                reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataPay", ListPay));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
