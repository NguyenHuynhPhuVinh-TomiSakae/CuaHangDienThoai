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
    public partial class TraCuuSanPham : Form
    {
        public TraCuuSanPham()
        {
            InitializeComponent();
        }

        private void sanPhamBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanPhamBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHDTDataSet);

        }

        private void TraCuuSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHDTDataSet.SanPham' table. You can move, or remove it, as needed.
            this.sanPhamTableAdapter.Fill(this.cHDTDataSet.SanPham);

        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_masp.Text = "";
            txt_tensp.Text = "";
            txt_masp.Focus();
        }

        private void btn_timtheoma_Click(object sender, EventArgs e)
        {
            sanPhamBindingSource.Filter = $"MaSanPham = '{txt_masp.Text}'";

        }

        private void btn_timtheoten_Click(object sender, EventArgs e)
        {
            sanPhamBindingSource.Filter = $"TenSanPham LIKE '%{txt_tensp.Text}%'";
        }
    }
}
