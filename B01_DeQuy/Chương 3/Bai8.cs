using System;

class Bai8
{
    static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    static double TinhS8(int n)
    {
        return Can(1, n);
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS8(n):F4}");
    }
}
