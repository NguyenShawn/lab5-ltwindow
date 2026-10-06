namespace CourseRegistrationApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controls declaration
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpThongTinHocVien;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkNhanEmail;

        private System.Windows.Forms.GroupBox grpThongTinKhoaHoc;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.RadioButton radOnline;
        private System.Windows.Forms.RadioButton radOffline;
        private System.Windows.Forms.Label lblSoThang;
        private System.Windows.Forms.NumericUpDown numSoThang;
        private System.Windows.Forms.Label lblTieuDeTongTien;
        private System.Windows.Forms.Label lblTongTien;

        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpThongTinHocVien = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkNhanEmail = new System.Windows.Forms.CheckBox();

            this.grpThongTinKhoaHoc = new System.Windows.Forms.GroupBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.radOnline = new System.Windows.Forms.RadioButton();
            this.radOffline = new System.Windows.Forms.RadioButton();
            this.lblSoThang = new System.Windows.Forms.Label();
            this.numSoThang = new System.Windows.Forms.NumericUpDown();
            this.lblTieuDeTongTien = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();

            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            this.grpThongTinHocVien.SuspendLayout();
            this.grpThongTinKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).BeginInit();
            this.SuspendLayout();

            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(26, 54, 93);
            this.lblHeader.Location = new System.Drawing.Point(20, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(585, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpThongTinHocVien
            // 
            this.grpThongTinHocVien.Controls.Add(this.chkNhanEmail);
            this.grpThongTinHocVien.Controls.Add(this.dtpNgaySinh);
            this.grpThongTinHocVien.Controls.Add(this.lblNgaySinh);
            this.grpThongTinHocVien.Controls.Add(this.txtSoDienThoai);
            this.grpThongTinHocVien.Controls.Add(this.lblSoDienThoai);
            this.grpThongTinHocVien.Controls.Add(this.txtHoTen);
            this.grpThongTinHocVien.Controls.Add(this.lblHoTen);
            this.grpThongTinHocVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpThongTinHocVien.ForeColor = System.Drawing.Color.FromArgb(43, 108, 176);
            this.grpThongTinHocVien.Location = new System.Drawing.Point(30, 65);
            this.grpThongTinHocVien.Name = "grpThongTinHocVien";
            this.grpThongTinHocVien.Size = new System.Drawing.Size(565, 195);
            this.grpThongTinHocVien.TabIndex = 1;
            this.grpThongTinHocVien.TabStop = false;
            this.grpThongTinHocVien.Text = "Thông tin học viên";

            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblHoTen.Location = new System.Drawing.Point(25, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(72, 23);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên :";

            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(155, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(380, 30);
            this.txtHoTen.TabIndex = 1;

            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblSoDienThoai.Location = new System.Drawing.Point(25, 75);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(120, 23);
            this.lblSoDienThoai.TabIndex = 2;
            this.lblSoDienThoai.Text = "Số điện thoại :";

            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoDienThoai.Location = new System.Drawing.Point(155, 72);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(380, 30);
            this.txtSoDienThoai.TabIndex = 3;

            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 115);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(95, 23);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh :";

            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(155, 112);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(380, 30);
            this.dtpNgaySinh.TabIndex = 5;

            // 
            // chkNhanEmail
            // 
            this.chkNhanEmail.AutoSize = true;
            this.chkNhanEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkNhanEmail.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.chkNhanEmail.Location = new System.Drawing.Point(155, 155);
            this.chkNhanEmail.Name = "chkNhanEmail";
            this.chkNhanEmail.Size = new System.Drawing.Size(193, 27);
            this.chkNhanEmail.TabIndex = 6;
            this.chkNhanEmail.Text = "Nhận email thông báo";
            this.chkNhanEmail.UseVisualStyleBackColor = true;

            // 
            // grpThongTinKhoaHoc
            // 
            this.grpThongTinKhoaHoc.Controls.Add(this.lblTongTien);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblTieuDeTongTien);
            this.grpThongTinKhoaHoc.Controls.Add(this.numSoThang);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblSoThang);
            this.grpThongTinKhoaHoc.Controls.Add(this.radOffline);
            this.grpThongTinKhoaHoc.Controls.Add(this.radOnline);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblHinhThuc);
            this.grpThongTinKhoaHoc.Controls.Add(this.cboKhoaHoc);
            this.grpThongTinKhoaHoc.Controls.Add(this.lblKhoaHoc);
            this.grpThongTinKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpThongTinKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(43, 108, 176);
            this.grpThongTinKhoaHoc.Location = new System.Drawing.Point(30, 275);
            this.grpThongTinKhoaHoc.Name = "grpThongTinKhoaHoc";
            this.grpThongTinKhoaHoc.Size = new System.Drawing.Size(565, 215);
            this.grpThongTinKhoaHoc.TabIndex = 2;
            this.grpThongTinKhoaHoc.TabStop = false;
            this.grpThongTinKhoaHoc.Text = "Thông tin khóa học";

            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKhoaHoc.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblKhoaHoc.Location = new System.Drawing.Point(25, 35);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(91, 23);
            this.lblKhoaHoc.TabIndex = 0;
            this.lblKhoaHoc.Text = "Khóa học :";

            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(155, 32);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(380, 29);
            this.cboKhoaHoc.TabIndex = 1;

            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHinhThuc.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblHinhThuc.Location = new System.Drawing.Point(25, 75);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(94, 23);
            this.lblHinhThuc.TabIndex = 2;
            this.lblHinhThuc.Text = "Hình thức :";

            // 
            // radOnline
            // 
            this.radOnline.AutoSize = true;
            this.radOnline.Checked = true;
            this.radOnline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radOnline.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.radOnline.Location = new System.Drawing.Point(155, 73);
            this.radOnline.Name = "radOnline";
            this.radOnline.Size = new System.Drawing.Size(81, 27);
            this.radOnline.TabIndex = 3;
            this.radOnline.TabStop = true;
            this.radOnline.Text = "Online";
            this.radOnline.UseVisualStyleBackColor = true;

            // 
            // radOffline
            // 
            this.radOffline.AutoSize = true;
            this.radOffline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radOffline.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.radOffline.Location = new System.Drawing.Point(280, 73);
            this.radOffline.Name = "radOffline";
            this.radOffline.Size = new System.Drawing.Size(96, 27);
            this.radOffline.TabIndex = 4;
            this.radOffline.Text = "Trực tiếp";
            this.radOffline.UseVisualStyleBackColor = true;

            // 
            // lblSoThang
            // 
            this.lblSoThang.AutoSize = true;
            this.lblSoThang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoThang.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblSoThang.Location = new System.Drawing.Point(25, 118);
            this.lblSoThang.Name = "lblSoThang";
            this.lblSoThang.Size = new System.Drawing.Size(88, 23);
            this.lblSoThang.TabIndex = 5;
            this.lblSoThang.Text = "Số tháng :";

            // 
            // numSoThang
            // 
            this.numSoThang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSoThang.Location = new System.Drawing.Point(155, 115);
            this.numSoThang.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            this.numSoThang.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoThang.Name = "numSoThang";
            this.numSoThang.Size = new System.Drawing.Size(120, 30);
            this.numSoThang.TabIndex = 6;
            this.numSoThang.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // lblTieuDeTongTien
            // 
            this.lblTieuDeTongTien.AutoSize = true;
            this.lblTieuDeTongTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDeTongTien.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.lblTieuDeTongTien.Location = new System.Drawing.Point(25, 163);
            this.lblTieuDeTongTien.Name = "lblTieuDeTongTien";
            this.lblTieuDeTongTien.Size = new System.Drawing.Size(121, 23);
            this.lblTieuDeTongTien.TabIndex = 7;
            this.lblTieuDeTongTien.Text = "Tổng học phí :";

            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(197, 48, 48);
            this.lblTongTien.Location = new System.Drawing.Point(155, 158);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(148, 30);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "800.000 VNĐ";

            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(43, 108, 176);
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(85, 515);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(130, 42);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(221, 107, 32);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(245, 515);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(130, 42);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;

            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(45, 55, 72);
            this.btnThoat.Location = new System.Drawing.Point(405, 515);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 42);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;

            // 
            // Form1
            // 
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(247, 250, 252);
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(625, 585);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.grpThongTinKhoaHoc);
            this.Controls.Add(this.grpThongTinHocVien);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ KHÓA HỌC";
            this.grpThongTinHocVien.ResumeLayout(false);
            this.grpThongTinHocVien.PerformLayout();
            this.grpThongTinKhoaHoc.ResumeLayout(false);
            this.grpThongTinKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoThang)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
