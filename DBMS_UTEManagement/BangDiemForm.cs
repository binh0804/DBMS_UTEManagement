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
    public partial class BangDiemForm : Form
    {
        DataTable dtDiem = null;
        BSBangDiem dbDiem = new BSBangDiem();
        bool Them;
        string err;
        public BangDiemForm()
        {
            InitializeComponent();
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtDiem = new DataTable();
                DataSet ds = dbDiem.LoadDDMH();
                dtDiem = ds.Tables[0];
                dgvDiem.DataSource = dtDiem;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table BangDiem. Lỗi rồi!!!");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_MaSV.Focus();
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
                    BSBangDiem BSSV = new BSBangDiem();
                    // Thực hiện lệnh 
                    BSSV.AddDiem(txt_MaSV.Text, txt_MaMH.Text, txt_LanThi.Text, int.Parse(txt_HocKy.Text),  float.Parse(txt_Diem.Text), int.Parse(txt_Nam.Text));
                    // Load lại dữ liệu trên DataGridView 
                    //LoadData();
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
                try
                {
                    // Thực hiện lệnh 
                    BSBangDiem BSSV = new BSBangDiem();
                    BSSV.UpdateDiem(txt_MaSV.Text, txt_MaMH.Text, txt_LanThi.Text, int.Parse(txt_HocKy.Text), float.Parse(txt_Diem.Text), int.Parse(txt_Nam.Text));

                    // Load lại dữ liệu trên DataGridView 
                    //LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Không Update được, lỗi rồi!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txt_MaSV.ResetText();
            txt_MaMH.ResetText();
            txt_LanThi.ResetText();
            txt_HocKy.ResetText();
            txt_Nam.ResetText();
            txt_Diem.ResetText();
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txt_MaSV.Enabled = true;
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvDiem.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaSV.Text = dgvDiem.Rows[r].Cells[0].Value.ToString().Trim();
            txt_MaMH.Text = dgvDiem.Rows[r].Cells[1].Value.ToString().Trim();
            txt_LanThi.Text = dgvDiem.Rows[r].Cells[2].Value.ToString().Trim();
            txt_HocKy.Text = dgvDiem.Rows[r].Cells[3].Value.ToString().Trim();
            txt_Nam.Text = dgvDiem.Rows[r].Cells[4].Value.ToString().Trim();
            txt_Diem.Text = dgvDiem.Rows[r].Cells[5].Value.ToString().Trim();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Them = false;
            txt_MaMH.Focus();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            int r = dgvDiem.CurrentCell.RowIndex;
            string strMaSV =
                dgvDiem.Rows[r].Cells[0].Value.ToString();
            txt_MaSV.Text = strMaSV;
            txt_MaSV.Enabled = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvDiem.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaSV =
                dgvDiem.Rows[r].Cells[0].Value.ToString();
                string strMaMH =
                dgvDiem.Rows[r].Cells[1].Value.ToString();
                string strLanThi =
                dgvDiem.Rows[r].Cells[2].Value.ToString();
                int strHocKy = int.Parse(dgvDiem.Rows[r].Cells[3].Value.ToString());
                int strNam = int.Parse(dgvDiem.Rows[r].Cells[4].Value.ToString());
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
                    dbDiem.DeleteDiem(strMaSV, strMaMH, strLanThi, strHocKy, strNam);
                    // Cập nhật lại DataGridView
                    //LoadData();
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

        //private void SinhVienForm_Load(object sender, EventArgs e)
        //{
        //    LoadData();
        //}
        //void LoadData()
        //{
        //    try
        //    {
        //        dtDiem = new DataTable();
        //        dtDiem.Clear();
        //        DataSet ds = dbDiem.LoadDDSV();
        //        dtDiem = ds.Tables[0];
        //        // Đưa dữ liệu lên DataGridView 
        //        dgvDiem.DataSource = dtDiem;
        //        // Thay đổi độ rộng cột 
        //        dgvDiem.AutoResizeColumns();
        //        // Xóa trống các đối tượng trong Panel 
        //        txt_MaSV.ResetText();
        //        txt_MaMH.ResetText();
        //        txt_LanThi.ResetText();
        //        txt_HocKy.ResetText();
        //        txt_Nam.ResetText();
        //        txt_Diem.ResetText();
        //        txt_hocbong.ResetText();
        //        txt_malop.ResetText();
        //        //// Không cho thao tác trên các nút Lưu / Hủy 
        //        this.btnLuu.Enabled = false;
        //        this.btnHuy.Enabled = false;

        //        //// Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
        //        this.btn_add.Enabled = true;
        //        this.btn_update.Enabled = true;
        //        this.btn_delete.Enabled = true;
        //        //
        //        Them = false;
        //        //dgvDiem_CellClick(null, null);
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("Không lấy được nội dung trong table Sản phẩm. Lỗi rồi!!!");
        //    }
        //}

        
    }
}
