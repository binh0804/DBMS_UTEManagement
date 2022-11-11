
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbDiem = new System.Windows.Forms.Label();
            this.lbHocKy = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbLanThi = new System.Windows.Forms.Label();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.txt_HocKy = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.txt_MaMH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_LanThi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_search);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Location = new System.Drawing.Point(1011, 314);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(690, 278);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và bộ lọc";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(166, 44);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(176, 26);
            this.txt_search.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(379, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(231, 35);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm kiếm thông tin";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaSV.Location = new System.Drawing.Point(15, 46);
            this.lbMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(108, 20);
            this.lbMaSV.TabIndex = 1;
            this.lbMaSV.Text = "Mã sinh viên:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Location = new System.Drawing.Point(1011, 602);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(690, 86);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(9, 29);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(129, 35);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(195, 29);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(380, 29);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(552, 29);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiem.Location = new System.Drawing.Point(375, 92);
            this.lbDiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(53, 20);
            this.lbDiem.TabIndex = 1;
            this.lbDiem.Text = "Điểm:";
            // 
            // lbHocKy
            // 
            this.lbHocKy.AutoSize = true;
            this.lbHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHocKy.Location = new System.Drawing.Point(375, 46);
            this.lbHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHocKy.Name = "lbHocKy";
            this.lbHocKy.Size = new System.Drawing.Size(66, 20);
            this.lbHocKy.TabIndex = 1;
            this.lbHocKy.Text = "Học kỳ:";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(480, 192);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 35);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMaMH.Location = new System.Drawing.Point(15, 92);
            this.lbMaMH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(106, 20);
            this.lbMaMH.TabIndex = 1;
            this.lbMaMH.Text = "Mã môn học:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(147, 192);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbLanThi
            // 
            this.lbLanThi.AutoSize = true;
            this.lbLanThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbLanThi.Location = new System.Drawing.Point(15, 138);
            this.lbLanThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLanThi.Name = "lbLanThi";
            this.lbLanThi.Size = new System.Drawing.Size(65, 20);
            this.lbLanThi.TabIndex = 1;
            this.lbLanThi.Text = "Lần thi:";
            // 
            // txt_Diem
            // 
            this.txt_Diem.Location = new System.Drawing.Point(480, 85);
            this.txt_Diem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.Size = new System.Drawing.Size(175, 26);
            this.txt_Diem.TabIndex = 2;
            // 
            // txt_HocKy
            // 
            this.txt_HocKy.Location = new System.Drawing.Point(480, 38);
            this.txt_HocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_HocKy.Name = "txt_HocKy";
            this.txt_HocKy.Size = new System.Drawing.Size(175, 26);
            this.txt_HocKy.TabIndex = 2;
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(147, 38);
            this.txt_MaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(175, 26);
            this.txt_MaSV.TabIndex = 2;
            // 
            // txt_MaMH
            // 
            this.txt_MaMH.Location = new System.Drawing.Point(147, 85);
            this.txt_MaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaMH.Name = "txt_MaMH";
            this.txt_MaMH.Size = new System.Drawing.Size(175, 26);
            this.txt_MaMH.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Nam);
            this.groupBox1.Controls.Add(this.lbDiem);
            this.groupBox1.Controls.Add(this.lbHocKy);
            this.groupBox1.Controls.Add(this.lbMaSV);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.lbMaMH);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.lbLanThi);
            this.groupBox1.Controls.Add(this.txt_Diem);
            this.groupBox1.Controls.Add(this.txt_HocKy);
            this.groupBox1.Controls.Add(this.txt_MaSV);
            this.groupBox1.Controls.Add(this.txt_MaMH);
            this.groupBox1.Controls.Add(this.txt_LanThi);
            this.groupBox1.Location = new System.Drawing.Point(1011, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(690, 240);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // txt_LanThi
            // 
            this.txt_LanThi.Location = new System.Drawing.Point(147, 131);
            this.txt_LanThi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_LanThi.Name = "txt_LanThi";
            this.txt_LanThi.Size = new System.Drawing.Size(175, 26);
            this.txt_LanThi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(426, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bảng điểm";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(15, 65);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 62;
            this.dgvDiem.Size = new System.Drawing.Size(987, 623);
            this.dgvDiem.TabIndex = 19;
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(480, 131);
            this.txt_Nam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.Size = new System.Drawing.Size(175, 26);
            this.txt_Nam.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(375, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm:";
            // 
            // BangDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 709);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDiem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BangDiemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điểm";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label lbHocKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbLanThi;
        private System.Windows.Forms.TextBox txt_Diem;
        private System.Windows.Forms.TextBox txt_HocKy;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.TextBox txt_MaMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_LanThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nam;
    }
}