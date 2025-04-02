using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spa_NNLT.Nguyên.Nguyên_DTO;

namespace Spa_NNLT.Nguyên.DichVuAD
{
    public class DIchVu
    {
        private string MaDV;
        private string TenDV;
        private int GiaDV;
        private int ThoiGianDV;

        public DIchVu(DataRow row) {
            this.MaDV = row["madichvu"].ToString();
            this.TenDV = row["ten"].ToString();
            this.GiaDV = (int)row["giadichvu"];
            this.ThoiGianDV = (int)row["thoiluong"];
        }

        public DIchVu(string maDV, string tenDV, int giaDV, int thoiGianDV)
        {
            MaDV = maDV;
            TenDV = tenDV;
            GiaDV = giaDV;
            ThoiGianDV = thoiGianDV;
        }

        public string maDV
            { get { return MaDV; } set { MaDV = value; } }
        public string tenDV
            { get { return TenDV; } set { TenDV = value; } }
        public int giaDV
            { get { return GiaDV; } set { GiaDV = value; } }
        public int thoiGianDV
        { get { return ThoiGianDV; } set { ThoiGianDV = value; } }

          
    }
    public class DichVuDAO
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuDAO();
                return instance;
            }
            set { instance = value; }

        }

        private DichVuDAO() { }

        public List<DIchVu> LoadTableList()
        {


            List<DIchVu> DVlist = new List<DIchVu>();
            DataTable data = DataProvider.Instance.Excuted("USP_GetDichVuList");
            foreach (DataRow dr in data.Rows)
            {
                DIchVu dIchVu = new DIchVu(dr);
                DVlist.Add(dIchVu);
            }
            return DVlist;
        }
    }
    
}
