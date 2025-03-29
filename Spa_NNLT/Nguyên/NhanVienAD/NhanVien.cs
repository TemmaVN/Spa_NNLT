using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Spa_NNLT.Nguyên.NhanVienAD
{
    class NhanVien
    {
        private int ID;
        private string Ten;
        private string GioiTinh;
        private string SDT;
        private DateTime NgaySinh;
        private string CongViec;

        public NhanVien(int iD, string ten, string gioiTinh, string sDT, DateTime ngaySinh, string congViec)
        {
            ID = iD;
            Ten = ten;
            GioiTinh = gioiTinh;
            SDT = sDT;
            NgaySinh = ngaySinh;
            CongViec = congViec;
        }

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string ten
        { get { return Ten; } set { Ten = value; } }
        public string gioiTinh
        { get { return Ten; } set { GioiTinh = value; } }
        public string sDT
            { get { return SDT; } set { SDT = value; } }
        public DateTime ngaySinh
            { get { return NgaySinh; } set { NgaySinh = value; } }
        public string congViec
            { get { return CongViec; } set { CongViec = value; } }

        

    }
}
