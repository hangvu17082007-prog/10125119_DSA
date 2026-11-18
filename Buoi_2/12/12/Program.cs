using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Bai12();
        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }

    static void Bai12()
    {
        Console.Write("Nhập số dòng: ");
        int m = DocSoNguyenDuong();
        Console.Write("Nhập số cột: ");
        int n = DocSoNguyenDuong();

        int[,] banCo = new int[m, n]; // -1 là mìn, 0..8 là số mìn xung quanh
        Console.Write("Nhập số lượng mìn: ");
        int soMin;
        while (true)
        {
            soMin = DocSoNguyen();
            if (soMin >= 0 && soMin < m * n) break;
            Console.Write($"Số mìn phải từ 0 đến {m * n - 1}. Nhập lại: ");
        }

        Random random = new Random();
        int daDat = 0;
        while (daDat < soMin)
        {
            int i = random.Next(m);
            int j = random.Next(n);
            if (banCo[i, j] != -1)
            {
                banCo[i, j] = -1;
                daDat++;
            }
        }

        int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
        int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (banCo[i, j] == -1) continue;

                int demMin = 0;
                for (int k = 0; k < 8; k++)
                {
                    int x = i + dx[k], y = j + dy[k];
                    if (x >= 0 && x < m && y >= 0 && y < n && banCo[x, y] == -1)
                        demMin++;
                }
                banCo[i, j] = demMin;
            }
        }

        Console.WriteLine("\nBảng Minesweeper (* là mìn):");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write((banCo[i, j] == -1 ? "*" : banCo[i, j].ToString()) + "\t");
            Console.WriteLine();
        }
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
