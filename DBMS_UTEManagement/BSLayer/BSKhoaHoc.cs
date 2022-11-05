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
        public DataSet AddKhoaHoc(string MaKhoaHoc, string TenKhoaHoc)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p1.Value = MaKhoaHoc;
            SqlParameter p2 = new SqlParameter("@TenKhoaHoc", SqlDbType.Char);
            p2.Value = TenKhoaHoc;
 
            return db.ExcuteQueryDataSetWithParam("AddKhoaHoc", CommandType.StoredProcedure, p1, p2);
        }
        public DataSet UpdateKhoaHoc(string MaKhoaHoc, string TenKhoaHoc)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p1.Value = MaKhoaHoc;
            SqlParameter p2 = new SqlParameter("@TenKhoaHoc", SqlDbType.Char);
            p2.Value = TenKhoaHoc;

            return db.ExcuteQueryDataSetWithParam("UpdateKhoaHoc", CommandType.StoredProcedure, p1, p2);
        }
        public DataSet DeleteKhoaHoc(string MaKhoaHoc)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p1.Value = MaKhoaHoc;

            return db.ExcuteQueryDataSetWithParam("DeleteKhoaHoc", CommandType.StoredProcedure, p1);
        }
    }
}
