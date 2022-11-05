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
    public partial class SinhVìenForm : Form
    {
        DataTable dtSinhVien = null;
        BSSinhVien dbSV = new BSSinhVien();
        bool Them;
        string err;
        public SinhVìenForm()
        {
            InitializeComponent();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtSinhVien = new DataTable();
                DataSet ds = dbSV.LoadDDSV();
                dtSinhVien = ds.Tables[0];
                dgvSinhVien.DataSource = dtSinhVien;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table SinhVien. Lỗi rồi!!!");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_masv.Focus();
            Them = true;
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BSSinhVien BSSV = new BSSinhVien();
                    // Thực hiện lệnh 
                    BSSV.AddSV(txt_masv.Text, txt_tensv.Text, txt_gioitinh.Text, DateTime.ParseExact(txt_ngaysinh.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture), txt_noisinh.Text, txt_diachi.Text, float.Parse(txt_hocbong.Text, CultureInfo.InvariantCulture.NumberFormat), txt_malop.Text);
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
                BSSinhVien BSSV = new BSSinhVien();
                BSSV.UpdateSV(txt_masv.Text.Trim(), txt_tensv.Text.Trim(), txt_gioitinh.Text.Trim(), DateTime.ParseExact(txt_ngaysinh.Text, "dd/MM/yyyy hh.mm.ss tt", CultureInfo.InvariantCulture), txt_noisinh.Text.Trim(), txt_diachi.Text.Trim(), float.Parse(txt_hocbong.Text, CultureInfo.InvariantCulture.NumberFormat), txt_malop.Text.Trim());

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_masv.ResetText();
            txt_tensv.ResetText();
            txt_gioitinh.ResetText();
            txt_ngaysinh.ResetText();
            txt_noisinh.ResetText();
            txt_diachi.ResetText();
            txt_hocbong.ResetText();
            txt_malop.ResetText();
            btn_huy.Enabled = false;
            btn_luu.Enabled = false;
            txt_masv.Enabled = true;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvSinhVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_masv.Text = dgvSinhVien.Rows[r].Cells[0].Value.ToString();
            txt_tensv.Text = dgvSinhVien.Rows[r].Cells[1].Value.ToString();
            txt_gioitinh.Text = dgvSinhVien.Rows[r].Cells[2].Value.ToString();
            txt_ngaysinh.Text = dgvSinhVien.Rows[r].Cells[3].Value.ToString();
            txt_noisinh.Text = dgvSinhVien.Rows[r].Cells[4].Value.ToString();
            txt_diachi.Text = dgvSinhVien.Rows[r].Cells[5].Value.ToString();
            txt_malop.Text = dgvSinhVien.Rows[r].Cells[6].Value.ToString();
            txt_hocbong.Text = dgvSinhVien.Rows[r].Cells[7].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Them = false;
            txt_tensv.Focus();
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            int r = dgvSinhVien.CurrentCell.RowIndex;
            string strMaSV =
                dgvSinhVien.Rows[r].Cells[0].Value.ToString();
            txt_masv.Text = strMaSV;
            txt_masv.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvSinhVien.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaSV =
                dgvSinhVien.Rows[r].Cells[0].Value.ToString();
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
                    dbSV.DeleteTTSV(strMaSV);
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

        private void SinhVienForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet ds = dbSV.LoadDDSV();
                dtSinhVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvSinhVien.DataSource = dtSinhVien;
                // Thay đổi độ rộng cột 
                dgvSinhVien.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                txt_masv.ResetText();
                txt_tensv.ResetText();
                txt_gioitinh.ResetText();
                txt_ngaysinh.ResetText();
                txt_noisinh.ResetText();
                txt_diachi.ResetText();
                txt_hocbong.ResetText();
                txt_malop.ResetText();
                //// Không cho thao tác trên các nút Lưu / Hủy 
                this.btn_luu.Enabled = false;
                this.btn_huy.Enabled = false;

                //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btn_add.Enabled = true;
                this.btn_update.Enabled = true;
                this.btn_delete.Enabled = true;
                //
                Them = false;
                //dgvSinhVien_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Sản phẩm. Lỗi rồi!!!");
            }
        }
    }
}
