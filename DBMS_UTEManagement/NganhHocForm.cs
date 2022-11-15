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
        bool Them = false;
        bool Sua = false;
        string err;
        public NganhHocForm()
        {
            InitializeComponent();
            SetUpNormalState();
            dgvNganhHoc.ReadOnly = true;
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
            SetUpAddState();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BSNganhHoc BSNH = new BSNganhHoc();
                    // Thực hiện lệnh 
                    BSNH.AddNganh(txt_MaNganh.Text, txt_TenNganh.Text, cb_makhoa.Text);
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
                    BSNganhHoc BSNH = new BSNganhHoc();
                    BSNH.UpdateNganh(txt_MaNganh.Text.Trim(), txt_TenNganh.Text.Trim(),cb_makhoa.Text.Trim());

                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (Exception ex)
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

        private void dgvNganhHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetTextAll();
            // Thứ tự dòng hiện hành 
            int r = dgvNganhHoc.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaNganh.Text = dgvNganhHoc.Rows[r].Cells[0].Value.ToString();
            txt_TenNganh.Text = dgvNganhHoc.Rows[r].Cells[1].Value.ToString();
            cb_makhoa.SelectedValue = dgvNganhHoc.Rows[r].Cells[2].Value.ToString().Trim();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Sua = true;
            SetUpAddState();
            int r = dgvNganhHoc.CurrentCell.RowIndex;
            string strMaSV = dgvNganhHoc.Rows[r].Cells[0].Value.ToString();
            txt_MaNganh.Text = strMaSV;
            txt_MaNganh.Enabled = false;
            txt_TenNganh.Focus();
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
            catch (Exception ex)
            {
                if (ex is SqlException)
                    MessageBox.Show("Không xóa được. Lỗi rồi!");
                else if (ex is NullReferenceException)
                    MessageBox.Show("Vui lòng chọn dữ liệu muốn xoá!");
            }
            SetUpNormalState();

        }

        private void NganhHocForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVien_UTEDataSet1.Khoa' table. You can move, or remove it, as needed.
            //this.khoaTableAdapter.Fill(this.quanLySinhVien_UTEDataSet1.Khoa);
            LoadData();
        }
        void LoadData()
        {
            try
            {
                SetUpDataList();
                dtNganhHoc = new DataTable();
                dtNganhHoc.Clear();
                DataSet ds = dbNH.LoadDDNganh();
                dtNganhHoc = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvNganhHoc.DataSource = dtNganhHoc;
                // Thay đổi độ rộng cột 
                dgvNganhHoc.AutoResizeColumns();
                //// Xóa trống các đối tượng trong Panel 
                //txt_MaNganh.ResetText();
                //txt_TenNganh.ResetText();
                //cb_makhoa.ResetText();
                ////// Không cho thao tác trên các nút Lưu / Hủy 
                //this.btn_luu.Enabled = false;
                //this.btn_huy.Enabled = false;

                ////// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                //this.btn_add.Enabled = true;
                //this.btn_update.Enabled = true;
                //this.btn_delete.Enabled = true;
                //
                //Them = false;
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
        private void SetUpNormalState()
        {
            Them = Sua = false;
            txt_MaNganh.Enabled = false;
            txt_TenNganh.Enabled = false;
            cb_makhoa.Enabled = false;

            btn_luu.Enabled = false;
            btn_huy.Enabled = false;

            this.btn_add.Enabled = true;
            this.btn_update.Enabled = true;
            this.btn_delete.Enabled = true;

            ResetTextAll();
        }
        private void ResetTextAll()
        {
            txt_MaNganh.ResetText();
            txt_TenNganh.ResetText();
            cb_makhoa.ResetText();

        }
        private void SetUpAddState()
        {
            txt_MaNganh.Enabled = true;
            txt_TenNganh.Enabled = true;
            cb_makhoa.Enabled = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;

            this.btn_add.Enabled = false;
            this.btn_update.Enabled = false;
            this.btn_delete.Enabled = false;
        }
        private void SetUpDataList()
        {
            DBLayer.DBMain db = new DBLayer.DBMain();
            //SetUp MaLop
            DataSet dsKhoa = db.ExcuteQueryDataSet($"select MaKhoa,TenKhoa from Khoa", CommandType.Text);
            cb_makhoa.DataSource = dsKhoa.Tables[0];
            cb_makhoa.ValueMember = "MaKhoa";
            cb_makhoa.DisplayMember = "TenKhoa";
        }
    }
}
