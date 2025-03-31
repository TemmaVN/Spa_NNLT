using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Spa_NNLT.Nguyên.KhachHangAD
{
    public class Khachhang
    {
        private int IDKH;
        private string TenKH;
        private string GioiTinhKH;
        private string SDTKH;

        public Khachhang(int iDKH, string tenKH, string gioiTinhKH,string sDTKH)
        {
            IDKH = iDKH;
            TenKH = tenKH;
            GioiTinhKH = gioiTinhKH;
            SDTKH = sDTKH;
        }
        public int idKH
            { get { return IDKH; } set { IDKH = value; } }
        public string tenKH
        { get { return TenKH; } set { TenKH= value; } }
        public string gioitinhKH
        { get {return GioiTinhKH;} set {GioiTinhKH= value; } }
        public string sDTKH
        { get { return SDTKH; } set{ SDTKH= value; } }
        

        
    }
}
