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
            Console.WriteLine("========== BUOI 01 - CHUONG 2 ==========");
            Console.WriteLine("1. Thap Ha Noi (do thoi gian)");
            Console.WriteLine("2. Tim kiem nhi phan (de quy)");
            Console.WriteLine("3. Kiem tra so nguyen to");
            Console.WriteLine("4. Liet ke so hoan hao nho hon n");
            Console.WriteLine("5. Fibonacci bang vong lap");
            Console.WriteLine("6. Sap xep noi bot (Bubble Sort)");
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
                default: Console.WriteLine("Lua chon khong hop le."); continue;
            }
            Console.WriteLine();
            Console.Write("Nhan Enter de quay lai menu...");
            Console.ReadLine();
        }
    }
}
