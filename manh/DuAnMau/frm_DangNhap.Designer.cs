namespace DuAnMau
{
    partial class frm_DangNhap
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_quenMatKhau = new System.Windows.Forms.Button();
            this.cbx_ghiNhoDangNhap = new System.Windows.Forms.CheckBox();
            this.txt_MatKhauDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EmailDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.Aqua;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_thoat.Location = new System.Drawing.Point(127, 385);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(215, 42);
            this.btn_thoat.TabIndex = 17;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.Aqua;
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_DangNhap.Location = new System.Drawing.Point(127, 319);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(215, 41);
            this.btn_DangNhap.TabIndex = 16;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_quenMatKhau
            // 
            this.btn_quenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quenMatKhau.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_quenMatKhau.Location = new System.Drawing.Point(308, 254);
            this.btn_quenMatKhau.Name = "btn_quenMatKhau";
            this.btn_quenMatKhau.Size = new System.Drawing.Size(160, 33);
            this.btn_quenMatKhau.TabIndex = 15;
            this.btn_quenMatKhau.Text = "Quên Mật Khẩu ?";
            this.btn_quenMatKhau.UseVisualStyleBackColor = true;
            this.btn_quenMatKhau.Click += new System.EventHandler(this.btn_quenMatKhau_Click);
            // 
            // cbx_ghiNhoDangNhap
            // 
            this.cbx_ghiNhoDangNhap.AutoSize = true;
            this.cbx_ghiNhoDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.cbx_ghiNhoDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ghiNhoDangNhap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbx_ghiNhoDangNhap.Location = new System.Drawing.Point(29, 259);
            this.cbx_ghiNhoDangNhap.Name = "cbx_ghiNhoDangNhap";
            this.cbx_ghiNhoDangNhap.Size = new System.Drawing.Size(190, 26);
            this.cbx_ghiNhoDangNhap.TabIndex = 14;
            this.cbx_ghiNhoDangNhap.Text = "Ghi Nhớ Tài Khoản";
            this.cbx_ghiNhoDangNhap.UseVisualStyleBackColor = false;
            // 
            // txt_MatKhauDangNhap
            // 
            this.txt_MatKhauDangNhap.Location = new System.Drawing.Point(29, 206);
            this.txt_MatKhauDangNhap.Name = "txt_MatKhauDangNhap";
            this.txt_MatKhauDangNhap.PasswordChar = '*';
            this.txt_MatKhauDangNhap.Size = new System.Drawing.Size(439, 26);
            this.txt_MatKhauDangNhap.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_EmailDangNhap
            // 
            this.txt_EmailDangNhap.Location = new System.Drawing.Point(29, 119);
            this.txt_EmailDangNhap.Name = "txt_EmailDangNhap";
            this.txt_EmailDangNhap.Size = new System.Drawing.Size(439, 26);
            this.txt_EmailDangNhap.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email Đăng Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đăng Nhập Hệ Thống";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 439);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_quenMatKhau);
            this.Controls.Add(this.cbx_ghiNhoDangNhap);
            this.Controls.Add(this.txt_MatKhauDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_EmailDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.Text = "frm_DangNhap";
            this.Enter += new System.EventHandler(this.frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_quenMatKhau;
        private System.Windows.Forms.CheckBox cbx_ghiNhoDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhauDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EmailDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}