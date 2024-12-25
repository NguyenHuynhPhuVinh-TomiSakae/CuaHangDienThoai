namespace CuaHangDienThoai
{
    partial class QuanLyHangSanXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHangSanXuat));
            System.Windows.Forms.Label maHangLabel;
            System.Windows.Forms.Label tenHangLabel;
            this.cHDTDataSet = new CuaHangDienThoai.CHDTDataSet();
            this.hangSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangSanXuatTableAdapter = new CuaHangDienThoai.CHDTDataSetTableAdapters.HangSanXuatTableAdapter();
            this.tableAdapterManager = new CuaHangDienThoai.CHDTDataSetTableAdapters.TableAdapterManager();
            this.hangSanXuatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hangSanXuatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hangSanXuatDataGridView = new System.Windows.Forms.DataGridView();
            this.maHangTextBox = new System.Windows.Forms.TextBox();
            this.tenHangTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maHangLabel = new System.Windows.Forms.Label();
            tenHangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cHDTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingNavigator)).BeginInit();
            this.hangSanXuatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cHDTDataSet
            // 
            this.cHDTDataSet.DataSetName = "CHDTDataSet";
            this.cHDTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangSanXuatBindingSource
            // 
            this.hangSanXuatBindingSource.DataMember = "HangSanXuat";
            this.hangSanXuatBindingSource.DataSource = this.cHDTDataSet;
            // 
            // hangSanXuatTableAdapter
            // 
            this.hangSanXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietHoaDonTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuNhapTableAdapter = null;
            this.tableAdapterManager.CungCapTableAdapter = null;
            this.tableAdapterManager.HangSanXuatTableAdapter = this.hangSanXuatTableAdapter;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhaCungCapTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.SanPhamTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CuaHangDienThoai.CHDTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hangSanXuatBindingNavigator
            // 
            this.hangSanXuatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hangSanXuatBindingNavigator.BindingSource = this.hangSanXuatBindingSource;
            this.hangSanXuatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hangSanXuatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hangSanXuatBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hangSanXuatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hangSanXuatBindingNavigatorSaveItem});
            this.hangSanXuatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hangSanXuatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hangSanXuatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hangSanXuatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hangSanXuatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hangSanXuatBindingNavigator.Name = "hangSanXuatBindingNavigator";
            this.hangSanXuatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hangSanXuatBindingNavigator.Size = new System.Drawing.Size(333, 31);
            this.hangSanXuatBindingNavigator.TabIndex = 0;
            this.hangSanXuatBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // hangSanXuatBindingNavigatorSaveItem
            // 
            this.hangSanXuatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hangSanXuatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hangSanXuatBindingNavigatorSaveItem.Image")));
            this.hangSanXuatBindingNavigatorSaveItem.Name = "hangSanXuatBindingNavigatorSaveItem";
            this.hangSanXuatBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.hangSanXuatBindingNavigatorSaveItem.Text = "Save Data";
            this.hangSanXuatBindingNavigatorSaveItem.Click += new System.EventHandler(this.hangSanXuatBindingNavigatorSaveItem_Click);
            // 
            // hangSanXuatDataGridView
            // 
            this.hangSanXuatDataGridView.AllowUserToAddRows = false;
            this.hangSanXuatDataGridView.AllowUserToDeleteRows = false;
            this.hangSanXuatDataGridView.AutoGenerateColumns = false;
            this.hangSanXuatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hangSanXuatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.hangSanXuatDataGridView.DataSource = this.hangSanXuatBindingSource;
            this.hangSanXuatDataGridView.Location = new System.Drawing.Point(12, 119);
            this.hangSanXuatDataGridView.Name = "hangSanXuatDataGridView";
            this.hangSanXuatDataGridView.ReadOnly = true;
            this.hangSanXuatDataGridView.RowHeadersWidth = 51;
            this.hangSanXuatDataGridView.RowTemplate.Height = 24;
            this.hangSanXuatDataGridView.Size = new System.Drawing.Size(309, 220);
            this.hangSanXuatDataGridView.TabIndex = 1;
            // 
            // maHangLabel
            // 
            maHangLabel.AutoSize = true;
            maHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maHangLabel.Location = new System.Drawing.Point(20, 47);
            maHangLabel.Name = "maHangLabel";
            maHangLabel.Size = new System.Drawing.Size(98, 25);
            maHangLabel.TabIndex = 2;
            maHangLabel.Text = "Mã Hãng:";
            // 
            // maHangTextBox
            // 
            this.maHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangSanXuatBindingSource, "MaHang", true));
            this.maHangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maHangTextBox.Location = new System.Drawing.Point(126, 47);
            this.maHangTextBox.Name = "maHangTextBox";
            this.maHangTextBox.Size = new System.Drawing.Size(186, 30);
            this.maHangTextBox.TabIndex = 3;
            // 
            // tenHangLabel
            // 
            tenHangLabel.AutoSize = true;
            tenHangLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenHangLabel.Location = new System.Drawing.Point(13, 86);
            tenHangLabel.Name = "tenHangLabel";
            tenHangLabel.Size = new System.Drawing.Size(105, 25);
            tenHangLabel.TabIndex = 4;
            tenHangLabel.Text = "Tên Hãng:";
            // 
            // tenHangTextBox
            // 
            this.tenHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangSanXuatBindingSource, "TenHang", true));
            this.tenHangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenHangTextBox.Location = new System.Drawing.Point(126, 83);
            this.tenHangTextBox.Name = "tenHangTextBox";
            this.tenHangTextBox.Size = new System.Drawing.Size(186, 30);
            this.tenHangTextBox.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Hãng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Hãng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // QuanLyHangSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 349);
            this.Controls.Add(maHangLabel);
            this.Controls.Add(this.maHangTextBox);
            this.Controls.Add(tenHangLabel);
            this.Controls.Add(this.tenHangTextBox);
            this.Controls.Add(this.hangSanXuatDataGridView);
            this.Controls.Add(this.hangSanXuatBindingNavigator);
            this.Name = "QuanLyHangSanXuat";
            this.Text = "QuanLyHangSanXuat";
            this.Load += new System.EventHandler(this.QuanLyHangSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cHDTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingNavigator)).EndInit();
            this.hangSanXuatBindingNavigator.ResumeLayout(false);
            this.hangSanXuatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CHDTDataSet cHDTDataSet;
        private System.Windows.Forms.BindingSource hangSanXuatBindingSource;
        private CHDTDataSetTableAdapters.HangSanXuatTableAdapter hangSanXuatTableAdapter;
        private CHDTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hangSanXuatBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hangSanXuatBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hangSanXuatDataGridView;
        private System.Windows.Forms.TextBox maHangTextBox;
        private System.Windows.Forms.TextBox tenHangTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}