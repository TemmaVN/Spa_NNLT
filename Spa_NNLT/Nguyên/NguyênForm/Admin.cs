using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spa_NNLT.Nguyên.DichVuAD;
using Spa_NNLT.Nguyên.KhachHangAD;
using Spa_NNLT.Nguyên.NhanVienAD;
using Spa_NNLT.Nguyên.Nguyên_DTO;
using Spa_NNLT.Nguyên.PhongAD;


namespace Spa_NNLT.Nguyên
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            LoadAccountList();
            LoadHoaDonList();
            LoadDichVuList();
            LoadHoaDonList();
            LoadLichHenList();
            LoadNhanVienlist();
            
            LoadThongTin();
            LoadThemPhong();
            
            // Load thông tin từ sql
            // Tìm thông tin qua text box
            // Thêm, xóa, sửa các thông tin 
            // Các bài toán thêm

        }

        #region method

        void LoadThongTin()
        {
            List<NhanVien> nhanViens = NhanVienDAO.Instance.LoadNhanVienAD();

            foreach (NhanVien nhan in nhanViens)
            {
                if (TimTheotenTb.Text == nhan.ten || TimtheoMatb.Text == nhan.id.ToString())
                {
                    MaNVtb.Text = nhan.id;
                    HTtb.Text = nhan.ten;
                    GTtb.Text = nhan.gioiTinh;
                    SDTlb.Text = nhan.sDT;
                    
                }
                
            }
        }

        void LoadKhachHang()
        {
            List<Khachhang> khachhangs = KhachHangDAO.Instance.LoadKhachHang();
            foreach(Khachhang khachhang in khachhangs)
            {
                if (TimTheoTenKHtb.Text == khachhang.tenKH || TimTheoMaKHtb.Text == khachhang.idKH)
                {
                    MaKHadTB.Text = khachhang.idKH;
                    HTKHadTB.Text = khachhang.tenKH;
                    GTKhadTB.Text = khachhang.gioitinhKH;
                    SDTKHadTB.Text = khachhang.sDTKH;

                }
            }
        }

        #endregion

        #region Events

        void LoadThemPhong()
        {
            
        }

        void LoadHoaDonList()
        {
            string query = "SELECT * from dbo.tblHoaDon";
            HoaDonADdata.DataSource = DataProvider.Instance.Excuted(query);
        }
        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.tblKhachHang";
            KhachHangADdata.DataSource = DataProvider.Instance.Excuted(query); 
        }

        void LoadNhanVienlist()
        {
            string query = "SELECT * from dbo.tblNhanVien";
            NhanVienADdata.DataSource = DataProvider.Instance.Excuted(query);
        }

        void LoadDichVuList()
        {
            string query = "SELECT * from dbo.tblDichVu";
            DichVuADdata.DataSource = DataProvider.Instance.Excuted(query);
        }

        void LoadLichHenList()
        {
            string query = "SELECT * from dbo.tblHoaDon";
            LichHenADdata.DataSource = DataProvider.Instance.Excuted(query);
        }

        void LoadNhanVienList()
        {
            string query = "SELECT * from dbo.tblNhanVien";
            NhanVienADdata.DataSource = DataProvider.Instance.Excuted(query);
        }

        void LoadPhongList()
        {
            
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
            HienThi();
        }

        private void HienThi()
        {
            TimTheotenTb.Text = "Tìm theo tên ...";
            TimTheotenTb.ForeColor = Color.Gray;
            TimtheoMatb.Text = "Tìm theo mã...";
            TimtheoMatb.ForeColor = Color.Gray;
            TimTheoTenKHtb.Text = "Tìm theo tên ...";
            TimTheoTenKHtb.ForeColor = Color.Gray;
            TimTheoMaKHtb.Text = "Tìm theo số điện thoại ..";
            TimTheoMaKHtb.ForeColor = Color.Gray;
            TimTheoTenDVtb.Text = "Tìm theo tên...";
            TimTheoTenDVtb.ForeColor = Color.Gray;
            TimTheoMaDVtb.Text = "Tìm theo mã...";
            TimTheoMaDVtb.ForeColor = Color.Gray;   
            TimTheoMaLHadTB.Text = "Tìm theo mã...";
            TimTheoMaLHadTB.ForeColor = Color.Gray;
            TTMaHDadTB.Text = "Tìm theo mã...";
            TTMaHDadTB.ForeColor= Color.Gray;
            TTTenKHLHadTB.Text = "Tên khách hàng...";
            TTTenKHLHadTB.ForeColor = Color.Gray;

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
            LoadKhachHang();
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
                TimTheoMaKHtb.Text = "Theo điện thoại ...";
                TimTheoMaKHtb.ForeColor = Color.Gray;
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThemKHad themKHad = new ThemKHad();
            themKHad.ShowDialog();
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

        private void ThemDVadTB_Click(object sender, EventArgs e)
        {
            ThemDVad themDVad = new ThemDVad();
            themDVad.ShowDialog();
        }

        private void CapNhatDVadBT_Click(object sender, EventArgs e)
        {
            SuaDVad suaDVad = new SuaDVad();
            suaDVad.ShowDialog();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            ThemKHad themKHad = new ThemKHad();
            themKHad.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LichHenADtp_Click(object sender, EventArgs e)
        {

        }

        private void DichVuADcl_Click(object sender, EventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void Khachhangtb_Click(object sender, EventArgs e)
        {

        }

        private void NhanVientb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimTheoTenDVtb_Enter(object sender, EventArgs e)
        {
            if (TimTheoTenDVtb.Text == "Tìm theo tên...")
            {
                TimTheoTenDVtb.Text = "";
                TimTheoTenDVtb.ForeColor = Color.Black;
            }
        }

        private void TimTheoTenDVtb_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TimTheoTenDVtb.Text))
            {
                TimTheoTenDVtb.Text = "Tìm theo tên...";
                TimTheoTenDVtb.ForeColor = Color.Gray;
            }
        }

        private void TimTheoMaLHadTB_Enter(object sender, EventArgs e)
        {
            if (TimTheoMaLHadTB.Text == "Tìm theo mã...")
            {
                TimTheoMaLHadTB.Text = "";
                TimTheoMaLHadTB.ForeColor = Color.Black;
            }
        }

        private void TimTheoMaLHadTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TimTheoMaLHadTB.Text))
            {
                TimTheoMaLHadTB.Text = "Tìm theo mã...";
                TimTheoMaLHadTB.ForeColor = Color.Gray;
            }
        }

        private void TimTheoMaDVtb_Enter(object sender, EventArgs e)
        {
            if (TimTheoMaDVtb.Text == "Tìm theo mã...")
            {
                TimTheoMaDVtb.Text = "";
                TimTheoMaDVtb.ForeColor= Color.Black;
            }
        }

        private void TimTheoMaDVtb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty (TimTheoMaDVtb.Text))
            {
                TimTheoMaDVtb.Text = "Tìm theo mã...";
                TimTheoMaDVtb.ForeColor = Color.Gray;
            }
        }

        private void TTTenKHLHadTB_Enter(object sender, EventArgs e)
        {
            if (TTTenKHLHadTB.Text == "Tên khách hàng...")
            {
                TTTenKHLHadTB.Text = "";
                TTTenKHLHadTB.ForeColor = Color.Black;
            }
        }

        private void TTTenKHLHadTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTTenKHLHadTB.Text))
            {
                TTTenKHLHadTB.Text = "Tên khách hàng...";
                TTTenKHLHadTB.ForeColor = Color.Gray;
            }
        }

        private void TimTheoMaKHtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
