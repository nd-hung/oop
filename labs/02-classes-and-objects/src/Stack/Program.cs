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
        Console.WriteLine("So {0} phan tich ra thua so nguyen to:", n0);
        s.Print();

        // Đổi số n sang hệ 16
        n = n0; // gán lại giá trị ban đầu của n
        // Tạo 1 ngăn xếp mới (rỗng)
        Stack stack2 = new Stack();
        
        while(n > 0)
        {
            // Lấy ra số dư của phép chia n/16
            int soDu = n % 16;
            stack2.Push(soDu);
            n = n / 16;
        }

        // In ra ngăn xếp (chứa các số dư theo thứ tự ngược lại)
        Console.WriteLine("\nSo {0} doi sang he 16 la", n0);
        stack2.PrintHex();
    }
}
