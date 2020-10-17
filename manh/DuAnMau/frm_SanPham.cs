using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace DuAnMau
{
    public partial class frm_SanPham : Form
    {
        public frm_SanPham()
        {
            InitializeComponent();
        }
        string stremail = cache.mail;//nhận email từ main
        string checkUrlImages;//kiểm tra đường dẫn ảnh
        string fileName;// tên file
        string fileSavePath;// lưu đường dẫn ảnh
        string fileAddress;// lấy đường link ảnh
        private void ResetValue()
        {
            txt_tenHang.Text = null;
            txt_soLuongHang.Text = null;
            txt_giaNhap.Text = null;
            txt_giaBan.Text = null;
            txt_timKiemSanPham.Text = "Nhập Tên Sản Phẩm";
            txt_hinh.Text = null;
            txt_ghiChu.Text = null;
            txt_tenHang.Enabled = false;
            txt_soLuongHang.Enabled = false;
            txt_giaNhap.Enabled = false;
            txt_giaBan.Enabled = false;
            txt_hinh.Enabled = false;
            txt_ghiChu.Enabled = false;
            btn_themSanPham.Enabled = true;
            btn_dongSanPham.Enabled = true;
            btn_luuSanPham.Enabled = false;
            btn_suaSanPham.Enabled = false;
            btn_xoaSanPham.Enabled = false;
        }
        public void LoadGridViewSanPham()
        {
            if (BUS_HANG.getHang().Rows.Count < 1)
            {
                return;
            }
            dgv_SanPham.DataSource = BUS_HANG.getHang();
        }
        private void btn_moHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.Title = "Chọn Hình Ảnh Minh Hoạ Sản Phẩm";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileAddress = openFile.FileName;
                pic_SanPham.Image = Image.FromFile(fileAddress);
                fileName = Path.GetFileName(openFile.FileName);
                string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                fileSavePath = saveDirectory + "\\Images\\" + fileName;
                txt_hinh.Text = "\\Images\\" + fileName;
            }
        }

        private void btn_luuSanPham_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            float floatDonGiaNhap;
            float floatDonGiaBan;
            bool isInt = int.TryParse(txt_soLuongHang.Text.Trim().ToString(), out intSoLuong);
            bool isFloatNhap = float.TryParse(txt_giaNhap.Text.Trim().ToString(), out floatDonGiaNhap);
            bool isFloatBan = float.TryParse(txt_giaBan.Text.Trim().ToString(), out floatDonGiaBan);
            if (txt_tenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên Hàng Không Được Bỏ Trống");
            }
            else if (int.Parse(txt_giaNhap.Text) < 0 || !isFloatNhap)
            {
                MessageBox.Show("Giá Nhập Không Được Âm");
            }
            else if (int.Parse(txt_giaBan.Text) < 0 || !isFloatBan)
            {
                MessageBox.Show("Giá Bán Không Được Âm");
            }
            else if (txt_hinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn Phải Upload Hình");
                btn_moHinh.Focus();
                return;
            }
            else
            {
                DTO_HANG hang = new DTO_HANG(txt_tenHang.Text, int.Parse(txt_soLuongHang.Text), float.Parse(txt_giaNhap.Text), float.Parse(txt_giaBan.Text), "\\Images\\" + fileName, txt_ghiChu.Text, cache.mail);
                if (BUS_HANG.insertHang(hang))
                {   
                    MessageBox.Show("Thêm Sản Phẩm Thành Công");
                    File.Copy(fileAddress, fileSavePath, true);
                    ResetValue();
                    LoadGridViewSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm Sản Phẩm Không Thành Công");
                }
            }
        }

        private void btn_suaSanPham_Click(object sender, EventArgs e)
        {
            try {
                int intSoLuong;
                float floatDonGiaNhap;
                float floatDonGiaBan;
                bool isInt = int.TryParse(txt_soLuongHang.Text.Trim().ToString(), out intSoLuong);
                bool isFloatNhap = float.TryParse(txt_giaNhap.Text.Trim().ToString(), out floatDonGiaNhap);
                bool isFloatBan = float.TryParse(txt_giaBan.Text.Trim().ToString(), out floatDonGiaBan);
                if (txt_tenHang.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tên Hàng Không Được Bỏ Trống");
                }
                else if (int.Parse(txt_giaNhap.Text) < 0 || !isFloatNhap)
                {
                    MessageBox.Show("Giá Nhập Không Được Âm");
                }
                else if (int.Parse(txt_giaBan.Text) < 0 || !isFloatBan)
                {
                    MessageBox.Show("Giá Bán Không Được Âm");
                }
                else if (txt_hinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn Phải Upload Hình");
                    btn_moHinh.Focus();
                    return;
                }
                else
                {
                    DTO_HANG hang = new DTO_HANG(txt_tenHang.Text, int.Parse(txt_soLuongHang.Text), float.Parse(txt_giaNhap.Text), float.Parse(txt_giaBan.Text), txt_hinh.Text, txt_ghiChu.Text, cache.mail);
                    MessageBox.Show(cache.mail);
                    if (MessageBox.Show("Bạn Có Chắc Muốn Thay Đổi Dữ Liệu Không", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (BUS_HANG.updateHang(hang))
                        {
                            if (txt_hinh.Text != checkUrlImages)
                            {
                                File.Copy(fileAddress, fileSavePath, true);
                            }
                            MessageBox.Show("Sửa Dữ Liệu Thành Công");
                            LoadGridViewSanPham();
                        }
                        else
                        {
                            MessageBox.Show("Sửa Dữ Liệu Không Thành Công");
                        }
                    }
                    else
                    {
                        ResetValue();
                        LoadGridViewSanPham();
                    }

                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
            if (dgv_SanPham.Rows.Count>1)
            {
                btn_moHinh.Enabled = true;
                btn_luuSanPham.Enabled = false;
                txt_tenHang.Enabled = true;
                txt_soLuongHang.Enabled = true;
                txt_giaNhap.Enabled = true; 
                txt_giaBan.Enabled = true; 
                txt_ghiChu.Enabled = true;
                btn_suaSanPham.Enabled = true;
                btn_xoaSanPham.Enabled = true;
                txt_tenHang.Focus();
                txt_maHang.Text = dgv_SanPham.CurrentRow.Cells[0].Value.ToString();
                txt_tenHang.Text = dgv_SanPham.CurrentRow.Cells[1].Value.ToString();
                txt_soLuongHang.Text = dgv_SanPham.CurrentRow.Cells[2].Value.ToString();
                txt_giaNhap.Text = dgv_SanPham.CurrentRow.Cells[3].Value.ToString();
                txt_giaBan.Text = dgv_SanPham.CurrentRow.Cells[4].Value.ToString();
                txt_hinh.Text = dgv_SanPham.CurrentRow.Cells[5].Value.ToString();
                txt_ghiChu.Text = dgv_SanPham.CurrentRow.Cells[6].Value.ToString();
                checkUrlImages = txt_hinh.Text;
                pic_SanPham.Image = Image.FromFile(saveDirectory + dgv_SanPham.CurrentRow.Cells[5].Value.ToString());
            }
            else
            {
                MessageBox.Show("Bảng Không Có Dữ Liệu");
            }
        }

        private void btn_xoaSanPham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Muốn Xoá Sản Phẩm Này", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BUS_HANG.deleteHang(int.Parse(txt_maHang.Text)))
                {
                    MessageBox.Show("Xoá Dữ Liệu Thành Công");
                    ResetValue();
                    LoadGridViewSanPham();
                }
                else
                {
                    MessageBox.Show("Xoá Dữ Liệu Không Thành Công");
                }
            }
            else
            {
                ResetValue();
                LoadGridViewSanPham();
            }
        }

        private void btn_dongSanPham_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themSanPham_Click(object sender, EventArgs e)
        {
            txt_tenHang.Enabled =true;
            txt_soLuongHang.Enabled = true;
            txt_giaNhap.Enabled = true;
            txt_giaBan.Enabled = true;
            txt_hinh.Enabled = true;
            txt_ghiChu.Enabled = true;
            btn_dongSanPham.Enabled =true;
            btn_xoaSanPham.Enabled = true;
            btn_luuSanPham.Enabled = true;
            btn_suaSanPham.Enabled = true;
        }

        private void btn_timKiemSanPham_Click(object sender, EventArgs e)
        {
            DataTable ds = BUS_HANG.searchHang(txt_tenHang.Text);
            if (ds.Rows.Count > 0)
            {
                dgv_SanPham.DataSource = ds;
                dgv_SanPham.Columns[0].HeaderText = "Mã Hàng";
                dgv_SanPham.Columns[1].HeaderText = "Tên Hàng";
                dgv_SanPham.Columns[2].HeaderText = "Số Lượng";
                dgv_SanPham.Columns[3].HeaderText = "Giá Nhập";
                dgv_SanPham.Columns[4].HeaderText = "Giá Bán";
                dgv_SanPham.Columns[5].HeaderText = "Hình";
                dgv_SanPham.Columns[6].HeaderText = "Ghi Chú";
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Kết Quả");
            }
            txt_timKiemSanPham.Text = "Nhập Tên Nhân Viên";
            txt_timKiemSanPham.BackColor = Color.White;
        }

        private void btn_boQuaSanPham_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridViewSanPham();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridViewSanPham();
        }

        private void btn_danhSachSanPham_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadGridViewSanPham();
        }

        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
