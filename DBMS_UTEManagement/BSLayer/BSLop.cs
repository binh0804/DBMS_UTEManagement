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
        public DataSet LoadMaLop()
        {
            return db.ExcuteQueryDataSet($"select MaLop from fLoadLop()", CommandType.Text);
        }
        public void ADDLopHoc(string MaLop, string TenLop, string MaKhoaHoc, string MaHe, string MaNganh)
        {
            SqlParameter p1 = new SqlParameter("@MaLop", SqlDbType.Char);
            p1.Value = MaLop;
            SqlParameter p2 = new SqlParameter("@TenLop", SqlDbType.NVarChar);
            p2.Value = TenLop;
            SqlParameter p3 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p3.Value = MaKhoaHoc;
            SqlParameter p4 = new SqlParameter("@MaHe", SqlDbType.Char);
            p4.Value = MaHe;
            SqlParameter p5 = new SqlParameter("@MaNganh", SqlDbType.Char);
            p5.Value = MaNganh;

            db.MyExcuteNonQuery("ADDLopHoc", CommandType.StoredProcedure, p1, p2,p3,p4,p5);
        }
        public void UpdateLopHoc(string MaLop, string TenLop, string MaKhoaHoc, string MaHe, string MaNganh)
        {
            SqlParameter p1 = new SqlParameter("@MaLop", SqlDbType.Char);
            p1.Value = MaLop;
            SqlParameter p2 = new SqlParameter("@TenLop", SqlDbType.NVarChar);
            p2.Value = TenLop;
            SqlParameter p3 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p3.Value = MaKhoaHoc;
            SqlParameter p4 = new SqlParameter("@MaHe", SqlDbType.Char);
            p4.Value = MaHe;
            SqlParameter p5 = new SqlParameter("@MaNganh", SqlDbType.Char);
            p5.Value = MaNganh;

            db.MyExcuteNonQuery("UpdateLopHoc", CommandType.StoredProcedure, p1, p2, p3, p4, p5);
        }
        public void DeleteLopHoc(string MaLop)
        {
            SqlParameter p1 = new SqlParameter("@MaLop", SqlDbType.Char);
            p1.Value = MaLop;

            db.MyExcuteNonQuery("DeleteLopHoc", CommandType.StoredProcedure, p1);
        }
        public DataSet Search(string thongTin)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = thongTin;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fSearchLopHoc(@string)", CommandType.Text, p1);
        }
    }
}
