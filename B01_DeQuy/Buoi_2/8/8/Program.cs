using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Bai8();
        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }

    static void Bai8()
    {
        Console.Write("Nhập một chuỗi: ");
        string chuoi = (Console.ReadLine() ?? "").ToLowerInvariant();

        // Thay ký tự không phải chữ hoặc số bằng dấu cách, sau đó tách từ.
        chuoi = Regex.Replace(chuoi, @"[^\p{L}\p{N}]+", " ");
        string[] cacTu = chuoi.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        Dictionary<string, int> dem = new Dictionary<string, int>();

        foreach (string tu in cacTu)
        {
            if (dem.ContainsKey(tu)) dem[tu]++;
            else dem[tu] = 1;
        }

        Console.WriteLine("\nThống kê từ:");
        foreach (var item in dem.OrderBy(x => x.Key))
            Console.WriteLine($"{item.Key}: {item.Value} lần");
    }
}
