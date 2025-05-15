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
        private string Malichhen;

        public HoaDon(DataRow data)
        {
            this.ID = data["mahoadon"].ToString();
            this.Malichhen = data["malichhen"].ToString();
        }

        public HoaDon(string iD,string malichhhen)
        {
            ID = iD;
            this.Malichhen= malichhhen;
        }

        public string iD
        {
            get { return ID; }
            set { ID = value; }
        }
        public string malichhen
        {
            get { return Malichhen; }
            set { Malichhen = value; }
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
            DataTable dt = DataProvider.Instance.Excuted("USP_GetHoaDonListup");
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hoaDon = new HoaDon(dr);
                list.Add(hoaDon);
            }
            return list;
        }
    }

}
