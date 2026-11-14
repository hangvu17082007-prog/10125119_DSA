using System;
using System.Text;

class Bai1
{
    public static void Run()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("--- BÀI 1: TÌM MAX / MIN TRONG 1000 SỐ NGẪU NHIÊN ---");

        int[] mangSo = TaoMangNgauNhien(1000, 1, 1000);

        int soLonNhat = mangSo[0];
        int soNhoNhat = mangSo[0];

        foreach (int so in mangSo)
        {
            if (so > soLonNhat) soLonNhat = so;
            if (so < soNhoNhat) soNhoNhat = so;
        }

        Console.WriteLine($"Đã khởi tạo mảng gồm 1000 phần tử ngẫu nhiên.");
        Console.WriteLine($"+ Số lớn nhất (Max) trong mảng là: {soLonNhat}");
        Console.WriteLine($"+ Số nhỏ nhất (Min) trong mảng là: {soNhoNhat}");

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