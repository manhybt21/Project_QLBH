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
using System.Text.RegularExpressions;
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
            frm_DangNhapLoad();
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

        public void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_EmailDangNhap.Text == "" || txt_MatKhauDangNhap.Text == "")
                {
                    MessageBox.Show("Email đăng nhập và Password không được để trống!");
                    return;
                }
                if (!KiemTraEmail(txt_EmailDangNhap.Text))
                {
                    MessageBox.Show("Email không đúng định dạng!");
                    return;
                }
                if (txt_MatKhauDangNhap.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải dài hơn hoặc bằng 6 kỹ tự!");
                    return;
                }
                DTO_NHANVIEN nv = new DTO_NHANVIEN();
                nv.Email = txt_EmailDangNhap.Text.ToLower();
                nv.matKhau = txt_MatKhauDangNhap.Text.ToLower();
                if (BUS_NHANVIEN.DangNhap(nv))
                {
                    string mail = nv.Email;
                    cache.mail = mail;// truyền mail đăng nhập cho Home
                    DataTable dt = BUS_NHANVIEN.LayVaiTroNV(nv.Email);
                    vaitro = dt.Rows[0][0].ToString();// lấy vai trò nhân viên
                    MessageBox.Show("Login Successfully");
                    cache.session = 1;// đăng nhập thành công
                    if (cbx_ghiNhoDangNhap.Checked)
                    {
                        Properties.Settings.Default.user = txt_EmailDangNhap.Text;
                        Properties.Settings.Default.pass = txt_MatKhauDangNhap.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.user = "";
                        Properties.Settings.Default.pass = "";
                        Properties.Settings.Default.isChecked = false;
                        Properties.Settings.Default.Save();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Fail, Email or PassWord Wrong!");
                    txt_EmailDangNhap.Text = null;
                    txt_MatKhauDangNhap.Text = null;
                    txt_EmailDangNhap.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool KiemTraEmail(string email)
        {
            email = email ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
                return true;
            else
                return false;
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
                    string matkhaumoi = BUS_NHANVIEN.encryption(builder.ToString());
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
            frm_DangNhapLoad();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DangNhapLoad()
        {
            if (Properties.Settings.Default.user != string.Empty)
            {
                txt_EmailDangNhap.Text = Properties.Settings.Default.user;
                txt_MatKhauDangNhap.Text = Properties.Settings.Default.pass;
            }
        }
    }
}
