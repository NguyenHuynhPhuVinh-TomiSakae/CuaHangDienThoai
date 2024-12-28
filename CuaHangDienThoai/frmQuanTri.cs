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
    public partial class frmQuanTri : Form
    {
        public string IsAdmin { get; set; } // Hoặc public bool IsAdmin { get; set; }

        // Constructor mặc định (không tham số)
        public frmQuanTri()
        {
            InitializeComponent();
            menuStrip1.Renderer = new CustomRenderer();
        }

        // Constructor có tham số để nhận giá trị IsAdmin
        public frmQuanTri(string isAdmin)
        {
            InitializeComponent();
            menuStrip1.Renderer = new CustomRenderer();
            this.IsAdmin = isAdmin; // Hoặc this.IsAdmin = (isAdmin == "admin"); nếu bạn dùng kiểu bool
        }

        private void frmQuanTri_Load(object sender, EventArgs e)
        {
            // Ẩn/hiện các menu dựa trên quyền admin
            if (IsAdmin == "admin")
            {
                quảnLýToolStripMenuItem.Visible = true;
                traCứuToolStripMenuItem.Visible = true;
            }
            else
            {
                // Nếu không phải admin thì có thể ẩn hết menu hoặc chỉ để lại 1 số menu tra cứu cơ bản
                quảnLýToolStripMenuItem.Visible = false;
                traCứuToolStripMenuItem.Visible = true;
                traCứuSảnPhẩmToolStripMenuItem.Visible = true;
            }

            // Hiển thị hướng dẫn sử dụng
            txtHuongDan.Text = GetHuongDanSuDung();
            txtHuongDan.ReadOnly = true; // Không cho phép chỉnh sửa
            txtHuongDan.Multiline = true;
            txtHuongDan.ScrollBars = ScrollBars.Vertical;
            txtHuongDan.Dock = DockStyle.Fill;
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở form quản lý sản phẩm
            //frmQLSanPham frm = new frmQLSanPham();
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();
        }

        // Phương thức tạo nội dung hướng dẫn sử dụng
        private string GetHuongDanSuDung()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("HƯỚNG DẪN SỬ DỤNG PHẦN MỀM QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI");
            sb.AppendLine("");

            sb.AppendLine("I. Đăng nhập:");
            sb.AppendLine("- Nhập tên đăng nhập và mật khẩu vào các ô tương ứng.");
            sb.AppendLine("- Nhấn nút \"Đăng nhập\".");
            sb.AppendLine("");

            sb.AppendLine("II. Quản lý:");
            sb.AppendLine("    1. Sản phẩm:");
            sb.AppendLine("    - Thêm mới sản phẩm: Nhấn vào menu \"Quản lý\" -> \"Sản phẩm\", chọn \"Thêm mới\". Nhập đầy đủ thông tin sản phẩm và nhấn \"Lưu\".");
            sb.AppendLine("    - Sửa thông tin sản phẩm: Chọn sản phẩm cần sửa, thay đổi thông tin và nhấn \"Lưu\".");
            sb.AppendLine("    - Xóa sản phẩm: Chọn sản phẩm cần xóa và nhấn \"Xóa\".");
            sb.AppendLine("    - Tìm kiếm sản phẩm: Nhập từ khóa vào ô tìm kiếm và nhấn \"Tìm kiếm\".");
            sb.AppendLine("");

            sb.AppendLine("    2. Nhân viên:");
            sb.AppendLine("    - (Tương tự như quản lý sản phẩm, bạn có thể thêm hướng dẫn cho các chức năng thêm, sửa, xóa, tìm kiếm nhân viên)");
            sb.AppendLine("");

            sb.AppendLine("    3. Khách hàng:");
            sb.AppendLine("    - (Tương tự như quản lý sản phẩm)");
            sb.AppendLine("");

            sb.AppendLine("    4. Tài khoản:");
            sb.AppendLine("    - (Tương tự như quản lý sản phẩm)");
            sb.AppendLine("");

            sb.AppendLine("    5. Nhà cung cấp:");
            sb.AppendLine("    - (Tương tự như quản lý sản phẩm)");
            sb.AppendLine("");

            sb.AppendLine("III. Tra cứu:");
            sb.AppendLine("    - Nhấn vào menu \"Tra cứu\" và chọn loại thông tin cần tra cứu (Sản phẩm, Nhân viên, Khách hàng, Tài khoản).");
            sb.AppendLine("    - Nhập từ khóa tìm kiếm và nhấn \"Tìm kiếm\".");
            sb.AppendLine("");

            sb.AppendLine("IV. Thoát:");
            sb.AppendLine("    - Để thoát khỏi chương trình, nhấn nút \"Đóng\" (dấu X ở góc trên bên phải).");
            sb.AppendLine("");

            sb.AppendLine("Lưu ý:");
            sb.AppendLine("- Các chức năng quản lý (thêm, sửa, xóa) chỉ dành cho tài khoản admin.");
            sb.AppendLine("- Vui lòng liên hệ quản trị viên nếu bạn gặp bất kỳ vấn đề nào trong quá trình sử dụng.");

            string markdownText = sb.ToString();

            return sb.ToString();
        }
    }
}