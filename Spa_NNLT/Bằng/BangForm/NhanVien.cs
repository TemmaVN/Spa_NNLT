using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spa_NNLT.Nguyên.KhachHangAD;
using Spa_NNLT.Nguyên.Nguyên_DTO;
using Spa_NNLT.Nguyên.NhanVienAD;

namespace Spa_NNLT.Bằng
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            LoadDichVuList();
            LoadHoaDonList();
            LoadKhachHangList();
            LoadLichHenList();
        }

        #region method

        

        #endregion

        #region event

        void LoadHoaDonList()
        {
            string query = "SELECT * from dbo.tblHoaDon,dbo.tblLichHen";
            HoaDonNVdata.DataSource = DataProvider.Instance.Excuted(query);
        }

        void LoadKhachHangList()
        {
            string query = "SELECT * FROM dbo.tblKhachHang";
            KHNVdata.DataSource = DataProvider.Instance.Excuted(query);
        }

        void LoadLichHenList()
        {
            string query = "SELECT * from dbo.tblLichHen";
            LHNVdata.DataSource = DataProvider.Instance.Excuted(query);
        }

        void LoadDichVuList()
        {
            string query = "SELECT * from dbo.tblDichVu";
            DVNVdata.DataSource = DataProvider.Instance.Excuted(query);
        }

       
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            TTTKHnvTB.Text = "Tìm theo tên";
            TTTKHnvTB.ForeColor = Color.Gray;
            TTTsdtKHnvTB.Text = "Tìm theo sdt";
            TTTsdtKHnvTB.ForeColor = Color.Gray;
            TTTDVnvTB.Text = "Tìm theo tên";
            TTTDVnvTB.ForeColor = Color.Gray;
            TTmaDVnvTB.Text = "Tìm theo mã";
            TTmaDVnvTB.ForeColor = Color.Gray;
            TTmaLHnvTB.Text = "Tìm theo mã";
            TTmaLHnvTB.ForeColor = Color.Gray;
            TTKHLHnvTB.Text = "Tìm theo tên khách hàng";
            TTKHLHnvTB.ForeColor= Color.Gray;   
            TTmaPhongnvTB.Text = "Tìm theo mã";
            TTmaPhongnvTB.ForeColor = Color.Gray;
            TTmaHDnvTB.Text = "Tìm theo mã hóa đơn";
            TTmaHDnvTB.ForeColor = Color.Gray;
            TTmaLHHDnvTb.Text = "Tìm theo mã lịch hẹn";
            TTmaLHHDnvTb.ForeColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLichhen_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel57_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TTmaLHnvTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTTKHnvTB_Enter(object sender, EventArgs e)
        {
            if (TTTKHnvTB.Text == "Tìm theo tên")
            {
                TTTKHnvTB.Text = "";
                TTTKHnvTB.ForeColor = Color.Black;
            }
        }

        private void TTTKHnvTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTTKHnvTB.Text)) {
                TTTKHnvTB.Text = "Tìm theo tên";
                TTTKHnvTB.ForeColor = Color.Gray;
            }
        }

        private void TTTmaKHnvTB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TTTsdtKHnvTB_Enter(object sender, EventArgs e)
        {
            if (TTTsdtKHnvTB.Text == "Tìm theo sdt")
            {
                TTTsdtKHnvTB.Text = "";
                TTTsdtKHnvTB.ForeColor = Color.Black;
            }
        }

        private void TTTsdtKHnvTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTTsdtKHnvTB.Text))
            {
                TTTsdtKHnvTB.Text = "Tìm theo sdt";
                TTTsdtKHnvTB.ForeColor = Color.Gray;
            }
        }

        private void TTTDVnvTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTmaDVnvTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTKHLHnvTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTTKHnvTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TTTDVnvTB_Enter(object sender, EventArgs e)
        {
            if (TTTDVnvTB.Text == "Tìm theo tên")
            {
                TTTDVnvTB.Text = "";
                TTTDVnvTB.ForeColor = Color.Black;
            }
        }

        private void TTmaDVnvTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTmaDVnvTB.Text))
            {
                TTmaDVnvTB.Text = "Tìm theo mã";
                TTmaDVnvTB.ForeColor = Color.Gray;
            }
        }

        private void TTTDVnvTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTTDVnvTB.Text))
            {
                TTTDVnvTB.Text = "Tìm theo tên";
                TTTDVnvTB.ForeColor = Color.Gray;
            }
        }

        private void TTmaDVnvTB_Enter(object sender, EventArgs e)
        {
            if (TTmaDVnvTB.Text == "Tìm theo mã")
            {
                TTmaDVnvTB.Text = "";
                TTmaDVnvTB.ForeColor = Color.Black;
            }
        }

        private void TTmaLHnvTB_Enter(object sender, EventArgs e)
        {
            if (TTmaLHnvTB.Text == "Tìm theo mã")
            {
                TTmaLHnvTB.Text = "";
                TTmaLHnvTB.ForeColor = Color.Black;
            }
        }

        private void TTmaLHnvTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTmaLHnvTB.Text))
            {
                TTmaLHnvTB.Text = "Tìm theo mã";
                TTmaLHnvTB.ForeColor = Color.Gray;
            }
        }

        private void TTmaPhongnvTB_Enter(object sender, EventArgs e)
        {
            if (TTmaPhongnvTB.Text == "Tìm theo mã")
            {
                TTmaPhongnvTB.Text = "";
                TTmaPhongnvTB.ForeColor = Color.Black;
            }
        }

        private void TTmaPhongnvTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTmaPhongnvTB.Text))
            {
                TTmaPhongnvTB.Text = "Tìm theo mã";
                TTmaPhongnvTB.ForeColor = Color.Gray;
            }
        }

        private void TTmaHDnvTB_Enter(object sender, EventArgs e)
        {
            if (TTmaHDnvTB.Text == "Tìm theo mã hóa đơn")
            {
                TTmaHDnvTB.Text = "";
                TTmaHDnvTB.ForeColor = Color.Black;
            }
        }

        private void TTmaHDnvTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTmaHDnvTB.Text))
            {
                TTmaHDnvTB.Text = "Tìm theo mã";
                TTmaHDnvTB.ForeColor = Color.Gray;
            }
        }

        private void TTmaLHHDnvTb_Enter(object sender, EventArgs e)
        {
            if (TTmaLHHDnvTb.Text == "Tìm theo mã lịch hẹn")
            {
                TTmaLHHDnvTb.Text = "";
                TTmaLHHDnvTb.ForeColor = Color.Black;
            }
        }

        private void TTmaLHHDnvTb_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTmaLHHDnvTb.Text))
            {
                TTmaLHHDnvTb.Text = "Tìm theo mã lịch hẹn";
                TTmaLHHDnvTb.ForeColor = Color.Gray;
            }
        }

        private void TTKHLHnvTB_Enter(object sender, EventArgs e)
        {
            if (TTKHLHnvTB.Text == "Tìm theo tên khách hàng")
            {
                TTKHLHnvTB.Text = "";
                TTKHLHnvTB.ForeColor = Color.Black;
            }
        }

        private void TTKHLHnvTB_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TTKHLHnvTB.Text))
            {
                TTKHLHnvTB.Text = "Tìm theo tên khách hàng";
                TTKHLHnvTB.ForeColor = Color.Gray;
            }
        }

        private void DVNVdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DVNVdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DVNVdata.Rows[e.RowIndex];
                IDDichVuText.Text = row.Cells["madichvu"].Value?.ToString();
                TenDichVuText.Text = row.Cells["ten"].Value?.ToString();
                MenhGiaText.Text = row.Cells["giadichvu"].Value?.ToString();
                ThoiLuongText.Text = row.Cells["thoiluong"].Value?.ToString();
            }
        }

        private void KHNVdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = KHNVdata.Rows[e.RowIndex];
                IDKhanhhangText.Text = row.Cells[0].Value?.ToString();
                TenKhachHangText.Text = row.Cells[1].Value?.ToString();
                string tg = row.Cells[2].Value?.ToString();
                if (tg == "0")
                {
                    GioiTinhText.Text = "Nữ";
                }
                else
                {
                    GioiTinhText.Text = "Nam";
                }
                sdtKhachHangText.Text = row.Cells[3].Value?.ToString();

            }
        }

        private void LHNVdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = LHNVdata.Rows[e.RowIndex];
                IDLichHenText.Text = row.Cells["malichhen"].Value?.ToString();
                KhachHangText.Text = row.Cells["makhachhang"].Value?.ToString();
                NhanVienText.Text = row.Cells["manhanvien"].Value?.ToString();
                DichVuText.Text = row.Cells["madichvu"].Value?.ToString();
                PhongText.Text = row.Cells["maphong"].Value?.ToString();
                ThoiGianText.Text = row.Cells["thoigian"].Value?.ToString();
                TinhTrangText.Text = row.Cells["trangthai"].Value?.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filter1 = TTTKHnvTB.Text.Trim();
            string filter2 = TTTsdtKHnvTB.Text.Trim();

            KHNVdata.CurrentCell = null;

            foreach (DataGridViewRow row in KHNVdata.Rows)
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

        private void button8_Click(object sender, EventArgs e)
        {
            string filter1 = TTTDVnvTB.Text.Trim();
            string filter2 = TTmaDVnvTB.Text.Trim();

            DVNVdata.CurrentCell = null;

            foreach (DataGridViewRow row in DVNVdata.Rows)
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

        private void button9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
