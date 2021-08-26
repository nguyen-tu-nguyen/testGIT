using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan01
{
    class Program
    {
        static double bai01(double dongia, int sl)
        {
            double tt = dongia * sl;
            double gg = 0;
            if (tt > 100) { gg = tt * 0.3; }
            return tt - gg;
        }
        static double bai02(double kw)
        {
            double tt=0;
            if (kw < 0)
            { return 0;}
            if (kw<=100)
            {tt = 5 * kw;            }
            else if (kw <= 150)
            { tt = 5 * 100 + (kw - 100) * 7; }
            else if (kw <= 200)
            { tt = 500 + 350 + (kw - 150) * 10; }
            else if (kw <=300)
            { tt = 500 + 350 + 500 + (kw - 200) * 15; }
            else
            { tt = 500 + 350 + 500 + 100 * 15 + (kw - 300) * 20; }
            return tt;
        }
        static void Main(string[] args)
        {
            int n = -1;
            
            while(n!=0)
            {
                Console.Write("===========================================\nNhap so bai:");
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Khong phai so nguyen.");
                    throw;
                }
                switch(n)
                {
                    case 1:
                        Console.Write("Nhap don gia:");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Nhap so luong:");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Thanh tien la: {0:0.00}",bai01(b,a));
                        break;
                    case 2:
                        Console.Write("Nhap kw:");
                        double kw = double.Parse(Console.ReadLine());
                        Console.WriteLine("Thanh tien la: {0:0.00}", bai02(kw));
                        break;
                    case 3:

                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 0: 
                        Console.WriteLine("Thoat");
                        return;

                }
            }
            Console.ReadLine();

        }
    }
}
