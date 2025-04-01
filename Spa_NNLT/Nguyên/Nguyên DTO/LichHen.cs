using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spa_NNLT.Nguyên.Nguyên_DTO;

namespace Spa_NNLT.Nguyên.Lịch_hẹn
{
    public class LichHen
    {
        private string ID;
        private string Madichvu;
        private string MaNhanVien;
        private string MaKhachHang;
        private string SoPhong;
        private DateTime ThoiGian;
        private int TrangThai;

        public LichHen(string iD, string madichvu, string maNhanVien, string maKhachHang, string soPhong, DateTime thoiGian, int trangThai)
        {
            ID = iD;
            Madichvu = madichvu;
            MaNhanVien = maNhanVien;
            MaKhachHang = maKhachHang;
            SoPhong = soPhong;
            ThoiGian = thoiGian;
            TrangThai = trangThai;
        }

        public LichHen(DataRow dr) { 
            this.ID = dr["malichhen"].ToString();
            this.Madichvu = dr["madichvu"].ToString();
            this.MaNhanVien = dr["makhachhang"].ToString();
            this.MaKhachHang = dr["makhachhang"].ToString();
            this.SoPhong = dr["maphong"].ToString() ;
            this.ThoiGian = (DateTime)dr["thoigian"];
            this.TrangThai = int.Parse(dr["trangthai"].ToString());
  
        }
    }

    public class LichHenDAO
    {
        private static LichHenDAO instance;

        public static LichHenDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichHenDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private LichHenDAO() { }

        public List<LichHen> LoadLichHen()
        {
            List<LichHen> lichHens = new List<LichHen>();
            DataTable dt = DataProvider.Instance.Excuted("Get_LichHenList");
            foreach (DataRow dr in dt.Rows) {
                LichHen lichHen = new LichHen(dr);
                lichHens.Add(lichHen);
                
            }
            return lichHens;
        }

    }

}
