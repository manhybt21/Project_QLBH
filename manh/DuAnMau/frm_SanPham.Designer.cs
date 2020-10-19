namespace DuAnMau
{
    partial class frm_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SanPham));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_moHinh = new System.Windows.Forms.Button();
            this.pic_SanPham = new System.Windows.Forms.PictureBox();
            this.txt_ghiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_giaBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_giaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soLuongHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_timKiemSanPham = new System.Windows.Forms.Button();
            this.txt_timKiemSanPham = new System.Windows.Forms.TextBox();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_dongSanPham = new System.Windows.Forms.Button();
            this.btn_danhSachSanPham = new System.Windows.Forms.Button();
            this.btn_boQuaSanPham = new System.Windows.Forms.Button();
            this.btn_luuSanPham = new System.Windows.Forms.Button();
            this.btn_suaSanPham = new System.Windows.Forms.Button();
            this.btn_xoaSanPham = new System.Windows.Forms.Button();
            this.btn_themSanPham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(433, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 37);
            this.label8.TabIndex = 66;
            this.label8.Text = "Sản Phẩm";
            // 
            // btn_moHinh
            // 
            this.btn_moHinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_moHinh.Location = new System.Drawing.Point(769, 130);
            this.btn_moHinh.Name = "btn_moHinh";
            this.btn_moHinh.Size = new System.Drawing.Size(128, 39);
            this.btn_moHinh.TabIndex = 65;
            this.btn_moHinh.Text = "Mở Hình";
            this.btn_moHinh.UseVisualStyleBackColor = true;
            this.btn_moHinh.Click += new System.EventHandler(this.btn_moHinh_Click);
            // 
            // pic_SanPham
            // 
            this.pic_SanPham.Location = new System.Drawing.Point(916, 118);
            this.pic_SanPham.Name = "pic_SanPham";
            this.pic_SanPham.Size = new System.Drawing.Size(219, 250);
            this.pic_SanPham.TabIndex = 64;
            this.pic_SanPham.TabStop = false;
            // 
            // txt_ghiChu
            // 
            this.txt_ghiChu.Location = new System.Drawing.Point(547, 241);
            this.txt_ghiChu.Multiline = true;
            this.txt_ghiChu.Name = "txt_ghiChu";
            this.txt_ghiChu.Size = new System.Drawing.Size(350, 126);
            this.txt_ghiChu.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Ghi Chú";
            // 
            // txt_hinh
            // 
            this.txt_hinh.Location = new System.Drawing.Point(547, 118);
            this.txt_hinh.Multiline = true;
            this.txt_hinh.Name = "txt_hinh";
            this.txt_hinh.Size = new System.Drawing.Size(204, 96);
            this.txt_hinh.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Hình";
            // 
            // txt_giaBan
            // 
            this.txt_giaBan.Location = new System.Drawing.Point(143, 339);
            this.txt_giaBan.Name = "txt_giaBan";
            this.txt_giaBan.Size = new System.Drawing.Size(265, 26);
            this.txt_giaBan.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Giá Bán";
            // 
            // txt_giaNhap
            // 
            this.txt_giaNhap.Location = new System.Drawing.Point(143, 283);
            this.txt_giaNhap.Name = "txt_giaNhap";
            this.txt_giaNhap.Size = new System.Drawing.Size(265, 26);
            this.txt_giaNhap.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Giá Nhập";
            // 
            // txt_tenHang
            // 
            this.txt_tenHang.Location = new System.Drawing.Point(143, 171);
            this.txt_tenHang.Name = "txt_tenHang";
            this.txt_tenHang.Size = new System.Drawing.Size(265, 26);
            this.txt_tenHang.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tên Hàng";
            // 
            // txt_soLuongHang
            // 
            this.txt_soLuongHang.Location = new System.Drawing.Point(143, 227);
            this.txt_soLuongHang.Name = "txt_soLuongHang";
            this.txt_soLuongHang.Size = new System.Drawing.Size(265, 26);
            this.txt_soLuongHang.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Số Lượng";
            // 
            // txt_maHang
            // 
            this.txt_maHang.Location = new System.Drawing.Point(143, 115);
            this.txt_maHang.Name = "txt_maHang";
            this.txt_maHang.ReadOnly = true;
            this.txt_maHang.Size = new System.Drawing.Size(265, 26);
            this.txt_maHang.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã Hàng";
            // 
            // btn_timKiemSanPham
            // 
            this.btn_timKiemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timKiemSanPham.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timKiemSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_timKiemSanPham.Image")));
            this.btn_timKiemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timKiemSanPham.Location = new System.Drawing.Point(578, 624);
            this.btn_timKiemSanPham.Name = "btn_timKiemSanPham";
            this.btn_timKiemSanPham.Size = new System.Drawing.Size(143, 46);
            this.btn_timKiemSanPham.TabIndex = 49;
            this.btn_timKiemSanPham.Text = "Tìm Kiếm";
            this.btn_timKiemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timKiemSanPham.UseVisualStyleBackColor = true;
            this.btn_timKiemSanPham.Click += new System.EventHandler(this.btn_timKiemSanPham_Click);
            // 
            // txt_timKiemSanPham
            // 
            this.txt_timKiemSanPham.Location = new System.Drawing.Point(271, 624);
            this.txt_timKiemSanPham.Multiline = true;
            this.txt_timKiemSanPham.Name = "txt_timKiemSanPham";
            this.txt_timKiemSanPham.Size = new System.Drawing.Size(282, 46);
            this.txt_timKiemSanPham.TabIndex = 48;
            this.txt_timKiemSanPham.TextChanged += new System.EventHandler(this.txt_timKiemSanPham_TextChanged);
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Location = new System.Drawing.Point(2, 388);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 62;
            this.dgv_SanPham.RowTemplate.Height = 28;
            this.dgv_SanPham.Size = new System.Drawing.Size(1146, 209);
            this.dgv_SanPham.TabIndex = 47;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            this.dgv_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_dongSanPham
            // 
            this.btn_dongSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_dongSanPham.Image")));
            this.btn_dongSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dongSanPham.Location = new System.Drawing.Point(1009, 704);
            this.btn_dongSanPham.Name = "btn_dongSanPham";
            this.btn_dongSanPham.Size = new System.Drawing.Size(104, 49);
            this.btn_dongSanPham.TabIndex = 75;
            this.btn_dongSanPham.Text = "Đóng";
            this.btn_dongSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dongSanPham.UseVisualStyleBackColor = true;
            this.btn_dongSanPham.Click += new System.EventHandler(this.btn_dongSanPham_Click);
            // 
            // btn_danhSachSanPham
            // 
            this.btn_danhSachSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_danhSachSanPham.Image")));
            this.btn_danhSachSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhSachSanPham.Location = new System.Drawing.Point(820, 704);
            this.btn_danhSachSanPham.Name = "btn_danhSachSanPham";
            this.btn_danhSachSanPham.Size = new System.Drawing.Size(147, 49);
            this.btn_danhSachSanPham.TabIndex = 74;
            this.btn_danhSachSanPham.Text = "Danh Sách";
            this.btn_danhSachSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_danhSachSanPham.UseVisualStyleBackColor = true;
            this.btn_danhSachSanPham.Click += new System.EventHandler(this.btn_danhSachSanPham_Click);
            // 
            // btn_boQuaSanPham
            // 
            this.btn_boQuaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_boQuaSanPham.Image")));
            this.btn_boQuaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_boQuaSanPham.Location = new System.Drawing.Point(654, 704);
            this.btn_boQuaSanPham.Name = "btn_boQuaSanPham";
            this.btn_boQuaSanPham.Size = new System.Drawing.Size(124, 49);
            this.btn_boQuaSanPham.TabIndex = 73;
            this.btn_boQuaSanPham.Text = "Bỏ Qua";
            this.btn_boQuaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_boQuaSanPham.UseVisualStyleBackColor = true;
            this.btn_boQuaSanPham.Click += new System.EventHandler(this.btn_boQuaSanPham_Click);
            // 
            // btn_luuSanPham
            // 
            this.btn_luuSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_luuSanPham.Image")));
            this.btn_luuSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luuSanPham.Location = new System.Drawing.Point(492, 704);
            this.btn_luuSanPham.Name = "btn_luuSanPham";
            this.btn_luuSanPham.Size = new System.Drawing.Size(120, 49);
            this.btn_luuSanPham.TabIndex = 72;
            this.btn_luuSanPham.Text = "Lưu";
            this.btn_luuSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luuSanPham.UseVisualStyleBackColor = true;
            this.btn_luuSanPham.Click += new System.EventHandler(this.btn_luuSanPham_Click);
            // 
            // btn_suaSanPham
            // 
            this.btn_suaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_suaSanPham.Image")));
            this.btn_suaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaSanPham.Location = new System.Drawing.Point(339, 704);
            this.btn_suaSanPham.Name = "btn_suaSanPham";
            this.btn_suaSanPham.Size = new System.Drawing.Size(111, 49);
            this.btn_suaSanPham.TabIndex = 71;
            this.btn_suaSanPham.Text = "Sửa";
            this.btn_suaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suaSanPham.UseVisualStyleBackColor = true;
            this.btn_suaSanPham.Click += new System.EventHandler(this.btn_suaSanPham_Click);
            // 
            // btn_xoaSanPham
            // 
            this.btn_xoaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaSanPham.Image")));
            this.btn_xoaSanPham.Location = new System.Drawing.Point(188, 704);
            this.btn_xoaSanPham.Name = "btn_xoaSanPham";
            this.btn_xoaSanPham.Size = new System.Drawing.Size(109, 49);
            this.btn_xoaSanPham.TabIndex = 70;
            this.btn_xoaSanPham.Text = "Xoá";
            this.btn_xoaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoaSanPham.UseVisualStyleBackColor = true;
            this.btn_xoaSanPham.Click += new System.EventHandler(this.btn_xoaSanPham_Click);
            // 
            // btn_themSanPham
            // 
            this.btn_themSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_themSanPham.Image")));
            this.btn_themSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themSanPham.Location = new System.Drawing.Point(48, 704);
            this.btn_themSanPham.Name = "btn_themSanPham";
            this.btn_themSanPham.Size = new System.Drawing.Size(93, 49);
            this.btn_themSanPham.TabIndex = 69;
            this.btn_themSanPham.Text = "Thêm";
            this.btn_themSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themSanPham.UseVisualStyleBackColor = true;
            this.btn_themSanPham.Click += new System.EventHandler(this.btn_themSanPham_Click);
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 769);
            this.Controls.Add(this.btn_dongSanPham);
            this.Controls.Add(this.btn_danhSachSanPham);
            this.Controls.Add(this.btn_boQuaSanPham);
            this.Controls.Add(this.btn_luuSanPham);
            this.Controls.Add(this.btn_suaSanPham);
            this.Controls.Add(this.btn_xoaSanPham);
            this.Controls.Add(this.btn_themSanPham);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_moHinh);
            this.Controls.Add(this.pic_SanPham);
            this.Controls.Add(this.txt_ghiChu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_hinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_giaBan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_giaNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soLuongHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_timKiemSanPham);
            this.Controls.Add(this.txt_timKiemSanPham);
            this.Controls.Add(this.dgv_SanPham);
            this.Name = "frm_SanPham";
            this.Text = "frm_SanPham";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_moHinh;
        private System.Windows.Forms.PictureBox pic_SanPham;
        private System.Windows.Forms.TextBox txt_ghiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_giaBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_giaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soLuongHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_timKiemSanPham;
        private System.Windows.Forms.TextBox txt_timKiemSanPham;
        private System.Windows.Forms.DataGridView dgv_SanPham;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_dongSanPham;
        private System.Windows.Forms.Button btn_danhSachSanPham;
        private System.Windows.Forms.Button btn_boQuaSanPham;
        private System.Windows.Forms.Button btn_luuSanPham;
        private System.Windows.Forms.Button btn_suaSanPham;
        private System.Windows.Forms.Button btn_xoaSanPham;
        private System.Windows.Forms.Button btn_themSanPham;
    }
}