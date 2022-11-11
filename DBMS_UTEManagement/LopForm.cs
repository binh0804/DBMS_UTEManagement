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
    public partial class LopForm : Form
    {
        DataTable dtLop = null;
        BSLop dbLop = new BSLop();
        bool Them;
        string err;
        public LopForm()
        {
            InitializeComponent();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtLop = new DataTable();
                DataSet ds = dbLop.LoadDDLop();
                dtLop = ds.Tables[0];
                dgvLop.DataSource = dtLop;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_MaLop.Focus();
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
                    BSLop BSNH = new BSLop();
                    // Thực hiện lệnh 
                    BSNH.ADDLopHoc(txt_MaLop.Text, txt_TenLop.Text, txt_MaKhoaHoc.Text, txt_MaHe.Text, txt_MaNganh.Text);
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
                BSLop BSNH = new BSLop();
                BSNH.UpdateLopHoc(txt_MaLop.Text, txt_TenLop.Text, txt_MaKhoaHoc.Text, txt_MaHe.Text, txt_MaNganh.Text);

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txt_MaLop.ResetText();
            txt_TenLop.ResetText();
            txt_MaKhoaHoc.ResetText();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txt_MaLop.Enabled = true;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvLop.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaLop.Text = dgvLop.Rows[r].Cells[0].Value.ToString();
            txt_TenLop.Text = dgvLop.Rows[r].Cells[1].Value.ToString();
            txt_MaKhoaHoc.Text = dgvLop.Rows[r].Cells[2].Value.ToString();
            txt_MaHe.Text = dgvLop.Rows[r].Cells[3].Value.ToString();
            txt_MaNganh.Text = dgvLop.Rows[r].Cells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Them = false;
            txt_TenLop.Focus();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            int r = dgvLop.CurrentCell.RowIndex;
            string strMaSV =
                dgvLop.Rows[r].Cells[0].Value.ToString();
            txt_MaLop.Text = strMaSV;
            txt_MaLop.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvLop.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaLopHoc =
                dgvLop.Rows[r].Cells[0].Value.ToString();
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
                    dbLop.DeleteLopHoc(strMaLopHoc);
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

        private void LopHocForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtLop = new DataTable();
                dtLop.Clear();
                DataSet ds = dbLop.LoadDDLop();
                dtLop = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvLop.DataSource = dtLop;
                // Thay đổi độ rộng cột 
                dgvLop.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                txt_MaLop.ResetText();
                txt_TenLop.ResetText();
                txt_MaKhoaHoc.ResetText();
                //// Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                //
                Them = false;
                //dgvLop_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table MonHoc. Lỗi rồi!!!");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dtLop = new DataTable();
                dtLop.Clear();
                DataSet ds = dbLop.Search(txt_search.Text.Trim());
                dtLop = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvLop.DataSource = dtLop;
                // Thay đổi độ rộng cột 
                dgvLop.AutoResizeColumns();
                txt_search.ResetText();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop Hoc. Lỗi rồi!!!");
            }
        }
    }
}
