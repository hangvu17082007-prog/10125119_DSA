using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("========== BUOI 01 - CHUONG 3 ==========");
            Console.WriteLine("1. S(n) = 1 + 2 + ... + n");
            Console.WriteLine("2. S(n) = 1 + 2^2 + ... + n^2");
            Console.WriteLine("3. S(n) = 1 + 1/2 + ... + 1/n");
            Console.WriteLine("4. S(x, n) = x^n");
            Console.WriteLine("5. Uoc le lon nhat cua n");
            Console.WriteLine("6. UCLN(a, b)");
            Console.WriteLine("7. Dem so chu so cua n");
            Console.WriteLine("8. S(n) = sqrt(1 + sqrt(2 + ... + sqrt(n)))");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon bai: ");
            if (!int.TryParse(Console.ReadLine(), out int chon))
            {
                Console.WriteLine("Gia tri khong hop le.");
                continue;
            }
            if (chon == 0) break;
            Console.WriteLine();
            switch (chon)
            {
                case 1: Bai1.Run(); break;
                case 2: Bai2.Run(); break;
                case 3: Bai3.Run(); break;
                case 4: Bai4.Run(); break;
                case 5: Bai5.Run(); break;
                case 6: Bai6.Run(); break;
                case 7: Bai7.Run(); break;
                case 8: Bai8.Run(); break;
                default: Console.WriteLine("Lua chon khong hop le."); continue;
            }
            Console.WriteLine();
            Console.Write("Nhan Enter de quay lai menu...");
            Console.ReadLine();
        }
    }
}
