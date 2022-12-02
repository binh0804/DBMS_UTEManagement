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
    internal class BSNganhHoc
    {
        DBMain db = null;
        string err = null;
        public BSNganhHoc()
        {
            db = new DBMain();
        }
        public DataSet LoadDDNganh()
        {
            return db.ExcuteQueryDataSet($"select * from fSelectNganh()", CommandType.Text);
        }
        public void AddNganh(string MaNganh, string TenNganh, string MaKhoa)
        {
            SqlParameter p1 = new SqlParameter("@MaNganh", SqlDbType.Char);
            p1.Value = MaNganh;
            SqlParameter p2 = new SqlParameter("@TenNganh", SqlDbType.NChar);
            p2.Value = TenNganh;
            SqlParameter p3 = new SqlParameter("@MaKhoa", SqlDbType.Char);
            p3.Value = MaKhoa;
            db.MyExcuteNonQuery("AddNganh", CommandType.StoredProcedure, p1, p2, p3);
        }
        public void DeleteNganh(string MaNganh)
        {
            SqlParameter p1 = new SqlParameter("@MaNganh", SqlDbType.Char);
            p1.Value = MaNganh;

            db.MyExcuteNonQuery("DeleteNganh", CommandType.StoredProcedure, p1);
        }
        public void UpdateNganh(string MaNganh, string TenNganh, string MaKhoa)
        {
            SqlParameter p1 = new SqlParameter("@MaNganh", SqlDbType.Char);
            p1.Value = MaNganh;
            SqlParameter p2 = new SqlParameter("@TenNganh", SqlDbType.NChar);
            p2.Value = TenNganh;
            SqlParameter p3 = new SqlParameter("@MaKhoa", SqlDbType.Char);
            p3.Value = MaKhoa;
            db.MyExcuteNonQuery("UpdateNganh", CommandType.StoredProcedure, p1, p2, p3);
        }
        public DataSet Search(string thongTin)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = thongTin;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fSearchNganh(@string)", CommandType.Text, p1);
        }
    }
}
