
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
    // Khai bao danh sach toan cuc
    static Node head = null;

    // HAM THEM PHAN TU VAO CUOI DANH SACH
    static void Them(int x)
    {
        Node p = new Node(x);

        // Neu danh sach rong
        if (head == null)
        {
            head = p;
            return;
        }

        Node q = head;

        // Duyet den nut cuoi
        while (q.Next != null)
        {
            q = q.Next;
        }

        // Noi nut moi vao cuoi
        q.Next = p;
    }

    // HAM NHAP DANH SACH
    static void Nhap()
    {
        Console.Write("Nhap so luong nut: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so nguyen duong: ");
            int x = int.Parse(Console.ReadLine());

            Them(x);
        }
    }

    // HAM XUAT DANH SACH
    static void Xuat()
    {
        Node p = head;

        while (p != null)
        {
            Console.Write(p.Data + " ");
            p = p.Next;
        }

        Console.WriteLine();
    }

    // a. DEM SO PHAN TU BANG X
    static int Dem(int x)
    {
        int dem = 0;
        Node p = head;

        while (p != null)
        {
            if (p.Data == x)
            {
                dem++;
            }

            p = p.Next;
        }

        return dem;
    }

    // b. TIM SO DUONG NHO NHAT
    static void TimMin()
    {
        int min = int.MaxValue;
        Node p = head;

        while (p != null)
        {
            if (p.Data > 0 && p.Data < min)
            {
                min = p.Data;
            }

            p = p.Next;
        }

        if (min == int.MaxValue)
        {
            Console.WriteLine("Khong co so duong");
        }
        else
        {
            Console.WriteLine("So duong nho nhat: " + min);
        }
    }

    // c. XOA PHAN TU X XUAT HIEN DAU TIEN
    static void Xoa(int x)
    {
        // Neu danh sach rong
        if (head == null)
        {
            Console.WriteLine("Danh sach rong");
            return;
        }

        // Truong hop x nam o nut dau tien
        if (head.Data == x)
        {
            head = head.Next;
            Console.WriteLine("Da xoa!");
            return;
        }

        Node p = head;

        // Tim nut dung truoc nut can xoa
        while (p.Next != null && p.Next.Data != x)
        {
            p = p.Next;
        }

        // Neu tim thay x
        if (p.Next != null)
        {
            p.Next = p.Next.Next;
            Console.WriteLine("Da xoa!");
        }
        else
        {
            Console.WriteLine("Khong tim thay x");
        }
    }

    static void Main()
    {
        // Nhap danh sach
        Nhap();

        // Xuat danh sach
        Console.WriteLine("\nDanh sach vua nhap:");
        Xuat();

        // a. Dem so lan xuat hien cua x
        Console.Write("\nNhap x can dem: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("So lan xuat hien: " + Dem(x));

        // b. Tim so duong nho nhat
        TimMin();

        // c. Xoa x dau tien
        Console.Write("\nNhap x can xoa: ");
        int y = int.Parse(Console.ReadLine());

        Xoa(y);

        Console.WriteLine("\nDanh sach sau khi xoa:");
        Xuat();

        Console.ReadKey();
    }
}
