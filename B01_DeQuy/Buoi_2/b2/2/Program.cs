using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct nhanvien
{
    public string manv;
    public string tennv;
    public int namsinh;
    public string phongban;
    public int luongcoban;
    public int thuong;


}
class chungtrinh
{
    static void Main()
    {
        Console.Write("nhap so nhan vien: ");
        int n = int.Parse(Console.ReadLine());
        nhanvien[] nv = new nhanvien[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("nhap ma nhan vien: ");
            nv[i].manv = Console.ReadLine();
            Console.Write("nhap ten nhan vien: ");
            nv[i].tennv = Console.ReadLine();
            Console.Write("nhap nam sinh: ");
            nv[i].namsinh = int.Parse(Console.ReadLine());
            Console.Write("nhap phong ban: ");
            nv[i].phongban = Console.ReadLine();
            Console.Write("nhap luong co ban: ");
            nv[i].luongcoban = int.Parse(Console.ReadLine());
            Console.Write("nhap thuong: ");
            nv[i].thuong = int.Parse(Console.ReadLine());
        }
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            tong += nv[i].luongcoban + nv[i].thuong;
        }
        Console.WriteLine("Tong luong cua tat ca nhan vien la: {0}", tong);
        if (n > 0)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (nv[i].luongcoban < min)
                {
                    min = nv[i].luongcoban;
                }
            }
            Console.WriteLine("\nNhan vien co luong co ban thap nhat:");
            for (int i = 0; i < n; i++)
            {
                if (nv[i].luongcoban == min)
                {
                    Console.WriteLine("- Ma nhan vien: {0}, Ten nhan vien: {1}", nv[i].manv, nv[i].tennv);
                }
            }
        }
        int dem = 0;
        for (int i = 0; i < n; i++)
        {
            if (nv[i].thuong > 1200000)
            {
                dem++;
            }
        }
        Console.WriteLine("\nSo nhan vien co thuong lon hon 1.200.000 la: {0}", dem);
        // duyet phan tu va in nhan vien do
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nThong tin nhan vien thu {0}:", i + 1);
            Console.WriteLine("Ma nhan vien: {0}", nv[i].manv);
            Console.WriteLine("Ten nhan vien: {0}", nv[i].tennv);
            Console.WriteLine("Nam sinh: {0}", nv[i].namsinh);
            Console.WriteLine("Phong ban: {0}", nv[i].phongban);
            Console.WriteLine("Luong co ban: {0}", nv[i].luongcoban);
            Console.WriteLine("Thuong: {0}", nv[i].thuong);
        }
        Console.WriteLine("\nDanh sach sau khi tang luong 5%:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                nv[i].tennv +
                " - Luong moi: " + nv[i].luongcoban);
        }

        Console.ReadKey();
    }
}