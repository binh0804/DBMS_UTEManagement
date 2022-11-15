
namespace DBMS_UTEManagement
{
    partial class NganhHocForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_makhoa = new System.Windows.Forms.ComboBox();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lbTenNganh = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.txt_MaNganh = new System.Windows.Forms.TextBox();
            this.txt_TenNganh = new System.Windows.Forms.TextBox();
            this.dgvNganhHoc = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganhHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(381, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngành Học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_load);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Location = new System.Drawing.Point(901, 454);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(395, 98);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(8, 23);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(115, 28);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load ngành";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(131, 23);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 28);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm ngành";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(253, 23);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 28);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Sửa ngành";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(8, 59);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 28);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa ngành";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(901, 239);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(395, 208);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm và bộ lọc";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(25, 37);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(157, 22);
            this.txt_search.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(205, 28);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm kiếm thông tin";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_makhoa);
            this.groupBox1.Controls.Add(this.lbMaNganh);
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.lbTenNganh);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.lbMaKhoa);
            this.groupBox1.Controls.Add(this.txt_MaNganh);
            this.groupBox1.Controls.Add(this.txt_TenNganh);
            this.groupBox1.Location = new System.Drawing.Point(901, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(395, 197);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết ngành";
            // 
            // cb_makhoa
            // 
            this.cb_makhoa.FormattingEnabled = true;
            this.cb_makhoa.Location = new System.Drawing.Point(108, 107);
            this.cb_makhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_makhoa.Name = "cb_makhoa";
            this.cb_makhoa.Size = new System.Drawing.Size(255, 24);
            this.cb_makhoa.TabIndex = 4;
            this.cb_makhoa.ValueMember = "MaKhoa";
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNganh.Location = new System.Drawing.Point(13, 37);
            this.lbMaNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(75, 17);
            this.lbMaNganh.TabIndex = 1;
            this.lbMaNganh.Text = "Mã ngành:";
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(249, 154);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(115, 28);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbTenNganh
            // 
            this.lbTenNganh.AutoSize = true;
            this.lbTenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenNganh.Location = new System.Drawing.Point(13, 74);
            this.lbTenNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenNganh.Name = "lbTenNganh";
            this.lbTenNganh.Size = new System.Drawing.Size(81, 17);
            this.lbTenNganh.TabIndex = 1;
            this.lbTenNganh.Text = "Tên ngành:";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(108, 154);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(115, 28);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMaKhoa.Location = new System.Drawing.Point(13, 111);
            this.lbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(66, 17);
            this.lbMaKhoa.TabIndex = 1;
            this.lbMaKhoa.Text = "Mã khoa:";
            // 
            // txt_MaNganh
            // 
            this.txt_MaNganh.Location = new System.Drawing.Point(108, 27);
            this.txt_MaNganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaNganh.Name = "txt_MaNganh";
            this.txt_MaNganh.Size = new System.Drawing.Size(255, 22);
            this.txt_MaNganh.TabIndex = 2;
            // 
            // txt_TenNganh
            // 
            this.txt_TenNganh.Location = new System.Drawing.Point(108, 70);
            this.txt_TenNganh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenNganh.Name = "txt_TenNganh";
            this.txt_TenNganh.Size = new System.Drawing.Size(255, 22);
            this.txt_TenNganh.TabIndex = 2;
            // 
            // dgvNganhHoc
            // 
            this.dgvNganhHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganhHoc.Location = new System.Drawing.Point(16, 34);
            this.dgvNganhHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNganhHoc.Name = "dgvNganhHoc";
            this.dgvNganhHoc.RowHeadersWidth = 62;
            this.dgvNganhHoc.Size = new System.Drawing.Size(877, 518);
            this.dgvNganhHoc.TabIndex = 8;
            this.dgvNganhHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNganhHoc_CellClick);
            // 
            // NganhHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNganhHoc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NganhHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngành học";
            this.Load += new System.EventHandler(this.NganhHocForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganhHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label lbTenNganh;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.TextBox txt_MaNganh;
        private System.Windows.Forms.TextBox txt_TenNganh;
        private System.Windows.Forms.DataGridView dgvNganhHoc;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cb_makhoa;
    }
}