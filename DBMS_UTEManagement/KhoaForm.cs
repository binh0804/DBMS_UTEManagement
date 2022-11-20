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
using DBMS_UTEManagement.DBLayer;

namespace DBMS_UTEManagement
{
    public partial class KhoaForm : Form
    {
        DataTable dtKhoa = null;
        BSKhoa dbKhoa = new BSKhoa();
        bool Them = false;
        bool Sua = false;
        string err;
        string username = DBMain.username;
        public KhoaForm()
        {
            InitializeComponent();
            SetUpNormalState();
            this.dgvKhoa.DefaultCellStyle.Font = new Font("Cambria", 12);

            dgvKhoa.ReadOnly = true;
            if (username == "GiangVien")
            {
                btn_add.Enabled = false;
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
            }
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
            SetUpAddState();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BSKhoa BSNH = new BSKhoa();
                    // Thực hiện lệnh 
                    BSNH.AddKhoa(txt_MaKhoa.Text.Trim(),
                                txt_TenKhoa.Text.Trim());
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (Exception ex)
                {
                    if (ex is SqlException)
                        MessageBox.Show("Không thêm được, hệ thống đang bị lỗi!");
                    if (ex is FormatException)
                        MessageBox.Show("Vui lòng nhập đúng định dạng, không bỏ trống!");
                    if (ex is NullReferenceException)
                        MessageBox.Show("Không được bỏ trống các mục!");
                }
            }
            else if(Sua)
            {
                try
                {
                    // Thực hiện lệnh 
                    BSKhoa BSNH = new BSKhoa();
                    BSNH.UpdateKhoa(txt_MaKhoa.Text.Trim(),
                                    txt_TenKhoa.Text.Trim());

                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã sửa xong!");
                }
                catch(Exception ex)
                {
                    if (ex is SqlException)
                        MessageBox.Show("Không sửa được, hệ thống đang bị lỗi!");
                    if (ex is FormatException)
                        MessageBox.Show("Vui lòng nhập đúng định dạng, không bỏ trống!");
                    if (ex is NullReferenceException)
                        MessageBox.Show("Không được bỏ trống các mục!");
                }
            }
            SetUpNormalState();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetUpNormalState();
        }

        private void dgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvKhoa.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaKhoa.Text = dgvKhoa.Rows[r].Cells[0].Value.ToString().Trim();
            txt_TenKhoa.Text = dgvKhoa.Rows[r].Cells[1].Value.ToString().Trim();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Sua = true;
            txt_TenKhoa.Focus();
            SetUpAddState();

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
                this.btn_luu.Enabled = false;
                this.btn_huy.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                if (username != "GiangVien")
                {
                    this.btn_add.Enabled = true;
                    this.btn_update.Enabled = true;
                    this.btn_delete.Enabled = true;
                }
                //
                Them = false;
                //dgvKhoa_CellClick(null, null);
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
                dtKhoa = new DataTable();
                dtKhoa.Clear();
                DataSet ds = dbKhoa.Search(txt_search.Text.Trim());
                dtKhoa = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvKhoa.DataSource = dtKhoa;
                // Thay đổi độ rộng cột 
                dgvKhoa.AutoResizeColumns();
                txt_search.ResetText();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Khoa Hoc. Lỗi rồi!!!");
            }
        }
        private void SetUpNormalState()
        {
            if (username == "GiangVien")
            {
                this.btn_add.Enabled = false;
                this.btn_update.Enabled = false;
                this.btn_delete.Enabled = false;
            }
            else
            {
                this.btn_add.Enabled = true;
                this.btn_update.Enabled = true;
                this.btn_delete.Enabled = true;
            }
            Them = Sua = false;
            txt_MaKhoa.Enabled = false;
            txt_TenKhoa.Enabled = false;
           

            btn_luu.Enabled = false;
            btn_huy.Enabled = false;

            ResetTextAll();
        }

        private void ResetTextAll()
        {
            txt_MaKhoa.ResetText();
            txt_TenKhoa.ResetText();

        }

        private void SetUpAddState()
        {
            txt_MaKhoa.Enabled = true;
            txt_TenKhoa.Enabled = true;
           

            btn_luu.Enabled = true;
            btn_huy.Enabled = true;

            this.btn_add.Enabled = false;
            this.btn_update.Enabled = false;
            this.btn_delete.Enabled = false;
        }
    }
}
