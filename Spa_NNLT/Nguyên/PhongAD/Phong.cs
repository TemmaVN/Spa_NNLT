using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spa_NNLT.Nguyên.PhongAD
{
    public class Phong
    {
        private int SoPhong;
        private string LoaiPhong;
        private bool TinhTrang;

        public Phong(int soPhong, string loaiPhong, bool tinhTrang)
        {
            SoPhong = soPhong;
            LoaiPhong = loaiPhong;
            TinhTrang = tinhTrang;
        }   
        public int soPhong
        {
            get { return SoPhong; }
            set { SoPhong = value; }
        }
        public string loaiPhong
            { get { return LoaiPhong; } set { LoaiPhong = value; }
        } public bool tinhTrang { get { return TinhTrang; } set {
                TinhTrang = value; } }

    }
}
