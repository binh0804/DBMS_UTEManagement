
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangDiemForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
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
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_ChonNam = new System.Windows.Forms.ComboBox();
            this.rd_NamvaHocKy = new System.Windows.Forms.RadioButton();
            this.rd_Nam = new System.Windows.Forms.RadioButton();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.image_Back = new System.Windows.Forms.PictureBox();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.lb_infoSV = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_XuatFile);
            this.groupBox4.Controls.Add(this.txt_search);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Location = new System.Drawing.Point(827, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 181);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và bộ lọc";
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_XuatFile.Location = new System.Drawing.Point(375, 152);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(75, 23);
            this.btn_XuatFile.TabIndex = 48;
            this.btn_XuatFile.Text = "Xuất file";
            this.btn_XuatFile.UseVisualStyleBackColor = false;
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
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
            this.btn_add.Location = new System.Drawing.Point(13, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(86, 23);
            this.btn_add.TabIndex = 48;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(130, 19);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 23);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(253, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(483, 36);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(138, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Chi tiết điểm từng môn";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btn_load_Click);
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
            this.groupBox2.Controls.Add(this.cb_ChonNam);
            this.groupBox2.Controls.Add(this.rd_NamvaHocKy);
            this.groupBox2.Controls.Add(this.rd_Nam);
            this.groupBox2.Controls.Add(this.btn_Loc);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 73);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả học tập";
            // 
            // cb_ChonNam
            // 
            this.cb_ChonNam.FormattingEnabled = true;
            this.cb_ChonNam.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cb_ChonNam.Location = new System.Drawing.Point(193, 35);
            this.cb_ChonNam.Name = "cb_ChonNam";
            this.cb_ChonNam.Size = new System.Drawing.Size(121, 21);
            this.cb_ChonNam.TabIndex = 6;
            this.cb_ChonNam.Text = "2022";
            // 
            // rd_NamvaHocKy
            // 
            this.rd_NamvaHocKy.AutoSize = true;
            this.rd_NamvaHocKy.Location = new System.Drawing.Point(90, 36);
            this.rd_NamvaHocKy.Name = "rd_NamvaHocKy";
            this.rd_NamvaHocKy.Size = new System.Drawing.Size(97, 17);
            this.rd_NamvaHocKy.TabIndex = 5;
            this.rd_NamvaHocKy.TabStop = true;
            this.rd_NamvaHocKy.Text = "Năm và học kỳ";
            this.rd_NamvaHocKy.UseVisualStyleBackColor = true;
            // 
            // rd_Nam
            // 
            this.rd_Nam.AutoSize = true;
            this.rd_Nam.Location = new System.Drawing.Point(19, 36);
            this.rd_Nam.Name = "rd_Nam";
            this.rd_Nam.Size = new System.Drawing.Size(47, 17);
            this.rd_Nam.TabIndex = 4;
            this.rd_Nam.TabStop = true;
            this.rd_Nam.Text = "Năm";
            this.rd_Nam.UseVisualStyleBackColor = true;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(335, 35);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(128, 23);
            this.btn_Loc.TabIndex = 2;
            this.btn_Loc.Text = "Lọc điểm trung bình";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // image_Back
            // 
            this.image_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("image_Back.BackgroundImage")));
            this.image_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.image_Back.Location = new System.Drawing.Point(1247, 12);
            this.image_Back.Name = "image_Back";
            this.image_Back.Size = new System.Drawing.Size(30, 30);
            this.image_Back.TabIndex = 24;
            this.image_Back.TabStop = false;
            this.image_Back.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_Back_MouseClick);
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.Location = new System.Drawing.Point(28, 12);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(106, 13);
            this.lb_ketqua.TabIndex = 25;
            this.lb_ketqua.Text = "Bảng điểm sinh viên:";
            // 
            // lb_infoSV
            // 
            this.lb_infoSV.AutoSize = true;
            this.lb_infoSV.Location = new System.Drawing.Point(152, 12);
            this.lb_infoSV.Name = "lb_infoSV";
            this.lb_infoSV.Size = new System.Drawing.Size(35, 13);
            this.lb_infoSV.TabIndex = 26;
            this.lb_infoSV.Text = "label1";
            // 
            // BangDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 461);
            this.Controls.Add(this.lb_infoSV);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.image_Back);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            ((System.ComponentModel.ISupportInitialize)(this.image_Back)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_HocKyChiTiet;
        private System.Windows.Forms.ComboBox cb_NamChiTiet;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.ComboBox cb_MaMonHoc;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox image_Back;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.Label lb_infoSV;
        private System.Windows.Forms.Button btn_XuatFile;
        private System.Windows.Forms.RadioButton rd_NamvaHocKy;
        private System.Windows.Forms.RadioButton rd_Nam;
        private System.Windows.Forms.ComboBox cb_ChonNam;
    }
}