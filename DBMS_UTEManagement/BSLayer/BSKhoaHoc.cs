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
    internal class BSKhoaHoc
    {
        DBMain db = null;
        string err = null;
        public BSKhoaHoc()
        {
            db = new DBMain();
        }
        public DataSet LoadDDKhoaHoc()
        {
            return db.ExcuteQueryDataSet($"select * from fLoadKhoaHoc()", CommandType.Text);
        }
        public void AddKhoaHoc(string MaKhoaHoc, string TenKhoaHoc)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p1.Value = MaKhoaHoc;
            SqlParameter p2 = new SqlParameter("@TenKhoaHoc", SqlDbType.NVarChar);
            p2.Value = TenKhoaHoc;
 
            db.MyExcuteNonQuery("AddKhoaHoc", CommandType.StoredProcedure, p1, p2);
        }
        public void UpdateKhoaHoc(string MaKhoaHoc, string TenKhoaHoc)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p1.Value = MaKhoaHoc;
            SqlParameter p2 = new SqlParameter("@TenKhoaHoc", SqlDbType.NVarChar);
            p2.Value = TenKhoaHoc;

            db.MyExcuteNonQuery("UpdateKhoaHoc", CommandType.StoredProcedure, p1, p2);
        }
        public void DeleteKhoaHoc(string MaKhoaHoc)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p1.Value = MaKhoaHoc;

            db.MyExcuteNonQuery("DeleteKhoaHoc", CommandType.StoredProcedure, p1);
        }
        public DataSet Search(string thongTin)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = thongTin;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fSearchKhoaHoc(@string)", CommandType.Text, p1);
        }
    }
}
