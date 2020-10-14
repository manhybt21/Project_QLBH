using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace DuAnMau
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        BUS_NHANVIEN bus_NHANVIEN = new BUS_NHANVIEN();
        public string vaitro { get; set; }// đăng nhập thành công kiểm tra vai trò
        public string matKhau { get; set; }
        public void sendMail(string email, string matKhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("manhldph10164@fpt.edu.vn", 25);
                NetworkCredential cred = new NetworkCredential("sender@gmail.com", "chonduoi");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("sender@gmail.com");
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

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DTO_NHANVIEN nv = new DTO_NHANVIEN();
            nv.Email = txt_EmailDangNhap.Text;
            nv.matKhau = bus_NHANVIEN.encryption(txt_MatKhauDangNhap.Text);
            if (BUS_NHANVIEN.DangNhap(nv))
            {
                string mail = nv.Email;
                cache.mail = nv.Email;// truyền mail đăng nhập cho Home
                DataTable dt = BUS_NHANVIEN.LayVaiTroNV(nv.Email);
                vaitro = dt.Rows[0][0].ToString();// lấy vai trò nhân viên
                MessageBox.Show("Login Successfully");
                cache.session = 1;// đăng nhập thành công
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Login Fall, Email or PassWord Wrong!");
                txt_EmailDangNhap.Text = null;
                txt_MatKhauDangNhap.Text = null;
                txt_EmailDangNhap.Focus();
            }
            
        }

        private void btn_quenMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_EmailDangNhap.Text != "")
            {
                if (BUS_NHANVIEN.QuenMatKhau(txt_EmailDangNhap.Text))
                {
                    StringBuilder builder = new StringBuilder();
                    builder.Append(bus_NHANVIEN.RandomString(4, true));
                    builder.Append(bus_NHANVIEN.RandomNumber(1000, 9990));
                    builder.Append(bus_NHANVIEN.RandomString(2, false));
                    MessageBox.Show(builder.ToString());
                    string matkhaumoi = bus_NHANVIEN.encryption(builder.ToString());
                    BUS_NHANVIEN.TaoMatKhauMoi(txt_EmailDangNhap.Text, matkhaumoi);
                    sendMail(txt_EmailDangNhap.Text, matkhaumoi);
                }
                else
                {
                    MessageBox.Show("Email Không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("bạn cần nhập email để phục hồi mật khẩu");
                txt_EmailDangNhap.Focus();
            }
        }

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            cache.session = 0;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
