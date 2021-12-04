/*
Xây dựng lớp hình vẽ thành lớp trừu tượng (abstract class)
*/

using System;

abstract class HinhVe
{
    public string Ten{get; set;}    // Thuộc tính không trừu tượng
    
    public abstract double DienTich();  // Phương thức trừu tượng

}

// Lớp HinhChuNhat kế thừa lớp hình vẽ
class HinhChuNhat: HinhVe
{
    private double _dai, _rong;
    // constructor
    public HinhChuNhat(double d=0, double r=0)
    {
        _dai = d;
        _rong = r;
    }
    public override double DienTich()
    {
        return _dai * _rong;
    }
}

// Lớp HinhTron kế thừa lớp hình vẽ
class HinhTron:HinhVe
{
    private double _banKinh;

    // constructor
    public HinhTron(double r=0)
    {
        if(r < 0)
            throw new ArgumentOutOfRangeException("Ban kinh phai >=0.", nameof(r));
        _banKinh = r;
    }

    public override double DienTich()
    {
        return _banKinh * _banKinh * 3.1416;    
    }
}

// Lớp tam giác kế thừa lớp hình vẽ
class TamGiac:HinhVe
{
    private double _a, _b, _c;

    public static bool LaTamGiac(double a, double b, double c)
    {
        return (a + b > c && a + c > b && b + c > a);
    }
    // hàm thiết lập
    public TamGiac(double a, double b, double c)
    {
        if(!LaTamGiac(a,b,c))
            throw new ArgumentException("Khong phai do dai 3 canh tam giac.");
        else
        {
            _a = a;
            _b = b;
            _c = c;
        }
    }

    // hàm tính & trả về diện tích tam giác
    public override double DienTich()
    {
        double p = (_a + _b + _c)/2;
        return(Math.Sqrt(p*(p - _a)*(p - _b)*(p - _c)));
    }
}