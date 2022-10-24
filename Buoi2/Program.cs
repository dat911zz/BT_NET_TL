using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chon bai: ");
            int bai = int.Parse(Console.ReadLine());
            switch (bai)
            {
                case 1:
                    {
                        Console.WriteLine("\n=====BAI 1=====");
                        BTTL.B1 b1 = new BTTL.B1();
                        b1.GenerateArray();
                        b1.ShowArray();
                        b1.ShowOddInEvenPos();
                        b1.ShowPrimeNums();
                        b1.FindFirstMinusElements();
                        b1.SumArr();
                        break; 
                    }
                case 2:
                    {
                        Console.WriteLine("\n=====BAI 2=====");
                        BTTL.B2 b2 = new BTTL.B2();
                        b2.Generate2DArray();
                        b2.Show2DArray();
                        b2.SumPositiveNum();
                        b2.SumElementInMainCross();
                        b2.SumElementInTopTriangle();
                        b2.SumEvenElement();
                        b2.SumElementAtRow();
                        break;
                    }
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
