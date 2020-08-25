using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class MHTrangChu : Form
    {
        public MHTrangChu()
        {
            InitializeComponent();
        }

        private void MHTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHQuanLyMatHang qlmh = new MHQuanLyMatHang();
            qlmh.StartPosition = FormStartPosition.CenterScreen;
            qlmh.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHQuanLyNV qlnv = new MHQuanLyNV();
            qlnv.StartPosition = FormStartPosition.CenterScreen;
            qlnv.Show();
        }

        private void quảnLýNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHQuanLyNCC qlncc = new MHQuanLyNCC();
            qlncc.StartPosition = FormStartPosition.CenterScreen;
            qlncc.Show();
        }

        private void cOMMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHXuLyComment cmt = new MHXuLyComment();
            cmt.StartPosition = FormStartPosition.CenterScreen;
            cmt.Show();
        }

        private void gIAOHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHDonGiaoHang dgh = new MHDonGiaoHang();
            dgh.StartPosition = FormStartPosition.CenterScreen;
            dgh.Show();
        }

        private void tHANHTOÁNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHThanhToan tt = new MHThanhToan();
            tt.StartPosition = FormStartPosition.CenterScreen;
            tt.Show();
        }
    }
}
