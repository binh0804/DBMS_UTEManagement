
namespace DBMS_UTEManagement
{
    partial class LopForm
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
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_makhoahoc = new System.Windows.Forms.ComboBox();
            this.cb_manganh = new System.Windows.Forms.ComboBox();
            this.cb_MaHe = new System.Windows.Forms.ComboBox();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.lbMaHe = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.lbMaKhoaHoc = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLop
            // 
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(16, 52);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 62;
            this.dgvLop.Size = new System.Drawing.Size(877, 498);
            this.dgvLop.TabIndex = 13;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaLop.Location = new System.Drawing.Point(13, 37);
            this.lbMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(54, 17);
            this.lbMaLop.TabIndex = 1;
            this.lbMaLop.Text = "Mã lớp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_makhoahoc);
            this.groupBox1.Controls.Add(this.cb_manganh);
            this.groupBox1.Controls.Add(this.cb_MaHe);
            this.groupBox1.Controls.Add(this.lbMaNganh);
            this.groupBox1.Controls.Add(this.lbMaHe);
            this.groupBox1.Controls.Add(this.lbMaLop);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.lbTenLop);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.lbMaKhoaHoc);
            this.groupBox1.Controls.Add(this.txt_MaLop);
            this.groupBox1.Controls.Add(this.txt_TenLop);
            this.groupBox1.Location = new System.Drawing.Point(901, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(613, 192);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết lớp";
            // 
            // cb_makhoahoc
            // 
            this.cb_makhoahoc.FormattingEnabled = true;
            this.cb_makhoahoc.Location = new System.Drawing.Point(131, 107);
            this.cb_makhoahoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_makhoahoc.Name = "cb_makhoahoc";
            this.cb_makhoahoc.Size = new System.Drawing.Size(156, 24);
            this.cb_makhoahoc.TabIndex = 48;
            // 
            // cb_manganh
            // 
            this.cb_manganh.FormattingEnabled = true;
            this.cb_manganh.Location = new System.Drawing.Point(427, 66);
            this.cb_manganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_manganh.Name = "cb_manganh";
            this.cb_manganh.Size = new System.Drawing.Size(160, 24);
            this.cb_manganh.TabIndex = 48;
            // 
            // cb_MaHe
            // 
            this.cb_MaHe.FormattingEnabled = true;
            this.cb_MaHe.Items.AddRange(new object[] {
            "DT",
            "CLC"});
            this.cb_MaHe.Location = new System.Drawing.Point(427, 33);
            this.cb_MaHe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_MaHe.Name = "cb_MaHe";
            this.cb_MaHe.Size = new System.Drawing.Size(160, 24);
            this.cb_MaHe.TabIndex = 48;
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNganh.Location = new System.Drawing.Point(333, 74);
            this.lbMaNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(75, 17);
            this.lbMaNganh.TabIndex = 1;
            this.lbMaNganh.Text = "Mã ngành:";
            // 
            // lbMaHe
            // 
            this.lbMaHe.AutoSize = true;
            this.lbMaHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaHe.Location = new System.Drawing.Point(333, 37);
            this.lbMaHe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaHe.Name = "lbMaHe";
            this.lbMaHe.Size = new System.Drawing.Size(51, 17);
            this.lbMaHe.TabIndex = 1;
            this.lbMaHe.Text = "Mã hệ:";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(427, 154);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(115, 28);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenLop.Location = new System.Drawing.Point(13, 74);
            this.lbTenLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(60, 17);
            this.lbTenLop.TabIndex = 1;
            this.lbTenLop.Text = "Tên lớp:";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(131, 154);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(115, 28);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbMaKhoaHoc
            // 
            this.lbMaKhoaHoc.AutoSize = true;
            this.lbMaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMaKhoaHoc.Location = new System.Drawing.Point(13, 111);
            this.lbMaKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaKhoaHoc.Name = "lbMaKhoaHoc";
            this.lbMaKhoaHoc.Size = new System.Drawing.Size(93, 17);
            this.lbMaKhoaHoc.TabIndex = 1;
            this.lbMaKhoaHoc.Text = "Mã khóa học:";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(131, 31);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(156, 22);
            this.txt_MaLop.TabIndex = 2;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(131, 68);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(156, 22);
            this.txt_TenLop.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(131, 23);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 28);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm lớp";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(272, 23);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 28);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Sửa Lớp";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(427, 23);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 28);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa Lớp";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(8, 23);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(115, 28);
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
            this.groupBox3.Location = new System.Drawing.Point(901, 481);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(613, 69);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(381, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lớp Học";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_search);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Location = new System.Drawing.Point(901, 251);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(613, 223);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và bộ lọc";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(16, 32);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(157, 22);
            this.txt_search.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(205, 28);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(205, 28);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm kiếm thông tin";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 567);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.LopHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label lbMaKhoaHoc;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.Label lbMaHe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cb_MaHe;
        private System.Windows.Forms.ComboBox cb_manganh;
        private System.Windows.Forms.ComboBox cb_makhoahoc;
    }
}