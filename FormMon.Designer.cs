namespace Quản_Lý_Sinh_Viên
{
    partial class FormMon
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            grbThongTin = new GroupBox();
            lblMaMonHoc = new Label();
            lblTenMonHoc = new Label();
            lblSoTinChi = new Label();
            txtMaMonHoc = new TextBox();
            txtTenMonHoc = new TextBox();
            numSoTinChi = new NumericUpDown();
            lblMonHoc = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            dgvMonHoc = new DataGridView();
            colMaMonHoc = new DataGridViewTextBoxColumn();
            colTenMonHoc = new DataGridViewTextBoxColumn();
            colSoTinChi = new DataGridViewTextBoxColumn();
            txtTimKiem = new TextBox();
            pnlHeader.SuspendLayout();
            grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTinChi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DodgerBlue;
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1161, 144);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(100, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTitle.ForeColor = Color.White;
            lblSubTitle.Location = new Point(102, 60);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(224, 25);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Hệ thống quản lý sinh viên";
            // 
            // grbThongTin
            // 
            grbThongTin.Controls.Add(numSoTinChi);
            grbThongTin.Controls.Add(txtTenMonHoc);
            grbThongTin.Controls.Add(txtMaMonHoc);
            grbThongTin.Controls.Add(lblSoTinChi);
            grbThongTin.Controls.Add(lblTenMonHoc);
            grbThongTin.Controls.Add(lblMaMonHoc);
            grbThongTin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbThongTin.ForeColor = SystemColors.Highlight;
            grbThongTin.Location = new Point(12, 186);
            grbThongTin.Name = "grbThongTin";
            grbThongTin.Size = new Size(1137, 230);
            grbThongTin.TabIndex = 1;
            grbThongTin.TabStop = false;
            grbThongTin.Text = "Thông tin môn học";
            // 
            // lblMaMonHoc
            // 
            lblMaMonHoc.AutoSize = true;
            lblMaMonHoc.ForeColor = Color.Black;
            lblMaMonHoc.Location = new Point(26, 55);
            lblMaMonHoc.Name = "lblMaMonHoc";
            lblMaMonHoc.Size = new Size(118, 25);
            lblMaMonHoc.TabIndex = 0;
            lblMaMonHoc.Text = "Mã môn học";
            // 
            // lblTenMonHoc
            // 
            lblTenMonHoc.AutoSize = true;
            lblTenMonHoc.ForeColor = Color.Black;
            lblTenMonHoc.Location = new Point(26, 130);
            lblTenMonHoc.Name = "lblTenMonHoc";
            lblTenMonHoc.Size = new Size(121, 25);
            lblTenMonHoc.TabIndex = 1;
            lblTenMonHoc.Text = "Tên môn học";
            // 
            // lblSoTinChi
            // 
            lblSoTinChi.AutoSize = true;
            lblSoTinChi.ForeColor = Color.Black;
            lblSoTinChi.Location = new Point(601, 55);
            lblSoTinChi.Name = "lblSoTinChi";
            lblSoTinChi.Size = new Size(91, 25);
            lblSoTinChi.TabIndex = 2;
            lblSoTinChi.Text = "Số tin chỉ";
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(187, 58);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(361, 31);
            txtMaMonHoc.TabIndex = 3;
            // 
            // txtTenMonHoc
            // 
            txtTenMonHoc.Location = new Point(187, 130);
            txtTenMonHoc.Name = "txtTenMonHoc";
            txtTenMonHoc.Size = new Size(361, 31);
            txtTenMonHoc.TabIndex = 4;
            // 
            // numSoTinChi
            // 
            numSoTinChi.BackColor = Color.White;
            numSoTinChi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numSoTinChi.Location = new Point(725, 55);
            numSoTinChi.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numSoTinChi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoTinChi.Name = "numSoTinChi";
            numSoTinChi.Size = new Size(393, 30);
            numSoTinChi.TabIndex = 5;
            numSoTinChi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMonHoc
            // 
            lblMonHoc.BackColor = Color.White;
            lblMonHoc.Cursor = Cursors.Hand;
            lblMonHoc.FlatStyle = FlatStyle.Flat;
            lblMonHoc.ForeColor = Color.DarkBlue;
            lblMonHoc.Location = new Point(12, 432);
            lblMonHoc.Name = "lblMonHoc";
            lblMonHoc.Size = new Size(140, 42);
            lblMonHoc.TabIndex = 2;
            lblMonHoc.Text = "Thêm";
            lblMonHoc.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(186, 432);
            button2.Name = "button2";
            button2.Size = new Size(140, 42);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(364, 432);
            button3.Name = "button3";
            button3.Size = new Size(140, 42);
            button3.TabIndex = 4;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.DarkBlue;
            button4.Location = new Point(541, 432);
            button4.Name = "button4";
            button4.Size = new Size(140, 42);
            button4.TabIndex = 5;
            button4.Text = "Làm mới";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 477);
            label1.Name = "label1";
            label1.Size = new Size(165, 23);
            label1.TabIndex = 6;
            label1.Text = "Danh sách môn học";
            label1.Click += label1_Click;
            // 
            // dgvMonHoc
            // 
            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.AllowUserToDeleteRows = false;
            dgvMonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMonHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonHoc.BackgroundColor = Color.White;
            dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonHoc.Columns.AddRange(new DataGridViewColumn[] { colMaMonHoc, colTenMonHoc, colSoTinChi });
            dgvMonHoc.EnableHeadersVisualStyles = false;
            dgvMonHoc.Location = new Point(12, 521);
            dgvMonHoc.MultiSelect = false;
            dgvMonHoc.Name = "dgvMonHoc";
            dgvMonHoc.ReadOnly = true;
            dgvMonHoc.RowHeadersVisible = false;
            dgvMonHoc.RowHeadersWidth = 51;
            dgvMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonHoc.Size = new Size(1137, 207);
            dgvMonHoc.TabIndex = 7;
            // 
            // colMaMonHoc
            // 
            colMaMonHoc.HeaderText = "Mã môn học";
            colMaMonHoc.MinimumWidth = 6;
            colMaMonHoc.Name = "colMaMonHoc";
            colMaMonHoc.ReadOnly = true;
            // 
            // colTenMonHoc
            // 
            colTenMonHoc.HeaderText = "Tên môn học";
            colTenMonHoc.MinimumWidth = 6;
            colTenMonHoc.Name = "colTenMonHoc";
            colTenMonHoc.ReadOnly = true;
            // 
            // colSoTinChi
            // 
            colSoTinChi.HeaderText = "Số tín chỉ";
            colSoTinChi.MinimumWidth = 6;
            colSoTinChi.Name = "colSoTinChi";
            colSoTinChi.ReadOnly = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Cursor = Cursors.IBeam;
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.Location = new Point(847, 432);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm mã môn, tên môn...";
            txtTimKiem.Size = new Size(260, 30);
            txtTimKiem.TabIndex = 8;
            // 
            // FormMon
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 728);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvMonHoc);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblMonHoc);
            Controls.Add(grbThongTin);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            MinimumSize = new Size(900, 600);
            Name = "FormMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ MÔN HỌC";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grbThongTin.ResumeLayout(false);
            grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoTinChi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubTitle;
        private Label lblTitle;
        private GroupBox grbThongTin;
        private TextBox txtTenMonHoc;
        private TextBox txtMaMonHoc;
        private Label lblSoTinChi;
        private Label lblTenMonHoc;
        private Label lblMaMonHoc;
        private NumericUpDown numSoTinChi;
        private Button lblMonHoc;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private DataGridView dgvMonHoc;
        private DataGridViewTextBoxColumn colMaMonHoc;
        private DataGridViewTextBoxColumn colTenMonHoc;
        private DataGridViewTextBoxColumn colSoTinChi;
        private TextBox txtTimKiem;
    }
}