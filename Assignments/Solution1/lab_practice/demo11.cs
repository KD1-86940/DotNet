using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_practice
{
    internal class demo11
    {
        public static void Main(String[] args)
        {
            int x=10, y=20;
            Console.WriteLine("X : " + x);
            Console.WriteLine("Y : " + y);

            Maths<int> maths = new Maths<int>();

            maths.Swap(ref x,ref y);

            Console.WriteLine("X : " + x);
            Console.WriteLine("Y : " + y);
        }
    }
    public class  Maths<T>
    {
        public void Swap(ref T x, ref T y)
        {
            T z = x ;
            x = y;
            y = z;
        }
    }
}
