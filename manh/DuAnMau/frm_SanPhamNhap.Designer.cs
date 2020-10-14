namespace DuAnMau
{
    partial class frm_SanPhamNhap
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
            this.dgv_SanPhamNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPhamNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SanPhamNhap
            // 
            this.dgv_SanPhamNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPhamNhap.Location = new System.Drawing.Point(2, 39);
            this.dgv_SanPhamNhap.Name = "dgv_SanPhamNhap";
            this.dgv_SanPhamNhap.RowHeadersWidth = 62;
            this.dgv_SanPhamNhap.RowTemplate.Height = 28;
            this.dgv_SanPhamNhap.Size = new System.Drawing.Size(804, 321);
            this.dgv_SanPhamNhap.TabIndex = 1;
            // 
            // frm_SanPhamNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 362);
            this.Controls.Add(this.dgv_SanPhamNhap);
            this.Name = "frm_SanPhamNhap";
            this.Text = "frm_SanPhamNhap";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPhamNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SanPhamNhap;
    }
}