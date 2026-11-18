using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Bai10();
        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }

    static void Bai10()
    {
        Console.Write("Nhập số dòng m: ");
        int m = DocSoNguyenDuong();
        Console.Write("Nhập số cột n: ");
        int n = DocSoNguyenDuong();

        int[,] a = new int[m, n];
        Console.WriteLine("Nhập các phần tử ma trận:");
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = DocSoNguyen();
            }

        int top = 0, bottom = m - 1, left = 0, right = n - 1;
        Console.WriteLine("\nCác phần tử theo thứ tự xoắn ốc:");

        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++) Console.Write(a[top, j] + " ");
            top++;

            for (int i = top; i <= bottom; i++) Console.Write(a[i, right] + " ");
            right--;

            if (top <= bottom)
            {
                for (int j = right; j >= left; j--) Console.Write(a[bottom, j] + " ");
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--) Console.Write(a[i, left] + " ");
                left++;
            }
        }
        Console.WriteLine();
    }

    static int DocSoNguyen()
    {
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
            Console.Write("Không hợp lệ, nhập lại số nguyên: ");
        return x;
    }

    static int DocSoNguyenDuong()
    {
        int x;
        while (true)
        {
            x = DocSoNguyen();
            if (x > 0) return x;
            Console.Write("Phải nhập số nguyên dương, nhập lại: ");
        }
    }
}
