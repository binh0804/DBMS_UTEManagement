
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNganhHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(286, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngành Học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Location = new System.Drawing.Point(676, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 80);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 19);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load ngành";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(98, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm ngành";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(190, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa ngành";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(6, 48);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa ngành";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(676, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 169);
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
            this.groupBox1.Location = new System.Drawing.Point(676, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 160);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết ngành";
            // 
            // lbMaNganh
            // 
            this.lbMaNganh.AutoSize = true;
            this.lbMaNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaNganh.Location = new System.Drawing.Point(10, 30);
            this.lbMaNganh.Name = "lbMaNganh";
            this.lbMaNganh.Size = new System.Drawing.Size(58, 13);
            this.lbMaNganh.TabIndex = 1;
            this.lbMaNganh.Text = "Mã ngành:";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(187, 125);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // lbTenNganh
            // 
            this.lbTenNganh.AutoSize = true;
            this.lbTenNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenNganh.Location = new System.Drawing.Point(10, 60);
            this.lbTenNganh.Name = "lbTenNganh";
            this.lbTenNganh.Size = new System.Drawing.Size(62, 13);
            this.lbTenNganh.TabIndex = 1;
            this.lbTenNganh.Text = "Tên ngành:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(81, 125);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbMaKhoa.Location = new System.Drawing.Point(10, 90);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(52, 13);
            this.lbMaKhoa.TabIndex = 1;
            this.lbMaKhoa.Text = "Mã khoa:";
            // 
            // txt_MaNganh
            // 
            this.txt_MaNganh.Location = new System.Drawing.Point(81, 22);
            this.txt_MaNganh.Name = "txt_MaNganh";
            this.txt_MaNganh.Size = new System.Drawing.Size(192, 20);
            this.txt_MaNganh.TabIndex = 2;
            // 
            // txt_TenNganh
            // 
            this.txt_TenNganh.Location = new System.Drawing.Point(81, 57);
            this.txt_TenNganh.Name = "txt_TenNganh";
            this.txt_TenNganh.Size = new System.Drawing.Size(192, 20);
            this.txt_TenNganh.TabIndex = 2;
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Location = new System.Drawing.Point(81, 90);
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(192, 20);
            this.txt_MaKhoa.TabIndex = 2;
            // 
            // dgvNganhHoc
            // 
            this.dgvNganhHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNganhHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvNganhHoc.Location = new System.Drawing.Point(12, 28);
            this.dgvNganhHoc.Name = "dgvNganhHoc";
            this.dgvNganhHoc.Size = new System.Drawing.Size(658, 421);
            this.dgvNganhHoc.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaNganh";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TenNganh";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MaKhoa";
            this.Column3.Name = "Column3";
            // 
            // NganhHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNganhHoc);
            this.Controls.Add(this.label1);
            this.Name = "NganhHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngành học";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}