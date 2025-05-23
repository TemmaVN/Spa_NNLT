﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Spa_NNLT.Nguyên.Nguyên_DTO;

namespace Spa_NNLT.Nguyên.NhanVienAD
{
    public class NhanVien
    {
        private string ID;
        private string Ten;
        private string GioiTinh;
        private string SDT;
        private DateTime NgaySinh;        
        private string calam;

        public NhanVien(string iD, string ten, string gioiTinh, string sDT, DateTime ngaySinh, string congViec, string caLam)
        {
            ID = iD;
            Ten = ten;
            GioiTinh = gioiTinh;
            SDT = sDT;
            NgaySinh = ngaySinh;
            
            calam = caLam;
        }

        public NhanVien(DataRow row) {
            ID = row["manhanvien"].ToString();
            Ten = row["tennhanvien"].ToString();
            this.GioiTinh = row["gioitinh"].ToString();           
            this.SDT = row["sdt"].ToString();
        }

        public string id
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

       


    }

    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            set { instance = value; }
        }

        private NhanVienDAO() { }

        public bool login(string username, string password)
        {
            string query = "SELECT * from dbo.tblNhanVien where taikhoan = N'" + username +"' AND matkhau = N'" + password + "' ";
            DataTable result = DataProvider.Instance.Excuted(query);
                
            return result.Rows.Count >0;
        }

        public List<NhanVien> LoadNhanVienAD()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            DataTable data = DataProvider.Instance.Excuted("USP_GetNhanVienList");

            foreach (DataRow dr in data.Rows)
            {
                NhanVien nhan = new NhanVien(dr);
                nhanViens.Add(nhan);
            }
            return nhanViens;
        }

        
    }
}
