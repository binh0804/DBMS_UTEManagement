﻿
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
            this.btn_ThemAnh = new System.Windows.Forms.Button();
            this.Anh = new System.Windows.Forms.Label();
            this.AnhSinhVien = new System.Windows.Forms.PictureBox();
            this.btn_BangDiem = new System.Windows.Forms.Button();
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cb_gioiTinh = new System.Windows.Forms.ComboBox();
            this.cb_maLop = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_NamHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_HocKy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TopHocBong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_DiemKhoa = new System.Windows.Forms.ComboBox();
            this.btn_SetHocBong = new System.Windows.Forms.Button();
            this.btn_DTBtheokhoa = new System.Windows.Forms.Button();
            this.btn_DTBlop = new System.Windows.Forms.Button();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.txt_searchSV = new System.Windows.Forms.TextBox();
            this.cb_DTBlop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhSinhVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // malop
            // 
            this.malop.AutoSize = true;
            this.malop.Location = new System.Drawing.Point(208, 169);
            this.malop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(46, 13);
            this.malop.TabIndex = 43;
            this.malop.Text = "Mã Lớp:";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(343, 230);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(64, 25);
            this.btn_huy.TabIndex = 42;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(269, 230);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(70, 25);
            this.btn_luu.TabIndex = 41;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(208, 109);
            this.DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(43, 13);
            this.DiaChi.TabIndex = 38;
            this.DiaChi.Text = "Địa chỉ:";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Location = new System.Drawing.Point(208, 79);
            this.NgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(57, 13);
            this.NgaySinh.TabIndex = 37;
            this.NgaySinh.Text = "Ngày sinh:";
            // 
            // NoiSinh
            // 
            this.NoiSinh.AutoSize = true;
            this.NoiSinh.Location = new System.Drawing.Point(208, 199);
            this.NoiSinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.Size = new System.Drawing.Size(48, 13);
            this.NoiSinh.TabIndex = 36;
            this.NoiSinh.Text = "Nơi sinh:";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Location = new System.Drawing.Point(208, 139);
            this.GioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(50, 13);
            this.GioiTinh.TabIndex = 35;
            this.GioiTinh.Text = "Giới tính:";
            // 
            // TenSV
            // 
            this.TenSV.AutoSize = true;
            this.TenSV.Location = new System.Drawing.Point(207, 49);
            this.TenSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenSV.Name = "TenSV";
            this.TenSV.Size = new System.Drawing.Size(74, 13);
            this.TenSV.TabIndex = 34;
            this.TenSV.Text = "Tên sinh viên:";
            // 
            // MaSV
            // 
            this.MaSV.AutoSize = true;
            this.MaSV.Location = new System.Drawing.Point(207, 19);
            this.MaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(70, 13);
            this.MaSV.TabIndex = 33;
            this.MaSV.Text = "Mã sinh viên:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(287, 104);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(120, 20);
            this.txt_diachi.TabIndex = 32;
            // 
            // txt_noisinh
            // 
            this.txt_noisinh.Location = new System.Drawing.Point(287, 194);
            this.txt_noisinh.Margin = new System.Windows.Forms.Padding(2);
            this.txt_noisinh.Name = "txt_noisinh";
            this.txt_noisinh.Size = new System.Drawing.Size(120, 20);
            this.txt_noisinh.TabIndex = 30;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(287, 44);
            this.txt_tensv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(120, 20);
            this.txt_tensv.TabIndex = 28;
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(287, 14);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(2);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(120, 20);
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
            this.groupBox1.Controls.Add(this.btn_ThemAnh);
            this.groupBox1.Controls.Add(this.Anh);
            this.groupBox1.Controls.Add(this.AnhSinhVien);
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
            this.groupBox1.Controls.Add(this.txt_noisinh);
            this.groupBox1.Controls.Add(this.DiaChi);
            this.groupBox1.Controls.Add(this.GioiTinh);
            this.groupBox1.Controls.Add(this.NgaySinh);
            this.groupBox1.Controls.Add(this.NoiSinh);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Location = new System.Drawing.Point(871, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 265);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sinh viên";
            // 
            // btn_ThemAnh
            // 
            this.btn_ThemAnh.Location = new System.Drawing.Point(59, 199);
            this.btn_ThemAnh.Name = "btn_ThemAnh";
            this.btn_ThemAnh.Size = new System.Drawing.Size(117, 25);
            this.btn_ThemAnh.TabIndex = 50;
            this.btn_ThemAnh.Text = "Thêm ảnh";
            this.btn_ThemAnh.UseVisualStyleBackColor = true;
            this.btn_ThemAnh.Click += new System.EventHandler(this.btn_ThemAnh_Click);
            // 
            // Anh
            // 
            this.Anh.AutoSize = true;
            this.Anh.Location = new System.Drawing.Point(7, 205);
            this.Anh.Name = "Anh";
            this.Anh.Size = new System.Drawing.Size(29, 13);
            this.Anh.TabIndex = 49;
            this.Anh.Text = "Ảnh:";
            // 
            // AnhSinhVien
            // 
            this.AnhSinhVien.Location = new System.Drawing.Point(6, 19);
            this.AnhSinhVien.Name = "AnhSinhVien";
            this.AnhSinhVien.Size = new System.Drawing.Size(170, 170);
            this.AnhSinhVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnhSinhVien.TabIndex = 48;
            this.AnhSinhVien.TabStop = false;
            // 
            // btn_BangDiem
            // 
            this.btn_BangDiem.Location = new System.Drawing.Point(10, 230);
            this.btn_BangDiem.Name = "btn_BangDiem";
            this.btn_BangDiem.Size = new System.Drawing.Size(114, 25);
            this.btn_BangDiem.TabIndex = 47;
            this.btn_BangDiem.Text = "Bảng điểm sinh viên";
            this.btn_BangDiem.UseVisualStyleBackColor = true;
            this.btn_BangDiem.Click += new System.EventHandler(this.btn_BangDiem_Click);
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.CustomFormat = "yyyy/MM/dd";
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaySinh.Location = new System.Drawing.Point(287, 74);
            this.dtp_ngaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(120, 20);
            this.dtp_ngaySinh.TabIndex = 46;
            this.dtp_ngaySinh.Value = new System.DateTime(2022, 11, 12, 0, 8, 30, 0);
            // 
            // cb_gioiTinh
            // 
            this.cb_gioiTinh.FormattingEnabled = true;
            this.cb_gioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cb_gioiTinh.Location = new System.Drawing.Point(287, 134);
            this.cb_gioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cb_gioiTinh.Name = "cb_gioiTinh";
            this.cb_gioiTinh.Size = new System.Drawing.Size(120, 21);
            this.cb_gioiTinh.TabIndex = 45;
            // 
            // cb_maLop
            // 
            this.cb_maLop.DisplayMember = "Lop.MaLop";
            this.cb_maLop.FormattingEnabled = true;
            this.cb_maLop.Location = new System.Drawing.Point(287, 164);
            this.cb_maLop.Margin = new System.Windows.Forms.Padding(2);
            this.cb_maLop.Name = "cb_maLop";
            this.cb_maLop.Size = new System.Drawing.Size(120, 21);
            this.cb_maLop.TabIndex = 44;
            this.cb_maLop.ValueMember = "Lop.MaLop";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_load);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Location = new System.Drawing.Point(868, 506);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 57);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cb_NamHoc);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cb_HocKy);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_TopHocBong);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cb_DiemKhoa);
            this.groupBox3.Controls.Add(this.btn_SetHocBong);
            this.groupBox3.Controls.Add(this.btn_DTBtheokhoa);
            this.groupBox3.Controls.Add(this.btn_DTBlop);
            this.groupBox3.Controls.Add(this.btn_XuatFile);
            this.groupBox3.Controls.Add(this.txt_searchSV);
            this.groupBox3.Controls.Add(this.cb_DTBlop);
            this.groupBox3.Location = new System.Drawing.Point(871, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 196);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm và bộ lọc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Năm:";
            // 
            // cb_NamHoc
            // 
            this.cb_NamHoc.FormattingEnabled = true;
            this.cb_NamHoc.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cb_NamHoc.Location = new System.Drawing.Point(171, 115);
            this.cb_NamHoc.Name = "cb_NamHoc";
            this.cb_NamHoc.Size = new System.Drawing.Size(52, 21);
            this.cb_NamHoc.TabIndex = 57;
            this.cb_NamHoc.Text = "2022";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Học kì:";
            // 
            // cb_HocKy
            // 
            this.cb_HocKy.FormattingEnabled = true;
            this.cb_HocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_HocKy.Location = new System.Drawing.Point(75, 115);
            this.cb_HocKy.Name = "cb_HocKy";
            this.cb_HocKy.Size = new System.Drawing.Size(52, 21);
            this.cb_HocKy.TabIndex = 55;
            this.cb_HocKy.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Top:";
            // 
            // txt_TopHocBong
            // 
            this.txt_TopHocBong.Location = new System.Drawing.Point(75, 145);
            this.txt_TopHocBong.Name = "txt_TopHocBong";
            this.txt_TopHocBong.Size = new System.Drawing.Size(52, 20);
            this.txt_TopHocBong.TabIndex = 53;
            this.txt_TopHocBong.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Khoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tìm kiếm:";
            // 
            // cb_DiemKhoa
            // 
            this.cb_DiemKhoa.FormattingEnabled = true;
            this.cb_DiemKhoa.Location = new System.Drawing.Point(75, 84);
            this.cb_DiemKhoa.Name = "cb_DiemKhoa";
            this.cb_DiemKhoa.Size = new System.Drawing.Size(148, 21);
            this.cb_DiemKhoa.TabIndex = 49;
            // 
            // btn_SetHocBong
            // 
            this.btn_SetHocBong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SetHocBong.Location = new System.Drawing.Point(136, 142);
            this.btn_SetHocBong.Name = "btn_SetHocBong";
            this.btn_SetHocBong.Size = new System.Drawing.Size(141, 25);
            this.btn_SetHocBong.TabIndex = 48;
            this.btn_SetHocBong.Text = "Danh sách học bổng";
            this.btn_SetHocBong.UseVisualStyleBackColor = false;
            this.btn_SetHocBong.Click += new System.EventHandler(this.btn_SetHocBong_Click);
            // 
            // btn_DTBtheokhoa
            // 
            this.btn_DTBtheokhoa.Location = new System.Drawing.Point(239, 82);
            this.btn_DTBtheokhoa.Name = "btn_DTBtheokhoa";
            this.btn_DTBtheokhoa.Size = new System.Drawing.Size(100, 23);
            this.btn_DTBtheokhoa.TabIndex = 47;
            this.btn_DTBtheokhoa.Text = "ĐTB theo khoa";
            this.btn_DTBtheokhoa.UseVisualStyleBackColor = true;
            this.btn_DTBtheokhoa.Click += new System.EventHandler(this.btn_DTBtheokhoa_Click);
            // 
            // btn_DTBlop
            // 
            this.btn_DTBlop.Location = new System.Drawing.Point(239, 52);
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
            this.btn_XuatFile.Location = new System.Drawing.Point(317, 143);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(95, 23);
            this.btn_XuatFile.TabIndex = 46;
            this.btn_XuatFile.Text = "Xuất file";
            this.btn_XuatFile.UseVisualStyleBackColor = false;
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // txt_searchSV
            // 
            this.txt_searchSV.Location = new System.Drawing.Point(75, 21);
            this.txt_searchSV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_searchSV.Name = "txt_searchSV";
            this.txt_searchSV.Size = new System.Drawing.Size(337, 20);
            this.txt_searchSV.TabIndex = 45;
            this.txt_searchSV.TextChanged += new System.EventHandler(this.txt_searchSV_TextChanged);
            // 
            // cb_DTBlop
            // 
            this.cb_DTBlop.DisplayMember = "Lop.MaLop";
            this.cb_DTBlop.FormattingEnabled = true;
            this.cb_DTBlop.Location = new System.Drawing.Point(75, 54);
            this.cb_DTBlop.Margin = new System.Windows.Forms.Padding(2);
            this.cb_DTBlop.Name = "cb_DTBlop";
            this.cb_DTBlop.Size = new System.Drawing.Size(148, 21);
            this.cb_DTBlop.TabIndex = 44;
            this.cb_DTBlop.ValueMember = "Lop.MaLop";
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
            this.dgvSinhVien.Location = new System.Drawing.Point(12, 33);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.Size = new System.Drawing.Size(850, 530);
            this.dgvSinhVien.TabIndex = 49;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1315, 575);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinhVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.SinhVienForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhSinhVien)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ThemAnh;
        private System.Windows.Forms.Label Anh;
        private System.Windows.Forms.PictureBox AnhSinhVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_HocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TopHocBong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_NamHoc;
    }
}