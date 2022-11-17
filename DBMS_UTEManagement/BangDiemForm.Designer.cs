
namespace DBMS_UTEManagement
{
    partial class BangDiemForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbHocKy = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.lbLanThi = new System.Windows.Forms.Label();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_MaMonHoc = new System.Windows.Forms.ComboBox();
            this.cb_NamChiTiet = new System.Windows.Forms.ComboBox();
            this.cb_HocKyChiTiet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LanThi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_KetQua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_HocKy = new System.Windows.Forms.ComboBox();
            this.cb_NamHoc = new System.Windows.Forms.ComboBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_search);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Location = new System.Drawing.Point(827, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 181);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và bộ lọc";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(111, 29);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(119, 20);
            this.txt_search.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 26);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm kiếm thông tin";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaSV.Location = new System.Drawing.Point(10, 30);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(70, 13);
            this.lbMaSV.TabIndex = 1;
            this.lbMaSV.Text = "Mã sinh viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Location = new System.Drawing.Point(827, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 56);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(130, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 23);
            this.btn_add.TabIndex = 48;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(253, 19);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 23);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(368, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiem.Location = new System.Drawing.Point(250, 60);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(34, 13);
            this.lbDiem.TabIndex = 1;
            this.lbDiem.Text = "Điểm:";
            // 
            // lbHocKy
            // 
            this.lbHocKy.AutoSize = true;
            this.lbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHocKy.Location = new System.Drawing.Point(250, 30);
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Size = new System.Drawing.Size(44, 13);
            this.lbHocKy.TabIndex = 1;
            this.lbHocKy.Text = "Học kỳ:";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(320, 125);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(86, 23);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMaMH.Location = new System.Drawing.Point(10, 60);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(69, 13);
            this.lbMaMH.TabIndex = 1;
            this.lbMaMH.Text = "Mã môn học:";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(98, 125);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(86, 23);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbLanThi
            // 
            this.lbLanThi.AutoSize = true;
            this.lbLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbLanThi.Location = new System.Drawing.Point(10, 90);
            this.lbLanThi.Name = "lbLanThi";
            this.lbLanThi.Size = new System.Drawing.Size(42, 13);
            this.lbLanThi.TabIndex = 1;
            this.lbLanThi.Text = "Lần thi:";
            // 
            // txt_Diem
            // 
            this.txt_Diem.Location = new System.Drawing.Point(320, 55);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.Size = new System.Drawing.Size(118, 20);
            this.txt_Diem.TabIndex = 2;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(98, 25);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(118, 20);
            this.txt_MaSV.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_MaMonHoc);
            this.groupBox1.Controls.Add(this.cb_NamChiTiet);
            this.groupBox1.Controls.Add(this.cb_HocKyChiTiet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbDiem);
            this.groupBox1.Controls.Add(this.lbHocKy);
            this.groupBox1.Controls.Add(this.lbMaSV);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.lbMaMH);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.lbLanThi);
            this.groupBox1.Controls.Add(this.txt_Diem);
            this.groupBox1.Controls.Add(this.txt_MaSV);
            this.groupBox1.Controls.Add(this.txt_LanThi);
            this.groupBox1.Location = new System.Drawing.Point(827, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 156);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // cb_MaMonHoc
            // 
            this.cb_MaMonHoc.FormattingEnabled = true;
            this.cb_MaMonHoc.Location = new System.Drawing.Point(98, 54);
            this.cb_MaMonHoc.Name = "cb_MaMonHoc";
            this.cb_MaMonHoc.Size = new System.Drawing.Size(118, 21);
            this.cb_MaMonHoc.TabIndex = 48;
            // 
            // cb_NamChiTiet
            // 
            this.cb_NamChiTiet.FormattingEnabled = true;
            this.cb_NamChiTiet.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cb_NamChiTiet.Location = new System.Drawing.Point(320, 85);
            this.cb_NamChiTiet.Name = "cb_NamChiTiet";
            this.cb_NamChiTiet.Size = new System.Drawing.Size(118, 21);
            this.cb_NamChiTiet.TabIndex = 7;
            // 
            // cb_HocKyChiTiet
            // 
            this.cb_HocKyChiTiet.FormattingEnabled = true;
            this.cb_HocKyChiTiet.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_HocKyChiTiet.Location = new System.Drawing.Point(320, 27);
            this.cb_HocKyChiTiet.Name = "cb_HocKyChiTiet";
            this.cb_HocKyChiTiet.Size = new System.Drawing.Size(118, 21);
            this.cb_HocKyChiTiet.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(250, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm:";
            // 
            // txt_LanThi
            // 
            this.txt_LanThi.Location = new System.Drawing.Point(98, 85);
            this.txt_LanThi.Name = "txt_LanThi";
            this.txt_LanThi.Size = new System.Drawing.Size(118, 20);
            this.txt_LanThi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(284, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bảng điểm";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(10, 127);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 62;
            this.dgvDiem.Size = new System.Drawing.Size(811, 320);
            this.dgvDiem.TabIndex = 19;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_KetQua);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_HocKy);
            this.groupBox2.Controls.Add(this.cb_NamHoc);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 73);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả học tập";
            // 
            // btn_KetQua
            // 
            this.btn_KetQua.Location = new System.Drawing.Point(433, 30);
            this.btn_KetQua.Name = "btn_KetQua";
            this.btn_KetQua.Size = new System.Drawing.Size(93, 23);
            this.btn_KetQua.TabIndex = 2;
            this.btn_KetQua.Text = "Lọc";
            this.btn_KetQua.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Học kỳ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Năm học:";
            // 
            // cb_HocKy
            // 
            this.cb_HocKy.FormattingEnabled = true;
            this.cb_HocKy.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_HocKy.Location = new System.Drawing.Point(280, 30);
            this.cb_HocKy.Name = "cb_HocKy";
            this.cb_HocKy.Size = new System.Drawing.Size(121, 21);
            this.cb_HocKy.TabIndex = 0;
            this.cb_HocKy.Text = "Tất cả";
            // 
            // cb_NamHoc
            // 
            this.cb_NamHoc.FormattingEnabled = true;
            this.cb_NamHoc.Location = new System.Drawing.Point(75, 30);
            this.cb_NamHoc.Name = "cb_NamHoc";
            this.cb_NamHoc.Size = new System.Drawing.Size(121, 21);
            this.cb_NamHoc.TabIndex = 0;
            this.cb_NamHoc.Text = "Tất cả";
            // 
            // BangDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDiem);
            this.Name = "BangDiemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.BangDiemForm_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label lbHocKy;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label lbLanThi;
        private System.Windows.Forms.TextBox txt_Diem;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_LanThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_HocKy;
        private System.Windows.Forms.ComboBox cb_NamHoc;
        private System.Windows.Forms.ComboBox cb_HocKyChiTiet;
        private System.Windows.Forms.ComboBox cb_NamChiTiet;
        private System.Windows.Forms.Button btn_KetQua;
        private System.Windows.Forms.ComboBox cb_MaMonHoc;
        private System.Windows.Forms.Button btn_add;
    }
}