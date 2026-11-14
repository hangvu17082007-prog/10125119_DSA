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
            Console.WriteLine("========== BUOI 01 - CHUONG 1 ==========");
            Console.WriteLine("1. Tim max/min trong 1000 so ngau nhien");
            Console.WriteLine("2. FizzBuzz 1 den 100");
            Console.WriteLine("3. Dao nguoc chuoi");
            Console.WriteLine("4. In mang va sap xep tang dan");
            Console.WriteLine("5. Tim so Fibonacci thu n");
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
                default: Console.WriteLine("Lua chon khong hop le."); continue;
            }
            Console.WriteLine();
            Console.Write("Nhan Enter de quay lai menu...");
            Console.ReadLine();
        }
    }
}
