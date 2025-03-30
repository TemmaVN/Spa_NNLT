using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Spa_NNLT.Nguyên.DichVuAD
{
    public class DIchVu
    {
        private int MaDV;
        private string TenDV;
        private int GiaDV;
        private TimeSpan ThoiGianDV;

        public DIchVu(int maDV, string tenDV, int giaDV, TimeSpan thoiGianDV)
        {
            MaDV = maDV;
            TenDV = tenDV;
            GiaDV = giaDV;
            ThoiGianDV = thoiGianDV;
        }

        public int maDV
            { get { return MaDV; } set { MaDV = value; } }
        public string tenDV
            { get { return TenDV; } set { TenDV = value; } }
        public int giaDV
            { get { return GiaDV; } set { GiaDV = value; } }
        public TimeSpan thoiGianDV
        { get { return ThoiGianDV; } set { ThoiGianDV = value; } }

        private string query = "SELECT * FROM dbo.tblKhachHang";
        

    }

    
}
