
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Location = new System.Drawing.Point(12, 34);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.Size = new System.Drawing.Size(658, 415);
            this.dgvMonHoc.TabIndex = 0;
            // 
            // lbMaMH
            // 
            this.lbMaMH.AutoSize = true;
            this.lbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaMH.Location = new System.Drawing.Point(10, 30);
            this.lbMaMH.Name = "lbMaMH";
            this.lbMaMH.Size = new System.Drawing.Size(69, 13);
            this.lbMaMH.TabIndex = 1;
            this.lbMaMH.Text = "Mã môn học:";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(81, 22);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(192, 20);
            this.txtMaMH.TabIndex = 2;
            // 
            // lbTenMH
            // 
            this.lbTenMH.AutoSize = true;
            this.lbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbTenMH.Location = new System.Drawing.Point(10, 60);
            this.lbTenMH.Name = "lbTenMH";
            this.lbTenMH.Size = new System.Drawing.Size(73, 13);
            this.lbTenMH.TabIndex = 1;
            this.lbTenMH.Text = "Tên môn học:";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(81, 57);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(192, 20);
            this.txtTenMH.TabIndex = 2;
            // 
            // lbLyThuyet
            // 
            this.lbLyThuyet.AutoSize = true;
            this.lbLyThuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbLyThuyet.Location = new System.Drawing.Point(10, 90);
            this.lbLyThuyet.Name = "lbLyThuyet";
            this.lbLyThuyet.Size = new System.Drawing.Size(53, 13);
            this.lbLyThuyet.TabIndex = 1;
            this.lbLyThuyet.Text = "Lý thuyết:";
            // 
            // lbThucHanh
            // 
            this.lbThucHanh.AutoSize = true;
            this.lbThucHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbThucHanh.Location = new System.Drawing.Point(10, 120);
            this.lbThucHanh.Name = "lbThucHanh";
            this.lbThucHanh.Size = new System.Drawing.Size(62, 13);
            this.lbThucHanh.TabIndex = 1;
            this.lbThucHanh.Text = "Thực hành:";
            // 
            // txtLyThuyet
            // 
            this.txtLyThuyet.Location = new System.Drawing.Point(81, 90);
            this.txtLyThuyet.Name = "txtLyThuyet";
            this.txtLyThuyet.Size = new System.Drawing.Size(192, 20);
            this.txtLyThuyet.TabIndex = 2;
            // 
            // txtThucHanh
            // 
            this.txtThucHanh.Location = new System.Drawing.Point(81, 120);
            this.txtThucHanh.Name = "txtThucHanh";
            this.txtThucHanh.Size = new System.Drawing.Size(192, 20);
            this.txtThucHanh.TabIndex = 2;
            // 
            // btnLoadMH
            // 
            this.btnLoadMH.Location = new System.Drawing.Point(6, 19);
            this.btnLoadMH.Name = "btnLoadMH";
            this.btnLoadMH.Size = new System.Drawing.Size(86, 23);
            this.btnLoadMH.TabIndex = 3;
            this.btnLoadMH.Text = "Load môn Học";
            this.btnLoadMH.UseVisualStyleBackColor = true;
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(98, 19);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(86, 23);
            this.btnThemMH.TabIndex = 3;
            this.btnThemMH.Text = "Thêm môn học";
            this.btnThemMH.UseVisualStyleBackColor = true;
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Location = new System.Drawing.Point(190, 19);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(86, 23);
            this.btnSuaMH.TabIndex = 3;
            this.btnSuaMH.Text = "Sửa môn học";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Location = new System.Drawing.Point(6, 48);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(86, 23);
            this.btnXoaMH.TabIndex = 3;
            this.btnXoaMH.Text = "Xóa môn học";
            this.btnXoaMH.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(676, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 186);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết môn học";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(187, 155);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(81, 155);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(288, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Môn học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadMH);
            this.groupBox3.Controls.Add(this.btnThemMH);
            this.groupBox3.Controls.Add(this.btnSuaMH);
            this.groupBox3.Controls.Add(this.btnXoaMH);
            this.groupBox3.Location = new System.Drawing.Point(676, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 81);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(676, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 136);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm và bộ lọc";
            // 
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMonHoc);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "MonHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.MonHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
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
    }
}