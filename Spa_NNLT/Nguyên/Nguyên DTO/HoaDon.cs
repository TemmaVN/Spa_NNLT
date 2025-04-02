using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Spa_NNLT.Nguyên.Nguyên_DTO;

namespace Spa_NNLT.Nguyên.Hóa_đơn
{
    public class HoaDon
    {
        private string ID;
        private string LichHen;
        private int ThanhTien;

        public HoaDon(DataRow data)
        {
            this.ID = data["mahoadon"].ToString();
            this.LichHen = data["malichhen"].ToString() ;
            this.ThanhTien = int.Parse(data["thanhtien"].ToString());  
        }

        public HoaDon(string iD,  string lichHen, int thanhTien)
        {
            ID = iD;
            LichHen = lichHen;
            ThanhTien = thanhTien;
        }

        public string iD
        {
            get { return ID; }
            set { ID = value; }
        }
        
        
        public string lichHen
        {
            get { return LichHen; }
            set { LichHen = value; }
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
            DataTable dt = DataProvider.Instance.Excuted("USP_GetHoaDonList");
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hoaDon = new HoaDon(dr);
                list.Add(hoaDon);
            }
            return list;
        }
    }

}
