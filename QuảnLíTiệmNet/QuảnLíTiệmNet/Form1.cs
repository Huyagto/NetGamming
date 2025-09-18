using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuảnLíTiệmNet
{
    public partial class Form1 : Form
    {
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
        } 
        private void btnComputer_Click(object sender, EventArgs e)
        {
            try
            {
                FormComputer formComputer = new FormComputer();
                formComputer.Show();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                FormCustomer formCustomer = new FormCustomer();
                formCustomer.Show();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            try
            {
                MenuMon menuMon = new MenuMon();
                menuMon.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                FormService formService = new FormService();
                formService.Show();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        bool menuExpand = false;
       
 
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand==false)
            {
                if (menuExpand == true)
                {
                    menuContainer.Height -= 10;
                    if (menuContainer.Height <= 73)
                    {
                        menuTransition.Stop();
                        menuExpand = false;
                    }
                }
                sidebar.Width-=5;
                if (sidebar.Width <=54)
                {
                    sidebarExpand=true;
                    sidebarTransition.Stop();  
                }
            }
            else
            {
                if (menuExpand == false)
                {
                    menuContainer.Height += 10;
                    if (menuContainer.Height >= 409)
                    {
                        menuTransition.Stop();
                        menuExpand = true;
                    }
                }
                sidebar.Width += 5;
                if (sidebar.Width >=264)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
        }
        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        
    }
}
