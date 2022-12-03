using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using DBMS_UTEManagement.BSLayer;
using DBMS_UTEManagement.DBLayer;

namespace DBMS_UTEManagement
{
    public partial class TrackingForm : Form
    {
        DataTable dtLop = null;
        BSLogin dbLop = new BSLogin();

        public TrackingForm()
        {
            InitializeComponent();
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {
            try
            {
                dtLop = new DataTable();
                dtLop.Clear();
                DataSet ds = dbLop.LoadTracking();
                dtLop = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvTracking.DataSource = dtLop;
                // Thay đổi độ rộng cột 
                dgvTracking.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                if(ex is SqlException)
                MessageBox.Show("Không có quyền xem tracklog!");
                this.Close();
            }
        }
    }
}
