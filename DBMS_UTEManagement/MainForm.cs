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
            lb_SinhVien.ForeColor = Color.FromArgb(40, 123, 247);
            pn_SinhVien.BackColor = Color.White;
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



        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void pn_SinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_SinhVien.ForeColor = Color.FromArgb(40, 123, 247);
            pn_SinhVien.BackColor = Color.White;
            OpenChildForm(new SinhVienForm());
        }

        private void pn_NganhHoc_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_NganhHoc.ForeColor = Color.FromArgb(40, 123, 247);
            pn_NganhHoc.BackColor = Color.White;
            OpenChildForm(new NganhHocForm());
        }

        private void pn_Khoa_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_Khoa.ForeColor = Color.FromArgb(40, 123, 247);
            pn_Khoa.BackColor = Color.White;
            OpenChildForm(new KhoaForm());
        }

        private void pn_Lop_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_Lop.ForeColor = Color.FromArgb(40, 123, 247);
            pn_Lop.BackColor = Color.White;
            OpenChildForm(new LopForm());
        }

        private void pn_MonHoc_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_MonHoc.ForeColor = Color.FromArgb(40, 123, 247);
            pn_MonHoc.BackColor = Color.White;
            OpenChildForm(new MonHocForm());
        }

        private void pn_KhoaHoc_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_KhoaHoc.ForeColor = Color.FromArgb(40, 123, 247);
            pn_KhoaHoc.BackColor = Color.White;
            OpenChildForm(new KhoaHocForm());
        }
        private void ResetColor()
        {
            lb_SinhVien.ForeColor = Color.White;
            lb_NganhHoc.ForeColor = Color.White;
            lb_Lop.ForeColor = Color.White;
            lb_Khoa.ForeColor = Color.White;
            lb_MonHoc.ForeColor = Color.White;
            lb_KhoaHoc.ForeColor = Color.White;
            lb_LogOut.ForeColor = Color.White;
            lb_Tracking.ForeColor = Color.White;

            pn_SinhVien.BackColor = Color.FromArgb(40, 123, 247);
            pn_NganhHoc.BackColor = Color.FromArgb(40, 123, 247);
            pn_Khoa.BackColor = Color.FromArgb(40, 123, 247);
            pn_Lop.BackColor = Color.FromArgb(40, 123, 247);
            pn_MonHoc.BackColor = Color.FromArgb(40, 123, 247);
            pn_KhoaHoc.BackColor = Color.FromArgb(40, 123, 247);
            pn_LogOut.BackColor = Color.FromArgb(40, 123, 247); 
            pn_Tracking.BackColor = Color.FromArgb(40, 123, 247);
        }

        private void pn_LogOut_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_LogOut.ForeColor = Color.FromArgb(40, 123, 247);
            pn_LogOut.BackColor = Color.White;
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đăng xuất không?", "Trả lời",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                LoginForm lg = new LoginForm();
                this.Hide();
                lg.ShowDialog();
            }    
        }

        private void pn_Tracking_MouseClick(object sender, MouseEventArgs e)
        {
            ResetColor();
            lb_Tracking.ForeColor = Color.FromArgb(40, 123, 247);
            pn_Tracking.BackColor = Color.White;
            TrackingForm tkf = new TrackingForm();
            tkf.ShowDialog();
        }
    }
}
