using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2.BTTL
{
    public class B3
    {
        string _name;
        public void Input()
        {
            Console.Write("\nNhap ten: ");
            _name = Console.ReadLine();
        }
        public bool isSymmetric()
        {
            var charArr = _name.ToCharArray();

            for (int i = 0; i < _name.Length / 2; i++)
            {
                if (charArr[i] != charArr[(_name.Length - 1) - i])
                {
                    return false;
                }
            }
            return true;
        }
        //public void CapitalizeEachWord()
        //{
        //    string[] tmp = _name.Split(' ');
        //    foreach (var item in tmp)
        //    {
        //        item.Replace(item, item.Substring(0, 1).ToUpper());
        //    }
        //    _name.Remove(0);
        //    _name.Join("das")
        //}
        //public void ShowResults()
        //{

        //}
    }
}
