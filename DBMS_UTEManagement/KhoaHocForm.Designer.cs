
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbTenKhoaHoc = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txt_MaKhoaHoc = new System.Windows.Forms.TextBox();
            this.txt_TenKhoaHoc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKhoaHoc
            // 
            this.dgvKhoaHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoaHoc.Location = new System.Drawing.Point(18, 52);
            this.dgvKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKhoaHoc.Name = "dgvKhoaHoc";
            this.dgvKhoaHoc.RowHeadersWidth = 62;
            this.dgvKhoaHoc.Size = new System.Drawing.Size(987, 638);
            this.dgvKhoaHoc.TabIndex = 13;
            // 
            // lbMaKhoaHoc
            // 
            this.lbMaKhoaHoc.AutoSize = true;
            this.lbMaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaKhoaHoc.Location = new System.Drawing.Point(15, 46);
            this.lbMaKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaKhoaHoc.Name = "lbMaKhoaHoc";
            this.lbMaKhoaHoc.Size = new System.Drawing.Size(109, 20);
            this.lbMaKhoaHoc.TabIndex = 1;
            this.lbMaKhoaHoc.Text = "Mã khóa học:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaKhoaHoc);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.lbTenKhoaHoc);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.txt_MaKhoaHoc);
            this.groupBox1.Controls.Add(this.txt_TenKhoaHoc);
            this.groupBox1.Location = new System.Drawing.Point(1014, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(444, 198);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết khóa học";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(285, 148);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 35);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lbTenKhoaHoc
            // 
            this.lbTenKhoaHoc.AutoSize = true;
            this.lbTenKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenKhoaHoc.Location = new System.Drawing.Point(15, 92);
            this.lbTenKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenKhoaHoc.Name = "lbTenKhoaHoc";
            this.lbTenKhoaHoc.Size = new System.Drawing.Size(114, 20);
            this.lbTenKhoaHoc.TabIndex = 1;
            this.lbTenKhoaHoc.Text = "Tên khóa học:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(147, 148);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txt_MaKhoaHoc
            // 
            this.txt_MaKhoaHoc.Location = new System.Drawing.Point(147, 42);
            this.txt_MaKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MaKhoaHoc.Name = "txt_MaKhoaHoc";
            this.txt_MaKhoaHoc.Size = new System.Drawing.Size(265, 26);
            this.txt_MaKhoaHoc.TabIndex = 2;
            // 
            // txt_TenKhoaHoc
            // 
            this.txt_TenKhoaHoc.Location = new System.Drawing.Point(147, 88);
            this.txt_TenKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenKhoaHoc.Name = "txt_TenKhoaHoc";
            this.txt_TenKhoaHoc.Size = new System.Drawing.Size(265, 26);
            this.txt_TenKhoaHoc.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(147, 29);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm khóa học";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(302, 29);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa khóa học";
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
            this.btnXoa.Text = "Xóa khóa học";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btn_delete_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Location = new System.Drawing.Point(1014, 545);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(444, 146);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1014, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(444, 275);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm và bộ lọc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khóa học";
            // 
            // KhoaHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 709);
            this.Controls.Add(this.dgvKhoaHoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KhoaHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khóa học";
            this.Load += new System.EventHandler(this.KhoaHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoaHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKhoaHoc;
        private System.Windows.Forms.Label lbMaKhoaHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbTenKhoaHoc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txt_MaKhoaHoc;
        private System.Windows.Forms.TextBox txt_TenKhoaHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}