﻿using System;
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
    public partial class SinhVienForm : Form
    {
        DataTable dtSinhVien = null;
        BSSinhVien dbSV = new BSSinhVien();
        bool Them = false;
        bool Sua = false;
        string err;
        public SinhVienForm()
        {
            InitializeComponent();
            
            SetUpNormalState();
            cb_gioiTinh.SelectedItem = "Nam";
            dgvSinhVien.ReadOnly = true;

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
                   
                    BSSV.AddSV( txt_masv.Text.Trim(), 
                                txt_tensv.Text.Trim(),
                                cb_gioiTinh.Text.ToString().Trim(), 
                                dtp_ngaySinh.Value.Date,
                                txt_noisinh.Text.Trim(), 
                                txt_diachi.Text.Trim(), 
                                float.Parse(txt_hocbong.Text, CultureInfo.InvariantCulture.NumberFormat), 
                                cb_maLop.SelectedValue.ToString().Trim());
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
                    BSSV.UpdateSV(  txt_masv.Text.Trim(), 
                                    txt_tensv.Text.Trim(), 
                                    cb_gioiTinh.Text.Trim(),
                                    dtp_ngaySinh.Value.Date,
                                    txt_noisinh.Text.Trim(), 
                                    txt_diachi.Text.Trim(), 
                                    float.Parse(txt_hocbong.Text, CultureInfo.InvariantCulture.NumberFormat), 
                                    cb_maLop.SelectedValue.ToString().Trim());

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
            int r = dgvSinhVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            txt_masv.Text = dgvSinhVien.Rows[r].Cells[0].Value.ToString().Trim();
            txt_tensv.Text = dgvSinhVien.Rows[r].Cells[1].Value.ToString().Trim();
            cb_gioiTinh.SelectedItem = cb_gioiTinh.SelectedValue = cb_gioiTinh.Text =  dgvSinhVien.Rows[r].Cells[2].Value.ToString().Trim();
            dtp_ngaySinh.Text = dgvSinhVien.Rows[r].Cells[3].Value.ToString().Trim();
            txt_noisinh.Text = dgvSinhVien.Rows[r].Cells[4].Value.ToString().Trim();
            txt_diachi.Text = dgvSinhVien.Rows[r].Cells[5].Value.ToString().Trim();
            cb_maLop.SelectedValue = dgvSinhVien.Rows[r].Cells[6].Value.ToString();
            txt_hocbong.Text = dgvSinhVien.Rows[r].Cells[7].Value.ToString().Trim();
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
            // TODO: This line of code loads data into the 'quanLySinhVien_UTEDataSet.Lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter.Fill(this.quanLySinhVien_UTEDataSet.Lop);
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
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Sinh Vien. Lỗi rồi!!!");
            }
        }

        private void SetUpNormalState()
        {
            Them = Sua = false;
            txt_diachi.Enabled = false;
            txt_hocbong.Enabled = false;
            txt_masv.Enabled = false;
            txt_noisinh.Enabled = false;
            txt_tensv.Enabled = false;
            cb_gioiTinh.Enabled = false;
            cb_maLop.Enabled = false;
            dtp_ngaySinh.Enabled = false;

            btn_luu.Enabled = false;
            btn_huy.Enabled = false;

            this.btn_add.Enabled = true;
            this.btn_update.Enabled = true;
            this.btn_delete.Enabled = true;

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
