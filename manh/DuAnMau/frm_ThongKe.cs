using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAnMau
{
    public partial class frm_ThongKe : Form
    {
        public frm_ThongKe()
        {
            InitializeComponent();
        }
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
        private void sảnPhẩmNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SanPhamNhap spn = new frm_SanPhamNhap();
            if (!CheckExitsFrom("frm_SanPhamNhap"))
            {
                spn.MdiParent = this;
                spn.Show();
            }
            else
            {
                ActiveChildFrom("frm_SanPhamNhap");
            }     
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TonKho tk = new frm_TonKho();
            if (!CheckExitsFrom("frm_TonKho"))
            {
                tk.MdiParent = this;
                tk.Show();
            }
            else
            {
                ActiveChildFrom("frm_TonKho");
            }
            
        }
    }
}
