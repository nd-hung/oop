using System;

// Lớp Rectangle
class Rectangle
{
    protected double _width, _height;

    // constructor
    public Rectangle(double w=0, double h=0)
    {
        _width = w;
        _height = h;
    }

    // return rectangle's area
    public double Area()
    {
        return _height * _width;
    }
}

/*
Hình vuông là trường hợp đặc biệt của hình chữ nhật khi các cạnh bằng nhau. 
Vì thế có thể cài đặt lớp hình vuông kế thừa lớp hình chữ nhật 
mà không cần phải viết lại toàn bộ mã nguồn.
Lớp hình chữ nhật cần chia sẻ các thành phần mà lớp hình vuông cũng có, như: các cạnh, 
công thức tính diện tích.
*/

class Square: Rectangle
{
    public Square(double w):base(w, w)
    {}
}