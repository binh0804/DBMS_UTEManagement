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
    public partial class MonHocForm : Form
    {
        DataTable dtMonHoc = null;
        BSMonHoc dbMH = new BSMonHoc();
        bool Them = false;
        bool Sua = false;
        string err;
        string username = DBMain.username;
        public MonHocForm()
        {
            InitializeComponent();
            SetUpNormalState();
            dgvMonHoc.ReadOnly = true;
            if (username == "GiangVien")
            {
                btn_add.Enabled = false;
                btn_delete.Enabled = false;
            }
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
            SetUpAddState();
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
                    BSMonHoc BSNH = new BSMonHoc();
                    BSNH.UpdateMH(txtMaMH.Text.Trim(), txtTenMH.Text.Trim(), float.Parse(txtLyThuyet.Text.Trim()), float.Parse(txtThucHanh.Text.Trim()));

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
                        MessageBox.Show("Không Update được, vui lòng nhập đúng định dạng!");
                    if (ex is NullReferenceException)
                        MessageBox.Show("Không để trống thông tin");
                }
            }
            SetUpNormalState();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetUpNormalState();
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
            Sua = true;
            txtTenMH.Focus();
            SetUpAddState();

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
                this.btn_luu.Enabled = false;
                this.btn_huy.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btn_add.Enabled = true;
                this.btn_update.Enabled = true;
                this.btn_delete.Enabled = true;
                //
                Them = false;
                //dgvMonHoc_CellClick(null, null);
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
                dtMonHoc = new DataTable();
                dtMonHoc.Clear();
                DataSet ds = dbMH.Search(txt_search.Text.Trim());
                dtMonHoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvMonHoc.DataSource = dtMonHoc;
                // Thay đổi độ rộng cột 
                dgvMonHoc.AutoResizeColumns();
                txt_search.ResetText();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Mon Hoc. Lỗi rồi!!!");
            }
        }

        private void SetUpNormalState()
        {
            if (username == "GiangVien")
            {
                this.btn_update.Enabled = true;
            }
            else
            {
                this.btn_add.Enabled = true;
                this.btn_update.Enabled = true;
                this.btn_delete.Enabled = true;
            }
            Them = Sua = false;
            txtLyThuyet.Enabled = false;
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtThucHanh.Enabled = false;
           

            btn_luu.Enabled = false;
            btn_huy.Enabled = false;


            ResetTextAll();
        }

        private void ResetTextAll()
        {
            txtLyThuyet.ResetText();
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtThucHanh.ResetText();
        }

        private void SetUpAddState()
        {
            txtLyThuyet.Enabled = true;
            txtMaMH.Enabled = true;
            txtTenMH.Enabled = true;
            txtThucHanh.Enabled = true;

            btn_luu.Enabled = true;
            btn_huy.Enabled = true;

            this.btn_add.Enabled = false;
            this.btn_update.Enabled = false;
            this.btn_delete.Enabled = false;
        }
    }
}
