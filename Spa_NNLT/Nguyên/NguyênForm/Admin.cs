﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Spa_NNLT.Nguyên
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            LoadAccountList();

            LoadDichVuList();

            LoadHoaDonList();

            LoadLichHenList();

            LoadNhanVienlist();
            
            LoadThongTin();

            LoadThemPhong();
            LoadPhong();

            HienThiAdmin();

            

            // Load thông tin từ sql
            // Tìm thông tin qua text box
            // Thêm, xóa, sửa các thông tin 
            // Các bài toán thêm

        }

      

        void LoadThongTin()
        {
            List<NhanVien> nhanViens = NhanVienDAO.Instance.LoadNhanVienAD();

            foreach (NhanVien nhan in nhanViens)
            {
                if (TimTheotenTb.Text == nhan.ten || TimtheoMatb.Text == nhan.id.ToString())
                {
                    MaNVtb.Text = nhan.id;
                    HTtb.Text = nhan.ten;
                    
                    SDTlb.Text = nhan.sDT;
                    NStb.Text = nhan.ngaySinh.ToString();
                    
                    //MKNVadTB.Text = nhan.password;
                }
                
            }
        }
        
        

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
            string query = @"select * from dbo.tblNhanVien";

            NhanVienADdata.DataSource = DataProvider.Instance.Excuted(query);

        }
         

        void LoadDichVuList()
        {
            string query = "SELECT * from dbo.DichVuCon";
            DichVuADdata.DataSource = DataProvider.Instance.Excuted(query);
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
            string ma = MaKHadTB.Text.Trim();
            string ten = HTKHadTB.Text.Trim();
            string sdt = SDTKHadTB.Text.Trim();
            
            

            if (ten == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại.");
                return;
            }

            string query = "INSERT INTO tblKhachHang (makhachhang, tenkhachhang, gioitinh, sdt) " +
                           "VALUES (@ma, @ten, @gioitinh, @sdt)";
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@gioiTinh", raNam.Checked ? "Nam" : "Nữ");
                cmd.ExecuteNonQuery();

                MessageBox.Show("Đã thêm khách hàng mới!");
                LoadAccountList(); // Cập nhật lại comboBox khách hàng
            }
        }

        private void PhongADtp_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void ThemNVbt_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
                {
                    conn.Open();

                    string query = "INSERT INTO tblNhanVien (manhanvien, tennhanvien, gioitinh, sdt, ngaysinh, chucvu, calam) " +
                                   "VALUES (@ma, @HoTen, @GioiTinh, @SDT, @NgaySinh, @ChucVu, @CaLam)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", MaNVtb.Text);
                    cmd.Parameters.AddWithValue("@HoTen", HTtb.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", rNam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@SDT", SDTTb.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", NStb.Value);
                    cmd.Parameters.AddWithValue("@ChucVu", cboChucVu.SelectedValue);
                    cmd.Parameters.AddWithValue("@CaLam", cboCaLam.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm nhân viên thành công!");
                LoadNhanVienlist();
                }
            }

        

        private void XoaNVbt_Click(object sender, EventArgs e)
        {
          
                if (string.IsNullOrEmpty(MaNVtb.Text)) return;

                var confirm = MessageBox.Show("Bạn có chắc muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
                {
                    conn.Open();

                    string query = "DELETE FROM tblNhanVien WHERE manhanvien = @MaNV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", MaNVtb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công!");
                LoadNhanVienlist();
                }
            }

        

        private void CapNhatADbt_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(MaNVtb.Text)) return;
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
                {
                    conn.Open();

                    string query = "UPDATE tblNhanVien SET tennhanvien = @HoTen, gioitinh = @GioiTinh, sdt=@SDT, " +
                                   "ngaysinh=@NgaySinh, chucvu=@ChucVu, calam=@CaLam WHERE manhanvien=@MaNV";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", MaNVtb.Text);
                    cmd.Parameters.AddWithValue("@HoTen", HTtb.Text);
                    cmd.Parameters.AddWithValue("@GioiTinh", rNam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@SDT", SDTTb.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", NStb.Value);
                    //string Cv = cboChucVu.Text;
                    cmd.Parameters.AddWithValue("@ChucVu", cboChucVu.SelectedValue);
                    //string cl = cboCaLam.Text;
                    cmd.Parameters.AddWithValue("@CaLam", cboCaLam.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                LoadNhanVienlist();
                }
            }

        

        private void ThemDVadTB_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();

                string query = "INSERT INTO DichVuCon (idcon, tendichvucon, gia, thoigian, iddichvucha) " +
                   "VALUES (@ma, @ten, @gia, @tg, @macha)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", MaDVADtb.Text);
                cmd.Parameters.AddWithValue("ten", TenDVadTB.Text);
                cmd.Parameters.AddWithValue("@gia", GiaDVadTB.Text);
                cmd.Parameters.AddWithValue("@tg", ThoiGianDVadTB.Text);
                cmd.Parameters.AddWithValue("@macha", comboBoxDichVuCha.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm dịch vụ thành công!");
                LoadDichVuList();
            }
        }

        private void CapNhatDVadBT_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(MaDVADtb.Text)) return;
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();

                string query = "UPDATE DichVuCon SET tendichvucon = @ten, gia = @Gia, iddichvucha = @IDcha WHERE idcon = @ID " ;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", MaDVADtb.Text);
                cmd.Parameters.AddWithValue("@ten", TenDVadTB.Text);
                cmd.Parameters.AddWithValue("@Gia", GiaDVadTB.Text);
                cmd.Parameters.AddWithValue("@IDcha", comboBoxDichVuCha.SelectedValue);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật nhân viên thành công!");
                LoadDichVuList();
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (KhachHangADdata.CurrentRow != null)
            {
                //int id = Convert.ToInt32(KhachHangADdata.CurrentRow.Cells["makhachhang"].Value);
                string hoten = HTKHadTB.Text.Trim();
                string sdt = SDTKHadTB.Text.Trim();
                string id = MaKHadTB.Text.Trim();
                

                string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
                //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionSTR))
                {
                    conn.Open();
                    string query = "UPDATE tblKhachHang SET tenkhachhang = @ten, sdt = @sdt, gioitinh = @gioitinh WHERE makhachhang = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ten", hoten);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@gioiTinh", raNam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã sửa thông tin khách hàng!");
                    LoadAccountList();
                }
            }
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
        

        private void NhanVienADdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = NhanVienADdata.Rows[e.RowIndex];
                MaNVtb.Text = row.Cells[0].Value?.ToString();
                HTtb.Text = row.Cells[1].Value?.ToString();
                
                string gioiTinh = row.Cells["gioitinh"].Value.ToString();
                if (gioiTinh == "Nam")
                    rNam.Checked = true;
                else
                    rNu.Checked = true;
                SDTTb.Text = row.Cells[4].Value?.ToString();
                //NStb.Text = row.Cells[2].Value?.ToString();
                if (DateTime.TryParse(row.Cells[4].Value?.ToString(), out DateTime ngaySinh))
                {
                    NStb.Value = ngaySinh;
                }
                else
                {
                    // Nếu dữ liệu không hợp lệ thì cho ngày mặc định hoặc thông báo lỗi
                    NStb.Value = DateTime.Today;
                }

                cboChucVu.Text = row.Cells[5].Value?.ToString();    
                cboCaLam.Text = row.Cells[6].Value?.ToString();
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
                string Ceil1 = row.Cells["TenDichVu"].Value?.ToString();
                string Ceil2 = row.Cells["ID"].Value?.ToString();

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
                string gioiTinh = row.Cells["gioitinh"].Value.ToString();
                if (gioiTinh == "Nam")
                    raNam.Checked = true;
                else
                    raNu.Checked = true;
                SDTKHadTB.Text = row.Cells[3].Value?.ToString();
                    
            }
        }

        private void DichVuADdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = DichVuADdata.Rows[e.RowIndex];
                MaDVADtb.Text = row.Cells["idcon"].Value?.ToString();
                TenDVadTB.Text = row.Cells["tendichvucon"].Value?.ToString();
                GiaDVadTB.Text = row.Cells["gia"].Value?.ToString();
                ThoiGianDVadTB.Text = row.Cells["thoigian"].Value?.ToString();
                comboBoxDichVuCha.Text = row.Cells["iddichvucha"].Value?.ToString();
            }
        }

        

        private void LichHenADdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = LichHenADdata.Rows[e.RowIndex];
            //    MaLHadTB.Text = row.Cells["malichhen"].Value?.ToString();
            //    MaKHLHadTB.Text = row.Cells["makhachhang"].Value?.ToString();
            //    MaNVLHadTB.Text = row.Cells["manhanvien"].Value?.ToString();
            //    //MaDVLHadTB.Text = row.Cells["madichvu"].Value?.ToString();
            //    MaPhongLHadTB.Text = row.Cells["maphong"].Value?.ToString();
            //    TGLHadTB.Text = row.Cells["thoigian"].Value?.ToString();
            //    TTLHadTB.Text = row.Cells["trangthai"].Value?.ToString();
            //}
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
                Button btn = new Button() { Width = PhongDAO.PhongWidth, Height = PhongDAO.PhongHeight };
                btn.Location = new Point(x, y);
                btn.Text = phong.maPhong.ToString();
                phong.TimMLH();
                if (phong.tinhTrang.ToString().Trim() == "0")
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
                cboLoaiphong.Text = phong.loaiPhong.ToString();
                string tg = phong.tinhTrang.ToString();
                if (tg.Trim() == "0")
                {
                    TinhTrangADtb.Text = "Trống";
                }
                else
                {
                    TinhTrangADtb.Text = "Đang làm";
                }
                MLHPhongADtb.Text = phong.maLichHen.ToString();
            }
        }

        private void NhanVienADdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (KhachHangADdata.CurrentRow != null)
            {
                string id = MaKHadTB.Text.Trim();
                var confirm = MessageBox.Show("Bạn có chắc muốn xoá khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
                //string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
                string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionSTR))
                    {
                        conn.Open();
                        string query = "DELETE FROM tblKhachHang WHERE makhachhang = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đã xoá khách hàng!");
                        LoadAccountList();
                    }
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TimtheoMatb_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhanVienADdata_Click(object sender, EventArgs e)
        {
        }

        void HienThiAdmin()
        {
            userLogin logininfo = QuanLiDAO.Instance.Readlogininfo();
            string query = "SELECT * from dbo.tblQuannLy where account = N'" + logininfo.Username + "' and password = N'" + logininfo.Password + "'";
            DataTable result = DataProvider.Instance.Excuted(query);
            if (result.Rows.Count > 0)
            {
                DataRow dr = result.Rows[0];
                MQLtb.Text = dr["maquanly"].ToString();
                HTQLtb.Text = dr["tenquanly"].ToString();
                string tg = dr["gioitinh"].ToString().Trim();
                if (tg == "1")
                {
                    GTQLtb.Text = "Nam";
                }
                else
                {
                    GTQLtb.Text = "Nữ";
                }
                NSQLtb.Text = dr["ngaysinh"].ToString();
                SLNVtb.Text = (NhanVienADdata.Rows.Count - 1).ToString();
            }
        }

        private void ThemPhongADbt_Click(object sender, EventArgs e)
        {
            string soPhong = SoPhongADtb.Text.Trim();
            string loaiPhong = cboLoaiphong.SelectedValue.ToString();
            string tinhTrang = TinhTrangADtb.Text.Trim();
            //int tt = (tinhTrang == "Trống") ? 0 : 1;
            string query = "INSERT INTO tblPhong(maphong, loaiphong, tinhtrang) " +
                           "VALUES (@sophong, @loaiphong, @tinhtrang)";
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionSTR)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sophong", soPhong);
                command.Parameters.AddWithValue("@loaiphong", loaiPhong);
                command.Parameters.AddWithValue("@tinhtrang", tinhTrang );
                command.ExecuteNonQuery();
                MessageBox.Show("Đã thêm phòng thành công!");
                LoadPhong();
            }
        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void TenDVadTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void XoaDVadBT_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(MaDVADtb.Text)) return;

            var confirm = MessageBox.Show("Bạn có chắc muốn xoá dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();

                string query = "DELETE FROM DichVuCon WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", MaDVADtb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa dịch vụ thành công!");
                LoadDichVuList();
            }
        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(MaLHadTB.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã lịch hẹn cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa lịch hẹn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionSTR))
                {
                    conn.Open();
                    string query = "DELETE FROM tblLichHen WHERE malichhen = @malichhen";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@malichhen", MaLHadTB.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa lịch hẹn thành công!");
                        LoadLichHenList(); // gọi lại hàm load để làm mới danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lịch hẹn để xóa.");
                    }
                }
            }
    }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void cboKhachHang_DropDown(object sender, EventArgs e)
        {
            string queryKH = "SELECT makhachhang, tenkhachhang + ' / ' + sdt AS thongtin FROM tblKhachHang";
            cboKhachHang.DataSource = DataProvider.Instance.Excuted(queryKH);
            cboKhachHang.DisplayMember = "thongtin";
            cboKhachHang.ValueMember = "makhachhang";
        }

        private void cboNhanVien_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cboPhong_DropDown(object sender, EventArgs e)
        {
        
        }

        private void cboChucVu_DropDown(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                string query = "SELECT * FROM DichVuCha";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboChucVu.DataSource = dt;
                cboChucVu.DisplayMember = "tendichvucha";
                cboChucVu.ValueMember = "tendichvucha";
            }
        }

        private void cboCaLam_DropDown(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                string query = "SELECT * FROM CaLam";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboCaLam.DataSource = dt;
                cboCaLam.DisplayMember = "tenca";
                cboCaLam.ValueMember = "tenca";
            }
        }

        private void comboBoxDichVuCha_DropDown(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DichVuCha";
            DataTable dt = DataProvider.Instance.Excuted(query);
            comboBoxDichVuCha.DataSource = dt;
            comboBoxDichVuCha.DisplayMember = "tendichvucha";
            comboBoxDichVuCha.ValueMember = "tendichvucha";
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "SELECT idcha,tendichvucha from DichVuCha";
            comboBoxDVCha.DataSource = DataProvider.Instance.Excuted(query);
            comboBoxDVCha.DisplayMember = "tendichvucha";
            comboBoxDVCha.ValueMember = "tendichvucha";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxDVCha.SelectedValue != null && comboBoxDVCha.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string madvcha = comboBoxDVCha.SelectedValue.ToString();
                string query = "SELECT tendichvucon FROM DichVuCon WHERE iddichvucha = @madvcha";
                DataTable data = DataProvider.Instance.Excuted(query, new object[] { madvcha });
                comboBoxDVCon.DataSource = data;
                comboBoxDVCon.DisplayMember = "tendichvucon";
                comboBoxDVCon.ValueMember = "tendichvucon";

                string query2 = "SELECT tennhanvien, tennhanvien + '/' + chucvu + '/' + calam as thongtin FROM tblNhanVien where chucvu = @madvcha";
                DataTable data2 = DataProvider.Instance.Excuted(query2, new object[] { madvcha });
                cboNhanVien.DataSource = data2;
                cboNhanVien.DisplayMember = "thongtin";
                cboNhanVien.ValueMember = "tennhanvien";

                string queryPhong = "SELECT maphong, maphong + '/' + loaiphong + '/' + tinhtrang AS thongtin FROM tblPhong where loaiphong = @madvcha";
                cboPhong.DataSource = DataProvider.Instance.Excuted(queryPhong, new object[] { madvcha });
                cboPhong.DisplayMember = "thongtin";
                cboPhong.ValueMember = "maphong";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string malichhen = MaLHadTB.Text.ToString();
            string makhachhang = cboKhachHang.SelectedValue.ToString();  
            string manhanvien = cboNhanVien.SelectedValue.ToString();
            string maphong = cboPhong.SelectedValue.ToString();
            string madichvu = comboBoxDVCon.SelectedValue.ToString();
            DateTime thoigianbatdau = dateTimePicker2.Value;
            ThemLichHen (malichhen, makhachhang, manhanvien, maphong, madichvu, thoigianbatdau);
        }

        bool ThemLichHen(string malichhen, string makhachhang, string manhanvien, string maphong, string madichvu, DateTime thoigianbatdau)
        {
            // Lấy thời lượng dịch vụ từ CSDL
            int thoiLuong = LayThoiGianDichVu(madichvu); // ví dụ trả về 90 phút
            DateTime thoiGianKetThuc = thoigianbatdau.AddMinutes(thoiLuong);

            // Kiểm tra trùng lịch
            if (TrungLichNhanVien(manhanvien, thoigianbatdau, thoiGianKetThuc))
            {
                MessageBox.Show("Nhân viên đã có lịch hẹn trong thời gian này!");
                return false;
            }

            if (TrungLichPhong(manhanvien, thoigianbatdau, thoiGianKetThuc))
            {
                MessageBox.Show("Phòng đã có lịch hẹn trong thời gian này!");
                return false;
            }

            if (TrungLichKhachHang(manhanvien, thoigianbatdau, thoiGianKetThuc))
            {
                MessageBox.Show("Khách hàng đã có lịch hẹn trong thời gian này!");
                return false;
            }

            // Nếu không trùng, thêm lịch hẹn vào CSDL
            string query = @"INSERT INTO tblLichHen (malichhen, makhachhang, manhanvien, maphong, madichvu, thoigian, tinhtrang)
                     VALUES (@malichhen, @makhachhang, @manhanvien, @maphong, @madichvu, @thoigianbatdau, N'Đang chờ')";

            int result = DataProvider.Instance.ExcutedNoneQuery(query,
                new object[] { malichhen, makhachhang, manhanvien, maphong, madichvu, thoigianbatdau });

            return result > 0;
        }
        bool TrungLichNhanVien(string manhanvien, DateTime thoigianbatdau, DateTime ketThuc)
        {
            string query = @"SELECT COUNT(*) FROM tblLichHen
                     WHERE manhanvien = @manhanvien
                     AND thoigianbatdau < @KetThuc";
            int count = (int)DataProvider.Instance.ExcutedSaclar(query, new object[] { manhanvien, ketThuc, thoigianbatdau });
            return count > 0;
        }

        bool TrungLichPhong(string maphong, DateTime thoigianbatdau, DateTime ketThuc)
        {
            string query = @"SELECT COUNT(*) FROM tblLichHen
                     WHERE maphong = @maphong
                     AND thoigianbatdau < @KetThuc";
            int count = (int)DataProvider.Instance.ExcutedSaclar(query, new object[] { maphong, ketThuc, thoigianbatdau });
            return count > 0;
        }

        bool TrungLichKhachHang(string makhachhang, DateTime thoigianbatdau, DateTime ketThuc)
        {
            string query = @"SELECT COUNT(*) FROM tblLichHen
                     WHERE makhachhang = @makhachhang
                     AND ThoiGianBatDau < @KetThuc";
            int count = (int)DataProvider.Instance.ExcutedSaclar(query, new object[] { makhachhang, ketThuc, thoigianbatdau });
            return count > 0;
        }

        int LayThoiGianDichVu(string madichvu)
        {
            int thoigian = 0;
            string query = "SELECT thoigian FROM DichVuCon WHERE tendichvucon = @madichvu";

            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@madichvu", madichvu);
                object result = cmd.ExecuteScalar();
                if (result != null)
                    thoigian = Convert.ToInt32(result);
            }
            return thoigian;
        }
        

        private void PhongADpn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboLoaiphong_DropDown(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionSTR))
            {
                conn.Open();
                string query = "SELECT * FROM DichVuCha";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboLoaiphong.DataSource = dt;
                cboLoaiphong.DisplayMember = "tendichvucha";
                cboLoaiphong.SelectedValue = "tendichvucha";
            }
        }

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDichVuCha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CapNhatPhogADbt_Click(object sender, EventArgs e)
        {

        }




        //private void CapNhatADbt_Click(object sender, EventArgs e)
        //{

        //    if (string.IsNullOrEmpty(MaNVtb.Text)) return;
        //    //string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
        //    string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
        //    using (SqlConnection conn = new SqlConnection(connectionSTR))
        //    {
        //        conn.Open();

        //        string query = "UPDATE tblNhanVien SET tennhanvien = @HoTen, gioitinh = @GioiTinh, sdt=@SDT, " +
        //                       "ngaysinh=@NgaySinh, chucvu=@ChucVu, calam=@CaLam WHERE manhanvien=@MaNV";

        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@MaNV", MaNVtb.Text);
        //        cmd.Parameters.AddWithValue("@HoTen", HTtb.Text);
        //        cmd.Parameters.AddWithValue("@GioiTinh", rNam.Checked ? "Nam" : "Nữ");
        //        cmd.Parameters.AddWithValue("@SDT", SDTTb.Text);
        //        cmd.Parameters.AddWithValue("@NgaySinh", NStb.Value);
        //        string Cv = cboChucVu.Text;
        //        cmd.Parameters.AddWithValue("@ChucVu", Cv);
        //        string cl = cboCaLam.Text;
        //        cmd.Parameters.AddWithValue("@CaLam", cl);
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Cập nhật nhân viên thành công!");
        //        LoadNhanVienlist();
        //    }
        //}
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    string ma = MaKHadTB.Text.Trim();
        //    string ten = HTKHadTB.Text.Trim();
        //    string sdt = SDTKHadTB.Text.Trim();
        //    string gioitinh = GTKhadTB.Text.Trim();
        //    int tggt = 0;
        //    if (gioitinh == "Nam")//" phhhh "
        //    {
        //        tggt = 1;
        //    }


        //    if (ten == "" || sdt == "")
        //    {
        //        MessageBox.Show("Vui lòng nhập tên và số điện thoại.");
        //        return;
        //    }

        //    string query = "INSERT INTO tblKhachHang (makhachhang, tenkhachhang, gioitinh, sdt) " +
        //                   "VALUES (@ma, @ten, @gioitinh, @sdt)";
        //    //string connectionSTR = "Data Source=LAPTOPMEMUA\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
        //    string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
        //    using (SqlConnection connection = new SqlConnection(connectionSTR))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@ten", ten);
        //        cmd.Parameters.AddWithValue("@sdt", sdt);
        //        cmd.Parameters.AddWithValue("@ma", ma);
        //        cmd.Parameters.AddWithValue("@gioitinh", tggt);
        //        cmd.ExecuteNonQuery();

        //        MessageBox.Show("Đã thêm khách hàng mới!");
        //        LoadAccountList(); // Cập nhật lại comboBox khách hàng
        //    }
        //}

    }
}

