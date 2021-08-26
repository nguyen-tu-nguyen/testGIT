using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ontap
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = -1;
           
            while (c != 0) {
                Console.WriteLine("Nhap lua chon:");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("1. Nhat rong\n2. Vuong rong\n3.Vuong dac");
                switch (c) {
                    case 1:
                        
                            Console.Write("Moi nhap chieu dai: ");
                    int d = int.Parse(Console.ReadLine());
                    Console.Write("Moi nhap chieu rong: ");
                    int r = int.Parse(Console.ReadLine());
                    for (int i = 0; i < d; i++)
                    {

                        for (int j = 0; j < r; j++)
                        {
                            if (j == 0 || j == r - 1 || i == 0 || i == d - 1)
                                Console.Write("*");
                            else
                                Console.Write(" ");

                        }
                        Console.WriteLine();
                }
                        break;
                    case 2:
                         Console.Write("Nhap h hinh vuong:");
                int h = int.Parse(Console.ReadLine());
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                break;
                    case 3:
                        Console.Write("Nhap h hinh vuong:");
                int u = int.Parse(Console.ReadLine());
                for (int i = 0; i < u; i++)
                {
                    for (int j = 0; j < u; j++)
                    {
                        if (i==0||j==0||i==u-1||j==u-1)
                        Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                break;
                    case 4:
                        break;
                    case 0:
                        return;
                    default: break;
                }
                // Ve hinh chu nhat rong trong C#
               
              
            }
            Console.ReadLine();
            

 }
        }
    }

