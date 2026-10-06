using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    public partial class Form1 : Form
    {
        private List<KhoaHoc> _danhSachKhoaHoc;
        private bool _isClosingConfirmed = false;

        public Form1()
        {
            InitializeComponent();
            DangKySuKien();
        }

        /// <summary>
        /// Đăng ký các sự kiện cho Form và các Control
        /// </summary>
        private void DangKySuKien()
        {
            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;

            cboKhoaHoc.SelectedIndexChanged += CboKhoaHoc_SelectedIndexChanged;
            numSoThang.ValueChanged += NumSoThang_ValueChanged;

            btnDangKy.Click += BtnDangKy_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            btnThoat.Click += BtnThoat_Click;
        }

        /// <summary>
        /// 5.1. Khi Form Load: Nạp danh sách khóa học và thiết lập mặc định
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách các khóa học theo yêu cầu đề bài
            _danhSachKhoaHoc = new List<KhoaHoc>
            {
                new KhoaHoc("C# WinForms cơ bản", 800000m),
                new KhoaHoc("SQL Server cơ bản", 700000m),
                new KhoaHoc("Web Frontend cơ bản", 750000m),
                new KhoaHoc("Lập trình Python cơ bản", 650000m)
            };

            // Nạp dữ liệu vào ComboBox
            cboKhoaHoc.Items.Clear();
            foreach (var kh in _danhSachKhoaHoc)
            {
                cboKhoaHoc.Items.Add(kh);
            }

            // Thiết lập giá trị mặc định ban đầu
            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0; // Chọn khóa học đầu tiên
            }

            radOnline.Checked = true; // Chọn hình thức Online
            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;
            numSoThang.Value = 1;

            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;

            // Tính và hiển thị tổng học phí ban đầu
            CapNhatTongHocPhi();

            txtHoTen.Focus();
        }

        private void CboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTongHocPhi();
        }

        private void NumSoThang_ValueChanged(object sender, EventArgs e)
        {
            CapNhatTongHocPhi();
        }

        /// <summary>
        /// Tính toán và hiển thị tổng học phí = học phí một tháng x số tháng
        /// </summary>
        private void CapNhatTongHocPhi()
        {
            if (cboKhoaHoc.SelectedItem is KhoaHoc khoaHocDuocChon)
            {
                int soThang = (int)numSoThang.Value;
                decimal tongTien = khoaHocDuocChon.HocPhiMotThang * soThang;
                lblTongTien.Text = $"{tongTien:N0} VNĐ";
            }
            else
            {
                lblTongTien.Text = "0 VNĐ";
            }
        }

        /// <summary>
        /// 5.2. Xử lý sự kiện nút Đăng ký
        /// </summary>
        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra Họ tên
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            // 2. Kiểm tra Số điện thoại
            string soDienThoai = txtSoDienThoai.Text.Trim();
            if (string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            // Kiểm tra định dạng số điện thoại (chỉ số, độ dài 9 - 11 chữ số)
            if (!Regex.IsMatch(soDienThoai, @"^0\d{8,10}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập số điện thoại bắt đầu bằng 0 và có từ 9 đến 11 chữ số.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                txtSoDienThoai.SelectAll();
                return;
            }

            // 3. Kiểm tra khóa học
            if (!(cboKhoaHoc.SelectedItem is KhoaHoc khoaHoc))
            {
                MessageBox.Show("Vui lòng chọn khóa học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKhoaHoc.Focus();
                return;
            }

            // 4. Thu thập dữ liệu
            string hinhThuc = radOnline.Checked ? "Online" : "Trực tiếp";
            int soThang = (int)numSoThang.Value;
            decimal tongTien = khoaHoc.HocPhiMotThang * soThang;
            string trangThaiEmail = chkNhanEmail.Checked ? "Có nhận" : "Không nhận";
            string ngaySinh = dtpNgaySinh.Value.ToString("dd/MM/yyyy");

            // 5. Hiển thị phiếu đăng ký bằng MessageBox
            string thongBao = "=========== PHIẾU ĐĂNG KÝ KHÓA HỌC ===========\n\n" +
                              $"• Họ và tên học viên: {hoTen}\n" +
                              $"• Số điện thoại: {soDienThoai}\n" +
                              $"• Ngày sinh: {ngaySinh}\n" +
                              $"• Khóa học đã chọn: {khoaHoc.TenKhoaHoc}\n" +
                              $"• Đơn giá học phí: {khoaHoc.HocPhiMotThang:N0} VNĐ/tháng\n" +
                              $"• Hình thức học: {hinhThuc}\n" +
                              $"• Thời gian đào tạo: {soThang} tháng\n" +
                              $"• TỔNG HỌC PHÍ: {tongTien:N0} VNĐ\n" +
                              $"• Nhận email thông báo: {trangThaiEmail}\n\n" +
                              "==============================================\n" +
                              "Chúc mừng bạn đã hoàn tất đăng ký khóa học thành công!";

            MessageBox.Show(thongBao, "Xác nhận đăng ký khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 5.3. Xử lý sự kiện nút Làm mới
        /// </summary>
        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            chkNhanEmail.Checked = false;

            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0;
            }

            radOnline.Checked = true;
            numSoThang.Value = 1;

            CapNhatTongHocPhi();

            txtHoTen.Focus();
        }

        /// <summary>
        /// 5.4. Xử lý sự kiện nút Thoát
        /// </summary>
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Bắt sự kiện đóng Form để hiển thị hộp thoại xác nhận
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isClosingConfirmed) return;

            DialogResult ketQua = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?",
                                                  "Xác nhận thoát",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                _isClosingConfirmed = true;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
