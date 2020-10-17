using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Net.Mail;
using System.Net;

namespace DuAnMau
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        public void sendMail(string email)
        {
            try
            {
                //Sử dụn smtpclient để thực hiện gửi mail từ máy chủ
                //Bắt buộc port phải là 587
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                //Sử dụng tên đăng nhập và mật khẩu muốn gửi mail
                NetworkCredential network = new NetworkCredential("manhluong284@gmail.com","manh110701");

                MailMessage Msg = new MailMessage();
                //tài khoản muốn gửi mail
                Msg.From = new MailAddress("manhluong284@gmail.com");
                //tài khoản nhận mail
                Msg.To.Add(new MailAddress(email));
                Msg.Subject = "Chào Mừng Thành Viên Mới";
                Msg.Body = "Chào anh/chị. Mật khẩu  của bạn là: 123456, Bạn có thể đăng nhập vào ứng dụng bằng mật khẩu mới. Cảm ơn!! ";
                //quan trọng
                client.Credentials = network;
                client.Send(Msg);
                MessageBox.Show("Tạo Tài Khoản Thành Công");

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void ResetValue()
        {
            txt_timKiemNhanVien.Text = "Nhập Tên Nhân Viên";
            txt_emailNhanVien.Text = null;
            txt_DiaChiNhanVien.Text = null;
            txt_TenNhanVien.Text = null;
            txt_emailNhanVien.Enabled = false;
            txt_TenNhanVien.Enabled = false;
            txt_DiaChiNhanVien.Enabled = false;
            rad_hoatDong.Enabled = false;
            rad_khongHoatDong.Enabled = false;
            rad_nhanVien.Enabled = false;
            rad_quanTri.Enabled = false;
            btn_them.Enabled = true;
            btn_dong.Enabled = true;
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }
        private void LoadGridView_NhanVien()
        {
            dgv_NhanVien.DataSource = BUS_NHANVIEN.getNhanVien();
            
        }
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_NhanVien();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_emailNhanVien.Text = null;
            txt_DiaChiNhanVien.Text = null;
            txt_TenNhanVien.Text = null;
            txt_emailNhanVien.Enabled = true;
            txt_TenNhanVien.Enabled = true;
            txt_DiaChiNhanVien.Enabled = true;
            rad_hoatDong.Enabled = true;
            rad_khongHoatDong.Enabled = true;
            rad_nhanVien.Enabled = true;
            rad_quanTri.Enabled = true;
            btn_luu.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            rad_hoatDong.Checked = false;
            rad_khongHoatDong.Checked = false;
            rad_nhanVien.Checked = false;
            rad_quanTri.Checked = false;
            txt_emailNhanVien.Focus();
        }
        public static bool IsValid(string emailAdress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAdress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            int Role=0;//role = 0 là nhân viên
            if (rad_quanTri.Checked)
            {
                Role = 1;
            }
            int tinhTrang = 0;// tình trạng = 0 là không hoạt động
            if (rad_hoatDong.Checked)
            {
                tinhTrang = 1;
            }
            if(txt_emailNhanVien.Text.Trim().Length==0)//kiểm tra email đã nhập chưa
            {
                MessageBox.Show("Vui Lòng Nhập Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_emailNhanVien.Focus();
                return;
            }   
            else if (!IsValid(txt_emailNhanVien.Text.Trim()))
            {
                MessageBox.Show("Vui Lòng Nhập Email", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txt_TenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Tên Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNhanVien.Focus();
                return;
            }
            else if (txt_DiaChiNhanVien.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui Lòng Nhập Địa Chỉ Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChiNhanVien.Focus();
                return;
            }
            else if(rad_hoatDong.Checked==false && rad_khongHoatDong.Checked == false)
            {
                MessageBox.Show("Vui Lòng Chọn Tình Trạng Tài Khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(rad_nhanVien.Checked==false&& rad_quanTri.Checked == false)
            {
                MessageBox.Show("Vui Lòng Chọn Chức Vụ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DTO_NHANVIEN nv = new DTO_NHANVIEN(txt_emailNhanVien.Text, txt_TenNhanVien.Text, txt_DiaChiNhanVien.Text, Role, tinhTrang);
                if (BUS_NHANVIEN.insertNhanVien(nv))
                {
                    MessageBox.Show("Thêm Nhân Viên Thành Công!");
                    ResetValue();
                    LoadGridView_NhanVien();
                    sendMail(nv.Email);
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_TenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Tên Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_TenNhanVien.Focus();
                return;
            }
            else if (txt_DiaChiNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Địa Chỉ Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_DiaChiNhanVien.Focus();
                return;
            }
            else
            {
                int role = 0;
                int tinhTrang = 0;
                if (rad_quanTri.Checked) { role = 1; }
                if (rad_hoatDong.Checked) { tinhTrang = 1; }
                DTO_NHANVIEN nv = new DTO_NHANVIEN(txt_emailNhanVien.Text, txt_TenNhanVien.Text, txt_DiaChiNhanVien.Text, role, tinhTrang);
                if(MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Nhân Viên Không","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BUS_NHANVIEN.updateNhanVien(nv)) {
                        MessageBox.Show("Sửa Thông Tin Thành Công");
                        ResetValue();
                        LoadGridView_NhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thông Tin Không Thành Công");
                    }
                }
                else
                {
                    ResetValue();
                }
            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_NhanVien.Rows.Count > 1)
            {
                btn_luu.Enabled = false;
                txt_TenNhanVien.Enabled = true;
                txt_DiaChiNhanVien.Enabled = true;
                rad_nhanVien.Enabled = true;
                rad_quanTri.Enabled = true;
                rad_hoatDong.Enabled = true;
                rad_khongHoatDong.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                // lấy dữ liệu từ hàng
                txt_emailNhanVien.Text = dgv_NhanVien.CurrentRow.Cells[3].Value.ToString();
                txt_TenNhanVien.Text= dgv_NhanVien.CurrentRow.Cells[2].Value.ToString();
                txt_DiaChiNhanVien.Text= dgv_NhanVien.CurrentRow.Cells[4].Value.ToString();
                if (int.Parse(dgv_NhanVien.CurrentRow.Cells[5].Value.ToString()) == 1)
                {
                    rad_quanTri.Checked = true;
                }
                else
                {
                    rad_nhanVien.Checked = true;
                }
                if(int.Parse(dgv_NhanVien.CurrentRow.Cells[6].Value.ToString()) == 1)
                {
                    rad_hoatDong.Checked = true;
                }
                else
                {
                    rad_khongHoatDong.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Không Có Dữ Liệu Trong Bảng","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string email = txt_emailNhanVien.Text;
            if(MessageBox.Show("Bạn Có Chắc Muốn Xoá Nhân Viên Này","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BUS_NHANVIEN.deleteNhanVien(email))
                {
                    MessageBox.Show("Xoá Dữ Liệu Thành Công");
                    ResetValue();
                    LoadGridView_NhanVien();
                }
                else
                {
                    MessageBox.Show("Xoá Dữ Liệu Không Thành Công");
                }
            }
            else
            {
                ResetValue();
            }
        }

        private void txt_timKiemNhanVien_Click(object sender, EventArgs e)
        {
            txt_timKiemNhanVien.Text = null;
            txt_timKiemNhanVien.BackColor = Color.White;
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            DataTable ds = BUS_NHANVIEN.SearchNhanVien(txt_timKiemNhanVien.Text);
            if (ds.Rows.Count > 0)
            {
                dgv_NhanVien.DataSource = ds;
                dgv_NhanVien.Columns[0].HeaderText = "Email";
                dgv_NhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
                dgv_NhanVien.Columns[2].HeaderText = "Địa Chỉ";
                dgv_NhanVien.Columns[3].HeaderText = "Vai Trò";
                dgv_NhanVien.Columns[4].HeaderText = "Tình Trạng";
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Kết Quả");
            }
            txt_timKiemNhanVien.Text = "Nhập Tên Nhân Viên";
            txt_timKiemNhanVien.BackColor = Color.White;
            ResetValue();

        }

        private void btn_danhSach_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_NhanVien();
        }

        private void btn_boQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridView_NhanVien();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_timKiemNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
