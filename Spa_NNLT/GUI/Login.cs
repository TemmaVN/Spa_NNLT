﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spa_NNLT.Nguyên;
using Spa_NNLT.Nguyên.Nguyên_DTO;
using Spa_NNLT.Nguyên.NhanVienAD;
using Newtonsoft.Json;
using System.IO;

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
            
            if (loginQL(textBoxUsename.Text, textBoxMatKhau.Text))
            {
                Admin admin = new Admin();
                this.Hide();
                admin.ShowDialog();
        }
                 else
                {
                MessageBox.Show("Sai tên đăng nhập hoặc mật kh");
             }
            this.Show();
            
        }

        

        bool loginQL(string username, string password) { 
            return QuanLiDAO.Instance.login(username, password);
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
