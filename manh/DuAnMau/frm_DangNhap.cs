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
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            System.Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase) return builder.ToString().ToLower();
            return builder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void SendMail(string email, string matKhau)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);//mail hệ thống
                NetworkCredential cred = new NetworkCredential("manhluong284@gmail.com", "manhyb112");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("manhluong284@gmail.com");
                Msg.To.Add(email);
                Msg.Subject = "bạn đã sử dụng chức năng quên mật khẩu";
                Msg.Body = "Chào Anh/Chị Mật Khẩu Mới Là " +matKhau+ " Mời Anh/Chị Đăng Nhập Lại" ;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                MessageBox.Show("Mật khẩu mới đã được gửi vui lòng kiểm tra email");

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
                cache.mail = mail;// truyền mail đăng nhập cho Home
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
                    builder.Append(RandomString(4, true));
                    builder.Append(RandomNumber(1000, 9990));
                    builder.Append(RandomString(2, false));
                    MessageBox.Show(builder.ToString());
                    string matkhaumoi = bus_NHANVIEN.encryption(builder.ToString());
                    BUS_NHANVIEN.TaoMatKhauMoi(txt_EmailDangNhap.Text, matkhaumoi);
                    SendMail(txt_EmailDangNhap.Text, matkhaumoi);
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
