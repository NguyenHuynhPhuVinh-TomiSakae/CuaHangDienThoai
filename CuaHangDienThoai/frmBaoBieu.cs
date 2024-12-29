using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace CuaHangDienThoai
{
    public partial class frmBaoBieu : Form
    {
        string connectionString = @"Data Source=TOMISAKAE;Initial Catalog=CHDT;Integrated Security=True";

        public frmBaoBieu()
        {
            InitializeComponent();
        }

        private void frmBaoBieu_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataToComboBox();
        }

        private void LoadData()
        {
            // Tạo kết nối
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo câu truy vấn
                    string query = "SELECT * FROM SanPham";

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Tạo đối tượng SqlDataAdapter
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Tạo DataTable để chứa dữ liệu
                            DataTable dataTable = new DataTable();

                            // Đổ dữ liệu vào DataTable
                            adapter.Fill(dataTable);

                            // Hiển thị dữ liệu lên DataGridView
                            dgvSanPham.Rows.Clear();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                dgvSanPham.Rows.Add(
                                    row["MaSanPham"],
                                    row["MaHang"],
                                    row["TenSanPham"],
                                    row["MoTa"],
                                    row["GiaBan"],
                                    row["SoLuongTonKho"],
                                    row["MauSac"],
                                    row["DungLuong"],
                                    row["HeDieuHanh"],
                                    row["KichThuocManHinh"]
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void LoadDataToComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaHang, TenHang FROM HangSanXuat";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            cboMaHang.DataSource = dataTable;
                            cboMaHang.DisplayMember = "TenHang";
                            cboMaHang.ValueMember = "MaHang";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM SanPham WHERE MaHang = @MaHang";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaHang", cboMaHang.SelectedValue);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgvSanPham.Rows.Clear();
                            foreach (DataRow row in dataTable.Rows)
                            {
                                dgvSanPham.Rows.Add(
                                    row["MaSanPham"],
                                    row["MaHang"],
                                    row["TenSanPham"],
                                    row["MoTa"],
                                    row["GiaBan"],
                                    row["SoLuongTonKho"],
                                    row["MauSac"],
                                    row["DungLuong"],
                                    row["HeDieuHanh"],
                                    row["KichThuocManHinh"]
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create a bitmap of the DataGridView
            Bitmap bitmap = new Bitmap(dgvSanPham.Width, dgvSanPham.Height);
            dgvSanPham.DrawToBitmap(bitmap, new Rectangle(0, 0, dgvSanPham.Width, dgvSanPham.Height));


            // Calculate the print area
            Rectangle printArea = e.MarginBounds;

            // Calculate the aspect ratio of the DataGridView and the print area
            float gridAspectRatio = (float)dgvSanPham.Width / dgvSanPham.Height;
            float printAspectRatio = (float)printArea.Width / printArea.Height;

            // Calculate the size of the image to fit the print area while maintaining aspect ratio
            float imageWidth, imageHeight;
            if (gridAspectRatio > printAspectRatio)
            {
                imageWidth = printArea.Width;
                imageHeight = printArea.Width / gridAspectRatio;
            }
            else
            {
                imageHeight = printArea.Height;
                imageWidth = printArea.Height * gridAspectRatio;
            }

            // Calculate the position to center the image in the print area
            float x = printArea.Left + (printArea.Width - imageWidth) / 2;
            float y = printArea.Top + (printArea.Height - imageHeight) / 2;

            // Draw the bitmap onto the print page
            e.Graphics.DrawImage(bitmap, x, y, imageWidth, imageHeight);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
            cboMaHang.SelectedIndex = -1; // Đặt lại combobox về trạng thái không chọn
        }
    }
}