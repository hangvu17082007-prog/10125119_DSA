
using System;

class Program
{
    static void Main()
    {
        // Nhap cap ma tran
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] a = new int[n, n];

        // NHAP MA TRAN
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("a[" + i + "," + j + "] = ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // HIEN THI MA TRAN
        Console.WriteLine("\nMa tran vua nhap:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(a[i, j] + "\t");
            }

            Console.WriteLine();
        }

        // a. TINH TONG CAC PHAN TU
        int tong = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tong += a[i, j];
            }
        }

        Console.WriteLine("\nTong ma tran: " + tong);

        // b. TIM SO DUONG NHO NHAT
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] > 0 && a[i, j] < min)
                {
                    min = a[i, j];
                }
            }
        }

        if (min == int.MaxValue)
        {
            Console.WriteLine("Khong co so duong trong ma tran");
        }
        else
        {
            Console.WriteLine("So duong nho nhat: " + min);
        }

        // c. TINH TONG DUONG CHEO PHU
        int tongPhu = 0;

        for (int i = 0; i < n; i++)
        {
            tongPhu += a[i, n - 1 - i];
        }

        Console.WriteLine("Tong duong cheo phu: " + tongPhu);

        // d. KIEM TRA DUONG CHEO CHINH TANG DAN
        bool tang = true;

        for (int i = 0; i < n - 1; i++)
        {
            if (a[i, i] >= a[i + 1, i + 1])
            {
                tang = false;
                break;
            }
        }

        if (tang)
        {
            Console.WriteLine("Duong cheo chinh tang dan");
        }
        else
        {
            Console.WriteLine("Duong cheo chinh khong tang dan");
        }

        Console.ReadKey();
    }
}
