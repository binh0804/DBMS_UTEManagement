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
    internal class BSBangDiem
    {
        DBMain db = null;
        string err = null;
        public BSBangDiem()
        {
            db = new DBMain();
        }
        public DataSet LoadDDMH()
        {
            return db.ExcuteQueryDataSet($"select * from fLoadMH()", CommandType.Text);
        }
        public DataSet AddBD(string MaSV, string MaMH, string LanThi, int HocKy, float Diem)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.Char);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@MaMH", SqlDbType.Char);
            p2.Value = MaMH;
            SqlParameter p3 = new SqlParameter("@LanThi", SqlDbType.Char);
            p3.Value = LanThi;
            SqlParameter p4 = new SqlParameter("@HocKy", SqlDbType.Int);
            p4.Value = HocKy;
            SqlParameter p5 = new SqlParameter("@Diem", SqlDbType.Float);
            p5.Value = Diem;
            return db.ExcuteQueryDataSetWithParam("Add", CommandType.StoredProcedure, p1, p2, p3, p4, p5);
        }
        public DataSet DeleteBD(string MaSV, string MaMH, string LanThi, int HocKy)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.Char);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@MaMH", SqlDbType.Char);
            p2.Value = MaMH;
            SqlParameter p3 = new SqlParameter("@LanThi", SqlDbType.Char);
            p3.Value = LanThi;
            SqlParameter p4 = new SqlParameter("@HocKy", SqlDbType.Int);
            p4.Value = HocKy;

            return db.ExcuteQueryDataSetWithParam("DeleteBD", CommandType.StoredProcedure, p1,p2,p3,p4);
        }
        public DataSet UpdateBD(string MaSV, string MaMH, string LanThi, int HocKy, float Diem)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.Char);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@MaMH", SqlDbType.Char);
            p2.Value = MaMH;
            SqlParameter p3 = new SqlParameter("@LanThi", SqlDbType.Char);
            p3.Value = LanThi;
            SqlParameter p4 = new SqlParameter("@HocKy", SqlDbType.Int);
            p4.Value = HocKy;
            SqlParameter p5 = new SqlParameter("@Diem", SqlDbType.Float);
            p5.Value = Diem;
            return db.ExcuteQueryDataSetWithParam("UpdateDiem", CommandType.StoredProcedure, p1, p2, p3, p4, p5);
        }
    }
}
