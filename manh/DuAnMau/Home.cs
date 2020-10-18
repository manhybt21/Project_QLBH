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
using BUS;
namespace DuAnMau

{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //public static int session = 0;
        //public static int profile = 0;
        //public static string mail;

        frm_DangNhap dn;
        frm_DoiMatKhau dmk;
        frm_KhachHang kh;
        frm_NhanVien nv;
        frm_SanPham sp;
        frm_ThongKe tk;
        private bool CheckExitsFrom(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildFrom(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void VaiTroNV()
        {
            nhânViênToolStripMenuItem.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dn = new frm_DangNhap();
                if (!CheckExitsFrom("frm_DangNhap"))
                {
                    dn.MdiParent = this;
                    dn.Show();
                    dn.FormClosed += new FormClosedEventHandler(FrmDangNhap_FromClose);
                }
                else
                {
                    ActiveChildFrom("frm_DangNhap");
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
        private void resetValue()
        {
            if (cache.session == 1)
            {
                lbl_emailNv.Text = "Chào " + cache.mail;
                danhMụcToolStripMenuItem.Visible = true;
                thoátToolStripMenuItem.Enabled = true;//enable = true hien
                danhMụcToolStripMenuItem.Enabled = true;
                nhânViênToolStripMenuItem.Visible = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                kháchHàngToolStripMenuItem.Enabled = true;
                nhânViênToolStripMenuItem.Enabled = true;
                thốngKêToolStripMenuItem.Enabled = true;
                if (int.Parse(dn.vaitro) == 0)
                {
                    VaiTroNV();
                }
            }
            else
            {
                nhânViênToolStripMenuItem.Visible = false;
                danhMụcToolStripMenuItem.Enabled = false;
                thoátToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
            }
        } 
        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try {
            //    var path = Path.Combine(Directory.GetCurrentDirectory(), "Tai lieu huong dan su dung phan mem");
            //    System.Diagnostics.Process.Start(path);
            //}
            //catch(FileNotFoundException)
            //{
            //    MessageBox.Show("The file not found in the specified location");
            //}
        }

        private void quênMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dmk = new frm_DoiMatKhau();
            if (!CheckExitsFrom("frm_DoiMatKhau"))
            {
                dmk.MdiParent = this;
                dmk.Show();
            }
            else
            {
                ActiveChildFrom("frm_DoiMatKhau");
            }
        }
        private void thốngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tk = new frm_ThongKe();
            if (!CheckExitsFrom("frm_ThongKe"))
            {
                tk.MdiParent = this;
                tk.Show();
            }
            else
            {
                ActiveChildFrom("frm_ThongKe");
            }
        }

        public void FrmDangNhap_FromClose(object sender,FormClosedEventArgs e)
        {
            this.Refresh();
            Home_Load(sender, e);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            resetValue();
            if (cache.profile == 1)
            {
                lbl_emailNv.Text = null;
                cache.profile = 0;
            }
        }

        
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sp = new frm_SanPham();
            if (!CheckExitsFrom("frm_SanPham"))
            {
                sp.MdiParent = this;
                sp.Show();
            }
            else
            {
                ActiveChildFrom("frm_SanPham");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nv = new frm_NhanVien();
            if (!CheckExitsFrom("frm_NhanVien"))
            {
                nv.MdiParent = this;
                nv.Show();
            }
            else
            {
                ActiveChildFrom("frm_NhanVien");
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kh = new frm_KhachHang();
            if (!CheckExitsFrom("frm_KhachHang"))
            {
                kh.MdiParent = this;
                kh.Show();
            }
            else
            {
                ActiveChildFrom("frm_KhachHang");
            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information)== DialogResult.Yes)
            Application.Exit();
        }

        private void proFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsFrom("frm_DoiMatKhau"))
            { 
            //    frm_DoiMatKhau profileNv = new frm_DoiMatKhau(dn.email);
            }
        }
    }
}
