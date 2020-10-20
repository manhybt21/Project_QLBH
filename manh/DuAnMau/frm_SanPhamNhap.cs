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
    public partial class frm_SanPhamNhap : Form
    {
        public frm_SanPhamNhap()
        {
            InitializeComponent();
        }

        public void LoadGridView()
        {
            dgv_SanPhamNhap.DataSource = BUS.BUS_HANG.ThongKeHang();
        }

        private void frm_SanPhamNhap_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
    }
}
