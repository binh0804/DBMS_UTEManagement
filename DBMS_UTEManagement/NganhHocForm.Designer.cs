
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbTenNganh = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.txt_MaNganh = new System.Windows.Forms.TextBox();
            this.txt_TenNganh = new System.Windows.Forms.TextBox();
            this.txt_MaKhoa = new System.Windows.Forms.TextBox();
            this.dgvNganhHoc = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganhHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(429, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngành Học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Location = new System.Drawing.Point(1014, 568);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(444, 123);
            this.groupBox3.TabIndex = 11;
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
            this.btnLoad.Text = "Load ngành";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(147, 29);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm ngành";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(285, 29);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa ngành";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(9, 74);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa ngành";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1014, 298);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(444, 260);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm và bộ lọc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaNganh);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.lbTenNganh);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.lbMaKhoa);
            this.groupBox1.Controls.Add(this.txt_MaNganh);
            this.groupBox1.Controls.Add(this.txt_TenNganh);
            this.groupBox1.Controls.Add(this.txt_MaKhoa);
            this.groupBox1.Location = new System.Drawing.Point(1014, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(444, 246);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết ngành";
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNganh.Location = new System.Drawing.Point(15, 46);
            this.lbMaNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(87, 20);
            this.lbMaNganh.TabIndex = 1;
            this.lbMaNganh.Text = "Mã ngành:";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(280, 192);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 35);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbTenNganh
            // 
            this.lbTenNganh.AutoSize = true;
            this.lbTenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenNganh.Location = new System.Drawing.Point(15, 92);
            this.lbTenNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenNganh.Name = "lbTenNganh";
            this.lbTenNganh.Size = new System.Drawing.Size(92, 20);
            this.lbTenNganh.TabIndex = 1;
            this.lbTenNganh.Text = "Tên ngành:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(122, 192);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMaKhoa.Location = new System.Drawing.Point(15, 138);
            this.lbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(77, 20);
            this.lbMaKhoa.TabIndex = 1;
            this.lbMaKhoa.Text = "Mã khoa:";
            // 
            // txt_MaNganh
            // 
            this.txt_MaNganh.Location = new System.Drawing.Point(122, 34);
            this.txt_MaNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaNganh.Name = "txt_MaNganh";
            this.txt_MaNganh.Size = new System.Drawing.Size(286, 26);
            this.txt_MaNganh.TabIndex = 2;
            // 
            // txt_TenNganh
            // 
            this.txt_TenNganh.Location = new System.Drawing.Point(122, 88);
            this.txt_TenNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenNganh.Name = "txt_TenNganh";
            this.txt_TenNganh.Size = new System.Drawing.Size(286, 26);
            this.txt_TenNganh.TabIndex = 2;
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Location = new System.Drawing.Point(122, 138);
            this.txt_MaKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(286, 26);
            this.txt_MaKhoa.TabIndex = 2;
            // 
            // dgvNganhHoc
            // 
            this.dgvNganhHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganhHoc.Location = new System.Drawing.Point(18, 43);
            this.dgvNganhHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNganhHoc.Name = "dgvNganhHoc";
            this.dgvNganhHoc.RowHeadersWidth = 62;
            this.dgvNganhHoc.Size = new System.Drawing.Size(987, 648);
            this.dgvNganhHoc.TabIndex = 8;
            // 
            // NganhHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 709);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNganhHoc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NganhHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngành học";
            this.Load += new System.EventHandler(this.NganhHocForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganhHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbTenNganh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.TextBox txt_MaNganh;
        private System.Windows.Forms.TextBox txt_TenNganh;
        private System.Windows.Forms.TextBox txt_MaKhoa;
        private System.Windows.Forms.DataGridView dgvNganhHoc;
    }
}