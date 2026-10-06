using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace CourseRegistrationApp
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            if (args.Length > 0 && args[0].Equals("--screenshot", StringComparison.OrdinalIgnoreCase))
            {
                ChupAnhGiaoDien(args.Length > 1 ? args[1] : null);
                return;
            }

            Application.Run(new Form1());
        }

        private static void ChupAnhGiaoDien(string duongDanLuu)
        {
            string thuMucGoc = @"C:\Users\ADMIN\Desktop\homework";
            string fileMacDinh = string.IsNullOrEmpty(duongDanLuu)
                ? Path.Combine(thuMucGoc, "CourseRegistrationApp_Screenshot.png")
                : duongDanLuu;

            using (var form = new Form1())
            {
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(100, 100);
                form.Show();
                Application.DoEvents();
                Thread.Sleep(500);

                // Chụp giao diện form mặc định
                Bitmap bmp = new Bitmap(form.Width, form.Height);
                form.DrawToBitmap(bmp, new Rectangle(0, 0, form.Width, form.Height));
                bmp.Save(fileMacDinh, System.Drawing.Imaging.ImageFormat.Png);
                Console.WriteLine($"[Thành công] Đã lưu ảnh chụp giao diện mặc định tại: {fileMacDinh}");

                // Chụp thêm 1 ảnh có nhập liệu thực tế
                var txtHoTen = form.Controls.Find("txtHoTen", true);
                var txtSoDienThoai = form.Controls.Find("txtSoDienThoai", true);
                var numSoThang = form.Controls.Find("numSoThang", true);
                var chkNhanEmail = form.Controls.Find("chkNhanEmail", true);

                if (txtHoTen.Length > 0) ((TextBox)txtHoTen[0]).Text = "Nguyễn Văn An";
                if (txtSoDienThoai.Length > 0) ((TextBox)txtSoDienThoai[0]).Text = "0912345678";
                if (numSoThang.Length > 0) ((NumericUpDown)numSoThang[0]).Value = 3;
                if (chkNhanEmail.Length > 0) ((CheckBox)chkNhanEmail[0]).Checked = true;

                Application.DoEvents();
                Thread.Sleep(300);

                string fileNhapLieu = Path.Combine(thuMucGoc, "CourseRegistrationApp_Screenshot_NhapLieu.png");
                Bitmap bmpNhapLieu = new Bitmap(form.Width, form.Height);
                form.DrawToBitmap(bmpNhapLieu, new Rectangle(0, 0, form.Width, form.Height));
                bmpNhapLieu.Save(fileNhapLieu, System.Drawing.Imaging.ImageFormat.Png);
                Console.WriteLine($"[Thành công] Đã lưu ảnh chụp giao diện nhập liệu tại: {fileNhapLieu}");

                Environment.Exit(0);
            }
        }
    }
}