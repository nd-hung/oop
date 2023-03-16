﻿class Program
{
    public static void Main()
    {
        // Tạo danh sách động quản lý các đối tượng của lớp Point
        uint nPoints;
        const int Max=100;
        List<Point> pointList = new List<Point>();

        Point GocToaDo = new Point(0,0);

        do{
            Console.Write("Nhap so diem = ");
            nPoints = uint.Parse(Console.ReadLine());
        }while(nPoints <= 0);

        // Khởi tạo bộ sinh số ngẫu nhiên
        Random rnd = new Random();
        for (int i = 0; i < nPoints; i++)
        {
            // Tạo điểm có tọa độ ngẫu nhiên trong khoảng 100
            pointList.Add(new Point(rnd.Next(Max), rnd.Next(Max)));
            
            // Nếu muốn nhập tọa độ các điểm từ bàn phím thì dùng các lệnh sau
            // pointList.Add(new Point()); // Khởi tạo điểm
            // pointList[i].Nhap();        // Gọi phương thức nhập cho điểm vừa tạo
        }

        // In ra các điểm vừa tạo
        Console.WriteLine("Danh sach diem: ");
        foreach(Point p in pointList)
        {
            p.Xuat();
        }

        // Tìm điểm gần gốc tọa độ nhất
        double minDistance = pointList[0].Distance(GocToaDo);
        Point nearestPoint = pointList[0];
        for(int i=1; i<pointList.Count; i++)
            if(pointList[i].Distance(GocToaDo) < minDistance)
            {
                minDistance = pointList[i].Distance(GocToaDo);
                nearestPoint = pointList[i];
            }

        Console.WriteLine("Diem gan goc toa do nhat: ");
        nearestPoint.Xuat();

        // Tìm cặp điểm gần nhau nhất: So sách khoảng cách từng cặp điểm -> tìm cặp có khoảng cách ngắn nhất
    }
}