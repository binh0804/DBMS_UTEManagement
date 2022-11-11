using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DBMS_UTEManagement.DBLayer;


namespace DBMS_UTEManagement.BSLayer
{
    internal class BSLop
    {
        DBMain db = null;
        string err = null;
        public BSLop()
        {
            db = new DBMain();
        }
        public DataSet LoadDDLop()
        {
            return db.ExcuteQueryDataSet($"select * from fLoadLop()", CommandType.Text);
        }
        public DataSet ADDLopHoc(string MaLop, string TenLop, string MaKhoaHoc, string MaHe, string MaNganh)
        {
            SqlParameter p1 = new SqlParameter("@MaLop", SqlDbType.Char);
            p1.Value = MaLop;
            SqlParameter p2 = new SqlParameter("@TenLop", SqlDbType.Char);
            p2.Value = TenLop;
            SqlParameter p3 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p3.Value = MaKhoaHoc;
            SqlParameter p4 = new SqlParameter("@MaHe", SqlDbType.Char);
            p4.Value = MaHe;
            SqlParameter p5 = new SqlParameter("@MaNganh", SqlDbType.Char);
            p5.Value = MaNganh;

            return db.ExcuteQueryDataSetWithParam("ADDLopHoc", CommandType.StoredProcedure, p1, p2,p3,p4,p5);
        }
        public DataSet UpdateLopHoc(string MaLop, string TenLop, string MaKhoaHoc, string MaHe, string MaNganh)
        {
            SqlParameter p1 = new SqlParameter("@MaLop", SqlDbType.Char);
            p1.Value = MaLop;
            SqlParameter p2 = new SqlParameter("@TenLop", SqlDbType.Char);
            p2.Value = TenLop;
            SqlParameter p3 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p3.Value = MaKhoaHoc;
            SqlParameter p4 = new SqlParameter("@MaHe", SqlDbType.Char);
            p4.Value = MaHe;
            SqlParameter p5 = new SqlParameter("@MaNganh", SqlDbType.Char);
            p5.Value = MaNganh;

            return db.ExcuteQueryDataSetWithParam("UpdateLopHoc", CommandType.StoredProcedure, p1, p2, p3, p4, p5);
        }
        public DataSet DeleteLopHoc(string MaLop)
        {
            SqlParameter p1 = new SqlParameter("@MaLop", SqlDbType.Char);
            p1.Value = MaLop;

            return db.ExcuteQueryDataSetWithParam("DeleteLopHoc", CommandType.StoredProcedure, p1);
        }
        public DataSet Search(string thongTin)
        {
            return db.ExcuteQueryDataSet($"select * from fSearchLopHoc({thongTin})", CommandType.Text);
        }
    }
}
