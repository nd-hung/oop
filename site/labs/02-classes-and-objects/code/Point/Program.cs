class Program
{
    public static void Main()
    {
        // Tạo danh sách động quản lý các đối tượng của lớp Point
        uint nPoints;
        const int Max = 100;
        List<Point> pointList = new List<Point>();

        Point GocToaDo = new Point(0, 0); // Gốc tọa độ

        do
        {
            Console.Write("Nhap so diem = ");
            nPoints = uint.Parse(Console.ReadLine());
        } while (nPoints <= 0);

        // Khởi tạo bộ sinh số ngẫu nhiên
        Random rnd = new Random();
        for (int i = 0; i < nPoints; i++)
        {
            // Tạo điểm có tọa độ ngẫu nhiên trong khoảng Max và thêm vào danh sách
            pointList.Add(new Point(rnd.Next(Max), rnd.Next(Max)));

            // Nếu muốn nhập tọa độ các điểm từ bàn phím thì dùng các lệnh sau
            // pointList.Add(new Point()); // Khởi tạo điểm
            // pointList[i].Nhap();        // Gọi phương thức nhập cho điểm vừa tạo
        }

        // Nếu muốn tạo danh sách đối tượng dạng tĩnh thì dùng các lệnh sau:
        /*
        Point[] pList = new Point[nPoints];
        (int i = 0; i < nPoints; i++)
        {
            pList[i] =  new Point();
            pList[i].Nhap();
        }
        */

        // In ra các điểm vừa tạo
        Console.WriteLine("Danh sach diem: ");
        foreach (Point p in pointList)
        {
            p.Xuat();
        }

        // Tìm điểm gần gốc tọa độ nhất
        // Khai báo biến minDistance và khởi tạo bằng khoảng cách từ điểm đầu tiên đến gốc tọa độ
        double minDistance = pointList[0].Distance(GocToaDo);
        // Biến nearestPoint là đối tượng thuộc lớp Point, khởi tạo bằng điểm đầu tiên trong danh sách
        Point nearestPoint = pointList[0];
        // Xét lần lượt các điểm còn lại
        for (int i = 1; i < pointList.Count; i++)
        {
            // Tính khoảng cách từng điểm đến gốc tọa độ
            double distance = pointList[i].Distance(GocToaDo);
            // Nếu có điểm gần gốc tọa độ hơn thì thực hiện lệnh gán
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestPoint = pointList[i];
            }
        }

        // Xuất kết quả
        Console.WriteLine("Diem gan goc toa do nhat: ");
        nearestPoint.Xuat();

        /* Tìm cặp điểm gần nhau nhất
        HD: So sánh khoảng cách từng cặp điểm -> tìm cặp có khoảng cách ngắn nhất.
        */
    }
}
