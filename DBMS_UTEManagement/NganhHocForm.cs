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
    public partial class NganhHocForm : Form
    {
        DataTable dtNganhHoc = null;
        BSNganhHoc dbNH = new BSNganhHoc();
        bool Them;
        string err;
        public NganhHocForm()
        {
            InitializeComponent();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtNganhHoc = new DataTable();
                DataSet ds = dbNH.LoadDDNganh();
                dtNganhHoc = ds.Tables[0];
                dgvNganhHoc.DataSource = dtNganhHoc;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NganhHoc. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_MaNganh.Focus();
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
                    BSNganhHoc BSNH = new BSNganhHoc();
                    // Thực hiện lệnh 
                    BSNH.AddNganh(txt_MaNganh.Text, txt_TenNganh.Text, float.Parse(txt_MaKhoa.Text.Trim()));
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
                BSNganhHoc BSNH = new BSNganhHoc();
                BSNH.UpdateNganh(txt_MaNganh.Text.Trim(), txt_TenNganh.Text.Trim(), float.Parse(txt_MaKhoa.Text.Trim()));

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txt_MaNganh.ResetText();
            txt_TenNganh.ResetText();
            txt_MaKhoa.ResetText();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txt_MaNganh.Enabled = true;
        }

        private void dgvNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNganhHoc.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaNganh.Text = dgvNganhHoc.Rows[r].Cells[0].Value.ToString();
            txt_TenNganh.Text = dgvNganhHoc.Rows[r].Cells[1].Value.ToString();
            txt_MaKhoa.Text = dgvNganhHoc.Rows[r].Cells[2].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Them = false;
            txt_TenNganh.Focus();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            int r = dgvNganhHoc.CurrentCell.RowIndex;
            string strMaSV =
                dgvNganhHoc.Rows[r].Cells[0].Value.ToString();
            txt_MaNganh.Text = strMaSV;
            txt_MaNganh.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvNganhHoc.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaNH =
                dgvNganhHoc.Rows[r].Cells[0].Value.ToString();
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
                    dbNH.DeleteNganh(strMaNH);
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

        private void NganhHocForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtNganhHoc = new DataTable();
                dtNganhHoc.Clear();
                DataSet ds = dbNH.LoadDDNganh();
                dtNganhHoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvNganhHoc.DataSource = dtNganhHoc;
                // Thay đổi độ rộng cột 
                dgvNganhHoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                txt_MaNganh.ResetText();
                txt_TenNganh.ResetText();
                txt_MaKhoa.ResetText();
                //// Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                //
                Them = false;
                //dgvNganhHoc_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Sản phẩm. Lỗi rồi!!!");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dtNganhHoc = new DataTable();
                dtNganhHoc.Clear();
                DataSet ds = dbNH.Search(txt_search.Text.Trim());
                dtNganhHoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvNganhHoc.DataSource = dtNganhHoc;
                // Thay đổi độ rộng cột 
                dgvNganhHoc.AutoResizeColumns();
                txt_search.ResetText();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Nganh Hoc. Lỗi rồi!!!");
            }
        }

    }
}
