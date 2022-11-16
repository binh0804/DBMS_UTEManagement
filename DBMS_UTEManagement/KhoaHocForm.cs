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
    public partial class KhoaHocForm : Form
    {
        DataTable dtKhoaHoc = null;
        BSKhoaHoc dbKhoaHoc = new BSKhoaHoc();
        bool Them = false;
        bool Sua = false;
        string err;
        string username = DBMain.username;
        public KhoaHocForm()
        {
            InitializeComponent();
            SetUpNormalState();
            dgvKhoaHoc.ReadOnly = true;
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
            SetUpAddState();
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
            else if(Sua)
            {
                try
                {
                    // Thực hiện lệnh 
                    BSKhoaHoc BSNH = new BSKhoaHoc();
                    BSNH.UpdateKhoaHoc(txt_MaKhoaHoc.Text, txt_TenKhoaHoc.Text);

                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã sửa xong!");
                }
                catch(Exception ex)
                {
                    if (ex is SqlException)
                        MessageBox.Show("Không thêm được, hệ thống đang bị lỗi!");
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
            Sua = true;
            SetUpAddState();
            txt_TenKhoaHoc.Focus();

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
            txt_MaKhoaHoc.Enabled = false;
            txt_TenKhoaHoc.Enabled = false;
           

            btn_luu.Enabled = false;
            btn_huy.Enabled = false;

            ResetTextAll();
        }

        private void ResetTextAll()
        {
            txt_MaKhoaHoc.ResetText();
            txt_TenKhoaHoc.ResetText();          
        }

        private void SetUpAddState()
        {
            txt_MaKhoaHoc.Enabled = true;
            txt_TenKhoaHoc.Enabled = true;
            

            btn_luu.Enabled = true;
            btn_huy.Enabled = true;

            this.btn_add.Enabled = false;
            this.btn_update.Enabled = false;
            this.btn_delete.Enabled = false;
        }
    }
}
