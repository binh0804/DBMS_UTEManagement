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
    public partial class KhoaForm : Form
    {
        DataTable dtKhoa = null;
        BSKhoa dbKhoa = new BSKhoa();
        bool Them;
        string err;
        public KhoaForm()
        {
            InitializeComponent();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtKhoa = new DataTable();
                DataSet ds = dbKhoa.LoadDDKhoa();
                dtKhoa = ds.Tables[0];
                dgvKhoa.DataSource = dtKhoa;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KhoaHoc. Lỗi rồi!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_MaKhoa.Focus();
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
                    BSKhoa BSNH = new BSKhoa();
                    // Thực hiện lệnh 
                    BSNH.AddKhoa(txt_MaKhoa.Text, txt_TenKhoa.Text);
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
                BSKhoa BSNH = new BSKhoa();
                BSNH.UpdateKhoa(txt_MaKhoa.Text, txt_TenKhoa.Text);

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txt_MaKhoa.ResetText();
            txt_TenKhoa.ResetText();
            txt_MaKhoa.ResetText();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txt_MaKhoa.Enabled = true;
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvKhoa.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaKhoa.Text = dgvKhoa.Rows[r].Cells[0].Value.ToString();
            txt_TenKhoa.Text = dgvKhoa.Rows[r].Cells[1].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Them = false;
            txt_TenKhoa.Focus();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            int r = dgvKhoa.CurrentCell.RowIndex;
            string strMaSV =
                dgvKhoa.Rows[r].Cells[0].Value.ToString();
            txt_MaKhoa.Text = strMaSV;
            txt_MaKhoa.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvKhoa.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaKhoaHoc =
                dgvKhoa.Rows[r].Cells[0].Value.ToString();
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
                    dbKhoa.DeleteKhoa(strMaKhoaHoc);
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

        private void KhoaForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtKhoa = new DataTable();
                dtKhoa.Clear();
                DataSet ds = dbKhoa.LoadDDKhoa();
                dtKhoa = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvKhoa.DataSource = dtKhoa;
                // Thay đổi độ rộng cột 
                dgvKhoa.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                txt_MaKhoa.ResetText();
                txt_TenKhoa.ResetText();
                //// Không cho thao tác trên các nút Lưu / Hủy 
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                //
                Them = false;
                //dgvKhoa_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KhoaHoc. Lỗi rồi!!!");
            }
        }
    }
}
