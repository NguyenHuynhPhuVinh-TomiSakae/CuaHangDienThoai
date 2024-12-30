namespace CuaHangDienThoai
{
    partial class frmThanhToanHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các biến controls
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap; 
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiDonHang;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Button btnThanhToan;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            
            // Panel tiêu đề
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "THANH TOÁN HÓA ĐƠN";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Size = new System.Drawing.Size(400, 54);
            
            this.panel1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Height = 85;
            
            // DataGridView hiển thị danh sách hóa đơn
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(46, 51, 73);
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 100);
            this.dgvHoaDon.Size = new System.Drawing.Size(750, 550);
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            
            // Cột cho DataGridView
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon.HeaderText = "Mã hóa đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Width = 120;

            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 100;

            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang.HeaderText = "Khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 200;

            this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhanVien.HeaderText = "Nhân viên";
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Width = 200;

            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 120;

            this.PhuongThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongThucThanhToan.HeaderText = "Phương thức TT";
            this.PhuongThucThanhToan.Name = "PhuongThucThanhToan";
            this.PhuongThucThanhToan.Width = 150;

            this.TrangThaiDonHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDonHang.HeaderText = "Trạng thái";
            this.TrangThaiDonHang.Name = "TrangThaiDonHang";
            this.TrangThaiDonHang.Width = 120;
            
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.MaHoaDon,
                this.NgayLap,
                this.TenKhachHang,
                this.TenNhanVien,
                this.TongTien,
                this.PhuongThucThanhToan,
                this.TrangThaiDonHang
            });
            
            // Panel thông tin thanh toán
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            this.panel2.Location = new System.Drawing.Point(780, 100);
            this.panel2.Size = new System.Drawing.Size(400, 550);
            
            // Label và TextBox Mã hóa đơn
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            this.lblMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaHoaDon.ForeColor = System.Drawing.Color.White;
            this.lblMaHoaDon.Location = new System.Drawing.Point(20, 30);
            this.lblMaHoaDon.Size = new System.Drawing.Size(150, 30);
            
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon.Location = new System.Drawing.Point(180, 30);
            this.txtMaHoaDon.Size = new System.Drawing.Size(200, 30);
            this.txtMaHoaDon.ReadOnly = true;
            
            // Label và TextBox Tổng tiền
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongTien.Text = "Tổng tiền";
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.White;
            this.lblTongTien.Location = new System.Drawing.Point(20, 80);
            this.lblTongTien.Size = new System.Drawing.Size(150, 30);
            
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTongTien.Location = new System.Drawing.Point(180, 80);
            this.txtTongTien.Size = new System.Drawing.Size(200, 30);
            this.txtTongTien.ReadOnly = true;
            
            // Label và ComboBox Phương thức thanh toán
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.lblPhuongThuc.Text = "Phương thức thanh toán";
            this.lblPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhuongThuc.ForeColor = System.Drawing.Color.White;
            this.lblPhuongThuc.Location = new System.Drawing.Point(20, 130);
            this.lblPhuongThuc.Size = new System.Drawing.Size(150, 30);
            
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.cboPhuongThuc.Location = new System.Drawing.Point(180, 130);
            this.cboPhuongThuc.Size = new System.Drawing.Size(200, 30);
            
            // Button Thanh toán
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.Location = new System.Drawing.Point(180, 180);
            this.btnThanhToan.Size = new System.Drawing.Size(200, 40);
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            
            // Thêm controls vào panel2
            this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaHoaDon,
                this.txtMaHoaDon,
                this.lblTongTien,
                this.txtTongTien,
                this.lblPhuongThuc,
                this.cboPhuongThuc,
                this.btnThanhToan
            });
            
            // Thiết lập form
            this.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panel1,
                this.dgvHoaDon,
                this.panel2
            });
            
            this.Text = "Thanh Toán Hóa Đơn";
            this.Size = new System.Drawing.Size(1200, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        }

        #endregion
    }
}