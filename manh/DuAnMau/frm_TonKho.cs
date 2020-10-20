using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace DuAnMau
{
    public partial class frm_TonKho : Form
    {
        public frm_TonKho()
        {
            InitializeComponent();
        }
        public void LoadGridView()
        {
            dgv_TonKho.DataSource = BUS_HANG.ThongKeTonKho();
        }

        private void frm_TonKho_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }
    }
}
