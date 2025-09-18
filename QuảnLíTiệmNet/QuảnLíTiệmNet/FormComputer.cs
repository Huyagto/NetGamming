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
    public partial class FormComputer : Form
    {
        private ComputerManagement computerManagement;
        private int idComputerNumber;
        public FormComputer()
        {
            InitializeComponent();
        }
        private void FormComputer_Load(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            List<Computer> computers  = DataSource.ReadComputersFromFile(filePath);
            computerManagement = new ComputerManagement(computers);
            PopulateDataGrid(dgvComputer, computerManagement.GetComputers());
            List<Computer> list = computerManagement.GetComputers();
            if (list.Count > 0)
            {
                idComputerNumber = list.Max(p => int.Parse(p.idComputer.Substring(2))) + 1;
              
            }
            else
            {
                idComputerNumber = 1;
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
            return Path.Combine(tepFileDirectory, "Computer.txt");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            if (!double.TryParse(txtprice.Text, out double price))
            {
                MessageBox.Show("Giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string idcomputer = $"M{idComputerNumber:D3}";
            
            Computer computer = new Computer(
                     idcomputer,
                computerManagement.GetSelectedValue(rbTrong, rbDangSuDung, rbBaoTri),
                computerManagement.GetSelectedValue(rbloaiThuong, rbloaiTrungBinh, rbloaiVip),
                computerManagement.GetSelectedValue(rbphongThuong, rbphongStream, rbphongCouple, rbphongVIP),
                price
            );
            computerManagement.addComputer(computer);
            PopulateDataGrid(dgvComputer, computerManagement.GetComputers());
            if (computerManagement == null)
            {
                MessageBox.Show("Không thể thêm máy tính do trùng ID hoặc lỗi khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            idComputerNumber++;
            txtidComputer.Text = $"M{idComputerNumber:D3}";
            DataSource.WriteComputersToFile(filePath, computerManagement.GetComputers());
        }
        private void PopulateDataGrid(DataGridView dgv, List<Computer> computers)
        {
            dgv.DataSource = null;
            dgv.DataSource = computers;
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Máy Tính Chưa Được Thêm Hoặc Rỗng!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgv.Refresh();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            if (dgvComputer.RowCount == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa. Vui lòng thêm dữ liệu trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketqua = MessageBox.Show("Bạn Thật Sự Muốn Xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketqua == DialogResult.Yes && dgvComputer.CurrentRow != null)
            {
                computerManagement.removeComputer(txtidComputer.Text);
                PopulateDataGrid(dgvComputer, computerManagement.GetComputers());
            }
            DataSource.WriteComputersToFile(filePath, computerManagement.GetComputers());
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            Computer computer = new Computer(
               txtidComputer.Text,
               computerManagement.GetSelectedValue(rbTrong, rbDangSuDung, rbBaoTri),
               computerManagement.GetSelectedValue(rbloaiThuong, rbloaiTrungBinh, rbloaiVip),
               computerManagement.GetSelectedValue(rbphongThuong, rbphongStream, rbphongCouple, rbphongVIP),
               double.Parse(txtprice.Text)
           );

            computerManagement.repairComputer(computer);
            PopulateDataGrid(dgvComputer, computerManagement.GetComputers());
            DataSource.WriteComputersToFile(filePath, computerManagement.GetComputers());
        }
        private void dgvComputer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvComputer.Rows[e.RowIndex];


                    txtidComputer.Text = row.Cells[0].Value.ToString();
                    string status = row.Cells["Status"].Value.ToString();
                    string kind = row.Cells["Kind"].Value.ToString();
                    string room = row.Cells["Room"].Value.ToString(); 
                    txtprice.Text = row.Cells[4].Value.ToString(); 
                    status = status.Normalize(NormalizationForm.FormC);
                    Console.WriteLine(status);
                    rbTrong.Checked = status == "Trống";
                    rbDangSuDung.Checked = status == "Đang Sử Dụng";
                    rbBaoTri.Checked = status == "Bảo Trì";
                    kind = kind.Normalize(NormalizationForm.FormC); 
                    rbloaiThuong.Checked = kind == "Thường";
                    rbloaiTrungBinh.Checked = kind == "Trung Bình";
                    rbloaiVip.Checked = kind == "VIP";
                    room = room.Normalize(NormalizationForm.FormC); 
                    rbphongThuong.Checked = room == "Thường";
                    rbphongStream.Checked = room == "Stream";
                    rbphongCouple.Checked = room == "Couple";
                    rbphongVIP.Checked = room == "VIP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi chọn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btntimKiem_Click(object sender, EventArgs e)
        {
            btnhienThiTatCa.Visible = true;
            List<Computer> dsketqua = new List<Computer>();
            string ketqua = null;
            if (rbtimTheoMa.Checked == true)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = computerManagement.TimTheoMa(ketqua);
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvComputer, dsketqua);
            }
            else if (rbtimTheoTinhTrang.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = computerManagement.TimTheoTinhTrang(ketqua);
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvComputer, dsketqua);
            }
            else if (rbtimTheoLoai.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = computerManagement.TimTheoLoai(ketqua);
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvComputer, dsketqua);
            }
            else if (rbtimTheoPhong.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = computerManagement.TimTheoPhong(ketqua);
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvComputer, dsketqua);
            }
            else if (rbtimTheoGia.Checked)
            {
                ketqua = txttimKiem.Text.Trim();
                dsketqua = computerManagement.TimTheoGia(double.Parse(ketqua));
                MessageBox.Show("Đã Tìm Xong!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateDataGrid(dgvComputer, dsketqua);
            }
            else
                MessageBox.Show("Bạn Chưa Chọn Phương Thức Tìm Kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void FormComputer_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            DataSource.WriteComputersToFile(filePath, computerManagement.GetComputers());
        }
        private void btnhienThiTatCa_Click(object sender, EventArgs e)
        {
            PopulateDataGrid(dgvComputer,computerManagement.GetComputers());
            btnhienThiTatCa.Visible = false;
        }
    }
}

