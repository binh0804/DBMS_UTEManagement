
namespace DBMS_UTEManagement
{
    partial class TrackingForm
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
            this.dgvTracking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTracking
            // 
            this.dgvTracking.AllowUserToAddRows = false;
            this.dgvTracking.AllowUserToDeleteRows = false;
            this.dgvTracking.AllowUserToResizeColumns = false;
            this.dgvTracking.AllowUserToResizeRows = false;
            this.dgvTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTracking.Location = new System.Drawing.Point(12, 12);
            this.dgvTracking.Name = "dgvTracking";
            this.dgvTracking.RowHeadersWidth = 51;
            this.dgvTracking.RowTemplate.Height = 24;
            this.dgvTracking.Size = new System.Drawing.Size(776, 426);
            this.dgvTracking.TabIndex = 0;
            // 
            // TrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTracking);
            this.Name = "TrackingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackingForm";
            this.Load += new System.EventHandler(this.TrackingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTracking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTracking;
    }
}