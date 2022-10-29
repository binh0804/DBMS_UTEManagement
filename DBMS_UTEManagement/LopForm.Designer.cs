
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.lbTenLop = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbMaKhoaHoc = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaKhoaHoc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaHe = new System.Windows.Forms.Label();
            this.txt_MaHe = new System.Windows.Forms.TextBox();
            this.lbMaNganh = new System.Windows.Forms.Label();
            this.txt_MaNganh = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLop
            // 
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Location = new System.Drawing.Point(12, 42);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Size = new System.Drawing.Size(658, 405);
            this.dgvLop.TabIndex = 13;
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaLop.Location = new System.Drawing.Point(10, 30);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(42, 13);
            this.lbMaLop.TabIndex = 1;
            this.lbMaLop.Text = "Mã lớp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbMaNganh);
            this.groupBox1.Controls.Add(this.lbMaHe);
            this.groupBox1.Controls.Add(this.lbMaLop);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.lbTenLop);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.lbMaKhoaHoc);
            this.groupBox1.Controls.Add(this.txt_MaNganh);
            this.groupBox1.Controls.Add(this.txt_MaHe);
            this.groupBox1.Controls.Add(this.txt_MaLop);
            this.groupBox1.Controls.Add(this.txt_TenLop);
            this.groupBox1.Controls.Add(this.txt_MaKhoaHoc);
            this.groupBox1.Location = new System.Drawing.Point(676, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 156);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết lớp";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(320, 125);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // lbTenLop
            // 
            this.lbTenLop.AutoSize = true;
            this.lbTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenLop.Location = new System.Drawing.Point(10, 60);
            this.lbTenLop.Name = "lbTenLop";
            this.lbTenLop.Size = new System.Drawing.Size(46, 13);
            this.lbTenLop.TabIndex = 1;
            this.lbTenLop.Text = "Tên lớp:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(98, 125);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // lbMaKhoaHoc
            // 
            this.lbMaKhoaHoc.AutoSize = true;
            this.lbMaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMaKhoaHoc.Location = new System.Drawing.Point(10, 90);
            this.lbMaKhoaHoc.Name = "lbMaKhoaHoc";
            this.lbMaKhoaHoc.Size = new System.Drawing.Size(73, 13);
            this.lbMaKhoaHoc.TabIndex = 1;
            this.lbMaKhoaHoc.Text = "Mã khóa học:";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(98, 25);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(118, 20);
            this.txt_MaLop.TabIndex = 2;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(98, 55);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(118, 20);
            this.txt_TenLop.TabIndex = 2;
            // 
            // txt_MaKhoaHoc
            // 
            this.txt_MaKhoaHoc.Location = new System.Drawing.Point(98, 85);
            this.txt_MaKhoaHoc.Name = "txt_MaKhoaHoc";
            this.txt_MaKhoaHoc.Size = new System.Drawing.Size(118, 20);
            this.txt_MaKhoaHoc.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(98, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm lớp";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(204, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa Lớp";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(320, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa Lớp";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Location = new System.Drawing.Point(676, 391);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 56);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(286, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lớp Học";
            // 
            // lbMaHe
            // 
            this.lbMaHe.AutoSize = true;
            this.lbMaHe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaHe.Location = new System.Drawing.Point(250, 30);
            this.lbMaHe.Name = "lbMaHe";
            this.lbMaHe.Size = new System.Drawing.Size(40, 13);
            this.lbMaHe.TabIndex = 1;
            this.lbMaHe.Text = "Mã hệ:";
            // 
            // txt_MaHe
            // 
            this.txt_MaHe.Location = new System.Drawing.Point(320, 25);
            this.txt_MaHe.Name = "txt_MaHe";
            this.txt_MaHe.Size = new System.Drawing.Size(118, 20);
            this.txt_MaHe.TabIndex = 2;
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNganh.Location = new System.Drawing.Point(250, 60);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(58, 13);
            this.lbMaNganh.TabIndex = 1;
            this.lbMaNganh.Text = "Mã ngành:";
            // 
            // txt_MaNganh
            // 
            this.txt_MaNganh.Location = new System.Drawing.Point(320, 55);
            this.txt_MaNganh.Name = "txt_MaNganh";
            this.txt_MaNganh.Size = new System.Drawing.Size(118, 20);
            this.txt_MaNganh.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(676, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(460, 181);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và bộ lọc";
            // 
            // LopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 455);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "LopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lbTenLop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbMaKhoaHoc;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaKhoaHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaNganh;
        private System.Windows.Forms.Label lbMaHe;
        private System.Windows.Forms.TextBox txt_MaNganh;
        private System.Windows.Forms.TextBox txt_MaHe;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}