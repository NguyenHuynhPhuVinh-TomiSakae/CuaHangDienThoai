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
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void sanPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHDTDataSet);

        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHDTDataSet.HangSanXuat' table. You can move, or remove it, as needed.
            this.hangSanXuatTableAdapter.Fill(this.cHDTDataSet.HangSanXuat);
            // TODO: This line of code loads data into the 'cHDTDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.cHDTDataSet.SanPham);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyHangSanXuat frm = new QuanLyHangSanXuat();
            frm.ShowDialog();
            
        }
    }
}
