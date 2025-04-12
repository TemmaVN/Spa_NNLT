using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spa_NNLT.Nguyên.Nguyên_DTO
{
    public class QuanLi
    {
        private string MaQuanLi;
        private string TenQuanLi;
        private DateTime NgaySinh;
        private string GioiTinh;
        private string TenDangNhap;
        private string MatKhau;

        public QuanLi(string maQuanLi, string tenQuanLi, DateTime ngaySinh, string gioiTinh, string tenDangNhap, string matKhau)
        {
            MaQuanLi = maQuanLi;
            TenQuanLi = tenQuanLi;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }

        public QuanLi(DataRow row)
        {
            this.MaQuanLi = row["maquanli"].ToString();
            this.TenQuanLi = row["tenquanli"].ToString();
            this.NgaySinh = (DateTime)row["ngaysinh"];
            int tg = (int)row["gioitinh"];
            if (tg == 0)
            {
                this.GioiTinh = "Nữ";
            }
            else
            {
                this.GioiTinh = "Nam";
            }
            this.TenDangNhap = row["account"].ToString();
            this.MatKhau = row["password"].ToString();
        }

        public string maQuanLi
        { get { return this.MaQuanLi; } set { this.MaQuanLi = value; } }
        public string tenQuanLi
        {
            get { return this.TenQuanLi; }
            set { this.TenQuanLi = value; }
        }
        public DateTime ngaySinh
        { get { return this.NgaySinh; } set { this.NgaySinh = value; } }
        public string matKhau
        { get { return this.matKhau; } set { this.matKhau = value; } }
        public string gioiTinh
        {
            get { return this.GioiTinh; }
            set { this.GioiTinh = value;}

        }
    }

    

    public class QuanLiDAO
    {
        private static QuanLiDAO instance;

        public static QuanLiDAO Instance
        {
            get { if (instance == null)
                    instance = new QuanLiDAO();
            return instance;
            }
            set { instance = value; }
        }

        private QuanLiDAO() { }

        public bool login(string username, string password)
        {
            string query = "SELECT * from dbo.tblQuannLy where account = N'" + username + "' and password = N'" + password + "'";
            DataTable result = DataProvider.Instance.Excuted(query);
            return result.Rows.Count > 0;
        }

        public List<QuanLi> LoadQuanLi()
        {
            List<QuanLi> quanLis = new List<QuanLi>();
            DataTable dt = DataProvider.Instance.Excuted("USP_GetQuanLiList");
            foreach (DataRow item in dt.Rows)
            {
                QuanLi quanLi = new QuanLi(item);
                quanLis.Add(quanLi);
            }
            return quanLis;
        }
    }

    public static class Session
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
    }
}
