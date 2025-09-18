using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    [Serializable]
     class MenuMonManagement
    {
        private List<MenuMons> listmenu = new List<MenuMons>();
        public MenuMonManagement()
        {
            DataSource dataSource = DataSource.Init();
            this.listmenu = dataSource.GetMenuMons();
        }
        public MenuMonManagement(List<MenuMons> listmenu)
        {
            this.listmenu = listmenu;
        }

        public List<MenuMons> GetMenuMons()
        {
            if (this.listmenu == null)
            {
                MessageBox.Show("Danh sách menu chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<MenuMons>();
            }
            return this.listmenu;
        }
        public List<string> GetUniqueLoaiMons()
        {
            return listmenu.Select(menu => menu.loai).Distinct().ToList();
        }

        public bool sameMenu(string id)
        {
            foreach (MenuMons menu in listmenu)
            {
                if (menu.idMon.Equals(id))
                {
                   
                    return false;
                }
            }
            return true;
        }
        public void addMenu(MenuMons menu)
        {
            if (sameMenu(menu.idMon))
            {
                this.listmenu.Add(menu);
                MessageBox.Show("Đã thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public MenuMons Find(string id)
        {
            foreach (MenuMons menu in listmenu)
            {
                if (menu.idMon.Equals(id)) { return menu; }

            }
            return null;
        }
        public void removeMenu(string id)
        {
            foreach (MenuMons menu in listmenu)
            {
                if (menu.idMon.Equals(id))
                {
                    listmenu.Remove(menu);
                    MessageBox.Show("Đã Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
        public void repairMenu(MenuMons menu)
        {
            MenuMons result = Find(menu.IDMon);
            if (result != null)
            {
                result.idMon = menu.idMon;
                result.tenMon = menu.tenMon;
                result.donViTinh = menu.donViTinh;
                result.donGia = menu.donGia;
                result.loai = menu.loai;
                MessageBox.Show("Đã Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<MenuMons> TimMonTheoLoai(string tenloai)
        {
            List<MenuMons> result = new List<MenuMons>();
            foreach (MenuMons menu in listmenu)
            {
                if (menu.loai.Equals(tenloai))
                    result.Add(menu);
            }
            return result;
        }
        public MenuMons TimMonTheoMa(string ma)
        {
            List<MenuMons> result = new List<MenuMons>();
            foreach (MenuMons menu in listmenu)
            {
                if (menu.idMon.Equals(ma))
                    return menu;
            }
            return null;
        }

    }
}
