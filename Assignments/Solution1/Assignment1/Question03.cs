using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Question03
    {
        public static int add(int x, int y)
        {
            return x + y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
        public static int mul(int x, int y)
        {
            return x * y;
        }
        public static int div(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            int choice = 0  ,num1=0,num2=0;
            do
            {
                Console.WriteLine("Which operation do you want to perform : ");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice != 0)
                {
                    Console.WriteLine("Enter first number : ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number : ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                switch (choice)
                {
                    case 0: Console.WriteLine("Exiting program");
                        break;
                    case 1:
                        Console.WriteLine("Addition : ");
                        Console.WriteLine(add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction : ");
                        Console.WriteLine(sub(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication : ");
                        Console.WriteLine(mul(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Division : ");
                        Console.WriteLine(div(num1, num2));
                        break;
                    default:
                        Console.WriteLine("invalid choice !");
                        break;
                }
            } while (choice != 0);
        }
    }
}
