
namespace DBMS_UTEManagement
{
    partial class KhoaHocForm
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
            this.dgvKhoaHoc = new System.Windows.Forms.DataGridView();
            this.lbMaKhoaHoc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lbTenKhoaHoc = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_MaKhoaHoc = new System.Windows.Forms.TextBox();
            this.txt_TenKhoaHoc = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhoaHoc
            // 
            this.dgvKhoaHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoaHoc.Location = new System.Drawing.Point(12, 34);
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            this.dgvKhoaHoc.RowHeadersWidth = 62;
            this.dgvKhoaHoc.Size = new System.Drawing.Size(973, 415);
            this.dgvKhoaHoc.TabIndex = 13;
            this.dgvKhoaHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoaHoc_CellClick);
            // 
            // lbMaKhoaHoc
            // 
            this.lbMaKhoaHoc.AutoSize = true;
            this.lbMaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaKhoaHoc.Location = new System.Drawing.Point(10, 30);
            this.lbMaKhoaHoc.Name = "lbMaKhoaHoc";
            this.lbMaKhoaHoc.Size = new System.Drawing.Size(73, 13);
            this.lbMaKhoaHoc.TabIndex = 1;
            this.lbMaKhoaHoc.Text = "Mã khóa học:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaKhoaHoc);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.lbTenKhoaHoc);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.txt_MaKhoaHoc);
            this.groupBox1.Controls.Add(this.txt_TenKhoaHoc);
            this.groupBox1.Location = new System.Drawing.Point(991, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 129);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết khóa học";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(190, 96);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(86, 23);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbTenKhoaHoc
            // 
            this.lbTenKhoaHoc.AutoSize = true;
            this.lbTenKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenKhoaHoc.Location = new System.Drawing.Point(10, 60);
            this.lbTenKhoaHoc.Name = "lbTenKhoaHoc";
            this.lbTenKhoaHoc.Size = new System.Drawing.Size(77, 13);
            this.lbTenKhoaHoc.TabIndex = 1;
            this.lbTenKhoaHoc.Text = "Tên khóa học:";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(98, 96);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(86, 23);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txt_MaKhoaHoc
            // 
            this.txt_MaKhoaHoc.Location = new System.Drawing.Point(98, 27);
            this.txt_MaKhoaHoc.Name = "txt_MaKhoaHoc";
            this.txt_MaKhoaHoc.Size = new System.Drawing.Size(178, 20);
            this.txt_MaKhoaHoc.TabIndex = 2;
            // 
            // txt_TenKhoaHoc
            // 
            this.txt_TenKhoaHoc.Location = new System.Drawing.Point(98, 57);
            this.txt_TenKhoaHoc.Name = "txt_TenKhoaHoc";
            this.txt_TenKhoaHoc.Size = new System.Drawing.Size(178, 20);
            this.txt_TenKhoaHoc.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(98, 19);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm khóa học";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(201, 19);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 23);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Sửa khóa học";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(6, 48);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa khóa học";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Location = new System.Drawing.Point(991, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 95);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(991, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 179);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm và bộ lọc";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(13, 32);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(119, 20);
            this.txt_search.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(142, 29);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm kiếm thông tin";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(286, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khóa học";
            // 
            // KhoaHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 461);
            this.Controls.Add(this.dgvKhoaHoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "KhoaHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khóa học";
            this.Load += new System.EventHandler(this.KhoaHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhoaHoc;
        private System.Windows.Forms.Label lbMaKhoaHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label lbTenKhoaHoc;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_MaKhoaHoc;
        private System.Windows.Forms.TextBox txt_TenKhoaHoc;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnSearch;
    }
}