// Tạo lớp Circle mô tả hình tròn trong mặt phẳng.
public class Circle
{
    // Tâm của hình tròn là một đối tượng thuộc lớp Point
    public Point Center { get; set; }
    // Bán kính của hình tròn
    private double radius;
    public double Radius {
         get => radius; 
         set{
                if(value < 0) throw new ArgumentException("Radius must be non-negative");
                radius = value;
         } }

    // Hàm khởi tạo hình tròn
    public Circle(Point center, double radius)
    {   
        Center = center;
        Radius = radius;
    }

    // Hàm trả về diện tích của hình tròn
    public double Area()
    {
        return MyMath.PI * Radius * Radius;
    } 
    // Hàm kiểm tra hình tròn có giao với hình tròn khác không
    public bool IntersectionCheck(Circle other)
    {
        // Tính khoảng cách giữa 2 tâm hình tròn
        double distance = Center.Distance(other.Center);
        // Nếu khoảng cách nhỏ hơn tổng bán kính 2 hình tròn thì 2 hình tròn giao nhau
        return distance < Radius + other.Radius;
    }
}