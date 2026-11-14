using System;

class Bai7
{
    static int SoChuSo(int n)
    {
        if (n == 0) return 0;
        return SoChuSo(n / 10) + 1;
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"So chu so cua {n} la: {(n == 0 ? 1 : SoChuSo(n))}");
    }
}
