namespace DuAnMau
{
    partial class frm_quenMatKhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_emailCanGui = new System.Windows.Forms.TextBox();
            this.btn_QuenMatKhau = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(88, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên Mật Khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // txt_emailCanGui
            // 
            this.txt_emailCanGui.Location = new System.Drawing.Point(40, 140);
            this.txt_emailCanGui.Multiline = true;
            this.txt_emailCanGui.Name = "txt_emailCanGui";
            this.txt_emailCanGui.Size = new System.Drawing.Size(316, 31);
            this.txt_emailCanGui.TabIndex = 2;
            // 
            // btn_QuenMatKhau
            // 
            this.btn_QuenMatKhau.BackColor = System.Drawing.Color.Aqua;
            this.btn_QuenMatKhau.Location = new System.Drawing.Point(40, 206);
            this.btn_QuenMatKhau.Name = "btn_QuenMatKhau";
            this.btn_QuenMatKhau.Size = new System.Drawing.Size(174, 42);
            this.btn_QuenMatKhau.TabIndex = 3;
            this.btn_QuenMatKhau.Text = "Gửi Mật Khẩu Mới";
            this.btn_QuenMatKhau.UseVisualStyleBackColor = false;
            this.btn_QuenMatKhau.Click += new System.EventHandler(this.btn_QuenMatKhau_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_thoat.BackColor = System.Drawing.Color.Aqua;
            this.btn_thoat.Location = new System.Drawing.Point(255, 206);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(101, 42);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_quenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 428);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_QuenMatKhau);
            this.Controls.Add(this.txt_emailCanGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "frm_quenMatKhau";
            this.Text = "frm_quenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_emailCanGui;
        private System.Windows.Forms.Button btn_QuenMatKhau;
        private System.Windows.Forms.Button btn_thoat;
    }
}