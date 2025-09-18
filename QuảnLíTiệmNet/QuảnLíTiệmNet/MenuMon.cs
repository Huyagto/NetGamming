using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    public partial class MenuMon : Form
    {
        private MenuMonManagement menuMons;
        public MenuMon()
        {
            InitializeComponent();
        }
        private string GetFilePathInTepFile()
        {
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string tepFileDirectory = Path.Combine(projectDirectory, "TepFile");
            if (!Directory.Exists(tepFileDirectory))
            {
                Directory.CreateDirectory(tepFileDirectory);
            }
            return Path.Combine(tepFileDirectory, "Menu.txt");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            if (string.IsNullOrEmpty(txtidMon.Text))
            {
                MessageBox.Show("ID không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MenuMons menu = new MenuMons(txtidMon.Text,txttenMon.Text,txtdonViTinh.Text,double.Parse(txtdonGia.Text),txtloaiMon.Text);
            menuMons.addMenu(menu);
            MessageBox.Show("Tổng số món: " + menuMons.GetMenuMons().Count);
            PopulateDataGrid(dgvmenuMons,menuMons.GetMenuMons());
            DataSource.WriteMenuMonsToFile( filePath, menuMons.GetMenuMons());
        }
        private void MenuMon_Load(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            List<MenuMons> menuMon = DataSource.ReadMenuMonsFromFile(filePath);
            menuMons = new MenuMonManagement(menuMon);
            PopulateDataGrid(dgvmenuMons, menuMons.GetMenuMons());
        }
        private void PopulateDataGrid(DataGridView dgv, List<MenuMons> menuMons)
        {
            dgv.DataSource = null;
            dgv.DataSource = menuMons;
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Menu Chưa Được Thêm Hoặc Rỗng!s.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgv.Refresh();
            }
        }
        private void dgvmenuMons_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvmenuMons.Rows[e.RowIndex];
                if(row == null)
                {
                    MessageBox.Show("Hàng được chọn không hợp lệ hoặc không chứa dữ liệu.");
                    return;
                }
                txtidMon.Text = row.Cells[0].Value.ToString();
                txttenMon.Text = row.Cells[1].Value.ToString();
                txtdonViTinh.Text = row.Cells[2].Value.ToString();
                txtdonGia.Text = row.Cells[3].Value.ToString();
                txtloaiMon.Text = row.Cells[4].Value.ToString();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            if (string.IsNullOrEmpty(txtidMon.Text))
            {
                MessageBox.Show("Vui lòng chọn một món để sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MenuMons updatedMenu = new MenuMons(
                txtidMon.Text,
                txttenMon.Text,
                txtdonViTinh.Text,
                double.Parse(txtdonGia.Text),
                txtloaiMon.Text
            );
            menuMons.repairMenu(updatedMenu);
            PopulateDataGrid(dgvmenuMons, menuMons.GetMenuMons());
            DataSource.WriteMenuMonsToFile(filePath , menuMons.GetMenuMons());
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePathInTepFile();
            if (string.IsNullOrEmpty(txtidMon.Text))
            {
                MessageBox.Show("Vui lòng chọn một món để xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa món này?",
                "Xác Nhận Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                menuMons.removeMenu(txtidMon.Text);
                PopulateDataGrid(dgvmenuMons, menuMons.GetMenuMons());
            }
            DataSource.WriteMenuMonsToFile(filePath, menuMons.GetMenuMons());
        }
    }
}
