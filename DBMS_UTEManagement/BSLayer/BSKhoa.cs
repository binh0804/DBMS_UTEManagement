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
        public DataSet AddKhoa(string MaKhoa, string TenKhoa)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoa", SqlDbType.Char);
            p1.Value = MaKhoa;
            SqlParameter p2 = new SqlParameter("@TenKhoac", SqlDbType.Char);
            p2.Value = TenKhoa;

            return db.ExcuteQueryDataSetWithParam("AddKhoa", CommandType.StoredProcedure, p1, p2);
        }
        public DataSet UpdateKhoa(string MaKhoa, string TenKhoa)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoa", SqlDbType.Char);
            p1.Value = MaKhoa;
            SqlParameter p2 = new SqlParameter("@TenKhoac", SqlDbType.Char);
            p2.Value = TenKhoa;

            return db.ExcuteQueryDataSetWithParam("UpdateKhoa", CommandType.StoredProcedure, p1, p2);
        }
        public DataSet DeleteKhoa(string MaKhoa)
        {
            SqlParameter p1 = new SqlParameter("@MaKhoaHoc", SqlDbType.Char);
            p1.Value = MaKhoa;

            return db.ExcuteQueryDataSetWithParam("DeleteKhoa", CommandType.StoredProcedure, p1);
        }
        public DataSet Search(string thongTin)
        {
            return db.ExcuteQueryDataSet($"select * from fSearchKhoa({thongTin})", CommandType.Text);
        }
    }
}