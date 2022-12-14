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
        public DataSet SearchSV(string thongTin)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = thongTin;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fSearch(@string)", CommandType.Text, p1);
        }
        public void AddSV(string MaSV, string TenSV, string GioiTinh, DateTime NgaySinh, string NoiSinh, string DiaChi, string MaLop, byte[] Anh)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.VarChar);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@TenSV", SqlDbType.NVarChar);
            p2.Value = TenSV;
            SqlParameter p3 = new SqlParameter("@GioiTinh", SqlDbType.NChar);
            p3.Value = GioiTinh;
            SqlParameter p4 = new SqlParameter("@NgaySinh", SqlDbType.Date);
            p4.Value = NgaySinh.Date;
            SqlParameter p5 = new SqlParameter("@NoiSinh", SqlDbType.NVarChar);
            p5.Value = NoiSinh;
            SqlParameter p6 = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            p6.Value = DiaChi;
            SqlParameter p7 = new SqlParameter("@MaLop", SqlDbType.Char);
            p7.Value = MaLop;
            SqlParameter p8 = new SqlParameter("@Anh", SqlDbType.VarBinary);
            p8.Value = Anh;
            db.MyExcuteNonQuery("InsertStudentTransaction", CommandType.StoredProcedure, p1,p2,p3,p4,p5,p6,p7,p8);
        }
        public void DeleteTTSV(string MaSV)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.Char);
            p1.Value = MaSV;
            db.MyExcuteNonQuery("DeleteTTSV", CommandType.StoredProcedure, p1);
        }
        public void UpdateSV(string MaSV, string TenSV, string GioiTinh, DateTime NgaySinh, string NoiSinh, string DiaChi, string MaLop, byte[] Anh)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.VarChar);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@TenSV", SqlDbType.NVarChar);
            p2.Value = TenSV;
            SqlParameter p3 = new SqlParameter("@GioiTinh", SqlDbType.NChar);
            p3.Value = GioiTinh;
            SqlParameter p4 = new SqlParameter("@NgaySinh", SqlDbType.Date);
            p4.Value = NgaySinh.Date;
            SqlParameter p5 = new SqlParameter("@NoiSinh", SqlDbType.NVarChar);
            p5.Value = NoiSinh;
            SqlParameter p6 = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
            p6.Value = DiaChi;
            SqlParameter p7 = new SqlParameter("@MaLop", SqlDbType.Char);
            p7.Value = MaLop;
            SqlParameter p8 = new SqlParameter("@Anh", SqlDbType.VarBinary);
            p8.Value = Anh;
            db.MyExcuteNonQuery("UpdateStudentTransaction", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6, p7, p8);
        }
        public DataSet LoadDSSVLop(string MaLop)
        {
            SqlParameter p1 = new SqlParameter("@MaLop", SqlDbType.Char);
            p1.Value = MaLop;
            return db.ExcuteQueryDataSetWithParam("LoadTTLop", CommandType.StoredProcedure, p1);
        }

        public DataSet DTBtheoLop(string Malop)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.Char);
            p1.Value = Malop;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fLoadDTBTheoLop(@string)", CommandType.Text, p1);
        }

        public DataSet DTBtheoKhoa(string MaKhoa)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.Char);
            p1.Value = MaKhoa;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fLoadDTBTheoKhoa(@string)", CommandType.Text, p1);
        }

        public DataSet DanhSachHocBong (int Top,int HocKy, int Nam, string Khoa)
        {
            SqlParameter p1 = new SqlParameter("@Top", SqlDbType.Int);
            p1.Value = Top;
            SqlParameter p2 = new SqlParameter("@HocKy", SqlDbType.Int);
            p2.Value = HocKy;
            SqlParameter p3 = new SqlParameter("@Nam", SqlDbType.Int);
            p3.Value = Nam;
            SqlParameter p4 = new SqlParameter("@Khoa", SqlDbType.Char);
            p4.Value = Khoa;
            return db.ExcuteQueryDataSetWithParam($"select * from GetDanhSachHocBongTheoKhoaVaHocKy(@Top,@HocKy,@Nam,@Khoa)", CommandType.Text,p1,p2,p3,p4);
        }

        public byte[] SelectImage(string MaSV)
        {
            string sqlString = "select Anh from SinhVien where MaSV = '" + MaSV + "'";
            return db.Image(sqlString, CommandType.Text);
        }
    }
}
