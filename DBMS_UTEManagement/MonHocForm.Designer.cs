﻿
namespace DBMS_UTEManagement
{
    partial class MonHocForm
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
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.lbMaMH = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.lbTenMH = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.lbLyThuyet = new System.Windows.Forms.Label();
            this.lbThucHanh = new System.Windows.Forms.Label();
            this.txtLyThuyet = new System.Windows.Forms.TextBox();
            this.txtThucHanh = new System.Windows.Forms.TextBox();
            this.btnLoadMH = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(18, 52);
            this.dgvMonHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 62;
            this.dgvMonHoc.Size = new System.Drawing.Size(987, 638);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellClick);
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaMH.Location = new System.Drawing.Point(15, 46);
            this.lbMaMH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(106, 20);
            this.lbMaMH.TabIndex = 1;
            this.lbMaMH.Text = "Mã môn học:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(122, 34);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(286, 26);
            this.txtMaMH.TabIndex = 2;
            // 
            // lbTenMH
            // 
            this.lbTenMH.AutoSize = true;
            this.lbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenMH.Location = new System.Drawing.Point(15, 92);
            this.lbTenMH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenMH.Name = "lbTenMH";
            this.lbTenMH.Size = new System.Drawing.Size(111, 20);
            this.lbTenMH.TabIndex = 1;
            this.lbTenMH.Text = "Tên môn học:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(122, 88);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(286, 26);
            this.txtTenMH.TabIndex = 2;
            // 
            // lbLyThuyet
            // 
            this.lbLyThuyet.AutoSize = true;
            this.lbLyThuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbLyThuyet.Location = new System.Drawing.Point(15, 138);
            this.lbLyThuyet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLyThuyet.Name = "lbLyThuyet";
            this.lbLyThuyet.Size = new System.Drawing.Size(82, 20);
            this.lbLyThuyet.TabIndex = 1;
            this.lbLyThuyet.Text = "Lý thuyết:";
            // 
            // lbThucHanh
            // 
            this.lbThucHanh.AutoSize = true;
            this.lbThucHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbThucHanh.Location = new System.Drawing.Point(15, 185);
            this.lbThucHanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThucHanh.Name = "lbThucHanh";
            this.lbThucHanh.Size = new System.Drawing.Size(92, 20);
            this.lbThucHanh.TabIndex = 1;
            this.lbThucHanh.Text = "Thực hành:";
            // 
            // txtLyThuyet
            // 
            this.txtLyThuyet.Location = new System.Drawing.Point(122, 138);
            this.txtLyThuyet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLyThuyet.Name = "txtLyThuyet";
            this.txtLyThuyet.Size = new System.Drawing.Size(286, 26);
            this.txtLyThuyet.TabIndex = 2;
            // 
            // txtThucHanh
            // 
            this.txtThucHanh.Location = new System.Drawing.Point(122, 185);
            this.txtThucHanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThucHanh.Name = "txtThucHanh";
            this.txtThucHanh.Size = new System.Drawing.Size(286, 26);
            this.txtThucHanh.TabIndex = 2;
            // 
            // btnLoadMH
            // 
            this.btnLoadMH.Location = new System.Drawing.Point(9, 29);
            this.btnLoadMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadMH.Name = "btnLoadMH";
            this.btnLoadMH.Size = new System.Drawing.Size(129, 35);
            this.btnLoadMH.TabIndex = 3;
            this.btnLoadMH.Text = "Load môn Học";
            this.btnLoadMH.UseVisualStyleBackColor = true;
            this.btnLoadMH.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(147, 29);
            this.btnThemMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(129, 35);
            this.btnThemMH.TabIndex = 3;
            this.btnThemMH.Text = "Thêm môn học";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Location = new System.Drawing.Point(285, 29);
            this.btnSuaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(129, 35);
            this.btnSuaMH.TabIndex = 3;
            this.btnSuaMH.Text = "Sửa môn học";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Location = new System.Drawing.Point(9, 74);
            this.btnXoaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(129, 35);
            this.btnXoaMH.TabIndex = 3;
            this.btnXoaMH.Text = "Xóa môn học";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaMH);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.lbTenMH);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.lbLyThuyet);
            this.groupBox1.Controls.Add(this.lbThucHanh);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.txtThucHanh);
            this.groupBox1.Controls.Add(this.txtLyThuyet);
            this.groupBox1.Location = new System.Drawing.Point(1014, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(444, 286);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết môn học";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(280, 238);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 35);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(122, 238);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Môn học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadMH);
            this.groupBox3.Controls.Add(this.btnThemMH);
            this.groupBox3.Controls.Add(this.btnSuaMH);
            this.groupBox3.Controls.Add(this.btnXoaMH);
            this.groupBox3.Location = new System.Drawing.Point(1014, 566);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(444, 125);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_search);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Location = new System.Drawing.Point(1014, 348);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(444, 209);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và bộ lọc";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(0, 31);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(176, 26);
            this.txt_search.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(213, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(231, 35);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm kiếm thông tin";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 709);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMonHoc);
            this.Location = new System.Drawing.Point(10, 10);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.MonHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.Label lbMaMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label lbTenMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Label lbLyThuyet;
        private System.Windows.Forms.Label lbThucHanh;
        private System.Windows.Forms.TextBox txtLyThuyet;
        private System.Windows.Forms.TextBox txtThucHanh;
        private System.Windows.Forms.Button btnLoadMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnSearch;
    }
}