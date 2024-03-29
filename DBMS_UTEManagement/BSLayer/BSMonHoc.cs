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
        public void AddMH(string MaMH, string TenMH, float LyThuyet, float ThucHanh)
        {
            SqlParameter p1 = new SqlParameter("@MaMH", SqlDbType.Char);
            p1.Value = MaMH;
            SqlParameter p2 = new SqlParameter("@TenMH", SqlDbType.NVarChar);
            p2.Value = TenMH;
            SqlParameter p3 = new SqlParameter("@LyThuyet", SqlDbType.Float);
            p3.Value = LyThuyet;
            SqlParameter p4 = new SqlParameter("@ThucHanh", SqlDbType.Float);
            p4.Value = ThucHanh;
            db.MyExcuteNonQuery("AddMH", CommandType.StoredProcedure, p1, p2, p3, p4);
        }
        public void DeleteMH(string MaMH)
        {
            SqlParameter p1 = new SqlParameter("@MaMH", SqlDbType.Char);
            p1.Value = MaMH;

            db.MyExcuteNonQuery("DeleteMH", CommandType.StoredProcedure, p1);
        }
        public void UpdateMH(string MaMH, string TenMH, float LyThuyet, float ThucHanh)
        {
            SqlParameter p1 = new SqlParameter("@MaMH", SqlDbType.Char);
            p1.Value = MaMH;
            SqlParameter p2 = new SqlParameter("@TenMH", SqlDbType.NVarChar);
            p2.Value = TenMH;
            SqlParameter p3 = new SqlParameter("@LyThuyet", SqlDbType.Float);
            p3.Value = LyThuyet;
            SqlParameter p4 = new SqlParameter("@ThucHanh", SqlDbType.Float);
            p4.Value = ThucHanh;
            db.MyExcuteNonQuery("UpdateMH", CommandType.StoredProcedure, p1, p2, p3, p4);
        }
        public DataSet Search(string thongTin)
        {
            SqlParameter p1 = new SqlParameter("@string", SqlDbType.NVarChar);
            p1.Value = thongTin;

            return db.ExcuteQueryDataSetWithParam("SELECT * FROM fSearchMH(@string)", CommandType.Text, p1);
        }
    }
}
