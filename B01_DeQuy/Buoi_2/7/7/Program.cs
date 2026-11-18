using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Bai7();
        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }

    static void Bai7()
    {
        Console.Write("Nhập số ngày: ");
        int n = DocSoNguyenDuong();
        double[] nhietDo = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhiệt độ ngày {i + 1}: ");
            nhietDo[i] = DocSoThuc();
        }

        double max = nhietDo[0], min = nhietDo[0], tong = 0;
        int ngayMax = 1, ngayMin = 1;

        for (int i = 0; i < n; i++)
        {
            tong += nhietDo[i];
            if (nhietDo[i] > max) { max = nhietDo[i]; ngayMax = i + 1; }
            if (nhietDo[i] < min) { min = nhietDo[i]; ngayMin = i + 1; }
        }

        Console.WriteLine($"Nhiệt độ cao nhất: {max} độ C (ngày {ngayMax})");
        Console.WriteLine($"Nhiệt độ thấp nhất: {min} độ C (ngày {ngayMin})");
        Console.WriteLine($"Nhiệt độ trung bình: {tong / n:F2} độ C");
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

    static double DocSoThuc()
    {
        double x;
        while (!double.TryParse(Console.ReadLine(), out x))
            Console.Write("Không hợp lệ, nhập lại số thực: ");
        return x;
    }
}
