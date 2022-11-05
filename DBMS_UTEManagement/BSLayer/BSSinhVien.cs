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
    internal class BSSinhVien
    {
        DBMain db = null;
        string err = null;
        public BSSinhVien()
        {
            db = new DBMain();
        }
        public DataSet LoadDDSV()
        {
            return db.ExcuteQueryDataSet($"select * from fLoadDSSV()", CommandType.Text);
        }
        public DataSet LoadTTSV(string MaSV)
        {
            return db.ExcuteQueryDataSet($"select * from fLoadTTSV({MaSV})", CommandType.Text);
        }
        public DataSet SearchSV(string thongTin)
        {
            return db.ExcuteQueryDataSet($"select * from fSearch({thongTin})", CommandType.Text);
        }
        public DataSet AddSV(string MaSV, string TenSV, string GioiTinh, DateTime NgaySinh, string NoiSinh, string DiaChi, float HocBong, string MaLop)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.Char);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@TenSV", SqlDbType.Char);
            p2.Value = TenSV;
            SqlParameter p3 = new SqlParameter("@GioiTinh", SqlDbType.Char);
            p3.Value = GioiTinh;
            SqlParameter p4 = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
            p4.Value = NgaySinh;
            SqlParameter p5 = new SqlParameter("@NoiSinh", SqlDbType.Char);
            p5.Value = NoiSinh;
            SqlParameter p6 = new SqlParameter("@DiaChi", SqlDbType.Char);
            p6.Value = DiaChi;
            SqlParameter p7 = new SqlParameter("@HocBong", SqlDbType.Float);
            p7.Value = HocBong;
            SqlParameter p8 = new SqlParameter("@MaLop", SqlDbType.Char);
            p8.Value = MaLop;
            return db.ExcuteQueryDataSetWithParam("ADDSV", CommandType.StoredProcedure, p1,p2,p3,p4,p5,p6,p7,p8);
        }
        public DataSet DeleteTTSV(string MaSV)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.Char);
            p1.Value = MaSV;
            return db.ExcuteQueryDataSetWithParam("DeleteTTSV", CommandType.StoredProcedure, p1);
        }
        public DataSet UpdateSV(string MaSV, string TenSV, string GioiTinh, DateTime NgaySinh, string NoiSinh, string DiaChi, float HocBong, string MaLop)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.Char);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@TenSV", SqlDbType.Char);
            p2.Value = TenSV;
            SqlParameter p3 = new SqlParameter("@GioiTinh", SqlDbType.Char);
            p3.Value = GioiTinh;
            SqlParameter p4 = new SqlParameter("@NgaySinh", SqlDbType.DateTime);
            p4.Value = NgaySinh;
            SqlParameter p5 = new SqlParameter("@NoiSinh", SqlDbType.Char);
            p5.Value = NoiSinh;
            SqlParameter p6 = new SqlParameter("@DiaChi", SqlDbType.Char);
            p6.Value = DiaChi;
            SqlParameter p7 = new SqlParameter("@HocBong", SqlDbType.Float);
            p7.Value = HocBong;
            SqlParameter p8 = new SqlParameter("@MaLop", SqlDbType.Char);
            p8.Value = MaLop;
            return db.ExcuteQueryDataSetWithParam("UpdateSV", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7, p8);
        }
        public DataSet LoadDSSVLop(string MaLop)
        {
            SqlParameter p1 = new SqlParameter("@MaLop", SqlDbType.Char);
            p1.Value = MaLop;
            return db.ExcuteQueryDataSetWithParam("LoadTTLop", CommandType.StoredProcedure, p1);
        }
    }
}
