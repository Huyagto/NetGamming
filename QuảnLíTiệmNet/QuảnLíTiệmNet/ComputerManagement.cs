using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    [Serializable]   
    
    class ComputerManagement
    {
        private List<Computer> listcomputer;
        public ComputerManagement()
        {
            listcomputer = new List<Computer>();
            DataSource dataSource = DataSource.Init();
            this.listcomputer = dataSource.GetComputers();
        }
        public ComputerManagement(List<Computer> computers)
        {
            this.listcomputer = computers;
        }
        public List<Computer> GetComputers()
        {
            if (listcomputer == null)
            {
                MessageBox.Show("Danh sách máy tính chưa được khởi tạo!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Computer>();
            }
            return listcomputer;
        }

        public bool sameComputer(string id)
        {
            foreach (Computer computer in listcomputer)
            {
                if (computer.IDComputer.Equals(id))
                {
                    
                    return false;
                }
            }
            return true;
        }
        public void addComputer(Computer computer)
        {
            if (sameComputer(computer.IDComputer)) { 
                this.listcomputer.Add(computer);
                MessageBox.Show("Đã thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Tổng số máy tính: " +  listcomputer.Count());
        }
            else
            {
                MessageBox.Show("ID trùng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        public Computer Find(string id)
        {
            foreach (Computer computer in listcomputer)
            {
                if (computer.IDComputer.Equals(id)) { return computer; }
               
            }
            return null;
        }
        public void removeComputer(string id)
        {
            foreach (Computer computer in listcomputer)
            {
                if (computer.IDComputer.Equals(id))
                {
                    listcomputer.Remove(computer);
                    MessageBox.Show("Đã Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        public void repairComputer(Computer computer)
        {
           Computer result = Find(computer.IDComputer);
            if (result != null)
            {
                result.Status = computer.Status;
                result.Kind = computer.Kind;
                result.Room = computer.Room;
                result.Price = computer.Price;
                MessageBox.Show("Đã Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string GetSelectedValue(params RadioButton[] radioButtons)
        {
            foreach (var rb in radioButtons)
            {
                if (rb.Checked)
                {
                    return rb.Text; // Trả về văn bản của RadioButton được chọn
                }
            }
            return "Chưa có lựa chọn."; // Không có lựa chọn
        }

        public Computer TimMaComputer(string ma)
        {
            foreach (Computer c in listcomputer)
            {
                if (c.IDComputer.Equals(ma))
                    return c;
            }
           return null;
        }
        public List<Computer> TimTheoMa(string ma)
        {
            List<Computer> dsTim = new List<Computer>();
            foreach(Computer c in listcomputer)
            {
                if (c.IDComputer.Normalize(NormalizationForm.FormC).Trim().ToLower().Contains(ma.Trim().ToLower()))
                {
                    dsTim.Add(c);
                }
            }
            return dsTim;
        }
        public List<Computer> TimTheoTinhTrang(string status)
        {
            List<Computer> dsTim = new List<Computer>();
            foreach (Computer c in listcomputer)
            {
                if (c.Status.Normalize(NormalizationForm.FormC).Trim().ToLower().Contains(status.Trim().ToLower()))
                {
                    dsTim.Add(c);
                }
            }
            return dsTim;
        }

        public List<Computer> TimTheoLoai(string kind)
        {
            List<Computer>  dsTim = new List<Computer>();
            foreach (Computer c in listcomputer)
            {
                if (c.Kind.Normalize(NormalizationForm.FormC).Trim().ToLower().Contains(kind.Trim().ToLower()))
                {
                    dsTim.Add(c);
                }
            }
            return dsTim;
        }
        public List<Computer> TimTheoPhong(string room)
        {
            List<Computer> dsTim = new List<Computer>();
            foreach(Computer c in listcomputer)
            {
                if (c.Room.Normalize(NormalizationForm.FormC).Trim().ToLower().Contains(room.Trim().ToLower()))
                {
                    dsTim.Add(c);
                }
            }
            return dsTim;
        }
        public List<Computer> TimTheoGia(double gia)
        {
            List<Computer> dsTim = new List<Computer>();
            foreach (Computer c in listcomputer)
            {
                if (c.Price.Equals(gia))
                {
                    dsTim.Add(c);
                }
            }
            return dsTim;

        }
        public List<Computer> TimTinhTrang(string status)
        {
            List<Computer> dsTim = new List<Computer>();
            foreach (Computer c in listcomputer)
            {
                if (c.Status.Equals(status))
                {
                    dsTim.Add(c);
                }
            }
            return dsTim;
        }
    }
}