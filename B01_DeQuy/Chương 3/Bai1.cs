using System;

class Bai1
{
    static int TinhS1(int n)
    {
        if (n == 1) return 1;
        return TinhS1(n - 1) + n;
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"S({n}) = {TinhS1(n)}");
    }
}
