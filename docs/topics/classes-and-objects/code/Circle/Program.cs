﻿/* Minh họa lớp và đối tượng
Xử lý hình tròn
*/

namespace CircleProject
{
    // Cài đặt lớp tĩnh chứa các hằng số (PI)
    public static class MyConstants
    {
        public static double PI = 3.1416;
    }
    // Cài đặt lớp hình tròn
    class HinhTron
    {
        public double X { get; set; }  // Hoành độ tâm
        public double Y { get; set; }  // Tung độ tâm
        private double banKinh; // Trường (field)
        public double BanKinh
        {
            get { return banKinh; }
            set
            {
                // Nếu giá trị >= 0 mới thực hiện lệnh gán giá trị
                if (value >= 0) banKinh = value;
            }
        }

        public static int SoLuong = 0;

        // Hàm thiết lập
        public HinhTron(double x = 0, double y = 0, double r = 0)
        {
            X = x;
            Y = y;
            if (r >= 0) banKinh = r;
            SoLuong++;
        }

        // Hàm thiết lập sao chép (copy constructor)
        public HinhTron(HinhTron c)
        {
            X = c.X;
            Y = c.Y;
            banKinh = c.banKinh;
            SoLuong++;
        }

        // Hàm in thông tin hình tròn
        public void Xuat()
        {
            Console.WriteLine("Toa do tam: ({0},{1}), ban kinh = {2}\n", X, Y, banKinh);
        }

        // Hàm trả về diện tích hình tròn
        public double DienTich()
        {
            return MyConstants.PI* banKinh * banKinh;
            // return Math.PI * banKinh * banKinh;
        }
    }

    // Chương trình chính
    class Program
    {
        public static void Main()
        {
            // Tạo 1 hình tròn
            HinhTron c1 = new HinhTron(1, 2, 3);
            // In thông tin hình tròn
            Console.WriteLine("Hinh tron thu 1:");
            c1.Xuat();

            // Tạo hình tròn thứ 2 bằng cách sao chép 
            HinhTron c2 = new HinhTron(c1);
            // In thông tin hình tròn thứ 2
            Console.WriteLine("Hinh tron thu 2:");
            c2.Xuat();

            HinhTron c3 = new HinhTron(4, 5, 10);
            // In diện tích hình tròn, làm tròn đến 3 chữ số phần thập phân
            Console.WriteLine("Dien tich = {0:#.000}", c3.DienTich());
            
            // In số lượng hình tròn được tạo ra
            Console.WriteLine("So hinh tron = {0}", HinhTron.SoLuong);
        }
    }
}