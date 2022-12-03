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
    public partial class BangDiemForm : Form
    {
        DataTable dtDiem = null;
        BSBangDiem dbDiem = new BSBangDiem();
        bool Them = false;
        bool Sua = false;
        string checkMSSV;
        bool check_dgv = false;
        string username = DBMain.username;
        public BangDiemForm(string MSSV, string TenSV)
        {
            InitializeComponent();
            dgvDiem.ReadOnly = true;
            checkMSSV = MSSV;
            SetUpNormalState();
            txt_MaSV.Text = checkMSSV;
            this.dgvDiem.DefaultCellStyle.Font = new Font("Cambria", 12);

            lb_infoSV.Text = TenSV + " - " + MSSV; 

            if (username == "GiangVien")
            {
                btn_delete.Enabled = false;
            }
        }
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                dtDiem = new DataTable();
                DataSet ds = dbDiem.LoadDDMH(checkMSSV);
                dtDiem = ds.Tables[0];
                dgvDiem.DataSource = dtDiem;
                SetUpNormalState();
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
            txt_MaSV.Enabled = false;
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
                        MessageBox.Show(ex.Message);
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
                        MessageBox.Show(ex.Message);
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
                this.btn_add.Enabled = true;
                this.btn_update.Enabled = true;
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
            check_dgv = false;
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
/*            LoadData();
*/        }
        void LoadData()
        {
            try
            {
                dtDiem = new DataTable();
                dtDiem.Clear();
                DataSet ds = dbDiem.LoadDDMH(checkMSSV);
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
            if (check_dgv == true)
            {

            }
            else
            {
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

        private void image_Back_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgvDiem.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvDiem.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvDiem.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDiem.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvDiem.Rows[i].Cells[j].Value;
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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            check_dgv = true;
            if(rd_Nam.Checked == true)
            {
                try
                {
                    dtDiem = new DataTable();
                    dtDiem.Clear();
                    DataSet ds = dbDiem.LoadDTBTheoNam(checkMSSV);
                    dtDiem = ds.Tables[0];
                    // Đưa dữ liệu lên DataGridView 
                    dgvDiem.DataSource = dtDiem;
                    // Thay đổi độ rộng cột 
                    dgvDiem.AutoResizeColumns();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi rồi!!!");
                }
            }
            else if(rd_NamvaHocKy.Checked == true)
            {
                try
                {
                    dtDiem = new DataTable();
                    dtDiem.Clear();
                    DataSet ds = dbDiem.fLoadDTBTheoNamHocKy(checkMSSV,int.Parse(cb_ChonNam.Text.ToString()));
                    dtDiem = ds.Tables[0];
                    // Đưa dữ liệu lên DataGridView 
                    dgvDiem.DataSource = dtDiem;
                    // Thay đổi độ rộng cột 
                    dgvDiem.AutoResizeColumns();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi rồi!!!");
                }
            }
        }

    }
}
