using System;

// Shape: lớp cơ sở trừu tượng
abstract class Shape
{
    // thuộc tính Name trả về tên kiểu đối tượng
    public string Name
    {
        get { return this.GetType().ToString(); }
    }

    // Hàm trừu tượng nhập
    public abstract void Input();

    // Hàm trừu tượng tính diện tích
    public abstract double Area();
}

// Lớp hình chữ nhật (rectangle) kế thừa lớp Shape
class Rectangle : Shape
{
    // fields
    protected double _width;
    protected double _height;

    // constructor
    public Rectangle(double w = 0, double h = 0)
    {
        _height = h;
        _width = w;
    }

    public override void Input()
    {
        Console.Write("Width = ");
        _width = double.Parse(Console.ReadLine());
        Console.Write("Height = ");
        _height = double.Parse(Console.ReadLine());
    }

    public override double Area()
    {
        return _height * _width;
    }
}

// Lớp hình vuông (square) kế thừa lớp hình chữ nhật
class Square : Rectangle
{
    public Square(double w = 0) : base(w, w) { }

    public override void Input()
    {
        Console.Write("Width = ");
        _width = _height = double.Parse(Console.ReadLine());
    }
}

// Lớp hình tròn (circle) kế thừa lớp Shape
class Circle : Shape
{
    static double Pi = 3.1416;
    private double _radius;

    public Circle(double r = 0)
    {
        if (r < 0)
            throw new ArgumentOutOfRangeException("Out of range.");
        _radius = r;
    }
    public override void Input()
    {
        Console.Write("Radius = ");
        _radius = double.Parse(Console.ReadLine());
    }

    public override double Area()
    {
        return Pi * _radius * _radius;
    }
}