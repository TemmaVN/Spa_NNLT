using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spa_NNLT.Nguyên.NhanVienAD;

namespace Spa_NNLT.Nguyên
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tàiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KhachhangAdbt_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LichHenADbt_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            TimTheotenTb.Text = "Tìm theo tên ...";
            TimTheotenTb.ForeColor = Color.Gray;
            TimtheoMatb.Text = "Tìm theo mã...";
            TimtheoMatb.ForeColor = Color.Gray;
            TimTheoTenKHtb.Text = "Tìm theo tên ...";
            TimTheoTenKHtb.ForeColor = Color.Gray;
            TimTheoMaKHtb.Text = "Tìm theo mã ...";
            TimTheoMaKHtb.ForeColor= Color.Gray;
        }

        private void TimTheotenTb_Enter(object sender, EventArgs e)
        {
           if (TimTheotenTb.Text == "Tìm theo tên ...")
           {
                TimTheotenTb.Text = "";
                TimTheotenTb.ForeColor = Color.Black;
           }
        }

        private void TimTheotenTb_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TimTheotenTb.Text))
            {
                TimTheotenTb.Text = "Tìm theo tên ...";
                TimTheotenTb.ForeColor = Color.Gray;
            }
        }

        private void TimtheoMatb_Enter(object sender, EventArgs e)
        {
            if(TimtheoMatb.Text == "Tìm theo mã...")
            {
                TimtheoMatb.Text = "";
                TimtheoMatb.ForeColor= Color.Black;
            }
        }

        private void TimtheoMatb_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty (TimtheoMatb.Text))
            {
                TimtheoMatb.Text = "Tìm theo mã...";
                TimtheoMatb.ForeColor = Color.Gray;
            }
        }

        private void panel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimTheotenTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Enter(object sender, EventArgs e)
        {

        }

        private void TimKHadbt_Click(object sender, EventArgs e)
        {

        }

        private void TimTheoTenKHtb_Enter(object sender, EventArgs e)
        {
            if (TimTheoTenKHtb.Text == "Tìm theo tên ...")
            {
                TimTheoTenKHtb.Text = "";
                TimTheoTenKHtb.ForeColor = Color.Black;
            }
        }

        private void TimTheoTenKHtb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TimTheoTenKHtb.Text))
            {
                TimTheoTenKHtb.Text = "Tìm theo tên ...";
                TimTheoTenKHtb.ForeColor = Color.Gray;
            }
        }

        private void TimTheoMaKHtb_Enter(object sender, EventArgs e)
        {
            if (TimTheoMaKHtb.Text == "Tìm theo mã ...")
            {
                TimTheoMaKHtb.Text = "";
                TimTheoMaKHtb.ForeColor = Color.Black;
            }
        }

        private void TimTheoMaKHtb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TimTheoMaKHtb.Text))
            {
                TimTheoMaKHtb.Text = "Tìm theo mã ...";
                TimTheoMaKHtb.ForeColor = Color.Gray;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void PhongADtp_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void ThemNVbt_Click(object sender, EventArgs e)
        {
            ThemNVad themNVad = new ThemNVad();
            themNVad.ShowDialog();
        }

        private void XoaNVbt_Click(object sender, EventArgs e)
        {
            
        }

        private void CapNhatADbt_Click(object sender, EventArgs e)
        {
            SuaNVad suaNVad = new SuaNVad();
            suaNVad.ShowDialog();
        }
    }
}
