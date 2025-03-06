// Chương trình chính

// Tạo một danh sách các hình tròn
List<Circle> circles = new List<Circle>();
circles.Add(new Circle(new Point(0, 0), 1));
circles.Add(new Circle(new Point(5, 6), 2));
circles.Add(new Circle(new Point(2, 2), 3));
circles.Add(new Circle(new Point(3, 3), 4));
circles.Add(new Circle(new Point(4, 4), 5));
// In ra các cặp hình tròn giao nhau
for(int i=0; i<circles.Count-1; i++)
    for(int j=i+1; j<circles.Count; j++) 
        if(circles[i].IntersectionCheck(circles[j])) 
        {
            Console.WriteLine("Circle {0} intersects with circle {1}", i, j);
        }
