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
    internal class BSLogin
    {
        DBMain db = null;
        public BSLogin()
        {
            db = new DBMain();
        }
        public int Kiemtra(string us, string pw)
        {
            string sqlString = "Select Count(*) From LoginData Where username ='" + us + "' and pwd ='" + pw + "'";
            return db.KiemTra(sqlString, CommandType.Text);
        }
        public int Checkrole(string us)
        {
            string sqlString = "select userRole from LoginData where username ='" + us + "'";
            return db.KiemTra(sqlString, CommandType.Text);
        }
    }
}
