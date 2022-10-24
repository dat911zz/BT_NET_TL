using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2.BTTL
{
    public class B1
    {
        public int[] _arr;
        public int n;
        public B1()
        {
            
        }
        public B1(int[] arr)
        {
            _arr = arr;
            int i = 0;
            foreach (var item in _arr)
            {
                n++;
            }
        }
        public void CreateArray()
        {
            Console.Write("\nNhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap gia tri phan tu vt {0}: ",i);
                _arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void GenerateArray()
        {
            var rand = new Random();
            Console.Write("\nNhap so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            _arr = new int[n];
            for (int i = 0; i < n; i++)
            { 
                _arr[i] = rand.Next(-99, 99);
            }
        }
        public void ShowArray()
        {
            Console.Write("\nSo luong phan tu trong M1C: {0}", n);
            Console.WriteLine("\nDanh sach phan tu trong M1C: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(_arr[i] + " ");
            }
        }
        public void ShowOddInEvenPos()
        {
            Console.WriteLine("\nDanh sach phan tu le o vt chan trong M1C: ");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0 && _arr[i] % 2 != 0)
                {
                    Console.Write(_arr[i] + " ");       
                }
            }
        }
        public static bool isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            double m = Math.Round(Math.Sqrt(n));
            for (int i = 2; i < m; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void ShowPrimeNums()
        {
            int[] tmp = new int[n];
            int n_tmp = 0;
            Array.Sort(_arr);
            Console.WriteLine("\nDanh sach phan tu la SNT trong M1C: ");
            for (int i = 0; i < n; i++)
            {
                if (isPrime(_arr[i]))
                {
                    tmp[n_tmp++] = _arr[i];
                }
            }
            Console.Write("" + tmp[0] + " ");
            for (int i = 1; i < n_tmp; i++)
            {
                if (tmp[i] != tmp[i-1])
                {
                    Console.Write(tmp[i] + " ");
                }
            }
        }
        public void FindFirstMinusElements()
        {
            Console.Write("\nDanh sach phan tu am dau tien trong M1C: ");
            for (int i = 0; i < n; i++)
            {
                if (_arr[i] < 0)
                {
                    Console.Write(_arr[i]);
                    return;
                }
            }
        }
        public void FindMaxMin()
        {
            Console.Write("\nPhan tu MAX trong M1C: {0}", _arr.Max());
            Console.Write("\nPhan tu MIN trong M1C: {0}", _arr.Min());        
        }
        public void SumArr()
        {
            Console.Write("\nTong phan tu trong M1C: {0}", _arr.Sum());
        }
    }
}
