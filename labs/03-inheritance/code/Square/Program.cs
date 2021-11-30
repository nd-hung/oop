using System;

class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng hình chữ nhật
        Rectangle r = new Rectangle(4,5);
        Console.WriteLine("Dien tich hinh chu nhat = " + r.Area().ToString());

        // Tạo đối tượng hình vuông
        Square s = new Square(8);
        Console.WriteLine("Dien tich hinh vuong = {0}", s.Area());

    }
}

