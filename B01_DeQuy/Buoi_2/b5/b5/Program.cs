
using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int x)
    {
        Data = x;
        Next = null;
    }
}

class Program
{
    static Node head = null;

    static void Them(int x)
    {
        Node p = new Node(x);

        if (head == null)
        {
            head = p;
            return;
        }

        Node q = head;

        while (q.Next != null)
        {
            q = q.Next;
        }

        q.Next = p;
    }

    // Kiem tra so nguyen to
    static bool KTNT(int x)
    {
        if (x < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0)
                return false;
        }

        return true;
    }

    // a. Tim max
    static int TimMax()
    {
        int max = int.MinValue;
        Node p = head;

        while (p != null)
        {
            if (p.Data > max)
                max = p.Data;

            p = p.Next;
        }

        return max;
    }

    // b. Tinh tong
    static int TinhTong()
    {
        int tong = 0;
        Node p = head;

        while (p != null)
        {
            tong += p.Data;
            p = p.Next;
        }

        return tong;
    }

    // c. Dem so nguyen to
    static int DemNguyenTo()
    {
        int dem = 0;
        Node p = head;

        while (p != null)
        {
            if (KTNT(p.Data))
                dem++;

            p = p.Next;
        }

        return dem;
    }

    // d. Dem am, 0, duong
    static void DemAmDuong0()
    {
        int am = 0, duong = 0, so0 = 0;

        Node p = head;

        while (p != null)
        {
            if (p.Data < 0)
                am++;
            else if (p.Data > 0)
                duong++;
            else
                so0++;

            p = p.Next;
        }

        Console.WriteLine("So am: " + am);
        Console.WriteLine("So duong: " + duong);
        Console.WriteLine("So 0: " + so0);
    }

    // e. Dem so phan tu bang x
    static int DemX(int x)
    {
        int dem = 0;
        Node p = head;

        while (p != null)
        {
            if (p.Data == x)
                dem++;

            p = p.Next;
        }

        return dem;
    }

    // f. Tim so duong nho nhat
    static void MinDuong()
    {
        int min = int.MaxValue;
        Node p = head;

        while (p != null)
        {
            if (p.Data > 0 && p.Data < min)
                min = p.Data;

            p = p.Next;
        }

        if (min == int.MaxValue)
            Console.WriteLine("Khong co so duong");
        else
            Console.WriteLine("Min duong: " + min);
    }

    static void Main()
    {
        Console.Write("Nhap so nut: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap gia tri: ");
            int x = int.Parse(Console.ReadLine());
            Them(x);
        }

        Console.WriteLine("\nDanh sach:");

        Node p = head;
        while (p != null)
        {
            Console.Write(p.Data + " ");
            p = p.Next;
        }

        if (head != null)
            Console.WriteLine("\nGia tri lon nhat: " + TimMax());
        else
            Console.WriteLine("\nDanh sach rong");

        Console.WriteLine("Tong: " + TinhTong());
        Console.WriteLine("So luong so nguyen to: " + DemNguyenTo());

        DemAmDuong0();

        Console.Write("\nNhap x: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("So lan xuat hien cua x: " + DemX(k));

        MinDuong();
    }
}
