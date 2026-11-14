using System;
using System.Text;

class Bai5
{
    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("--- BÀI 5: TÌM SỐ FIBONACCI THỨ N ---");

        Console.Write("Nhập số nguyên dương n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Giá trị n không hợp lệ!");
            return;
        }

        if (n == 0)
        {
            Console.WriteLine("Số Fibonacci thứ 0 là: 0");
            return;
        }
        if (n == 1 || n == 2)
        { 
            Console.WriteLine($"Số Fibonacci thứ {n} là: 1");
            return;
        }

        long f1 = 0, f2 = 1, fn = 0;
        for (int i = 2; i <= n; i++)
        {
            fn = f1 + f2;
            f1 = f2;
            f2 = fn;
        }

        Console.WriteLine($"Số Fibonacci thứ {n} là: {fn}");

    }
}