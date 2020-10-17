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
namespace DuAnMau
{
    public partial class frm_KhachHang : Form
    {
        string stremail;
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        
        private void btn_themKhachHang_Click(object sender, EventArgs e)
        {
            stremail = cache.mail;
            txt_dienThoai.Enabled = true;
            txt_dienThoai.Text = null;
            txt_hoVaTenKhach.Text = null;
            txt_DiaChiKhach.Text = null;
            txt_dienThoai.Enabled = true;
            txt_hoVaTenKhach.Enabled = true;
            txt_DiaChiKhach.Enabled = true;
            rad_nam.Enabled = true;
            rad_nu.Enabled = true;
            btn_luuKhachHang.Enabled = true;
            btn_suaKhachHang.Enabled = true;
            btn_xoaKhachHang.Enabled = true;
            rad_nam.Checked = false;
            rad_nu.Checked = false;
        }
        private void ResetValue()
        {
            txt_timKiemKhachHang.Text = "Nhập Tên Khách";
            txt_dienThoai.Text = null;
            txt_hoVaTenKhach.Text = null;
            txt_DiaChiKhach.Text = null;
            txt_dienThoai.Enabled = false;
            txt_hoVaTenKhach.Enabled = false;
            txt_DiaChiKhach.Enabled = false;
            rad_nam.Enabled = false;
            rad_nu.Enabled = false;
            btn_themKhachHang.Enabled = true;
            btn_luuKhachHang.Enabled = false;
            btn_suaKhachHang.Enabled = false;
            btn_xoaKhachHang.Enabled = false;
        }
        public void LoadGridViewKhach()
        {
            dgv_KhachHang.DataSource = BUS_KHACH.getKhach();
            dgv_KhachHang.Columns[0].HeaderText = "Số Điện Thoại";
            dgv_KhachHang.Columns[1].HeaderText = "Tên Khách";
            dgv_KhachHang.Columns[2].HeaderText = "Địa Chỉ";
            dgv_KhachHang.Columns[3].HeaderText = "Mã Nhân Viên";
            dgv_KhachHang.Columns[4].HeaderText = "Giới Tính";
        }
        private void btn_luuKhachHang_Click(object sender, EventArgs e)
        {
            try {
                string phai = "Nam";
                int soDT;
                bool isInt = int.TryParse(txt_dienThoai.Text.Trim().ToString(), out soDT);
                if (rad_nu.Checked == true)
                {
                    phai = "Nữ";
                }
                if (!isInt || int.Parse(txt_dienThoai.Text) < 0)
                {
                    MessageBox.Show("Số Điện Thoại Phải Là Số Nguyên");
                    txt_dienThoai.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show(cache.mail);
                    DTO_KHACH kh = new DTO_KHACH(txt_dienThoai.Text, txt_hoVaTenKhach.Text, txt_DiaChiKhach.Text, cache.mail, phai);
                    if (BUS_KHACH.insertKhach(kh))
                    {
                        MessageBox.Show("Thêm Thông Tin Khách Thành Công");
                        ResetValue();
                        LoadGridViewKhach();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thông Tin Khách Không Thành Công");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridViewKhach();
        }

        private void btn_suaKhachHang_Click(object sender, EventArgs e)
        {
            try {
                string phai = dgv_KhachHang.CurrentRow.Cells[3].Value.ToString();
                DTO_KHACH kh = new DTO_KHACH(txt_dienThoai.Text, txt_hoVaTenKhach.Text, txt_DiaChiKhach.Text, cache.mail, phai);
                if (MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Nhân Viên Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BUS_KHACH.updateKhach(kh))
                    {
                        MessageBox.Show("Sửa Thông Tin Thành Công");
                        ResetValue();
                        LoadGridViewKhach();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thông Tin Không Thành Công");
                    }
                }
                else
                {
                    ResetValue();
                    LoadGridViewKhach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoaKhachHang_Click(object sender, EventArgs e)
        {
            try {
                if (MessageBox.Show("Bạn Có Chắc Muốn Xoá Nhân Viên Này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BUS_KHACH.deleteKhach(txt_dienThoai.Text))
                    {
                        MessageBox.Show("Xoá Dữ Liệu Thành Công");
                        ResetValue();
                        LoadGridViewKhach();
                    }
                    else
                    {
                        MessageBox.Show("Xoá Dữ Liệu Không Thành Công");
                    }
                }
                else
                {
                    ResetValue();
                    LoadGridViewKhach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_boQuaKhachHang_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridViewKhach();
        }

        private void btn_danhSachKhachHang_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridViewKhach();
        }

        private void btn_dongKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                btn_suaKhachHang.Enabled = true;
                btn_xoaKhachHang.Enabled = true;
                txt_hoVaTenKhach.Enabled = true;
                txt_DiaChiKhach.Enabled = true;
                rad_nam.Enabled = true;
                rad_nu.Enabled = true;
                if (dgv_KhachHang.Rows.Count > 1)
                {
                    txt_dienThoai.Text = dgv_KhachHang.CurrentRow.Cells[0].Value.ToString();
                    txt_hoVaTenKhach.Text = dgv_KhachHang.CurrentRow.Cells[1].Value.ToString();
                    txt_DiaChiKhach.Text = dgv_KhachHang.CurrentRow.Cells[2].Value.ToString();
                    if (dgv_KhachHang.CurrentRow.Cells[4].Value.ToString() == "Nam")
                    {
                        rad_nam.Checked = true;
                    }
                    if (dgv_KhachHang.CurrentRow.Cells[4].Value.ToString() == "Nữ")
                    {
                        rad_nu.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("Không Có Dữ Liệu Trong Bảng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_timKiemKhachHang_Click(object sender, EventArgs e)
        {
            DataTable ds = BUS_KHACH.searchKhach(txt_hoVaTenKhach.Text);
            if (ds.Rows.Count > 0)
            {
                dgv_KhachHang.DataSource = ds;
            }
            else
            {
                MessageBox.Show("Không Khong Tìm Thấy Khách Hàng");
            }
            txt_timKiemKhachHang.Text = "Nhập Tên Khách Hàng";
            ResetValue();
        }

        private void txt_timKiemKhachHang_Click(object sender, EventArgs e)
        {
           txt_timKiemKhachHang.Text = null;
        }
    }
}
