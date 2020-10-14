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

        private void sảnPhẩmNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SanPhamNhap spn = new frm_SanPhamNhap();
            spn.Show();
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TonKho tk = new frm_TonKho();
            tk.Show();
        }
    }
}
