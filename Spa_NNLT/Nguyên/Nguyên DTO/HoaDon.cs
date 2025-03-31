using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Spa_NNLT.Nguyên.Hóa_đơn
{
    public class HoaDon
    {
        private string ID;
        private string MaKhachHang;

        private string MaDichVu;
        private int ThanhTien;

        public HoaDon(DataRow data)
        {
            this.ID = data["mahoadon"].ToString();
            this.MaKhachHang = data["makhachhang"].ToString();
            this.MaDichVu = data["madichvu"].ToString() ;
            this.ThanhTien = int.Parse(data["thanhtien"].ToString());  
        }

        public HoaDon(string iD, string maKhachHang, string maDichVu, int thanhTien)
        {
            ID = iD;
            MaKhachHang = maKhachHang;
            MaDichVu = maDichVu;
            ThanhTien = thanhTien;
        }

        public string iD
        {
            get { return ID; }
            set { ID = value; }
        }
        public string maKhachHang
        {
            get { return MaKhachHang; }
            set { MaKhachHang = value; }
        }
        public string maDichVu
        {
            get { return MaDichVu; }
            set { MaDichVu = value; }
        }
        public int thanhTien
        {
            get { return ThanhTien; }
            set { ThanhTien = value; }
        }


    }
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAO();
                return instance;
            }
            set { instance = value; }

        }

        private HoaDonDAO() { }

        public List<HoaDon> GetHoaDonList() 
        {
            List<HoaDon> list = new List<HoaDon>();
            DataTable dt = new DataTable();
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hoaDon = new HoaDon(dr);
                list.Add(hoaDon);
            }
            return list;
        }
    }

}
