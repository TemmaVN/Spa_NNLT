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
using System.Security.Principal;



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
            LoadPhong();
            
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
                    NStb.Text = nhan.ngaySinh.ToString();
                    //TDNNVadTB.Text = nhan.username;
                    //MKNVadTB.Text = nhan.password;
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

        void LoadDichVu()
        {
            List<DIchVu> dIchVus = DichVuDAO.Instance.LoadTableList();
            
        }

        #endregion

        #region Events

        void LoadThemPhong()
        {
            
        }

        void LoadHoaDonList()
        {
            string query = "SELECT * from dbo.tblHoaDon,dbo.tblLichHen";
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

        

        void LoadNhanVienList()
        {
            string query = "SELECT * from dbo.tblNhanVien";
            NhanVienADdata.DataSource = DataProvider.Instance.Excuted(query);
        }

        void LoadLichHenList()
        {
            string query = "select * from dbo.tblLichHen";
            LichHenADdata.DataSource = DataProvider.Instance.Excuted(query);
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
            TimtheoMatb.Text = "Tìm theo mã ...";
            TimtheoMatb.ForeColor = Color.Gray;
            TimTheoTenKHtb.Text = "Tìm theo tên ...";
            TimTheoTenKHtb.ForeColor = Color.Gray;
            TimTheoMaKHtb.Text = "Tìm theo số điện thoại ...";
            TimTheoMaKHtb.ForeColor = Color.Gray;
            TimTheoTenDVtb.Text = "Tìm theo tên ...";
            TimTheoTenDVtb.ForeColor = Color.Gray;
            TimTheoMaDVtb.Text = "Tìm theo mã ...";
            TimTheoMaDVtb.ForeColor = Color.Gray;   
            TimTheoMaLHadTB.Text = "Tìm theo mã ...";
            TimTheoMaLHadTB.ForeColor = Color.Gray;
            TTMaHDadTB.Text = "Tìm theo mã ...";
            TTMaHDadTB.ForeColor= Color.Gray;
            TTTenKHLHadTB.Text = "Tên khách hàng ...";
            TTTenKHLHadTB.ForeColor = Color.Gray;
            TTMaLHHDadTB.Text = "Tên khách hàng ...";
            TTMaLHHDadTB.ForeColor = Color.Gray;
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
            if(TimtheoMatb.Text == "Tìm theo mã ...")
            {
                TimtheoMatb.Text = "";
                TimtheoMatb.ForeColor= Color.Black;
            }
        }

        private void TimtheoMatb_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty (TimtheoMatb.Text))
            {
                TimtheoMatb.Text = "Tìm theo mã ...";
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
            string filter1 = TimTheoTenKHtb.Text.Trim();
            string filter2 = TimTheoMaKHtb.Text.Trim();

            KhachHangADdata.CurrentCell = null;

            foreach(DataGridViewRow row in KhachHangADdata.Rows)
            {
                if (row.IsNewRow) continue;
                string Cell1 = row.Cells["tenkhachhang"].Value.ToString().Trim();
                string Cell2 = row.Cells["sdt"].Value.ToString().Trim();

                if (filter1 == "Tìm theo tên ..." && filter2 == "Tìm theo số điện thoại ...")
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = (filter1 == "" || Cell1.Contains(filter1)) || (filter2 == "" || Cell2.Contains(filter2));
                }
            }
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
            if (TimTheoMaKHtb.Text == "Tìm theo số điện thoại ...")
            {
                TimTheoMaKHtb.Text = "";
                TimTheoMaKHtb.ForeColor = Color.Black;
            }
        }

        private void TimTheoMaKHtb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TimTheoMaKHtb.Text))
            {
                TimTheoMaKHtb.Text = "Tìm theo số điện thoại ...";
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
            
        }

        private void XoaNVbt_Click(object sender, EventArgs e)
        {
            
        }

        private void CapNhatADbt_Click(object sender, EventArgs e)
        {
            
        }

        private void ThemDVadTB_Click(object sender, EventArgs e)
        {
            
        }

        private void CapNhatDVadBT_Click(object sender, EventArgs e)
        {
           
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
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
        

        private void Khachhangtb_Click(object sender, EventArgs e)
        {

        }

        private void NhanVientb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filter1 = TimTheotenTb.Text.Trim();
            string filter2 = TimtheoMatb.Text.Trim();

            NhanVienADdata.CurrentCell = null;

            foreach (DataGridViewRow row in NhanVienADdata.Rows)
            {
                if (row.Cells["tennhanvien"].Value != null && row.Cells["manhanvien"].Value != null)
                {
                    string cellvalue = row.Cells["tennhanvien"].Value.ToString();
                    string cellvalue1 = row.Cells["manhanvien"].Value.ToString();
                    HTtb.Text = filter2;
                    if(filter1 == "Tìm theo tên ..." && filter2 == "Tìm theo mã ...")
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = (filter1 == "" || cellvalue.Contains(filter1)) ||
              (filter2 == "" || cellvalue1.Contains(filter2));
                    }


                }
            }    

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimTheoTenDVtb_Enter(object sender, EventArgs e)
        {
            if (TimTheoTenDVtb.Text == "Tìm theo tên ...")
            {
                TimTheoTenDVtb.Text = "";
                TimTheoTenDVtb.ForeColor = Color.Black;
            }
        }

        private void TimTheoTenDVtb_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TimTheoTenDVtb.Text))
            {
                TimTheoTenDVtb.Text = "Tìm theo tên ...";
                TimTheoTenDVtb.ForeColor = Color.Gray;
            }
        }

        private void TimTheoMaLHadTB_Enter(object sender, EventArgs e)
        {
            if (TimTheoMaLHadTB.Text == "Tìm theo mã ...")
            {
                TimTheoMaLHadTB.Text = "";
                TimTheoMaLHadTB.ForeColor = Color.Black;
            }
        }

        private void TimTheoMaLHadTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TimTheoMaLHadTB.Text))
            {
                TimTheoMaLHadTB.Text = "Tìm theo mã ...";
                TimTheoMaLHadTB.ForeColor = Color.Gray;
            }
        }

        private void TimTheoMaDVtb_Enter(object sender, EventArgs e)
        {
            if (TimTheoMaDVtb.Text == "Tìm theo mã ...")
            {
                TimTheoMaDVtb.Text = "";
                TimTheoMaDVtb.ForeColor= Color.Black;
            }
        }

        private void TimTheoMaDVtb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TimTheoMaDVtb.Text))
            {
                TimTheoMaDVtb.Text = "Tìm theo mã ...";
                TimTheoMaDVtb.ForeColor = Color.Gray;
            }
        }

        private void TTTenKHLHadTB_Enter(object sender, EventArgs e)
        {
            if (TTTenKHLHadTB.Text == "Tên khách hàng ...")
            {
                TTTenKHLHadTB.Text = "";
                TTTenKHLHadTB.ForeColor = Color.Black;
            }
        }

        private void TTTenKHLHadTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTTenKHLHadTB.Text))
            {
                TTTenKHLHadTB.Text = "Tên khách hàng ...";
                TTTenKHLHadTB.ForeColor = Color.Gray;
            }
        }

        private void TimTheoMaKHtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTMaKHHDadTB_Enter(object sender, EventArgs e)
        {
            if (TTMaLHHDadTB.Text == "Tên khách hàng ...")
            {
                TTMaLHHDadTB.Text = "";
                TTMaLHHDadTB.ForeColor = Color.Black;
            }
        }

        private void TTMaKHHDadTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTMaLHHDadTB.Text))
            {
                TTMaLHHDadTB.Text = "Tên khách hàng ...";
                TTMaLHHDadTB.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void NhanVienADdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = NhanVienADdata.Rows[e.RowIndex];
                MaNVtb.Text = row.Cells[0].Value?.ToString();
                HTtb.Text = row.Cells[1].Value?.ToString();
                string tg = row.Cells[3].Value?.ToString();
                if (tg == "0")
                {
                    GTtb.Text = "Nữ";
                }
                else
                {
                    GTtb.Text = "Nam";
                }
                SDTTb.Text = row.Cells[4].Value?.ToString();
                NStb.Text = row.Cells[2].Value?.ToString();
                TDNNVadTB.Text = row.Cells[5].Value?.ToString();
                MKNVadTB.Text = row.Cells[6].Value?.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string filter1 = TimTheoTenDVtb.Text.Trim();
            string filter2 = TimTheoMaDVtb.Text.Trim();

            DichVuADdata.CurrentCell = null;

            foreach (DataGridViewRow row in DichVuADdata.Rows)
            {

                if (row.IsNewRow) continue;
                string Ceil1 = row.Cells["ten"].Value?.ToString();
                string Ceil2 = row.Cells["madichvu"].Value?.ToString();

                if (filter1 == "Tìm theo tên ..." && filter2 == "Tìm theo mã ...")
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = filter1 == "" || filter2 == "" || Ceil1.Contains(filter1) || Ceil2.Contains(filter2);
                }
            }
        }

        private void KhachHangADdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                DataGridViewRow row = KhachHangADdata.Rows[e.RowIndex];
                MaKHadTB.Text = row.Cells[0].Value?.ToString();
                HTKHadTB.Text = row.Cells[1].Value?.ToString();
                string tg = row.Cells[2].Value?.ToString();
                if (tg == "0")
                {
                    GTKhadTB.Text = "Nữ";
                }
                else
                {
                    GTKhadTB.Text = "Nam";
                } 
                SDTKHadTB.Text = row.Cells[3].Value?.ToString();
                    
            }
        }

        private void DichVuADdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = DichVuADdata.Rows[e.RowIndex];
                MaDVADtb.Text = row.Cells["madichvu"].Value?.ToString();
                TenDVadTB.Text = row.Cells["ten"].Value?.ToString();
                GiaDVadTB.Text = row.Cells["giadichvu"].Value?.ToString();
                ThoiGianDVadTB.Text = row.Cells["thoiluong"].Value?.ToString();    
            }
        }

        private void LichHenADdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = LichHenADdata.Rows[e.RowIndex];
                MaLHadTB.Text = row.Cells["malichhen"].Value?.ToString();
                MaKHLHadTB.Text = row.Cells["makhachhang"].Value?.ToString();
                MaNVLHadTB.Text = row.Cells["manhanvien"].Value?.ToString();
                MaDVLHadTB.Text = row.Cells["madichvu"].Value?.ToString();
                MaPhongLHadTB.Text = row.Cells["maphong"].Value?.ToString();
                TGLHadTB.Text = row.Cells["thoigian"].Value?.ToString();
                TTLHadTB.Text = row.Cells["trangthai"].Value?.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string filter1 = TimTheoMaLHadTB.Text.Trim();
            LichHenADdata.CurrentCell = null;

            foreach(DataGridViewRow row in LichHenADdata.Rows)
            {
                if (row.IsNewRow) continue;
                string cell = row.Cells["malichhen"].Value?.ToString().Trim();
                if (filter1 == "Tìm theo mã ...")
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = filter1 == "" || cell.Contains(filter1);
                }
            }
        }

        private void HoaDonADdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = HoaDonADdata.Rows[e.RowIndex];
                MaHDadTB.Text = row.Cells["mahoadon"].Value?.ToString();
                MaLHHDadTB.Text = row.Cells["malichhen"].Value?.ToString();

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        void LoadPhong()
        {
            List<Phong> phongs = PhongDAO.Instance.LoadDanhSachPhong();
            int x = 20;
            int y = 20;
            int maxwidth = PhongADpn.Width - PhongDAO.PhongWidth;
            foreach (Phong phong in phongs)
            {
                Button btn = new Button() { Width = PhongDAO.PhongWidth, Height = PhongDAO.PhongHeight  };
                btn.Location = new Point(x, y);
                btn.Text = phong.maPhong.ToString();
                if(phong.tinhTrang.ToString().Trim() == "0")
                {
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.Aqua;
                }
                btn.Tag = phong;
                btn.Click += btn_click;
                PhongADpn.Controls.Add(btn);
                x += PhongDAO.PhongWidth;
                if (x > maxwidth)
                {
                    x = 20;
                    y += PhongDAO.PhongHeight;
                }
                
            }


        }

        private void btn_click(object sender, EventArgs e) { 
            Button btn = sender as Button;
            Phong phong = btn.Tag as Phong;
            if (phong != null)
            {
                SoPhongADtb.Text = phong.maPhong.ToString();
                LoaiPhonfADtb.Text = phong.loaiPhong.ToString();
                string tg = phong.tinhTrang.ToString();
                if (tg.Trim() == "0")
                {
                    TinhTrangADtb.Text = "Trống";
                }
                else {
                    TinhTrangADtb.Text = "Đang làm";
                }
            }
        }

        
    }
}
