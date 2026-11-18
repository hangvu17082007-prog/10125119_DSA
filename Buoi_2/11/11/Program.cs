using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Bai11();
        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }

    static void Bai11()
    {
        Console.Write("Nhập cấp ma trận vuông n: ");
        int n = DocSoNguyenDuong();
        int[,] a = new int[n, n];

        Console.WriteLine("Nhập các phần tử ma trận:");
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                Console.Write($"a[{i},{j}] = ");
                a[i, j] = DocSoNguyen();
            }

        bool donVi = true;
        bool doiXung = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int giaTriCanCo = (i == j) ? 1 : 0;
                if (a[i, j] != giaTriCanCo) donVi = false;
                if (a[i, j] != a[j, i]) doiXung = false;
            }
        }

        Console.WriteLine(donVi ? "Là ma trận đơn vị." : "Không phải ma trận đơn vị.");
        Console.WriteLine(doiXung ? "Là ma trận đối xứng." : "Không phải ma trận đối xứng.");
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
