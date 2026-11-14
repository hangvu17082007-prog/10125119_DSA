using System;
using System.Text;

class Bai4
{
    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("--- BÀI 4: IN MẢNG VÀ SẮP XẾP TĂNG DẦN ---");

        // Dùng 50 số để hiển thị đẹp mắt trên màn hình Console, nếu thích 1000 bạn sửa số 50 thành 1000
        int[] mangSo = TaoMangNgauNhien(50, 1, 100);

        Console.WriteLine("Mảng ban đầu:");
        Console.WriteLine(string.Join(", ", mangSo));

        Array.Sort(mangSo);

        Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
        Console.WriteLine(string.Join(", ", mangSo));

    }

    static int[] TaoMangNgauNhien(int soLuong, int minVal, int maxVal)
    {
        Random rand = new Random();
        int[] mang = new int[soLuong];
        for (int i = 0; i < soLuong; i++)
        {
            mang[i] = rand.Next(minVal, maxVal);
        }
        return mang;
    }
}