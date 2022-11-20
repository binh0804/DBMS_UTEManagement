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
    public partial class LopForm : Form
    {
        DataTable dtLop = null;
        BSLop dbLop = new BSLop();
        bool Them = false;
        bool Sua = false;
        string err;
        string username = DBMain.username;
        public LopForm()
        {
            InitializeComponent();
            SetUpNormalState();
            this.dgvLop.DefaultCellStyle.Font = new Font("Cambria", 12);

            dgvLop.ReadOnly = true;
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
            SetUpAddState();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BSLop BSNH = new BSLop();
                    // Thực hiện lệnh 
                    BSNH.ADDLopHoc( txt_MaLop.Text.Trim(),
                                    txt_TenLop.Text.Trim(),
                                    cb_makhoahoc.SelectedValue.ToString().Trim(),
                                    cb_MaHe.Text.Trim(),
                                    cb_manganh.SelectedValue.ToString().Trim());
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
                    BSLop BSNH = new BSLop();
                    BSNH.UpdateLopHoc(txt_MaLop.Text.Trim(), 
                                        txt_TenLop.Text.Trim(), 
                                        cb_makhoahoc.SelectedValue.ToString().Trim(), 
                                        cb_MaHe.Text.Trim(), 
                                        cb_manganh.SelectedValue.ToString().Trim());

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

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvLop.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaLop.Text = dgvLop.Rows[r].Cells[0].Value.ToString().Trim();
            txt_TenLop.Text = dgvLop.Rows[r].Cells[1].Value.ToString().Trim();
            cb_makhoahoc.Text = dgvLop.Rows[r].Cells[2].Value.ToString().Trim();
            cb_MaHe.Text = dgvLop.Rows[r].Cells[3].Value.ToString().Trim();
            cb_manganh.Text = dgvLop.Rows[r].Cells[4].Value.ToString().Trim();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Sua = true;
            SetUpAddState();
            txt_MaLop.Focus();

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
                SetUpDataList();
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
                cb_makhoahoc.ResetText();
                cb_MaHe.ResetText();
                cb_manganh.ResetText();
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
            txt_MaLop.Enabled = false;
            txt_TenLop.Enabled = false;
            cb_MaHe.Enabled = false;
            cb_makhoahoc.Enabled = false;
            cb_manganh.Enabled = false;

            btn_luu.Enabled = false;
            btn_huy.Enabled = false;

            ResetTextAll();
        }

        private void ResetTextAll()
        {
            txt_MaLop.ResetText();
            txt_TenLop.ResetText();
            cb_MaHe.ResetText();
            cb_makhoahoc.ResetText();
            cb_manganh.ResetText();
           
        }

        private void SetUpAddState()
        {
            txt_MaLop.Enabled = true;
            txt_TenLop.Enabled = true;
            cb_MaHe.Enabled = true;
            cb_makhoahoc.Enabled = true;
            cb_manganh.Enabled = true;

            btn_luu.Enabled = true;
            btn_huy.Enabled = true;

            this.btn_add.Enabled = false;
            this.btn_update.Enabled = false;
            this.btn_delete.Enabled = false;
        }
        private void SetUpDataList()
        {
            SetUpDataNganhHoc();
            SetUpDataHeDaoTao();
            SetUpDataKhoaHoc();
        }


        private void SetUpDataHeDaoTao()
        {
            DBLayer.DBMain db = new DBLayer.DBMain();
            //SetUp MaLop
            DataSet dsHe = db.ExcuteQueryDataSet($"select MaHe,TenHe from HeDaoTao", CommandType.Text);
            cb_MaHe.DataSource = dsHe.Tables[0];
            cb_MaHe.ValueMember = "MaHe";
            cb_MaHe.DisplayMember = "TenHe";
        }
        private void SetUpDataKhoaHoc()
        {
            DBLayer.DBMain db = new DBLayer.DBMain();
            DataSet dsKhoaHoc = db.ExcuteQueryDataSet($"select MaKhoaHoc,TenKhoaHoc from KhoaHoc", CommandType.Text);
            cb_makhoahoc.DataSource = dsKhoaHoc.Tables[0];
            cb_makhoahoc.ValueMember = "MaKhoaHoc";
            cb_makhoahoc.DisplayMember = "TenKhoaHoc";  
        }

        private void SetUpDataNganhHoc()
        {
            DBLayer.DBMain db = new DBLayer.DBMain();
            DataSet dsNganh = db.ExcuteQueryDataSet($"select MaNganh,TenNganh from NganhHoc", CommandType.Text);
            cb_manganh.DataSource = dsNganh.Tables[0];
            cb_manganh.ValueMember = "MaNganh";
            cb_manganh.DisplayMember = "TenNganh";
            
        }
        
    }
}

