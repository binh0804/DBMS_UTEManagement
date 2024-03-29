﻿using System;
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
        public DataSet LoadDDMH(string MSSV)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = MSSV;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fLoadDiem(@string)", CommandType.Text, p1);
        }
        public void AddDiem(string MaSV, string MaMH, int LanThi, int HocKy, float Diem, int Nam)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.VarChar);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@MaMH", SqlDbType.Char);
            p2.Value = MaMH;
            SqlParameter p3 = new SqlParameter("@LanThi", SqlDbType.Int);
            p3.Value = LanThi;
            SqlParameter p4 = new SqlParameter("@HocKy", SqlDbType.Int);
            p4.Value = HocKy;
            SqlParameter p5 = new SqlParameter("@Diem", SqlDbType.Float);
            p5.Value = Diem;
            SqlParameter p6 = new SqlParameter("@Nam", SqlDbType.Int);
            p6.Value = Nam;
            db.MyExcuteNonQuery("Add", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6);
        }
        public void DeleteDiem(string MaSV, string MaMH, int LanThi, int HocKy, int Nam)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.VarChar);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@MaMH", SqlDbType.Char);
            p2.Value = MaMH;
            SqlParameter p3 = new SqlParameter("@LanThi", SqlDbType.Int);
            p3.Value = LanThi;
            SqlParameter p4 = new SqlParameter("@HocKy", SqlDbType.Int);
            p4.Value = HocKy;
            SqlParameter p5 = new SqlParameter("@Nam", SqlDbType.Int);
            p5.Value = Nam;
            db.MyExcuteNonQuery("DeleteDiem", CommandType.StoredProcedure, p1,p2,p3,p4, p5);
        }
        public void UpdateDiem(string MaSV, string MaMH, int LanThi, int HocKy, float Diem, int Nam)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.VarChar);
            p1.Value = MaSV;
            SqlParameter p2 = new SqlParameter("@MaMH", SqlDbType.Char);
            p2.Value = MaMH;
            SqlParameter p3 = new SqlParameter("@LanThi", SqlDbType.Int);
            p3.Value = LanThi;
            SqlParameter p4 = new SqlParameter("@HocKy", SqlDbType.Int);
            p4.Value = HocKy;
            SqlParameter p5 = new SqlParameter("@Diem", SqlDbType.Float);
            p5.Value = Diem;
            SqlParameter p6 = new SqlParameter("@Nam", SqlDbType.Int);
            p6.Value = Nam;
            db.MyExcuteNonQuery("UpdateDiem", CommandType.StoredProcedure, p1, p2, p3, p4, p5, p6);
        }

        public DataSet LoadDTBTheoNam(string MSSV)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = MSSV;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fLoadDTBTheoNam(@string)", CommandType.Text, p1);
        }

        public DataSet fLoadDTBTheoNamHocKy(string MSSV,int Nam)
        {
            SqlParameter p1 = new SqlParameter("@MaSV", SqlDbType.NVarChar);
            p1.Value = MSSV;
            SqlParameter p2 = new SqlParameter("@Nam", SqlDbType.Int);
            p2.Value = Nam;
            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fLoadDTBTheoNamHocKy(@MaSV,@Nam)", CommandType.Text, p1,p2);
        }
    }
}
