using System;

class Bai3
{
    static double TinhS3(int n)
    {
        if (n == 1) return 1.0;
        return TinhS3(n - 1) + 1.0 / n;
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS3(n):F4}");
    }
}
