using System;
class bai1
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen n: ");
        int n = int.Parse(Console.ReadLine());

        int[]a = new int[n];
        for(int i=0; i<n; i++)
        {
            Console.Write("nhap mang a[" + i + "]=");
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Cac phan tu cua mang la: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.Write("\nNhap gia tri x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Nhap vi tri k: ");
        int k = int.Parse(Console.ReadLine());

        if (k < 0 || k > n)
        {
            Console.WriteLine("Vi tri k khong hop le!");
            return;
        }
        int[] tmp = new int[n + 1];
        for (int i = 0; i < k; i++)
        {
            tmp[i] = a[i];
        }
        tmp[k] = x;
        for (int i = k; i < n; i++)
        {
            tmp[i + 1] = a[i];
        }
        a = tmp;
        n++;
        Console.WriteLine("\nMang sau khi chen:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

        Console.ReadKey();
    }
}
    
