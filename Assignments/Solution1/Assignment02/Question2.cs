using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Question2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How Many records you want to insert : ");
            int size=Convert.ToInt32(Console.ReadLine());   
            Assignment02.Student[] students = new Student[size];
            CreateArray(students);
            AcceptInfo(students);
            PrintInfo(students);
            ReverseArray(students);
            PrintInfo(students);
        }

        private static void ReverseArray(Student[] students)
        {
            for(int i = 0,j=students.Length-1;i<j;i++,j--)
            {
                Student temp = students[i];
                students[i] = students[j];
                students[j] = temp;
            }
        }

        private static void PrintInfo(Student[] students)
        {
            Console.WriteLine("Students Details : ");
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Student [{i + 1}] : ");
                students[i].PrintDetails(); 
            }
        }

        private static void AcceptInfo(Student[] students)
        {
            for (int i = 0;i < students.Length;i++)
            {
                students[i].AcceptDetails();
            }
        }

        private static void CreateArray(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();    
            }
        }
    }
}
