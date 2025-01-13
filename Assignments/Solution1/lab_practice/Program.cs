using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_practice
{
    delegate bool MyDelegate(int i);
    internal class Program
    {
        static void Main1(string[] args)
        {
            MyDelegate pointer=new MyDelegate(check);
            bool result = pointer(200);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static bool check(int i)
        {
            return i > 200;
        }
    }
}
