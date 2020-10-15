using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace DuAnMau
{
    public partial class frm_DoiMatKhau : Form
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN bus_NHANVIEN = new BUS_NHANVIEN();
        private void btn_doiMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_MatKhauCu.Text.Trim().Length == 0)
            {
                MessageBox.Show("bạn phải nhập mật khẩu cũ để thay đổi mạt khẩu");
                txt_MatKhauCu.Focus();
                return;
            }
            string matKhauMoi = bus_NHANVIEN.encryption(txt_matKhauMoi.Text);
            string matKhauCu = bus_NHANVIEN.encryption(txt_MatKhauCu.Text);
            if (BUS_NHANVIEN.DoimatKhau(txt_EmailNhanVien.Text, matKhauCu, matKhauMoi))
            {
                cache.profile = 1;
                cache.session = 0;
                sendMail(txt_EmailNhanVien.Text, txt_nhapLaiMatKhauMoi.Text);
                MessageBox.Show("đổi mật khẩu thành công vui lòng đăng nhập lại để thực hiện chức năng");
                this.Close();
            }
            else
            {
                MessageBox.Show("đổi mật khẩu khong thành công vui lòng đăng nhập lại để thực hiện chức năng");
            }
        }
        public void sendMail(string email, string matKhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                NetworkCredential cred = new NetworkCredential("sender@gmail.com", "chonduoi");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("manhldph10164@fpt.edu.vn");
                Msg.To.Add(email);
                Msg.Subject = "bạn đã sử dụng chức năng quên mật khẩu";
                Msg.Body = "mật khẩu mới là " + matKhau;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("mật khẩu mới đã được gửi vui lòng kiểm tra email");

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_EmailNhanVien.Text = cache.mail;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_EmailNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
        bool click = true;
        private void cb_matkhaucu_Click(object sender, EventArgs e)
        {
            if (cb_matkhaucu.Checked == true)
            {
                txt_MatKhauCu.PasswordChar = '\0';
                click = false;
            }
            else
            {
                txt_MatKhauCu.PasswordChar = '*';
                click = true;
            }
        }

        private void cb_matkhaumoi_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_matkhaumoi.Checked == true)
            {
                txt_matKhauMoi.PasswordChar = '\0';
                click = false;
            }
            else
            {
                txt_matKhauMoi.PasswordChar = '*';
                click = true;
            }
        }

        private void cb_matkhaumoi2_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_matkhaumoi2.Checked == true)
            {
                txt_nhapLaiMatKhauMoi.PasswordChar = '\0';
                click = false;
            }
            else
            {
                txt_nhapLaiMatKhauMoi.PasswordChar = '*';
                click = true;
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
