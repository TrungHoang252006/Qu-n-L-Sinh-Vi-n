namespace Quản_Lý_Sinh_Viên
{
    partial class FormLop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            label1 = new Label();
            lblTitle = new Label();
            grpThongTin = new GroupBox();
            cboKhoa = new ComboBox();
            txtMaNganh = new TextBox();
            txtTenLop = new TextBox();
            txtKhoaHoc = new TextBox();
            txtMaLop = new TextBox();
            lblMaNganh = new Label();
            lblTenLop = new Label();
            lblKhoaHoc = new Label();
            lblKhoa = new Label();
            lblMaLop = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblDanhSach = new Label();
            dgvLop = new DataGridView();
            colMaLop = new DataGridViewTextBoxColumn();
            colTenLop = new DataGridViewTextBoxColumn();
            colKhoa = new DataGridViewTextBoxColumn();
            colMaNganh = new DataGridViewTextBoxColumn();
            colKhoaHoc = new DataGridViewTextBoxColumn();
            txtTimKiem = new TextBox();
            pnlHeader.SuspendLayout();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DodgerBlue;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1161, 144);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(102, 60);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 1;
            label1.Text = "Hệ thống quản lý sinh viên";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(100, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(cboKhoa);
            grpThongTin.Controls.Add(txtMaNganh);
            grpThongTin.Controls.Add(txtTenLop);
            grpThongTin.Controls.Add(txtKhoaHoc);
            grpThongTin.Controls.Add(txtMaLop);
            grpThongTin.Controls.Add(lblMaNganh);
            grpThongTin.Controls.Add(lblTenLop);
            grpThongTin.Controls.Add(lblKhoaHoc);
            grpThongTin.Controls.Add(lblKhoa);
            grpThongTin.Controls.Add(lblMaLop);
            grpThongTin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpThongTin.ForeColor = SystemColors.Highlight;
            grpThongTin.Location = new Point(9, 171);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1129, 230);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin lớp học";
            // 
            // cboKhoa
            // 
            cboKhoa.BackColor = Color.White;
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboKhoa.ForeColor = Color.Black;
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(149, 101);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(312, 31);
            cboKhoa.TabIndex = 9;
            // 
            // txtMaNganh
            // 
            txtMaNganh.BackColor = Color.White;
            txtMaNganh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaNganh.ForeColor = Color.Black;
            txtMaNganh.Location = new Point(771, 101);
            txtMaNganh.Name = "txtMaNganh";
            txtMaNganh.Size = new Size(323, 30);
            txtMaNganh.TabIndex = 8;
            // 
            // txtTenLop
            // 
            txtTenLop.BackColor = Color.White;
            txtTenLop.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenLop.ForeColor = Color.Black;
            txtTenLop.Location = new Point(771, 33);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(323, 30);
            txtTenLop.TabIndex = 7;
            // 
            // txtKhoaHoc
            // 
            txtKhoaHoc.BackColor = Color.White;
            txtKhoaHoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKhoaHoc.ForeColor = Color.Black;
            txtKhoaHoc.Location = new Point(149, 173);
            txtKhoaHoc.Name = "txtKhoaHoc";
            txtKhoaHoc.Size = new Size(312, 30);
            txtKhoaHoc.TabIndex = 6;
            // 
            // txtMaLop
            // 
            txtMaLop.BackColor = Color.White;
            txtMaLop.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaLop.ForeColor = Color.Black;
            txtMaLop.Location = new Point(149, 39);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(312, 30);
            txtMaLop.TabIndex = 5;
            // 
            // lblMaNganh
            // 
            lblMaNganh.AutoSize = true;
            lblMaNganh.ForeColor = Color.Black;
            lblMaNganh.Location = new Point(656, 109);
            lblMaNganh.Name = "lblMaNganh";
            lblMaNganh.Size = new Size(98, 25);
            lblMaNganh.TabIndex = 4;
            lblMaNganh.Text = "Mã ngành";
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.ForeColor = Color.Black;
            lblTenLop.Location = new Point(656, 39);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(74, 25);
            lblTenLop.TabIndex = 3;
            lblTenLop.Text = "Tên lớp";
            // 
            // lblKhoaHoc
            // 
            lblKhoaHoc.AutoSize = true;
            lblKhoaHoc.ForeColor = Color.Black;
            lblKhoaHoc.Location = new Point(23, 179);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new Size(92, 25);
            lblKhoaHoc.TabIndex = 2;
            lblKhoaHoc.Text = "Khóa học";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.ForeColor = Color.Black;
            lblKhoa.Location = new Point(23, 109);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(56, 25);
            lblKhoa.TabIndex = 1;
            lblKhoa.Text = "Khoa";
            lblKhoa.Click += label3_Click;
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.ForeColor = Color.Black;
            lblMaLop.Location = new Point(23, 39);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(71, 25);
            lblMaLop.TabIndex = 0;
            lblMaLop.Text = "Mã lớp";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.DarkBlue;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(9, 418);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 42);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.DarkBlue;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(171, 418);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(140, 42);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.DarkBlue;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(330, 418);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 42);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.White;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.ForeColor = Color.DarkBlue;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(489, 418);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(140, 42);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSach.ForeColor = SystemColors.Highlight;
            lblDanhSach.Location = new Point(9, 473);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(132, 25);
            lblDanhSach.TabIndex = 6;
            lblDanhSach.Text = "Danh sách lớp";
            // 
            // dgvLop
            // 
            dgvLop.AllowUserToAddRows = false;
            dgvLop.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLop.BackgroundColor = Color.White;
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Columns.AddRange(new DataGridViewColumn[] { colMaLop, colTenLop, colKhoa, colMaNganh, colKhoaHoc });
            dgvLop.EnableHeadersVisualStyles = false;
            dgvLop.Location = new Point(13, 501);
            dgvLop.MultiSelect = false;
            dgvLop.Name = "dgvLop";
            dgvLop.ReadOnly = true;
            dgvLop.RowHeadersVisible = false;
            dgvLop.RowHeadersWidth = 51;
            dgvLop.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLop.Size = new Size(1125, 223);
            dgvLop.TabIndex = 7;
            // 
            // colMaLop
            // 
            colMaLop.HeaderText = "Mã lớp";
            colMaLop.MinimumWidth = 6;
            colMaLop.Name = "colMaLop";
            colMaLop.ReadOnly = true;
            // 
            // colTenLop
            // 
            colTenLop.HeaderText = "Tên lớp";
            colTenLop.MinimumWidth = 6;
            colTenLop.Name = "colTenLop";
            colTenLop.ReadOnly = true;
            // 
            // colKhoa
            // 
            colKhoa.HeaderText = "Khoa";
            colKhoa.MinimumWidth = 6;
            colKhoa.Name = "colKhoa";
            colKhoa.ReadOnly = true;
            // 
            // colMaNganh
            // 
            colMaNganh.HeaderText = "Mã ngành";
            colMaNganh.MinimumWidth = 6;
            colMaNganh.Name = "colMaNganh";
            colMaNganh.ReadOnly = true;
            // 
            // colKhoaHoc
            // 
            colKhoaHoc.HeaderText = "Khóa học";
            colKhoaHoc.MinimumWidth = 6;
            colKhoaHoc.Name = "colKhoaHoc";
            colKhoaHoc.ReadOnly = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Location = new Point(843, 425);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm mã lớp, tên lớp...";
            txtTimKiem.Size = new Size(260, 30);
            txtTimKiem.TabIndex = 8;
            // 
            // FormLop
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1161, 728);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvLop);
            Controls.Add(lblDanhSach);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpThongTin);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            MinimumSize = new Size(900, 600);
            Name = "FormLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý lớp học";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label lblTitle;
        private GroupBox grpThongTin;
        private ComboBox cboKhoa;
        private TextBox txtMaNganh;
        private TextBox txtTenLop;
        private TextBox txtKhoaHoc;
        private TextBox txtMaLop;
        private Label lblMaNganh;
        private Label lblTenLop;
        private Label lblKhoaHoc;
        private Label lblKhoa;
        private Label lblMaLop;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblDanhSach;
        private DataGridView dgvLop;
        private DataGridViewTextBoxColumn colMaLop;
        private DataGridViewTextBoxColumn colTenLop;
        private DataGridViewTextBoxColumn colKhoa;
        private DataGridViewTextBoxColumn colMaNganh;
        private DataGridViewTextBoxColumn colKhoaHoc;
        private TextBox txtTimKiem;
    }
}
