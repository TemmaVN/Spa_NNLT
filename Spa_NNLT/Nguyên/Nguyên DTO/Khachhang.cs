using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Spa_NNLT.Nguyên.Nguyên_DTO;

namespace Spa_NNLT.Nguyên.KhachHangAD
{
    public class Khachhang
    {
        private string IDKH;
        private string TenKH;
        private string GioiTinhKH;
        private string SDTKH;

        public Khachhang(DataRow row)
        {
             this.IDKH = row["makhachhang"].ToString();
            this.TenKH = row["ten"].ToString();
            int tg = int.Parse(row["gioitinh"].ToString());
            this.GioiTinhKH = (tg == 1) ? "Nam" : "Nữ";
            this.SDTKH = row["sdt"].ToString();
        }

        public Khachhang(string iDKH, string tenKH, string gioiTinhKH,string sDTKH)
        {
            IDKH = iDKH;
            TenKH = tenKH;
            GioiTinhKH = gioiTinhKH;
            SDTKH = sDTKH;
        }
        public string idKH
            { get { return IDKH; } set { IDKH = value; } }
        public string tenKH
        { get { return TenKH; } set { TenKH= value; } }
        public string gioitinhKH
        { get {return GioiTinhKH;} set {GioiTinhKH= value; } }
        public string sDTKH
        { get { return SDTKH; } set{ SDTKH= value; } }
        

        
    }

    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO(); return instance;
            }
            set
            {
                instance = value;
            }
        }

        private KhachHangDAO() { }

        public List<Khachhang> LoadKhachHang()
        {
            List<Khachhang> khachhangs = new List<Khachhang>();
            DataTable dt = DataProvider.Instance.Excuted("USP_GetKhachHangList");
            foreach (DataRow dr in dt.Rows)
            {
                Khachhang k = new Khachhang(dr);
                khachhangs.Add(k);
            }
            return khachhangs;

        }
    }

}
