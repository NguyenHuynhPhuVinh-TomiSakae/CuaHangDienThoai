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
    public partial class QuanLyHangSanXuat : Form
    {
        public QuanLyHangSanXuat()
        {
            InitializeComponent();
        }

        private void hangSanXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hangSanXuatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cHDTDataSet);

        }

        private void QuanLyHangSanXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cHDTDataSet.HangSanXuat' table. You can move, or remove it, as needed.
            this.hangSanXuatTableAdapter.Fill(this.cHDTDataSet.HangSanXuat);

        }
    }
}
