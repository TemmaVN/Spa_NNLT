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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.CodeDom.Compiler;
using System.Drawing.Text;
using System.Collections;
using Spa_NNLT.Nguyên.Lịch_hẹn;
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

            LoadLichHenList();

            LoadDichVuList();

            LoadNhanVienlist();
            
            LoadThongTin();

            LoadThemPhong();
            LoadPhong();

            LoadlvCombo();
            Loadlv1();

            HienThiAdmin();
            LoadComboList();
           
           
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

        void LoadlvCombo()
        {
            lvCombo.View = View.Details;
            lvCombo.Columns.Clear();
            lvCombo.Columns.Add("", 1);
            lvCombo.Columns.Add("Tên dịch vụ", 250);
            lvCombo.Columns.Add("Giá cả", 150);
            lvCombo.Columns.Add("Thời lượng", 150);          
        }

        void Loadlv1()
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("", 1);
            listView1.Columns.Add("Tên dịch vụ/combo", 160);
            listView1.Columns.Add("Giá cả", 120);
            listView1.Columns.Add("Thời lượng", 120);
        }

        void LoadThemPhong()
        {
            
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

        void LoadComboList()
        {
            string query = "SELECT * from dbo.Combo";
            ComboData.DataSource = DataProvider.Instance.Excuted(query);
        }
        void LoadLichHenList()
        {
            string query = "select * from dbo.tblLichHen";
            DateTime ht = DateTime.Now;
            DataTable Lichhen = DataProvider.Instance.Excuted(query);

            DataView DT1 = new DataView(Lichhen);
            DT1.RowFilter = $"thoigianbatdau >= #{ht:MM/dd/yyyy HH:mm:ss}#";
            LichHenADdata.DataSource = DT1;

            DataView DT2 = new DataView(Lichhen);
            DT2.RowFilter = $"thoigianbatdau < #{ht:MM/dd/yyyy HH:mm:ss}#";
            LHChTTdata.DataSource = DT2;

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
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@ma", MaKHadTB.Text.Trim()),
                    new SqlParameter("@ten", HTKHadTB.Text.Trim()),
                    new SqlParameter("@gioiTinh", raNam.Checked ? "Nam" : "Nữ"),
                    new SqlParameter("@SDT",SDTKHadTB.Text.Trim()),
            };
            if (HTKHadTB.Text.Trim() == "" || SDTKHadTB.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại.");
                return;
            }

            string query = "INSERT INTO tblKhachHang (makhachhang, tenkhachhang, gioitinh, sdt) " +
                           "VALUES (@ma, @ten, @gioitinh, @sdt)";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, parameters);
            if (results > 0) MessageBox.Show("Thêm khách hàng thành công");
            else MessageBox.Show("Thêm khách hàng thất bại");          
                LoadAccountList(); // Cập nhật lại comboBox khách hàng            
        }

        private void PhongADtp_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void ThemNVbt_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@ma", MaNVtb.Text),
                    new SqlParameter("@HoTen", HTtb.Text),
                    new SqlParameter("@GioiTinh", rNam.Checked ? "Nam" : "Nữ"),
                    new SqlParameter("@SDT", SDTTb.Text),
                    new SqlParameter("@NgaySinh", NStb.Value),                    
            };
            string query = "INSERT INTO tblNhanVien (manhanvien, tennhanvien, gioitinh, sdt, ngaysinh) " +
                                     "VALUES (@ma, @HoTen, @GioiTinh, @SDT, @NgaySinh)";
            int results =  DataProvider.Instance.ExcutedNoneQuery(query, parameters);
            if (results > 0) MessageBox.Show("Thêm nhân viên thành công");
            else MessageBox.Show("Thêm nhân viên thất bại");
            LoadNhanVienlist();
        }





        private void XoaNVbt_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrEmpty(MaNVtb.Text)) return;

            var confirm = MessageBox.Show("Bạn có chắc muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;           
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("MaNV", MaNVtb.Text)
            };
            string query = "DELETE FROM tblNhanVien WHERE manhanvien = @MaNV";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, parameters);
            if (results > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            LoadNhanVienlist();    
            }

        

        private void CapNhatADbt_Click(object sender, EventArgs e)
        {           
            if (string.IsNullOrEmpty(MaNVtb.Text)) return;            
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaNV", MaNVtb.Text),
                new SqlParameter("@HoTen", HTtb.Text),
                new SqlParameter("@GioiTinh", rNam.Checked ? "Nam" : "Nữ"),
                new SqlParameter("@SDT", SDTTb.Text),
                new SqlParameter("@NgaySinh", NStb.Value)                
            };
            string query = "UPDATE tblNhanVien SET tennhanvien = @HoTen, gioitinh = @GioiTinh, sdt=@SDT, " +
                           "ngaysinh=@NgaySinh WHERE manhanvien=@MaNV";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, parameters);
            if (results > 0) MessageBox.Show("Cập nhật thành công");
            else MessageBox.Show("Cập nhật thất bại");
            LoadNhanVienlist();                
            }

        

        private void ThemDVadTB_Click(object sender, EventArgs e)
        {
            
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@ma", MaDV.Text),
                new SqlParameter("@ten", TenDVadTB.Text),
                new SqlParameter("gia", GiaDVadTB.Text),
                new SqlParameter("@tg", ThoiGianDVadTB.Text),
                new SqlParameter("@macha", comboBoxDichVuCha.SelectedValue),
            };
            string query = "INSERT INTO DichVuCon (idcon, tendichvucon, gia, thoigian, iddichvucha) " +
                  "VALUES (@ma, @ten, @gia, @tg, @macha)";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
            if (results > 0) MessageBox.Show("Thêm dịch vụ thành công");
            else MessageBox.Show("Thêm dịch vụ thất bại");
            LoadDichVuList();
        }

        private void CapNhatDVadBT_Click(object sender, EventArgs e)
        {

            

            if (string.IsNullOrEmpty (TenDVadTB.Text)) return;
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@ma", MaDV.Text),
                new SqlParameter("@ten", TenDVadTB.Text),
                new SqlParameter("@Gia", GiaDVadTB.Text),
                new SqlParameter("@IDcha", comboBoxDichVuCha.Text),
                new SqlParameter("@thoigian", ThoiGianDVadTB.Text),
            };
            string query = "UPDATE DichVuCon SET tendichvucon = @ten, gia = @Gia, thoigian = @thoigian, iddichvucha = @IDcha WHERE idcon = @ma ";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
            if (results > 0) MessageBox.Show("Cập nhật thành công");
            else MessageBox.Show("Cập nhật thất bại");
            LoadDichVuList ();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaKHadTB.Text)) {return;}
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@ten", HTKHadTB.Text),
                new SqlParameter("@sdt", SDTKHadTB.Text),
                new SqlParameter("@gioitinh", raNam.Checked ? "Nam" : "Nữ"),
                new SqlParameter("@id", MaKHadTB.Text),
            };
            string query = "UPDATE tblKhachHang SET tenkhachhang = @ten, sdt = @sdt, gioitinh = @gioitinh WHERE makhachhang = @id";
            int result = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
            if (result > 0) MessageBox.Show("Cập nhật thành công");
            else MessageBox.Show("Cập nhật thất bại");
            LoadAccountList();
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

    

        private void TimTheoMaKHtb_TextChanged(object sender, EventArgs e)
        {

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
                MaDV.Text = row.Cells["idcon"].Value?.ToString();
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
                
                string tg = phong.tinhTrang.ToString();
                if (tg.Trim() == "0")
                {
                    TTphongcb.SelectedItem = "Trống";
                }
                else
                {
                    TTphongcb.SelectedItem = "Đang làm";
                }
                MLHPhongADtb.Text = phong.loaiPhong.ToString();
            }
        }

        private void NhanVienADdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(MaKHadTB.Text)) return;

            var confirm = MessageBox.Show("Bạn có chắc muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("id",  MaKHadTB.Text),
            };
            string query = "DELETE FROM tblKhachHang WHERE makhachhang = @id";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameter);
            if (results > 0) MessageBox.Show("Xóa khách hàng thành công");
            else MessageBox.Show("Xóa khách hàng thất bại");
            LoadAccountList();
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
                SDTQLtb.Text = dr["sdtquanly"].ToString();
            }
        }

        private void ThemPhongADbt_Click(object sender, EventArgs e)
        {
            string soPhong = SoPhongADtb.Text.Trim();

            var selectedItem = TTphongcb.SelectedItem;
            string tinhTrang = selectedItem != null ? selectedItem.ToString().Trim() : "";
            string tt = (tinhTrang == "Trống") ? "0" : "1";
            if (tinhTrang == "")
            {
                MessageBox.Show("Chưa để tình trạng!!");
                return;
            }
            string LoaiPhong = MLHPhongADtb.Text.Trim();
            string query = "INSERT INTO tblPhong(maphong, loaiphong, tinhtrang) " +
                           "VALUES (@sophong, @loaiphong, @tinhtrang)";
            string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            //string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionSTR)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sophong", soPhong);
                command.Parameters.AddWithValue("@tinhtrang", tt );
                command.Parameters.AddWithValue("@loaiphong", LoaiPhong);
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
            if (string.IsNullOrEmpty(MaDV.Text)) return;
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@ma", MaDV.Text.ToString()),
            };
            var confirm = MessageBox.Show("Bạn có chắc muốn xoá dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;
            string query = "DELETE FROM DichVuCon WHERE idcon = @ma";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
            if (results > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
            LoadDichVuList();
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
                string connectionSTR = "Data Source=DESKTOP-IE5BPNN\\SQLEXPRESS;Initial Catalog=QUANLY_SPA;Integrated Security=True";
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
            string queryKH = "SELECT tenkhachhang, tenkhachhang + ' / ' + sdt AS thongtin FROM tblKhachHang";
            cboKhachHang.DataSource = DataProvider.Instance.Excuted(queryKH);
            cboKhachHang.DisplayMember = "thongtin";
            cboKhachHang.ValueMember = "tenkhachhang";
        }

        private void cboNhanVien_DropDown(object sender, EventArgs e)
        {
            string QueryNV = "SELECT tennhanvien FROM tblNhanVien";
            cboNhanVien.DataSource = DataProvider.Instance.Excuted(QueryNV);
            cboNhanVien.DisplayMember = "tennhanvien";
            cboNhanVien.ValueMember = "tennhanvien";
        }

        private void cboPhong_DropDown(object sender, EventArgs e)
        {
            string QueryPhong = "SELECT tinhtrang,maphong FROM tblPhong";
            cboPhong.DataSource = DataProvider.Instance.Excuted(QueryPhong);
            cboPhong.DisplayMember = "maphong";
            cboPhong.ValueMember = "maphong";
        }

        

        private void comboBoxDichVuCha_DropDown(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DichVuCha";
            comboBoxDichVuCha.DataSource = DataProvider.Instance.Excuted(query);
            comboBoxDichVuCha.DisplayMember = "tendichvucha";
            comboBoxDichVuCha.ValueMember = "tendichvucha";
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string query = "SELECT tendichvucha from DichVuCha";
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
                comboBoxDVCon.DataSource = DataProvider.Instance.Excuted(query, new object[] { madvcha });
                comboBoxDVCon.DisplayMember = "tendichvucon";
                comboBoxDVCon.ValueMember = "tendichvucon";                
            }
        }
        #region tsts
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion
        private void button10_Click(object sender, EventArgs e)
        {
            string TenDV = "";
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems.Count > 1)
                {
                    TenDV += item.SubItems[1].Text + ", ";
                }
            }

            decimal tongtien = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems.Count > 1)
                {
                    string textGia = item.SubItems[2].Text;
                    decimal gia = ChuyenDoiGia(textGia);
                    tongtien += gia;
                }
            }

           int tongTG = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems.Count > 1)
                {
                    //string textGia = item.SubItems[3].Text;
                    //decimal gia = ChuyenDoiGia(textGia);
                    //tongTG += Convert.ToInt32(item.SubItems[3]);
                }
            }

            DateTime thoiGianBatDau = dateTimePicker2.Value;
            int TGcho = 45;
            DateTime thoiGianKetThuc = thoiGianBatDau.AddMinutes(tongTG + TGcho);

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ma",MaLHadTB.Text.Trim()),
                new SqlParameter("@makh",cboKhachHang.Text.Trim()),
                new SqlParameter("@manv",cboNhanVien.Text.Trim()),
                new SqlParameter("@madv",TenDV),
                new SqlParameter("@maphong",cboPhong.Text.Trim()),
                new SqlParameter("@batdau",thoiGianBatDau),
                new SqlParameter("@ketthuc",thoiGianKetThuc),
                new SqlParameter("@tongtien",0),
                new SqlParameter("@tinhtrang","Đang chờ"),
        };
            string query = @"INSERT INTO tblLichHen (malichhen, makhachhang, manhanvien, madichvu, maphong, 
                                                  thoigianbatdau, thoigianketthuc, trangthai, tongtien)
                         VALUES (@ma, @makh, @manv, @madv, @maphong, @batdau, @ketthuc, @tinhtrang, @tongtien";
            int result = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
                if (result > 0) MessageBox.Show("Thêm lịch hẹn thành công");
                else MessageBox.Show("Thêm lịch hẹn thất bại");

            LoadLichHenList();   // Làm mới datagridview
        }

        private bool KiemTraTrungLich(SqlConnection conn, string maKH, string maNV, string maPhong, DateTime batDau, DateTime ketThuc)
        {
            string query = @"SELECT COUNT(*) FROM tblLichHen
                     WHERE (
                         (manhanvien = @manv OR maphong = @maphong OR makhachhang = @maKH)
                         AND thoigianbatdau < @ketthuc
                         AND thoigianketthuc > @batdau
                     )";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@maKH", maKH);
            cmd.Parameters.AddWithValue("@manv", maNV);
            cmd.Parameters.AddWithValue("@maphong", maPhong);
            cmd.Parameters.AddWithValue("@batdau", batDau);
            cmd.Parameters.AddWithValue("@ketthuc", ketThuc);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }
        
        private void PhongADpn_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDichVuCha_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CapNhatPhogADbt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SoPhongADtb.Text)) { return; }
            var selectedItem = TTphongcb.SelectedItem;
            string tinhTrang = selectedItem != null ? selectedItem.ToString().Trim() : "";
            string tt = (tinhTrang == "Trống") ? "0" : "1";
            if (tinhTrang == "")
            {
                MessageBox.Show("Chưa để tình trạng!!");
                return;
            }
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter ("@id",SoPhongADtb.Text),
                new SqlParameter ("@tinhtrang",tt),
                new SqlParameter ("@loaiphong",MLHPhongADtb.Text.Trim())
            };

            string query = "UPDATE tblPhong SET tinhtrang = @tinhtrang,loaiphong = @loaiphong WHERE maphong = @id";
            int result = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
            if (result > 0) MessageBox.Show("Cập nhật phòng thành công!");
            else MessageBox.Show("Cập nhật phòng thất bại");
            foreach (Control control in PhongADpn.Controls.OfType<Button>().ToList())
            {
                PhongADpn.Controls.Remove(control);
            }
            LoadPhong();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void cbDVcha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDVcha.SelectedValue != null && cbDVcha.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                string madvcha = cbDVcha.SelectedValue.ToString();
                string query = "SELECT tendichvucon FROM DichVuCon WHERE iddichvucha = @madvcha";
                cbDVcon.DataSource = DataProvider.Instance.Excuted(query, new object[] { madvcha });
                cbDVcon.DisplayMember = "tendichvucon";
                cbDVcon.ValueMember = "tendichvucon";
            }
        }

        private void cbDVcha_DropDown(object sender, EventArgs e)
        {
            string query = "SELECT tendichvucha from DichVuCha";
            cbDVcha.DataSource = DataProvider.Instance.Excuted(query);
            cbDVcha.DisplayMember = "tendichvucha";
            cbDVcha.ValueMember = "tendichvucha";
           
        }

        private void cbDVcon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string tenDV = comboBoxDVCon.Text.Trim();
            string query = "select gia, thoigian from DichVuCon where tendichvucon = @tenDV";
            DataTable data = DataProvider.Instance.Excuted(query, new object[] { tenDV });
            
            decimal gia = Convert.ToDecimal(data.Rows[0]["gia"]);
            int thoigian = Convert.ToInt32(data.Rows[0]["thoigian"]);
            ListViewItem lv = new ListViewItem();
            lv.SubItems.Add(tenDV);
            lv.SubItems.Add(gia + " đ");
            lv.SubItems.Add(thoigian + "p");
            listView1.Items.Add(lv);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string tenDV = cbDVcon.Text.Trim();
            string query = "select gia, thoigian from DichVuCon where tendichvucon = @tenDV";
            DataTable data = DataProvider.Instance.Excuted(query, new object[] {tenDV});
            if (TGchuanbi.Value <=0)
            {
                MessageBox.Show("Chưa chọn thời gian chuẩn bị");
                return;
            }
            decimal gia = Convert.ToDecimal(data.Rows[0]["gia"]);
            int thoigian = Convert.ToInt32(data.Rows[0]["thoigian"]);
            ListViewItem lv = new ListViewItem();
            lv.SubItems.Add(tenDV);
            lv.SubItems.Add(gia + " đ");
            lv.SubItems.Add(thoigian + "p" );
            lvCombo.Items.Add(lv);
            CapNhatTongGia();
            decimal TGmoi = decimal.Parse(thoigian.ToString());
            string TGtg = TLcombo.Text.Trim();
            TGmoi += ChuyenDoiGia(TGtg);
            TGmoi += TGchuanbi.Value;
            TLcombo.Text = TGmoi.ToString()+"p";
        }

        private void GiaDVadTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDVlon_DropDown(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DichVuCha";
            cboDVlon.DataSource = DataProvider.Instance.Excuted(query);
            cboDVlon.DisplayMember = "tendichvucha";
            cboDVlon.ValueMember = "tendichvucha";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@ten", cboDVlon.Text.ToString()),
            };
            string query = "Insert into DichVuCha (tendichvucha) Values (@ten) ";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
            if (results > 0) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboDVlon.Text.ToString())) return;
            var confirm = MessageBox.Show("Bạn có chắc muốn xoá dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@ten", cboDVlon.Text.ToString()),
            };
            string query = "Delete from DichVuCha where tendichvucha = @ten";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
            if (results > 0) MessageBox.Show("Xóa thành công");
            else MessageBox.Show("Xóa thất bại");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvCombo.SelectedItems)
            {
                lvCombo.Items.Remove(item);
            }
        }

        private void CapNhatTongGia()
        {
            decimal tongGia = 0;
            foreach (ListViewItem item in lvCombo.Items)
            {
                if (item.SubItems.Count > 1)
                {
                    string textGia = item.SubItems[2].Text;
                    decimal gia = ChuyenDoiGia(textGia);
                    tongGia += gia;
                }
            }

            tonggia.Text = tongGia.ToString(); // Hiển thị 1,000,000 thay vì 1000000
    
        }


        private void tonggia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CapNhatBT_Click(object sender, EventArgs e)
        {
            bool yeucau = false;
            int result = 0;
            yeucau = string.IsNullOrEmpty(HoTenmoitb.Text) || string.IsNullOrEmpty(Gioitinhtb.Text) || string.IsNullOrEmpty(SDTmoitb.Text);
            if (!yeucau)
            {
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@tencu",HTQLtb.Text),
                    new SqlParameter("@tenquanly",HoTenmoitb.Text),
                    new SqlParameter("@gioitinh",(Gioitinhtb.Text == "Nam")),
                    new SqlParameter("@ngaysinh",NgaysinhADmoi.Value),
                    new SqlParameter("@sdtquanly",SDTmoitb.Text)
                };
                string query = "UPDATE tblQuannLy SET tenquanly = @tenquanly, gioitinh = @gioitinh, ngaysinh = @ngaysinh, sdtquanly = @sdtquanly WHERE @tencu = tenquanly";
                result = DataProvider.Instance.ExcutedNoneQuery(query, parameter);

            }
            if (result > 0) MessageBox.Show("Cập nhật admin thành công ");
            else MessageBox.Show("Cập nhật thất bại !!");
            HienThiAdmin();
        }

        private void Gioitinhtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void HTQLtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SDTQLtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void LichHenADdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void TimBt_Click(object sender, EventArgs e)
        {
            DateTime BD = NgayBD.Value;
            DateTime Kt = NgayKT.Value;
            LichHenADdata.CurrentCell = null;
            if (BD >= Kt)
            {
                MessageBox.Show("Ngày bắt đầu sau ngày kết thúc");
                return;
            }
            else
            {
                foreach(DataGridViewRow row in LichHenADdata.Rows)
                {
                    if (row.Cells["thoigianbatdau"].Value != null)
                    {
                        DateTime tg = Convert.ToDateTime(row.Cells["thoigianbatdau"].Value);
                        if (tg >= BD && tg <= Kt)
                        {
                            row.Visible = true;
                        }
                        else { row.Visible = false; }
                    }

                    if (row.Visible && CbTimNV.SelectedValue != null && row.Cells["manhanvien"].Value!=null)
                    {
                        string tg =CbTimNV.SelectedValue.ToString().Trim();
                        if (tg == row.Cells["manhanvien"].Value.ToString())
                        {
                            row.Visible=true;
                        }
                        else row.Visible = false;
                    }

                    if (row.Visible && CbTimKH.SelectedValue != null && row.Cells["makhachhang"].Value != null)
                    {
                        string tg = CbTimKH.SelectedValue.ToString().Trim();
                        if (tg == row.Cells["makhachhang"].Value.ToString())
                        {
                            row.Visible= true;
                        }
                        else  row.Visible=false; 
                    }
                }
            }    
        }

            private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cboPhong.SelectedItem is DataRowView row) { 
                    string tg = row["tinhtrang"].ToString();
                    if(tg == "0") trangthai.Text = "Trống";
                    else trangthai.Text = "Đang dùng";
                }
            }

        private void XoaPhongADbt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SoPhongADtb.Text)) return;
            var confirm = MessageBox.Show("Bạn có chắc muốn xoá phòng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("id",  SoPhongADtb.Text),
            };
            string query = "DELETE FROM tblPhong WHERE maphong = @id";
            int results = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameter);
            if (results > 0) MessageBox.Show("Xóa phòng thành công");
            else MessageBox.Show("Xóa phòng thất bại");
            foreach (Control control in PhongADpn.Controls.OfType<Button>().ToList())
            {
                PhongADpn.Controls.Remove(control);
            }
            LoadPhong();
        }

        private void MLHPhongADtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown_1(object sender, EventArgs e)
        {
            string QueryNV = "SELECT manhanvien, tennhanvien AS thongtin FROM tblNhanVien";
            CbTimNV.DataSource = DataProvider.Instance.Excuted(QueryNV);
            CbTimNV.DisplayMember = "thongtin";
            CbTimNV.ValueMember = "manhanvien";
        }

        private void CbTimKH_DropDown(object sender, EventArgs e)
        {
            string queryKH = "SELECT makhachhang, tenkhachhang + ' / ' + sdt AS thongtin FROM tblKhachHang";
            CbTimKH.DataSource = DataProvider.Instance.Excuted(queryKH);
            CbTimKH.DisplayMember = "thongtin";
            CbTimKH.ValueMember = "makhachhang";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string TenDV = "";
            foreach(ListViewItem item in lvCombo.Items)
            {
                if(item.SubItems.Count > 1)
                {
                    TenDV += item.SubItems[1].Text + ",";
                }
            }
        
            if (string.IsNullOrEmpty(MaCombo.Text) || string.IsNullOrEmpty(TenCombotb.Text))
            {
                MessageBox.Show("Chưa nhập tên hoặc mã combo" +
                    "");
                return;
            }
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@idcombo",MaCombo.Text.Trim()),
                new SqlParameter("@tencombo",TenCombotb.Text.Trim()),
                new SqlParameter("@dichvu",TenDV),
                new SqlParameter("@thoiluong",int.Parse(TLcombo.Text.Replace("p",""))),
                new SqlParameter("@giagoc",ChuyenDoiGia(tonggia.Text.Trim())),
                new SqlParameter("@giadagiam",ChuyenDoiGia(textBox1.Text.Trim())),
            };
            string query = "INSERT INTO Combo(idcombo,tenncombo,dichvu,thoiluong,giagoc,giadagiam) " +
                " VALUES (@idcombo,@tencombo,@dichvu,@thoiluong,@giagoc,@giadagiam)";
            int result = DataProvider.Instance.ExcutedNoneQuery(query,sqlParameters);
            if (result > 0) MessageBox.Show("Thêm combo thành công");
            else MessageBox.Show("Thêm dịch vụ thất bại");
            LoadComboList();
        }

        private void giamgia_ValueChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tonggia.Text.Replace(",", ""), out decimal GiaGoc))
            {
                decimal GiamGia = giamgia.Value;
                decimal GiaDaGiam = GiaGoc * (1 - GiamGia / 100);
                string tg = GiaDaGiam.ToString();
                GiaDaGiam = ChuyenDoiGia(tg);
                textBox1.Text = GiaDaGiam.ToString();
            }
            else textBox1.Text = "";
         
        }

            public decimal ChuyenDoiGia(string text)
            {
                // Loại bỏ mọi ký tự không phải chữ số
                string cleaned = new string(text.Where(c => char.IsDigit(c) || c == '.').ToArray());

                if (decimal.TryParse(cleaned, out decimal result))
                {
                    return result;
                }
                else
                {
                    throw new FormatException("Giá không hợp lệ");
                }
            }

        private void TGchuanbi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (ComboData.CurrentRow != null)
            {
                string idcombo = ComboData.CurrentRow.Cells["idcombo"].Value.ToString();

                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@idcombo",  ComboData.CurrentRow.Cells["idcombo"].Value.ToString()),
                };
                var confirm = MessageBox.Show("Bạn có chắc muốn xoá combo này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;
                string query = "DELETE FROM Combo WHERE idcombo = @idcombo";
                int results = DataProvider.Instance.ExcutedNoneQuery(query, sqlParameters);
                if (results > 0) MessageBox.Show("Xóa thành công");
                else MessageBox.Show("Xóa thất bại");
                LoadComboList();
            }
        }

        private void ComboData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string query = "SELECT tenncombo from Combo";
            comboBox2.DataSource = DataProvider.Instance.Excuted(query);
            comboBox2.DisplayMember = "tenncombo";
            comboBox2.ValueMember = "tenncombo";
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void cboKhachHang_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void lvCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trangthai_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string tenncombo = comboBox2.Text.Trim();
            string query = "select giadagiam, thoiluong from Combo where tenncombo = @tenncombo";
            DataTable data = DataProvider.Instance.Excuted(query, new object[] { tenncombo });

            decimal gia = Convert.ToDecimal(data.Rows[0]["giadagiam"]);
            int thoigian = Convert.ToInt32(data.Rows[0]["thoiluong"]);
            ListViewItem lv = new ListViewItem();
            lv.SubItems.Add(tenncombo);
            lv.SubItems.Add(gia + " đ");
            lv.SubItems.Add(thoigian + "p");
            listView1.Items.Add(lv);
        }

        private void ComboData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                DataGridViewRow row = ComboData.Rows[e.RowIndex];
                MaCombo.Text = row.Cells["idcombo"].Value.ToString().Trim();
                TenCombotb.Text = row.Cells["tenncombo"].Value.ToString().Trim();
                tonggia.Text = row.Cells["giagoc"].Value.ToString().Trim();
                textBox1.Text = row.Cells["giadagiam"].Value.ToString().Trim();
            }
        }
    }
}

