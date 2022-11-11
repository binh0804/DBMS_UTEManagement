
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
            this.components = new System.ComponentModel.Container();
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
            this.dtp_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.cb_gioiTinh = new System.Windows.Forms.ComboBox();
            this.cb_maLop = new System.Windows.Forms.ComboBox();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLySinhVien_UTEDataSet = new DBMS_UTEManagement.QuanLySinhVien_UTEDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_searchSV = new System.Windows.Forms.TextBox();
            this.btnSearchTTSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lopTableAdapter = new DBMS_UTEManagement.QuanLySinhVien_UTEDataSetTableAdapters.LopTableAdapter();
            this.lopBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVien_UTEDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // malop
            // 
            this.malop.AutoSize = true;
            this.malop.Location = new System.Drawing.Point(307, 148);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(59, 17);
            this.malop.TabIndex = 43;
            this.malop.Text = "Mã Lớp:";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(391, 194);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(124, 28);
            this.btn_huy.TabIndex = 42;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(153, 194);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(124, 28);
            this.btn_luu.TabIndex = 41;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_hocbong
            // 
            this.txt_hocbong.Location = new System.Drawing.Point(391, 111);
            this.txt_hocbong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_hocbong.Name = "txt_hocbong";
            this.txt_hocbong.Size = new System.Drawing.Size(147, 22);
            this.txt_hocbong.TabIndex = 40;
            // 
            // HocBong
            // 
            this.HocBong.AutoSize = true;
            this.HocBong.Location = new System.Drawing.Point(307, 111);
            this.HocBong.Name = "HocBong";
            this.HocBong.Size = new System.Drawing.Size(73, 17);
            this.HocBong.TabIndex = 39;
            this.HocBong.Text = "Học bổng:";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Location = new System.Drawing.Point(13, 148);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(55, 17);
            this.DiaChi.TabIndex = 38;
            this.DiaChi.Text = "Địa chỉ:";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSize = true;
            this.NgaySinh.Location = new System.Drawing.Point(13, 111);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(75, 17);
            this.NgaySinh.TabIndex = 37;
            this.NgaySinh.Text = "Ngày sinh:";
            // 
            // NoiSinh
            // 
            this.NoiSinh.AutoSize = true;
            this.NoiSinh.Location = new System.Drawing.Point(307, 74);
            this.NoiSinh.Name = "NoiSinh";
            this.NoiSinh.Size = new System.Drawing.Size(63, 17);
            this.NoiSinh.TabIndex = 36;
            this.NoiSinh.Text = "Nơi sinh:";
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSize = true;
            this.GioiTinh.Location = new System.Drawing.Point(307, 37);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(64, 17);
            this.GioiTinh.TabIndex = 35;
            this.GioiTinh.Text = "Giới tính:";
            // 
            // TenSV
            // 
            this.TenSV.AutoSize = true;
            this.TenSV.Location = new System.Drawing.Point(13, 74);
            this.TenSV.Name = "TenSV";
            this.TenSV.Size = new System.Drawing.Size(97, 17);
            this.TenSV.TabIndex = 34;
            this.TenSV.Text = "Tên sinh viên:";
            // 
            // MaSV
            // 
            this.MaSV.AutoSize = true;
            this.MaSV.Location = new System.Drawing.Point(13, 37);
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(91, 17);
            this.MaSV.TabIndex = 33;
            this.MaSV.Text = "Mã sinh viên:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(119, 144);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(157, 22);
            this.txt_diachi.TabIndex = 32;
            // 
            // txt_noisinh
            // 
            this.txt_noisinh.Location = new System.Drawing.Point(391, 74);
            this.txt_noisinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_noisinh.Name = "txt_noisinh";
            this.txt_noisinh.Size = new System.Drawing.Size(147, 22);
            this.txt_noisinh.TabIndex = 30;
            // 
            // txt_tensv
            // 
            this.txt_tensv.Location = new System.Drawing.Point(119, 69);
            this.txt_tensv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tensv.Name = "txt_tensv";
            this.txt_tensv.Size = new System.Drawing.Size(157, 22);
            this.txt_tensv.TabIndex = 28;
            // 
            // txt_masv
            // 
            this.txt_masv.Location = new System.Drawing.Point(119, 37);
            this.txt_masv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_masv.Name = "txt_masv";
            this.txt_masv.Size = new System.Drawing.Size(157, 22);
            this.txt_masv.TabIndex = 27;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(413, 22);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 28);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "Xóa Sinh Viên";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(284, 22);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(124, 28);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Sửa Sinh Viên";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(156, 22);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(124, 28);
            this.btn_add.TabIndex = 24;
            this.btn_add.Text = "Thêm Sinh Viên";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(27, 22);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(124, 28);
            this.btn_load.TabIndex = 23;
            this.btn_load.Text = "Load Sinh Vien";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(1161, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(548, 236);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sinh viên";
            // 
            // dtp_ngaySinh
            // 
            this.dtp_ngaySinh.CustomFormat = "yyyy/MM/dd";
            this.dtp_ngaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaySinh.Location = new System.Drawing.Point(119, 109);
            this.dtp_ngaySinh.Name = "dtp_ngaySinh";
            this.dtp_ngaySinh.Size = new System.Drawing.Size(157, 22);
            this.dtp_ngaySinh.TabIndex = 46;
            this.dtp_ngaySinh.Value = new System.DateTime(2022, 11, 12, 0, 8, 30, 0);
            // 
            // cb_gioiTinh
            // 
            this.cb_gioiTinh.FormattingEnabled = true;
            this.cb_gioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cb_gioiTinh.Location = new System.Drawing.Point(391, 30);
            this.cb_gioiTinh.Name = "cb_gioiTinh";
            this.cb_gioiTinh.Size = new System.Drawing.Size(142, 24);
            this.cb_gioiTinh.TabIndex = 45;
            // 
            // cb_maLop
            // 
            this.cb_maLop.DataSource = this.lopBindingSource;
            this.cb_maLop.DisplayMember = "MaLop";
            this.cb_maLop.FormattingEnabled = true;
            this.cb_maLop.Location = new System.Drawing.Point(391, 148);
            this.cb_maLop.Name = "cb_maLop";
            this.cb_maLop.Size = new System.Drawing.Size(147, 24);
            this.cb_maLop.TabIndex = 44;
            this.cb_maLop.ValueMember = "MaLop";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.quanLySinhVien_UTEDataSet;
            // 
            // quanLySinhVien_UTEDataSet
            // 
            this.quanLySinhVien_UTEDataSet.DataSetName = "QuanLySinhVien_UTEDataSet";
            this.quanLySinhVien_UTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_load);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Location = new System.Drawing.Point(1157, 484);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(552, 70);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_searchSV);
            this.groupBox3.Controls.Add(this.btnSearchTTSV);
            this.groupBox3.Location = new System.Drawing.Point(1157, 286);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(552, 191);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm và bộ lọc";
            // 
            // txt_searchSV
            // 
            this.txt_searchSV.Location = new System.Drawing.Point(124, 25);
            this.txt_searchSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searchSV.Name = "txt_searchSV";
            this.txt_searchSV.Size = new System.Drawing.Size(157, 22);
            this.txt_searchSV.TabIndex = 45;
            // 
            // btnSearchTTSV
            // 
            this.btnSearchTTSV.Location = new System.Drawing.Point(313, 22);
            this.btnSearchTTSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchTTSV.Name = "btnSearchTTSV";
            this.btnSearchTTSV.Size = new System.Drawing.Size(205, 28);
            this.btnSearchTTSV.TabIndex = 45;
            this.btnSearchTTSV.Text = "Tìm kiếm thông tin";
            this.btnSearchTTSV.UseVisualStyleBackColor = true;
            this.btnSearchTTSV.Click += new System.EventHandler(this.btnSearchTTSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(533, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Sinh viên";
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(16, 42);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.Size = new System.Drawing.Size(1133, 511);
            this.dgvSinhVien.TabIndex = 49;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // lopBindingSource1
            // 
            this.lopBindingSource1.DataMember = "Lop";
            this.lopBindingSource1.DataSource = this.quanLySinhVien_UTEDataSet;
            // 
            // SinhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1729, 567);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SinhVienForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.SinhVienForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVien_UTEDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource1)).EndInit();
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
        private QuanLySinhVien_UTEDataSet quanLySinhVien_UTEDataSet;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QuanLySinhVien_UTEDataSetTableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DateTimePicker dtp_ngaySinh;
        private System.Windows.Forms.ComboBox cb_gioiTinh;
        private System.Windows.Forms.BindingSource lopBindingSource1;
    }
}