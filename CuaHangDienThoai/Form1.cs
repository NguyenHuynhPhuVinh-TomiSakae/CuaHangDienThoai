using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuaHangDienThoai
{    
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=TOMISAKAE;Initial Catalog=CHDT;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm vẽ bo tròn cho form
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Độ bo tròn
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top left
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top right
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom right
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom left
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "   Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "   Tên đăng nhập";
                txtUsername.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "   Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true; // Ẩn ký tự khi bắt đầu nhập
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "   Mật khẩu";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = false; // Không ẩn ký tự khi không có gì
            }
        }

        // Hàm vẽ bo tròn cho Panel
        private void RoundedPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            GraphicsPath path = new GraphicsPath();
            int radius = 10; // Độ bo tròn cho panel
            Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top left
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Top right
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90); // Bottom right
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90); // Bottom left
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        // Override để loại bỏ border mặc định khi form có bo tròn
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000; // CS_NOCLOSE
                return cp;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenTaiKhoan", txtUsername.Text);
                        command.Parameters.AddWithValue("@MatKhau", txtPassword.Text);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string role = result.ToString();
                            frmQuanTri frm = new frmQuanTri(role);
                            this.Hide();
                            frm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}