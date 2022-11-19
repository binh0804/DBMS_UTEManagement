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

using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
namespace DBMS_UTEManagement
{
    public partial class SinhVienForm : Form
    {

        DataTable dtSinhVien = null;
        BSSinhVien dbSV = new BSSinhVien();
        string username = DBMain.username;
        bool Them = false;
        bool Sua = false;
        string err;
        bool dtb = false;
        public SinhVienForm()
        {
            InitializeComponent();
            
            SetUpNormalState();
            this.dgvSinhVien.DefaultCellStyle.Font = new Font("Cambria", 10);
            this.dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cb_gioiTinh.SelectedItem = "Nam";
            dgvSinhVien.ReadOnly = true;
            if (username == "GiangVien")
            {
                btn_add.Enabled = false;
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtSinhVien = new DataTable();
                DataSet ds = dbSV.LoadDDSV();
                dtSinhVien = ds.Tables[0];
                dgvSinhVien.DataSource = dtSinhVien;
                SetUpNormalState();
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
            SetUpAddState();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Sua = true;
            SetUpAddState();
            //Khoá mã sinh viên
            txt_masv.Enabled = false;

            txt_tensv.Focus();
            if(dgvSinhVien.CurrentCell != null)
            {
                int r = dgvSinhVien.CurrentCell.RowIndex;
                string strMaSV = dgvSinhVien.Rows[r].Cells[0].Value.ToString();
                txt_masv.Text = strMaSV;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BSSinhVien BSSV = new BSSinhVien();
                    // Thực hiện lệnh 
                    Console.WriteLine(cb_gioiTinh.Text.ToString().Trim());
                    Console.WriteLine(cb_maLop.SelectedValue.ToString().Trim());
                    Console.WriteLine(dtp_ngaySinh.Value.Date);
                    Console.WriteLine(float.Parse(txt_hocbong.Text, CultureInfo.InvariantCulture.NumberFormat));
                    BSSV.AddSV( txt_masv.Text.Trim(), 
                                txt_tensv.Text.Trim(),
                                cb_gioiTinh.Text.ToString().Trim(), 
                                dtp_ngaySinh.Value.Date,
                                txt_noisinh.Text.Trim(), 
                                txt_diachi.Text.Trim(),
                                cb_maLop.SelectedValue.ToString().Trim(),
                                float.Parse(txt_hocbong.Text, CultureInfo.InvariantCulture.NumberFormat));
                    // Load lại dữ liệu trên DataGridView 

                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (Exception ex)
                {
                    if(ex is SqlException)
                        MessageBox.Show("Không thêm được, hệ thống đang bị lỗi!");
                    if (ex is FormatException)
                        MessageBox.Show("Vui lòng nhập đúng định dạng, không bỏ trống!");
                    if (ex is NullReferenceException)
                        MessageBox.Show("Không được bỏ trống các mục!");
                }
            }
            else if(Sua)
            {
                Console.WriteLine("SUA");
                try
                {
                    // Thực hiện lệnh 
                    BSSinhVien BSSV = new BSSinhVien();
                    BSSV.UpdateSV(txt_masv.Text.Trim(),
                                    txt_tensv.Text.Trim(),
                                    cb_gioiTinh.Text.Trim(),
                                    dtp_ngaySinh.Value.Date,
                                    txt_noisinh.Text.Trim(),
                                    txt_diachi.Text.Trim(),
                                    cb_maLop.SelectedValue.ToString().Trim(),
                                    float.Parse(txt_hocbong.Text, CultureInfo.InvariantCulture.NumberFormat));
                    // Load lại dữ liệu trên DataGridView 
                    // Thông báo 
                    LoadData();
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

        private void btn_huy_Click(object sender, EventArgs e)
        {
            SetUpNormalState();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetTextAll();
            // Thứ tự dòng hiện hành 
            if(dtb==true)
            {
                int r = dgvSinhVien.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
                txt_masv.Text = dgvSinhVien.Rows[r].Cells[0].Value.ToString().Trim();
                txt_tensv.Text = dgvSinhVien.Rows[r].Cells[1].Value.ToString().Trim();
            }
            else
            {
                int r = dgvSinhVien.CurrentCell.RowIndex;
                // Chuyển thông tin lên panel 
                txt_masv.Text = dgvSinhVien.Rows[r].Cells[0].Value.ToString().Trim();
                txt_tensv.Text = dgvSinhVien.Rows[r].Cells[1].Value.ToString().Trim();
                cb_gioiTinh.SelectedItem = cb_gioiTinh.SelectedValue = cb_gioiTinh.Text =  dgvSinhVien.Rows[r].Cells[2].Value.ToString().Trim();
                dtp_ngaySinh.Text = dgvSinhVien.Rows[r].Cells[3].Value.ToString().Trim();
                txt_noisinh.Text = dgvSinhVien.Rows[r].Cells[4].Value.ToString().Trim();
                txt_diachi.Text = dgvSinhVien.Rows[r].Cells[5].Value.ToString().Trim();
                cb_maLop.SelectedValue = dgvSinhVien.Rows[r].Cells[6].Value.ToString().Trim();
                Console.WriteLine(" cb " +cb_maLop.SelectedValue);
                Console.WriteLine(dgvSinhVien.Rows[r].Cells[6].Value.ToString().Trim());
                txt_hocbong.Text = dgvSinhVien.Rows[r].Cells[7].Value.ToString().Trim();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvSinhVien.CurrentCell.RowIndex;
                // Lấy MaSV của record hiện hành 
                string strMaSV = dgvSinhVien.Rows[r].Cells[0].Value.ToString();
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
            catch (Exception ex)
            {
                if(ex is SqlException)
                    MessageBox.Show("Không xóa được. Lỗi rồi!");
                else if (ex is NullReferenceException)
                    MessageBox.Show("Vui lòng chọn sinh viên muốn xoá!");
            }
            SetUpNormalState();
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
                SetUpNormalState();
                SetUpDataList();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Sản phẩm. Lỗi rồi!!!");
            }
        }

        private void btnSearchTTSV_Click(object sender, EventArgs e)
        {
            try
            {
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet ds = dbSV.SearchSV(txt_searchSV.Text.Trim());
                dtSinhVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvSinhVien.DataSource = dtSinhVien;
                // Thay đổi độ rộng cột 
                dgvSinhVien.AutoResizeColumns();
                txt_searchSV.ResetText();
                SetUpNormalState();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Sinh Vien. Lỗi rồi!!!");
            }
        }

        private void SetUpNormalState()
        {
            if (username == "GiangVien")
            {
                this.btn_add.Enabled = false;
                this.btn_update.Enabled = false;
                this.btn_delete.Enabled = false;

            } else
            {
                this.btn_add.Enabled = true;
                this.btn_update.Enabled = true;
                this.btn_delete.Enabled = true;
            }
            Them = Sua = false;
            txt_diachi.Enabled = false;
            txt_hocbong.Enabled = false;
            txt_masv.Enabled = false;
            txt_noisinh.Enabled = false;
            txt_tensv.Enabled = false;
            cb_gioiTinh.Enabled = false;
            cb_maLop.Enabled = false;
            dtp_ngaySinh.Enabled = false;
            dtb = false;

            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            this.dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            ResetTextAll();
        }

        private void ResetTextAll()
        {
            txt_masv.ResetText();
            txt_tensv.ResetText();
            txt_noisinh.ResetText();
            txt_diachi.ResetText();
            txt_hocbong.ResetText();
            cb_gioiTinh.ResetText();
            cb_maLop.ResetText();
            dtp_ngaySinh.ResetText();
        }

        private void SetUpAddState()
        {
            txt_diachi.Enabled = true;
            txt_hocbong.Enabled = true;
            txt_masv.Enabled = true;
            txt_noisinh.Enabled = true;
            txt_tensv.Enabled = true;
            cb_gioiTinh.Enabled = true;
            cb_maLop.Enabled = true;
            dtp_ngaySinh.Enabled = true;

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
            DataSet dsLop = db.ExcuteQueryDataSet($"select MaLop,TenLop from Lop", CommandType.Text);
            cb_maLop.DataSource = dsLop.Tables[0];
            cb_maLop.ValueMember = "MaLop";
            cb_maLop.DisplayMember = "TenLop";

            cb_DTBlop.DataSource = dsLop.Tables[0];
            cb_DTBlop.ValueMember = "MaLop";
            cb_DTBlop.DisplayMember = "TenLop";

            DataSet dsKhoa = db.ExcuteQueryDataSet($"select MaKhoa,TenKhoa from Khoa", CommandType.Text);
            cb_DiemKhoa.DataSource = dsKhoa.Tables[0];
            cb_DiemKhoa.ValueMember = "MaKhoa";
            cb_DiemKhoa.DisplayMember = "TenKhoa";
        }

        private void btn_BangDiem_Click(object sender, EventArgs e)
        {
            if(txt_masv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 sinh viên");
            }
            else
            {
                BangDiemForm bd = new BangDiemForm(txt_masv.Text.ToString().Trim(),txt_tensv.Text.ToString().Trim());
                bd.Show();
            }

        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i=0; i<dgvSinhVien.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvSinhVien.Columns[i].HeaderText;
            }
            for(int i=0; i<dgvSinhVien.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSinhVien.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvSinhVien.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btn_DTBlop_Click(object sender, EventArgs e)
        {
            try
            {
                dtb = true;
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet ds = dbSV.DTBtheoLop(cb_DTBlop.SelectedValue.ToString().Trim());
                dtSinhVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvSinhVien.DataSource = dtSinhVien;
                this.dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Thay đổi độ rộng cột 
                dgvSinhVien.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void btn_DTBtheokhoa_Click(object sender, EventArgs e)
        {
            try
            {
                dtb = true;
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet ds = dbSV.DTBtheoKhoa(cb_DiemKhoa.SelectedValue.ToString().Trim());
                dtSinhVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvSinhVien.DataSource = dtSinhVien;
                this.dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Thay đổi độ rộng cột 
                dgvSinhVien.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void btn_SetHocBong_Click(object sender, EventArgs e)
        {
            try
            {
                dtb = false;
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                dbSV.SetHocBongTop5(12675000);
                DataSet ds = dbSV.LoadDSHocBongTop5();
                dtSinhVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvSinhVien.DataSource = dtSinhVien;
                this.dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Thay đổi độ rộng cột 
                dgvSinhVien.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi rồi");
            }
        }

        private void txt_searchSV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtSinhVien = new DataTable();
                dtSinhVien.Clear();
                DataSet ds = dbSV.SearchSV(txt_searchSV.Text.Trim());
                dtSinhVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvSinhVien.DataSource = dtSinhVien;
                // Thay đổi độ rộng cột 
                dgvSinhVien.AutoResizeColumns();
                SetUpNormalState();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Sinh Vien. Lỗi rồi!!!");
            }
        }
    }
}


//Console.WriteLine(txt_masv.Text.Trim());
//Console.WriteLine(txt_tensv.Text.Trim());
//Console.WriteLine(cb_gioiTinh.Text.ToString().Trim());
//Console.WriteLine(dtp_ngaySinh.Value.Date);
//Console.WriteLine(txt_noisinh.Text.Trim());
//Console.WriteLine(txt_diachi.Text.Trim());
//Console.WriteLine(float.Parse(txt_hocbong.Text, CultureInfo.InvariantCulture.NumberFormat));
//Console.WriteLine(cb_maLop.SelectedValue.ToString().Trim());
