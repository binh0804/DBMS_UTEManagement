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
    public partial class BangDiemForm : Form
    {
        DataTable dtDiem = null;
        BSBangDiem dbDiem = new BSBangDiem();
        bool Them = false;
        bool Sua = false;

        string username = DBMain.username;
        public BangDiemForm()
        {
            InitializeComponent();
            SetUpNormalState();
            dgvDiem.ReadOnly = true;

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
                dtDiem = new DataTable();
                DataSet ds = dbDiem.LoadDDMH("20110252");
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
            SetUpAddState();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BSBangDiem BSSV = new BSBangDiem();
                    // Thực hiện lệnh 
                    BSSV.AddDiem(txt_MaSV.Text.Trim(),
                                cb_MaMonHoc.SelectedValue.ToString().Trim(), 
                                int.Parse(txt_LanThi.Text.Trim()), 
                                int.Parse(cb_HocKyChiTiet.Text.Trim()),  
                                float.Parse(txt_Diem.Text.Trim()), 
                                int.Parse(cb_NamChiTiet.Text.Trim()));
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
                    BSBangDiem BSSV = new BSBangDiem();
                    BSSV.UpdateDiem(txt_MaSV.Text.Trim(),
                                cb_MaMonHoc.SelectedValue.ToString().Trim(),
                                int.Parse(txt_LanThi.Text.Trim()),
                                int.Parse(cb_HocKyChiTiet.Text.Trim()),
                                float.Parse(txt_Diem.Text.Trim()),
                                int.Parse(cb_NamChiTiet.Text.Trim()));
                    // Load lại dữ liệu trên DataGridView 
                    //LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã sửa xong!");
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
        SetUpNormalState();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetUpNormalState();
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            Sua = true;
            SetUpAddState();
            //Khoá mã sinh viên
            txt_MaSV.Enabled = false;
            cb_MaMonHoc.Enabled = false;
            int r = dgvDiem.CurrentCell.RowIndex;
            string strMaSV =
                dgvDiem.Rows[r].Cells[0].Value.ToString();
            txt_MaSV.Text = strMaSV;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvDiem.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaSV = dgvDiem.Rows[r].Cells[0].Value.ToString().Trim();
                string strMaMH = dgvDiem.Rows[r].Cells[1].Value.ToString().Trim();
                int strLanThi =  int.Parse(dgvDiem.Rows[r].Cells[2].Value.ToString().Trim());
                int strHocKy = int.Parse(dgvDiem.Rows[r].Cells[3].Value.ToString().Trim());
                int strNam = int.Parse(dgvDiem.Rows[r].Cells[5].Value.ToString().Trim());
                // Viết câu lệnh SQL 
                Console.WriteLine(strMaSV + " " +strMaMH + " " + strLanThi + " " + strHocKy +"  " + strNam);
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
            SetUpNormalState();
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
            txt_Diem.Enabled = false;
            txt_LanThi.Enabled = false;
            txt_MaSV.Enabled = false;
            cb_HocKyChiTiet.Enabled = false;
            cb_NamChiTiet.Enabled = false;
            cb_MaMonHoc.Enabled = false;

            btn_luu.Enabled = false;
            btn_huy.Enabled = false;

            ResetTextAll();
            LoadData();
        }

        private void ResetTextAll()
        {
            txt_Diem.ResetText();
            txt_LanThi.ResetText();
            txt_MaSV.ResetText();
            cb_HocKyChiTiet.ResetText();
            cb_NamChiTiet.ResetText();
            cb_MaMonHoc.ResetText();
        }

        private void SetUpAddState()
        {
            txt_Diem.Enabled = true;
            txt_LanThi.Enabled = true;
            txt_MaSV.Enabled = true;
            cb_HocKyChiTiet.Enabled = true;
            cb_NamChiTiet.Enabled = true;
            cb_MaMonHoc.Enabled = true;

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
            DataSet dsLop = db.ExcuteQueryDataSet($"select MaMH,TenMH from MonHoc", CommandType.Text);
            cb_MaMonHoc.DataSource = dsLop.Tables[0];
            cb_MaMonHoc.ValueMember = "MaMH";
            cb_MaMonHoc.DisplayMember = "TenMH";
        }

        private void BangDiemForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                dtDiem = new DataTable();
                dtDiem.Clear();
                DataSet ds = dbDiem.LoadDDMH("20110252");
                dtDiem = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvDiem.DataSource = dtDiem;
                // Thay đổi độ rộng cột 
                dgvDiem.AutoResizeColumns();
                SetUpDataList();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Sản phẩm. Lỗi rồi!!!");
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetTextAll();
            SetUpDataList();
            // Thứ tự dòng hiện hành 
            int r = dgvDiem.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_MaSV.Text = dgvDiem.Rows[r].Cells[0].Value.ToString().Trim();
            cb_MaMonHoc.SelectedValue = dgvDiem.Rows[r].Cells[1].Value.ToString().Trim();
            txt_LanThi.Text = dgvDiem.Rows[r].Cells[2].Value.ToString().Trim();
            cb_HocKyChiTiet.SelectedText = dgvDiem.Rows[r].Cells[3].Value.ToString().Trim();
            txt_Diem.Text = dgvDiem.Rows[r].Cells[4].Value.ToString().Trim();
            cb_NamChiTiet.SelectedText = dgvDiem.Rows[r].Cells[5].Value.ToString().Trim();
        }
    }
}
