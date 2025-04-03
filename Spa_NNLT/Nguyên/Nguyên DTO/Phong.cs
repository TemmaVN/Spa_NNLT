using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spa_NNLT.Nguyên.Nguyên_DTO;

namespace Spa_NNLT.Nguyên.PhongAD
{
    public class Phong
    {
        private string MaPhong;
        private string LoaiPhong;
        private string Tinhtrang;
        private string MaLichHen;

        public Phong(string maPhong, string loaiPhong, string tinhtrang, string maLichHen)
        {
            MaPhong = maPhong;
            LoaiPhong = loaiPhong;
            this.Tinhtrang = tinhtrang;
            MaLichHen = maLichHen;
        }

        public Phong(DataRow row)
        {
            this.MaPhong = row["maphong"].ToString();
            this.LoaiPhong = row["loaiphong"].ToString();
            this.Tinhtrang = row["tinhtrang"].ToString();
            this.MaLichHen = row["malichhen"].ToString();


        }

        public string maPhong
        {
            get
            {
                return MaPhong;
            }
            set
            {
                MaPhong = value;
            }
        }

        public string loaiPhong
            {
                get { return LoaiPhong; }
            set
            {
                LoaiPhong = value;
            }
        }

        public string tinhTrang
        {
            get { return Tinhtrang; }
            set
            {
                Tinhtrang = value;
            }
        }
        public string maLichHen
        {
            get { return maLichHen; }
            set
            {
                MaLichHen = value;
            }
        }

        
    }
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongDAO();
                }
                return instance;
            }
            set { instance = value; }
        }

        private PhongDAO() { }

        public static int PhongWidth = 50;
        public static int PhongHeight = 50;

        public List<Phong> LoadDanhSachPhong()
        {
            List<Phong> phongs = new List<Phong>();

            DataTable dt = DataProvider.Instance.Excuted("USP_GetPhongList");
            foreach (DataRow dr in dt.Rows)
            {
                Phong phong = new Phong(dr);
                phongs.Add(phong);

            }
            return phongs;

        }
    }
}
