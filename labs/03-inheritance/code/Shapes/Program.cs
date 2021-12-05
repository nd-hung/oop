using System;

class Program
{
    static void Main(string[] args)
    {
        Shape s1 = new Rectangle(3,4);
        Console.WriteLine("This is a {0}, area = {1}", s1.GetType(), s1.Area());

        Shape s2 = new Square(5);
        Console.WriteLine("This is a {0}, area = {1}", s2.GetType(), s2.Area());

        Shape s3 = new Rectangle();
        s3.Input();
        Console.WriteLine("This is a {0}, area = {1}", s3.GetType(), s3.Area());

        Shape s4 = new Square();
        s4.Input();
        Console.WriteLine("This is a {0}, area = {1}", s4.GetType(), s4.Area());

    }
}

