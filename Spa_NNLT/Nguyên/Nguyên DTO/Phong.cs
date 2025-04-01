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
        private string tinhtrang;
        private string MaLichHen;

        public Phong (string maPhong, string loaiPhong, string tinhtrang, string maLichHen)
        {
            MaPhong = maPhong;
            LoaiPhong = loaiPhong;
            this.tinhtrang = tinhtrang;
            MaLichHen = maLichHen;
        }

        public Phong(DataRow row)
        {
            this.MaPhong = row["maphong"].ToString();
            this.LoaiPhong = row["loaiphong"].ToString();
            this.tinhtrang = row["tinhtrang"].ToString();
            this.MaLichHen = row["malichhen"].ToString() ;


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

            public List<Phong> LoadDanhSachPhong()
            {
                List<Phong> phongs = new List<Phong>();

                DataTable dt = DataProvider.Instance.Excuted("USP_GetPhongList");
                foreach (DataRow dr in dt.Rows) {
                    Phong phong = new Phong(dr);
                    phongs.Add(phong);
                        
                }
                return phongs;

            }
        }
    } 
}
