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
namespace DuAnMau
{
    public partial class frm_quenMatKhau : Form
    {
        public frm_quenMatKhau()
        {
            InitializeComponent();
        }
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
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);//mail hệ thống
                NetworkCredential cred = new NetworkCredential("manhluong284@gmail.com", "manh110701");
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("manhluong284@gmail.com");
                Msg.To.Add(email);
                Msg.Subject = "bạn đã sử dụng chức năng quên mật khẩu";
                Msg.Body = "Chào Anh/Chị Mật Khẩu Mới Là " + matKhau + " Mời Anh/Chị Đăng Nhập Lại";
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
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encrypdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encrypdata.Append(encrypt[i].ToString("x2"));
            }
            return encrypdata.ToString();
        }
        private void btn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            if (txt_emailCanGui.Text != "")
            {
                if (BUS_NHANVIEN.QuenMatKhau(txt_emailCanGui.Text)){
                StringBuilder builder = new StringBuilder();
                builder.Append(RandomString(4, true));
                builder.Append(RandomNumber(1000, 9990));
                builder.Append(RandomString(2, false));
                MessageBox.Show(builder.ToString());
                string matkhaumoi = encryption(builder.ToString());
                BUS_NHANVIEN.TaoMatKhauMoi(txt_emailCanGui.Text, matkhaumoi);
                SendMail(txt_emailCanGui.Text, matkhaumoi);
            }
                else
                {
                    MessageBox.Show("Email Không tồn tại");
                }
        }
            else
                {
                    MessageBox.Show("bạn cần nhập email để phục hồi mật khẩu");
                    txt_emailCanGui.Focus();
                }
}

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
