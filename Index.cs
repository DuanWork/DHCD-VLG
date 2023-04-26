using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCoDong
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            customzeDesing();
        }
        private void customzeDesing()
        {
            panelInthuSubMenu.Visible = false;
            panelDangkySubMenu.Visible = false;
            panelTrinhchieuSubMenu.Visible = false; 
            panelBieuQuyetSubMenu.Visible = false;
            panelBaocaoSubMenu.Visible = false;
            panelCauhinhSubMenu.Visible = false;
            panelKiemtraSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelInthuSubMenu.Visible == true)
                panelInthuSubMenu.Visible = false;
            if (panelDangkySubMenu.Visible == true)
                panelDangkySubMenu.Visible = false;
            if (panelTrinhchieuSubMenu.Visible == true)
                panelTrinhchieuSubMenu.Visible = false;
            if (panelBieuQuyetSubMenu.Visible == true)
                panelBieuQuyetSubMenu.Visible = false;
            if (panelBaocaoSubMenu.Visible == true)
                panelBaocaoSubMenu.Visible= false;
            if (panelCauhinhSubMenu.Visible == true)
                panelCauhinhSubMenu.Visible = false;
            if (panelKiemtraSubMenu.Visible == true)
                panelKiemtraSubMenu.Visible= false;
        }
        private void showSubMenu (Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnInthu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInthuSubMenu);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInthu());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDangkySubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new DangKy_NhapCoDong());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new DangKy_ThamDu());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new DangKy_NhatKyUyQuyen());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new DangKy_CCDDK_Tham_Du());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnTrinhChieu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTrinhchieuSubMenu);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new TCTyLeCoDongTD());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new TCKetQuaBieuQuyet());
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnBieuquyet_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBieuQuyetSubMenu);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBaocaoSubMenu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnCauhinh_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCauhinhSubMenu);   
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKiemtraSubMenu);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //..
            //Your codes
            //..
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm (Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}