
namespace DBMS_UTEManagement
{
    partial class SinhVienForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.malop = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_hocbong = new System.Windows.Forms.TextBox();
            this.HocBong = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.Label();
            this.NoiSinh = new System.Windows.Forms.Label();
            this.GioiTinh = new System.Windows.Forms.Label();
            this.TenSV = new System.Windows.Forms.Label();
            this.MaSV = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_noisinh = new System.Windows.Forms.TextBox();
            this.txt_tensv = new System.Windows.Forms.TextBox();
            this.txt_masv = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_BangDiem = new System.Windows.Forms.Button();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cb_gioiTinh = new System.Windows.Forms.ComboBox();
            this.cb_maLop = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_SetHocBong = new System.Windows.Forms.Button();
            this.btn_DTBlop = new System.Windows.Forms.Button();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.txt_searchSV = new System.Windows.Forms.TextBox();
            this.cb_DTBlop = new System.Windows.Forms.ComboBox();
            this.btnSearchTTSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.cb_DiemKhoa = new System.Windows.Forms.ComboBox();
            this.btn_DTBtheokhoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // malop
            // 
            this.malop.AutoSize = true;
            this.malop.Location = new System.Drawing.Point(230, 120);
            this.malop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(46, 13);
            this.malop.TabIndex = 43;
            this.malop.Text = "Mã Lớp:";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(330, 158);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(70, 25);
            this.btn_huy.TabIndex = 42;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(256, 158);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(70, 25);
            this.btn_luu.TabIndex = 41;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_hocbong
            // 
            this.txt_hocbong.Location = new System.Drawing.Point(293, 90);
            this.txt_hocbong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_hocbong.Name = "txt_hocbong";
            this.txt_hocbong.Size = new System.Drawing.Size(111, 20);
            this.txt_hocbong.TabIndex = 40;
            // 
            // HocBong
            // 
            this.HocBong.AutoSize = true;
            this.HocBong.Location = new System.Drawing.Point(230, 90);
            this.HocBong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HocBong.Name = "HocBong";
            this.HocBong.Size = new System.Drawing.Size(57, 13);
            this.HocBong.TabIndex = 39;
            this.HocBong.Text = "Học bổng:";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(10, 120);
            this.DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(43, 13);
            this.DiaChi.TabIndex = 38;
            this.DiaChi.Text = "Địa chỉ:";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Location = new System.Drawing.Point(10, 90);
            this.NgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(57, 13);
            this.NgaySinh.TabIndex = 37;
            this.NgaySinh.Text = "Ngày sinh:";
            // 
            // NoiSinh
            // 
            this.NoiSinh.AutoSize = true;
            this.NoiSinh.Location = new System.Drawing.Point(230, 60);
            this.NoiSinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.Size = new System.Drawing.Size(48, 13);
            this.NoiSinh.TabIndex = 36;
            this.NoiSinh.Text = "Nơi sinh:";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Location = new System.Drawing.Point(230, 30);
            this.GioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(50, 13);
            this.GioiTinh.TabIndex = 35;
            this.GioiTinh.Text = "Giới tính:";
            // 
            // TenSV
            // 
            this.TenSV.AutoSize = true;
            this.TenSV.Location = new System.Drawing.Point(10, 60);
            this.TenSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenSV.Name = "TenSV";
            this.TenSV.Size = new System.Drawing.Size(74, 13);
            this.TenSV.TabIndex = 34;
            this.TenSV.Text = "Tên sinh viên:";
            // 
            // MaSV
            // 
            this.MaSV.AutoSize = true;
            this.MaSV.Location = new System.Drawing.Point(10, 30);
            this.MaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(70, 13);
            this.MaSV.TabIndex = 33;
            this.MaSV.Text = "Mã sinh viên:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(89, 117);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(119, 20);
            this.txt_diachi.TabIndex = 32;
            // 
            // txt_noisinh
            // 
            this.txt_noisinh.Location = new System.Drawing.Point(293, 60);
            this.txt_noisinh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_noisinh.Name = "txt_noisinh";
            this.txt_noisinh.Size = new System.Drawing.Size(111, 20);
            this.txt_noisinh.TabIndex = 30;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(89, 56);
            this.txt_tensv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(119, 20);
            this.txt_tensv.TabIndex = 28;
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(89, 30);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(119, 20);
            this.txt_masv.TabIndex = 27;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(310, 18);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 23);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Xóa Sinh Viên";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(213, 18);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(93, 23);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Sửa Sinh Viên";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(117, 18);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(93, 23);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Thêm Sinh Viên";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(20, 18);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(93, 23);
            this.btn_load.TabIndex = 23;
            this.btn_load.Text = "Load Sinh Vien";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_BangDiem);
            this.groupBox1.Controls.Add(this.dtp_ngaySinh);
            this.groupBox1.Controls.Add(this.cb_gioiTinh);
            this.groupBox1.Controls.Add(this.cb_maLop);
            this.groupBox1.Controls.Add(this.txt_masv);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.MaSV);
            this.groupBox1.Controls.Add(this.malop);
            this.groupBox1.Controls.Add(this.txt_tensv);
            this.groupBox1.Controls.Add(this.TenSV);
            this.groupBox1.Controls.Add(this.txt_hocbong);
            this.groupBox1.Controls.Add(this.HocBong);
            this.groupBox1.Controls.Add(this.txt_noisinh);
            this.groupBox1.Controls.Add(this.DiaChi);
            this.groupBox1.Controls.Add(this.GioiTinh);
            this.groupBox1.Controls.Add(this.NgaySinh);
            this.groupBox1.Controls.Add(this.NoiSinh);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Location = new System.Drawing.Point(871, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 192);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sinh viên";
            // 
            // btn_BangDiem
            // 
            this.btn_BangDiem.Location = new System.Drawing.Point(138, 158);
            this.btn_BangDiem.Name = "btn_BangDiem";
            this.btn_BangDiem.Size = new System.Drawing.Size(70, 25);
            this.btn_BangDiem.TabIndex = 47;
            this.btn_BangDiem.Text = "Bảng điểm";
            this.btn_BangDiem.UseVisualStyleBackColor = true;
            this.btn_BangDiem.Click += new System.EventHandler(this.btn_BangDiem_Click);
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.CustomFormat = "yyyy/MM/dd";
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaySinh.Location = new System.Drawing.Point(89, 89);
            this.dtp_ngaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(119, 20);
            this.dtp_ngaySinh.TabIndex = 46;
            this.dtp_ngaySinh.Value = new System.DateTime(2022, 11, 12, 0, 8, 30, 0);
            // 
            // cb_gioiTinh
            // 
            this.cb_gioiTinh.FormattingEnabled = true;
            this.cb_gioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cb_gioiTinh.Location = new System.Drawing.Point(293, 24);
            this.cb_gioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gioiTinh.Name = "cb_gioiTinh";
            this.cb_gioiTinh.Size = new System.Drawing.Size(111, 21);
            this.cb_gioiTinh.TabIndex = 45;
            // 
            // cb_maLop
            // 
            this.cb_maLop.DisplayMember = "Lop.MaLop";
            this.cb_maLop.FormattingEnabled = true;
            this.cb_maLop.Location = new System.Drawing.Point(293, 120);
            this.cb_maLop.Margin = new System.Windows.Forms.Padding(2);
            this.cb_maLop.Name = "cb_maLop";
            this.cb_maLop.Size = new System.Drawing.Size(111, 21);
            this.cb_maLop.TabIndex = 44;
            this.cb_maLop.ValueMember = "Lop.MaLop";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_load);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Location = new System.Drawing.Point(868, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 57);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_DiemKhoa);
            this.groupBox3.Controls.Add(this.btn_SetHocBong);
            this.groupBox3.Controls.Add(this.btn_DTBtheokhoa);
            this.groupBox3.Controls.Add(this.btn_DTBlop);
            this.groupBox3.Controls.Add(this.btn_XuatFile);
            this.groupBox3.Controls.Add(this.txt_searchSV);
            this.groupBox3.Controls.Add(this.cb_DTBlop);
            this.groupBox3.Controls.Add(this.btnSearchTTSV);
            this.groupBox3.Location = new System.Drawing.Point(868, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 155);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm và bộ lọc";
            // 
            // btn_SetHocBong
            // 
            this.btn_SetHocBong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SetHocBong.Location = new System.Drawing.Point(213, 126);
            this.btn_SetHocBong.Name = "btn_SetHocBong";
            this.btn_SetHocBong.Size = new System.Drawing.Size(95, 23);
            this.btn_SetHocBong.TabIndex = 48;
            this.btn_SetHocBong.Text = "Set học bổng";
            this.btn_SetHocBong.UseVisualStyleBackColor = false;
            this.btn_SetHocBong.Click += new System.EventHandler(this.btn_SetHocBong_Click);
            // 
            // btn_DTBlop
            // 
            this.btn_DTBlop.Location = new System.Drawing.Point(132, 46);
            this.btn_DTBlop.Name = "btn_DTBlop";
            this.btn_DTBlop.Size = new System.Drawing.Size(100, 23);
            this.btn_DTBlop.TabIndex = 47;
            this.btn_DTBlop.Text = "ĐTB theo lớp";
            this.btn_DTBlop.UseVisualStyleBackColor = true;
            this.btn_DTBlop.Click += new System.EventHandler(this.btn_DTBlop_Click);
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_XuatFile.Location = new System.Drawing.Point(314, 126);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(75, 23);
            this.btn_XuatFile.TabIndex = 46;
            this.btn_XuatFile.Text = "Xuất file";
            this.btn_XuatFile.UseVisualStyleBackColor = false;
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // txt_searchSV
            // 
            this.txt_searchSV.Location = new System.Drawing.Point(16, 21);
            this.txt_searchSV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_searchSV.Name = "txt_searchSV";
            this.txt_searchSV.Size = new System.Drawing.Size(215, 20);
            this.txt_searchSV.TabIndex = 45;
            // 
            // cb_DTBlop
            // 
            this.cb_DTBlop.DisplayMember = "Lop.MaLop";
            this.cb_DTBlop.FormattingEnabled = true;
            this.cb_DTBlop.Location = new System.Drawing.Point(16, 48);
            this.cb_DTBlop.Margin = new System.Windows.Forms.Padding(2);
            this.cb_DTBlop.Name = "cb_DTBlop";
            this.cb_DTBlop.Size = new System.Drawing.Size(111, 21);
            this.cb_DTBlop.TabIndex = 44;
            this.cb_DTBlop.ValueMember = "Lop.MaLop";
            // 
            // btnSearchTTSV
            // 
            this.btnSearchTTSV.Location = new System.Drawing.Point(237, 21);
            this.btnSearchTTSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTTSV.Name = "btnSearchTTSV";
            this.btnSearchTTSV.Size = new System.Drawing.Size(154, 23);
            this.btnSearchTTSV.TabIndex = 45;
            this.btnSearchTTSV.Text = "Tìm kiếm thông tin";
            this.btnSearchTTSV.UseVisualStyleBackColor = true;
            this.btnSearchTTSV.Click += new System.EventHandler(this.btnSearchTTSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(400, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sinh viên";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 34);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.Size = new System.Drawing.Size(850, 415);
            this.dgvSinhVien.TabIndex = 49;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // cb_DiemKhoa
            // 
            this.cb_DiemKhoa.FormattingEnabled = true;
            this.cb_DiemKhoa.Location = new System.Drawing.Point(16, 75);
            this.cb_DiemKhoa.Name = "cb_DiemKhoa";
            this.cb_DiemKhoa.Size = new System.Drawing.Size(111, 21);
            this.cb_DiemKhoa.TabIndex = 49;
            // 
            // btn_DTBtheokhoa
            // 
            this.btn_DTBtheokhoa.Location = new System.Drawing.Point(133, 73);
            this.btn_DTBtheokhoa.Name = "btn_DTBtheokhoa";
            this.btn_DTBtheokhoa.Size = new System.Drawing.Size(100, 23);
            this.btn_DTBtheokhoa.TabIndex = 47;
            this.btn_DTBtheokhoa.Text = "ĐTB theo khoa";
            this.btn_DTBtheokhoa.UseVisualStyleBackColor = true;
            this.btn_DTBtheokhoa.Click += new System.EventHandler(this.btn_DTBtheokhoa_Click);
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1299, 461);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SinhVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.SinhVienForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label malop;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_hocbong;
        private System.Windows.Forms.Label HocBong;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label NgaySinh;
        private System.Windows.Forms.Label NoiSinh;
        private System.Windows.Forms.Label GioiTinh;
        private System.Windows.Forms.Label TenSV;
        private System.Windows.Forms.Label MaSV;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_noisinh;
        private System.Windows.Forms.TextBox txt_tensv;
        private System.Windows.Forms.TextBox txt_masv;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnSearchTTSV;
        private System.Windows.Forms.TextBox txt_searchSV;
        private System.Windows.Forms.ComboBox cb_maLop;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.ComboBox cb_gioiTinh;
        private System.Windows.Forms.Button btn_BangDiem;
        private System.Windows.Forms.Button btn_XuatFile;
        private System.Windows.Forms.Button btn_DTBlop;
        private System.Windows.Forms.ComboBox cb_DTBlop;
        private System.Windows.Forms.Button btn_SetHocBong;
        private System.Windows.Forms.ComboBox cb_DiemKhoa;
        private System.Windows.Forms.Button btn_DTBtheokhoa;
    }
}