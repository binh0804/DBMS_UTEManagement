using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DBMS_UTEManagement.BSLayer;
using System.Data.SqlClient;
using DBMS_UTEManagement.DBLayer;

namespace DBMS_UTEManagement
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            DBMain.string_ConnStr = "Data Source = LOJC\\LOJC; Initial Catalog = QuanLySinhVien_UTE; Integrated Security = true";
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                BSLogin blLG = new BSLogin();
                int k = blLG.Kiemtra(txt_username.Text, txt_password.Text);
                if (k > 0)
                {
/*                    DBMain.string_ConnStr = "Data Source=LOJC\\LOJC;Initial Catalog=QuanLySinhVien_UTE;User ID=" + txt_username.Text + ";Password=" + txt_password.Text + ";";
*/                    if (blLG.Checkrole(txt_username.Text) == 1)
                    {
                        DBMain.username = "QuanTri";
                    }
                    else if(blLG.Checkrole(txt_username.Text) == 0)
                    {
                        DBMain.username = "GiangVien";
                    }
                    MainForm fr = new MainForm();
                    fr.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                    txt_username.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi!");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
/*if (txt_username.Text == "" || txt_password.Text == "")
{
    MessageBox.Show("Please don't leave any textbox is empty");
}
else if ((txt_username.Text == "QuanTri" && txt_password.Text == "123") || (txt_username.Text == "GiangVien" && txt_password.Text == "123"))
{
    DBMain.username = txt_username.Text;
    DBMain.password = txt_password.Text;
    DBMain.string_ConnStr = "Data Source=LOJC\\LOJC;Initial Catalog=QuanLySinhVien_UTE;User ID=" + DBMain.username + ";Password=" + DBMain.password + ";";
    MainForm fr = new MainForm();
    fr.ShowDialog();
    Application.Exit();
}
else
{
    MessageBox.Show("Wrong username or password");
}*/