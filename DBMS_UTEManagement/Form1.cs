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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnSinhVienF_Click(object sender, EventArgs e)
        {
            Form frm = new SinhVienForm();
            frm.ShowDialog();
        }

        private void btnMonHocF_Click(object sender, EventArgs e)
        {
            Form frm = new MonHocForm();
            frm.ShowDialog();
        }

        private void btnNganhHocF_Click(object sender, EventArgs e)
        {
            Form frm = new NganhHocForm();
            frm.ShowDialog();
        }

        private void btnLopF_Click(object sender, EventArgs e)
        {
            Form frm = new LopForm();
            frm.ShowDialog();
        }

        private void btnKhoahocF_Click(object sender, EventArgs e)
        {
            Form frm = new KhoaHocForm();
            frm.ShowDialog();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            Form frm = new KhoaForm();
            frm.ShowDialog();
        }

        private void btnBangDiemF_Click(object sender, EventArgs e)
        {
            Form frm = new BangDiemForm();
            frm.ShowDialog();
        }
    }
}
