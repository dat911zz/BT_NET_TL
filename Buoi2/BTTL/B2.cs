using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2.BTTL
{
    public class B2
    {
        int[][] _arr;
        int n, m;
        public void Generate2DArray()
        {
            var rand = new Random();
            Console.Write("\nNhap so dong: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("\nNhap so cot: ");
            n = int.Parse(Console.ReadLine());
            //Khởi tạo mảng 
            _arr = new int[m][];
            for (int i = 0; i < m; i++)
            {
                _arr[i] = new int[m];
            }
            //Nhập giá trị cho mảng
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    _arr[i][j] = rand.Next(-99, 99);            
                }
            }
        }
        public void Show2DArray()
        {
            Console.Write("\nM2C co: {0} dong, {1} cot", m, n);
            Console.WriteLine("\nDanh sach phan tu trong M1C: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(_arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void SumPositiveNum()
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum = _arr[i].Where(x => x > 0).Sum();
            }
            Console.WriteLine("\nTong cua cac so duong M2C: {0}", sum);

        }
        public void SumElementInMainCross()
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sum += _arr[i][j];
                    }
                }
            }
            Console.WriteLine("Tong cac phan tu tren duong cheo chinh: " + sum);
        }
        public void SumElementInTopTriangle()
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        sum += _arr[i][j];
                    }
                }
            }
            Console.WriteLine("Tong cac phan tu tam giac tren duong cheo chinh: " + sum);
        }
        public void SumEvenElement()
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum = _arr[i].Where(x => x % 2 == 0).Sum();
            }
            Console.WriteLine("Tong cac phan tu chan: " + sum);
        }
        public void SumElementAtRow()
        {
            Console.Write("\nNhap so dong: ");
            int row = int.Parse(Console.ReadLine());
            if (row < 0 || row > m)
            {
                Console.Write("\nSo dong da nhap khong nam trong khoang [{0},{1}]", 0, m - 1);                
            }
            else
            {
                Console.WriteLine("Tong cac phan tu tai dong {0} : {1}", row , _arr[row].Sum());
            }
            
        }
    }
}
