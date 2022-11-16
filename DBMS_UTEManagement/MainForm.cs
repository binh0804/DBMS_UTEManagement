using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DBMS_UTEManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lb_SinhVien.ForeColor = Color.White;
            pn_SinhVien.BackColor = Color.FromArgb(53, 73, 93);
            OpenChildForm(new SinhVienForm());
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBangDiemF_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BangDiemForm());
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void pn_SinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_SinhVien.ForeColor = Color.White;
            pn_SinhVien.BackColor = Color.FromArgb(53, 73, 93);
            OpenChildForm(new SinhVienForm());
        }

        private void pn_NganhHoc_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_NganhHoc.ForeColor = Color.White;
            pn_NganhHoc.BackColor = Color.FromArgb(53, 73, 93);
            OpenChildForm(new NganhHocForm());
        }

        private void pn_Khoa_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_Khoa.ForeColor = Color.White;
            pn_Khoa.BackColor = Color.FromArgb(53, 73, 93);
            OpenChildForm(new KhoaForm());
        }

        private void pn_Lop_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_Lop.ForeColor = Color.White;
            pn_Lop.BackColor = Color.FromArgb(53, 73, 93);
            OpenChildForm(new LopForm());
        }

        private void pn_MonHoc_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_MonHoc.ForeColor = Color.White;
            pn_MonHoc.BackColor = Color.FromArgb(53, 73, 93);
            OpenChildForm(new MonHocForm());
        }

        private void pn_KhoaHoc_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_KhoaHoc.ForeColor = Color.White;
            pn_KhoaHoc.BackColor = Color.FromArgb(53, 73, 93);
            OpenChildForm(new KhoaHocForm());
        }
        private void ResetColor()
        {
            lb_SinhVien.ForeColor = Color.FromArgb(203, 207, 210);
            lb_NganhHoc.ForeColor = Color.FromArgb(203, 207, 210);
            lb_Lop.ForeColor = Color.FromArgb(203, 207, 210);
            lb_Khoa.ForeColor = Color.FromArgb(203, 207, 210);
            lb_MonHoc.ForeColor = Color.FromArgb(203, 207, 210);
            lb_KhoaHoc.ForeColor = Color.FromArgb(203, 207, 210);


            pn_SinhVien.BackColor = Color.FromArgb(42, 63, 84);
            pn_NganhHoc.BackColor = Color.FromArgb(42, 63, 84);
            pn_Khoa.BackColor = Color.FromArgb(42, 63, 84);
            pn_Lop.BackColor = Color.FromArgb(42, 63, 84);
            pn_MonHoc.BackColor = Color.FromArgb(42, 63, 84);
            pn_KhoaHoc.BackColor = Color.FromArgb(42, 63, 84);

        }
    }
}
