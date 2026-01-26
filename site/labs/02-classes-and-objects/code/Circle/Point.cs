// Tạo lớp Point mô tả các điểm trong mặt phẳng.
public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    // Hàm khởi tạo
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Hàm trả về khoảng cách đến 1 điểm khác (công thức Euclid)
    public double Distance(Point p)
    {
        double dx = X - p.X;
        double dy = Y - p.Y;
        return System.Math.Sqrt(dx * dx + dy * dy);
    }
}