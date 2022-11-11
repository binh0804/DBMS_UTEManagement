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
    public partial class KhoaHocForm : Form
    {
        DataTable dtKhoaHoc = null;
        BSKhoaHoc dbKhoaHoc = new BSKhoaHoc();
        bool Them;
        string err;
        public KhoaHocForm()
        {
            InitializeComponent();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtKhoaHoc = new DataTable();
                DataSet ds = dbKhoaHoc.LoadDDKhoaHoc();
                dtKhoaHoc = ds.Tables[0];
                dgvKhoaHoc.DataSource = dtKhoaHoc;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KhoaHoc. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_MaKhoaHoc.Focus();
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
                    BSKhoaHoc BSNH = new BSKhoaHoc();
                    // Thực hiện lệnh 
                    BSNH.AddKhoaHoc(txt_MaKhoaHoc.Text, txt_TenKhoaHoc.Text);
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
                BSKhoaHoc BSNH = new BSKhoaHoc();
                BSNH.UpdateKhoaHoc(txt_MaKhoaHoc.Text, txt_TenKhoaHoc.Text);

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txt_MaKhoaHoc.ResetText();
            txt_TenKhoaHoc.ResetText();
            txt_MaKhoaHoc.ResetText();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txt_MaKhoaHoc.Enabled = true;
        }

        private void dgvKhoaHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvKhoaHoc.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaKhoaHoc.Text = dgvKhoaHoc.Rows[r].Cells[0].Value.ToString();
            txt_TenKhoaHoc.Text = dgvKhoaHoc.Rows[r].Cells[1].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Them = false;
            txt_TenKhoaHoc.Focus();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            int r = dgvKhoaHoc.CurrentCell.RowIndex;
            string strMaSV =
                dgvKhoaHoc.Rows[r].Cells[0].Value.ToString();
            txt_MaKhoaHoc.Text = strMaSV;
            txt_MaKhoaHoc.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvKhoaHoc.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaKhoaHoc =
                dgvKhoaHoc.Rows[r].Cells[0].Value.ToString();
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
                    dbKhoaHoc.DeleteKhoaHoc(strMaKhoaHoc);
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

        private void KhoaHocForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtKhoaHoc = new DataTable();
                dtKhoaHoc.Clear();
                DataSet ds = dbKhoaHoc.LoadDDKhoaHoc();
                dtKhoaHoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvKhoaHoc.DataSource = dtKhoaHoc;
                // Thay đổi độ rộng cột 
                dgvKhoaHoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                txt_MaKhoaHoc.ResetText();
                txt_TenKhoaHoc.ResetText();
                //// Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                //
                Them = false;
                //dgvKhoaHoc_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KhoaHoc. Lỗi rồi!!!");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dtKhoaHoc = new DataTable();
                dtKhoaHoc.Clear();
                DataSet ds = dbKhoaHoc.Search(txt_search.Text.Trim());
                dtKhoaHoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvKhoaHoc.DataSource = dtKhoaHoc;
                // Thay đổi độ rộng cột 
                dgvKhoaHoc.AutoResizeColumns();
                txt_search.ResetText();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Nganh Hoc. Lỗi rồi!!!");
            }
        }
    }
}
