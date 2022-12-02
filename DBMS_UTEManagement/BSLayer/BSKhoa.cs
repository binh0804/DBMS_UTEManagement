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
    internal class BSKhoa
    {
        DBMain db = null;
        string err = null;
        public BSKhoa()
        {
            db = new DBMain();
        }
        public DataSet LoadDDKhoa()
        {
            return db.ExcuteQueryDataSet($"select * from fLoadKhoa()", CommandType.Text);
        }
        public void AddKhoa(string MaKhoa, string TenKhoa)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoa", SqlDbType.Char);
            p1.Value = MaKhoa;
            SqlParameter p2 = new SqlParameter("@TenKhoa", SqlDbType.NVarChar);
            p2.Value = TenKhoa;

            db.MyExcuteNonQuery("AddKhoa", CommandType.StoredProcedure, p1, p2);
        }
        public void UpdateKhoa(string MaKhoa, string TenKhoa)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoa", SqlDbType.Char);
            p1.Value = MaKhoa;
            SqlParameter p2 = new SqlParameter("@TenKhoa", SqlDbType.NVarChar);
            p2.Value = TenKhoa;

            db.MyExcuteNonQuery("UpdateKhoa", CommandType.StoredProcedure, p1, p2);
        }
        public void DeleteKhoa(string MaKhoa)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoa", SqlDbType.Char);
            p1.Value = MaKhoa;

            db.MyExcuteNonQuery("DeleteKhoa", CommandType.StoredProcedure, p1);
        }
        public DataSet Search(string thongTin)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = thongTin;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fSearchKhoa(@string)", CommandType.Text, p1);
        }
    }
}
