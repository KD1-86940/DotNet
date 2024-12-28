using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal struct Student
    {
        private String name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public void InitializeDefaults()
        {
            name = string.Empty;
            gender = false;
            age = 0;
            std = 0;
            div = 'A';
            marks = 0.0;
        }

        public Student(String name,bool gender , int age,int std,char div,double marks)
        {
            this.name =name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }
         
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Std
        {
            get { return std; }
            set { std = value; }
        }
        public char Div
        {
            get { return div; }
            set { div = value; }
        }
        public double Marks
        {
            get { return marks; }
            set { marks = value; }  
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Student Details : ");
            Console.WriteLine("Name     : ");
            name=Console.ReadLine();
            Console.WriteLine("Gender   : ");
            gender=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Age      : ");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Standard : ");
            std=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Division : ");
            div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Marks    : ");
            marks=Convert.ToDouble(Console.ReadLine());

        }
        public void PrintDetails()
        {
            Console.WriteLine($"Name     : { name}");
            Console.WriteLine($"Gender   : {(gender ? "male" : "female")}");
            Console.WriteLine($"Age      : { age}");
            Console.WriteLine($"Standard : {std}");
            Console.WriteLine($"Division : {div}");
            Console.WriteLine($"Marks    : {marks}");
        }
        /*static void Main(string[] args)
        {
            Student s = new Student();
            s.AcceptDetails();
            s.PrintDetails();
        }*/
    }
}
