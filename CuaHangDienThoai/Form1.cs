using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienThoai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void qUẢNLÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySanPham frm = new QuanLySanPham();
            frm.Show();
        }

        private void tRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraCuuSanPham frm = new TraCuuSanPham();
            frm.Show();
        }

        private void gIỚITHIỆUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GioiThieu frm = new GioiThieu();
            frm.Show();
        }
    }
}
