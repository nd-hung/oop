using System;

abstract class Shape
{
    public string Name{get; set;}

    public abstract void Input();
   public abstract double Area();
}

class Rectangle: Shape
{
    protected double _width;
    protected double _height;
    
    public Rectangle(double w=0, double h=0)
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

class Square : Rectangle
{
    public Square(double w=0):base(w, w)
    {
    }

    public override void Input()
    {
        Console.Write("Width = ");
        _width = _height = double.Parse(Console.ReadLine());
    }
}