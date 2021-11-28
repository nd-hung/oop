using System;

class Program
{
    static void Main(string[] args)
    {
        // Sử dụng stack vào bài toán phân tích số tự nhiên ra thừa số nguyên tố.
        int n, n0;

        // Khởi tạo ngăn xếp
        Stack s = new Stack();

        Console.Write("Nhap so tu nhien n: ");
        n = int.Parse(Console.ReadLine());
        n0 = n; // n0 lưu giá trị ban đầu của n

        // phân tích n ra thừa số nguyên tố
        for(int i=2; i <= n; i++)
        {
            // Chừng nào n còn chia hết cho i -> đẩy i vào ngăn xếp, giảm n = n/i
            while(n % i == 0)
            {
                s.Push(i);
                n /= i;
            }
        }

        // In ra các phần tử trong ngăn xếp:
        Console.WriteLine("So {0} phan tich ra thua so nguyen to:",n0);
        s.Print();
    }
}
