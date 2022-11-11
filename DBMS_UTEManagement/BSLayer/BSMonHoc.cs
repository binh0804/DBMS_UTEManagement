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
    internal class BSMonHoc
    {
        DBMain db = null;
        string err = null;
        public BSMonHoc()
        {
            db = new DBMain();
        }
        public DataSet LoadDDMH()
        {
            return db.ExcuteQueryDataSet($"select * from fLoadMH()", CommandType.Text);
        }
        public DataSet AddMH(string MaMH, string TenMH, float LyThuyet, float ThucHanh)
        {
            SqlParameter p1 = new SqlParameter("@TenMH", SqlDbType.Char);
            p1.Value = MaMH;
            SqlParameter p2 = new SqlParameter("@TenSV", SqlDbType.Char);
            p2.Value = TenMH;
            SqlParameter p3 = new SqlParameter("@LyThuyet", SqlDbType.Float);
            p3.Value = LyThuyet;
            SqlParameter p4 = new SqlParameter("@ThucHanh", SqlDbType.Float);
            p4.Value = ThucHanh;
            return db.ExcuteQueryDataSetWithParam("AddMH", CommandType.StoredProcedure, p1, p2, p3, p4);
        }
        public DataSet DeleteMH(string MaMH)
        {
            SqlParameter p1 = new SqlParameter("@TenMH", SqlDbType.Char);
            p1.Value = MaMH;

            return db.ExcuteQueryDataSetWithParam("DeleteMH", CommandType.StoredProcedure, p1);
        }
        public DataSet UpdateMH(string MaMH, string TenMH, float LyThuyet, float ThucHanh)
        {
            SqlParameter p1 = new SqlParameter("@TenMH", SqlDbType.Char);
            p1.Value = MaMH;
            SqlParameter p2 = new SqlParameter("@TenSV", SqlDbType.Char);
            p2.Value = TenMH;
            SqlParameter p3 = new SqlParameter("@LyThuyet", SqlDbType.Float);
            p3.Value = LyThuyet;
            SqlParameter p4 = new SqlParameter("@ThucHanh", SqlDbType.Float);
            p4.Value = ThucHanh;
            return db.ExcuteQueryDataSetWithParam("UpdateMH", CommandType.StoredProcedure, p1, p2, p3, p4);
        }
        public DataSet Search(string thongTin)
        {
            return db.ExcuteQueryDataSet($"select * from fSearchMH({thongTin})", CommandType.Text);
        }
    }
}
