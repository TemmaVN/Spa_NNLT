using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spa_NNLT.Bằng;
using Spa_NNLT.Nguyên;

namespace Spa_NNLT
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxUsename_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if(textBoxUsename.Text == "1")
            {
                FormNhanVien f = new FormNhanVien();
                this.Hide();
                f.ShowDialog();
            }
            else if (textBoxUsename.Text == "2")
            {
                Admin admin = new Admin();
                this.Hide();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai kia fen");
            }
            this.Show();
            
        }

        

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
