
namespace DBMS_UTEManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ic_username = new System.Windows.Forms.PictureBox();
            this.icon_password = new System.Windows.Forms.PictureBox();
            this.pn_exit = new System.Windows.Forms.Panel();
            this.pn_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ic_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 494);
            this.panel1.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_password.Location = new System.Drawing.Point(361, 208);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(200, 26);
            this.txt_password.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_username.Location = new System.Drawing.Point(361, 137);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(200, 26);
            this.txt_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(357, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(357, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(317, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quản lý sinh viên";
            // 
            // ic_username
            // 
            this.ic_username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ic_username.BackgroundImage")));
            this.ic_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ic_username.Location = new System.Drawing.Point(540, 139);
            this.ic_username.Name = "ic_username";
            this.ic_username.Size = new System.Drawing.Size(20, 20);
            this.ic_username.TabIndex = 5;
            this.ic_username.TabStop = false;
            // 
            // icon_password
            // 
            this.icon_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon_password.BackgroundImage")));
            this.icon_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_password.Location = new System.Drawing.Point(540, 211);
            this.icon_password.Name = "icon_password";
            this.icon_password.Size = new System.Drawing.Size(20, 20);
            this.icon_password.TabIndex = 6;
            this.icon_password.TabStop = false;
            this.icon_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.icon_password_MouseClick);
            // 
            // pn_exit
            // 
            this.pn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_exit.BackgroundImage")));
            this.pn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pn_exit.Location = new System.Drawing.Point(586, 328);
            this.pn_exit.Name = "pn_exit";
            this.pn_exit.Size = new System.Drawing.Size(57, 48);
            this.pn_exit.TabIndex = 8;
            this.pn_exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_exit_MouseClick);
            // 
            // pn_login
            // 
            this.pn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn_login.BackgroundImage")));
            this.pn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pn_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_login.Location = new System.Drawing.Point(480, 249);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(80, 40);
            this.pn_login.TabIndex = 9;
            this.pn_login.TabStop = false;
            this.pn_login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pn_login_MouseClick);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 388);
            this.Controls.Add(this.pn_login);
            this.Controls.Add(this.pn_exit);
            this.Controls.Add(this.icon_password);
            this.Controls.Add(this.ic_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ic_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ic_username;
        private System.Windows.Forms.PictureBox icon_password;
        private System.Windows.Forms.Panel pn_exit;
        private System.Windows.Forms.PictureBox pn_login;
    }
}