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
        private string TenKhach;
        private string TenNV;
        private string TenDV;
        private string SoPhong;
        private DateTime ThoiGian;
        private int tinhTrang;

        public LichHen(DataRow row)
        {
            this.ID = row["malichhen"].ToString();
            
        }

        public LichHen(string iD, string tenKhach, string tenNV, string tenDV, string soPhong, DateTime thoiGian, int tinhTrang)
        {
            ID = iD;
            TenKhach = tenKhach;
            TenNV = tenNV;
            TenDV = tenDV;
            SoPhong = soPhong;
            ThoiGian = thoiGian;
            this.tinhTrang = tinhTrang;
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
