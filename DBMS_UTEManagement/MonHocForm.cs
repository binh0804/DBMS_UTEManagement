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

using System.Data.SqlClient;
using DBMS_UTEManagement.BSLayer;

namespace DBMS_UTEManagement
{
    public partial class MonHocForm : Form
    {
        DataTable dtMonHoc = null;
        BSMonHoc dbMH = new BSMonHoc();
        bool Them;
        string err;
        public MonHocForm()
        {
            InitializeComponent();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtMonHoc = new DataTable();
                DataSet ds = dbMH.LoadDDMH();
                dtMonHoc = ds.Tables[0];
                dgvMonHoc.DataSource = dtMonHoc;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table MonHoc. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMH.Focus();
            Them = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BSMonHoc BSNH = new BSMonHoc();
                    // Thực hiện lệnh 
                    BSNH.AddMH(txtMaMH.Text, txtTenMH.Text, float.Parse(txtLyThuyet.Text.Trim()), float.Parse(txtThucHanh.Text.Trim()));
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BSMonHoc BSNH = new BSMonHoc();
                BSNH.UpdateMH(txtMaMH.Text.Trim(), txtTenMH.Text.Trim(), float.Parse(txtLyThuyet.Text.Trim()), float.Parse(txtThucHanh.Text.Trim()));

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtLyThuyet.ResetText();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaMH.Enabled = true;
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvMonHoc.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txtMaMH.Text = dgvMonHoc.Rows[r].Cells[0].Value.ToString();
            txtTenMH.Text = dgvMonHoc.Rows[r].Cells[1].Value.ToString();
            txtLyThuyet.Text = dgvMonHoc.Rows[r].Cells[2].Value.ToString();
            txtThucHanh.Text = dgvMonHoc.Rows[r].Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Them = false;
            txtTenMH.Focus();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            int r = dgvMonHoc.CurrentCell.RowIndex;
            string strMaSV =
                dgvMonHoc.Rows[r].Cells[0].Value.ToString();
            txtMaMH.Text = strMaSV;
            txtMaMH.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvMonHoc.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaMH =
                dgvMonHoc.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbMH.DeleteMH(strMaMH);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void MonHocForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtMonHoc = new DataTable();
                dtMonHoc.Clear();
                DataSet ds = dbMH.LoadDDMH();
                dtMonHoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvMonHoc.DataSource = dtMonHoc;
                // Thay đổi độ rộng cột 
                dgvMonHoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                txtMaMH.ResetText();
                txtTenMH.ResetText();
                txtLyThuyet.ResetText();
                //// Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThemMH.Enabled = true;
                this.btnSuaMH.Enabled = true;
                this.btnXoaMH.Enabled = true;
                //
                Them = false;
                //dgvMonHoc_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table MonHoc. Lỗi rồi!!!");
            }
        }

    }
}
