using System;

class Program
{
    static void Main(string[] args)
    {
        // Cannot create an instance of the abstract type or interface:
        // Shape s0 = new Shape();  // Lệnh này không thực hiện được

        // Tạo hình chữ nhật có độ dài các cạnh là 3,4
        Shape s1 = new Rectangle(3,4);
        Console.WriteLine("This is a {0}, area = {1}", s1.GetType(), s1.Area());

        // Tạo hình vuông có độ dài cạnh = 5
        Shape s2 = new Square(5);
        Console.WriteLine("This is a {0}, area = {1}", s2.GetType(), s2.Area());

        // Tạo 1 hình chữ nhật & nhập độ dài các cạnh từ bàn phím
        Shape s3 = new Rectangle();
        s3.Input();
        Console.WriteLine("This is a {0}, area = {1}", s3.Name, s3.Area());

        // Tạo 1 hình vuông & nhập độ dài cạnh từ bàn phím
        Shape s4 = new Square();
        s4.Input();
        Console.WriteLine("This is a {0}, area = {1}", s4.Name, s4.Area());

        // Tạo một hình tròn có bán kính = 1
        Shape s5 = new Circle(1);
        Console.WriteLine("This is a {0}, area = {1}", s5.Name, s5.Area());
    }
}

