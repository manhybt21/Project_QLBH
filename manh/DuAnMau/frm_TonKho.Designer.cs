namespace DuAnMau
{
    partial class frm_TonKho
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
            this.dgv_TonKho = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TonKho
            // 
            this.dgv_TonKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TonKho.Location = new System.Drawing.Point(5, 22);
            this.dgv_TonKho.Name = "dgv_TonKho";
            this.dgv_TonKho.RowHeadersWidth = 62;
            this.dgv_TonKho.RowTemplate.Height = 28;
            this.dgv_TonKho.Size = new System.Drawing.Size(800, 248);
            this.dgv_TonKho.TabIndex = 1;
            // 
            // frm_TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 279);
            this.Controls.Add(this.dgv_TonKho);
            this.Name = "frm_TonKho";
            this.Text = "frm_TonKho";
            this.Load += new System.EventHandler(this.frm_TonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TonKho;
    }
}