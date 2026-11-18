using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Bai9();
        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }

    static void Bai9()
    {
        Console.Write("Nhập số lượng phần tử n: ");
        int n = DocSoNguyenDuong();
        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = DocSoNguyen();
        }

        Console.WriteLine("\nCác số nguyên tố:");
        InDay(a.Where(LaSoNguyenTo));

        Console.WriteLine("Các số chẵn:");
        InDay(a.Where(x => x % 2 == 0));

        Console.WriteLine("Các số hoàn hảo:");
        InDay(a.Where(LaSoHoanHao));
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

    static void InDay(IEnumerable<int> day)
    {
        int[] kq = day.ToArray();
        Console.WriteLine(kq.Length == 0 ? "(Không có)" : string.Join(", ", kq));
    }

    static bool LaSoNguyenTo(int x)
    {
        if (x < 2) return false;
        for (int i = 2; i <= x / i; i++)
            if (x % i == 0) return false;
        return true;
    }

    static bool LaSoHoanHao(int x)
    {
        if (x <= 1) return false;
        int tongUoc = 1;
        for (int i = 2; i <= x / i; i++)
        {
            if (x % i == 0)
            {
                tongUoc += i;
                int uocConLai = x / i;
                if (uocConLai != i) tongUoc += uocConLai;
            }
        }
        return tongUoc == x;
    }
}
