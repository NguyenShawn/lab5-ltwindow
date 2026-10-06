namespace CourseRegistrationApp
{
    /// <summary>
    /// Lớp đối tượng biểu diễn một khóa học
    /// </summary>
    public class KhoaHoc
    {
        public string TenKhoaHoc { get; set; }
        public decimal HocPhiMotThang { get; set; }

        public KhoaHoc(string tenKhoaHoc, decimal hocPhiMotThang)
        {
            TenKhoaHoc = tenKhoaHoc;
            HocPhiMotThang = hocPhiMotThang;
        }

        public override string ToString()
        {
            return $"{TenKhoaHoc} - ({HocPhiMotThang:N0} VNĐ/tháng)";
        }
    }
}
