using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Employee :Person
    {
        private int id;
        private static int count = 1;

        public  int Id
        {
           
            get { return id; }
            
        }

        private double salary;
        public double Salary
        {get { return salary; } set { salary = value; }     

        }
        private string designation;
        public string Designation
        {

            get { return designation; } set { designation = value; }
        }
        private string department;
        public string Department
        {
            get { return department; }  set { department = value; }
        }
        
        public  override void AcceptData() {
            base.AcceptData();
            Console.WriteLine("Enter the Salary");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the designation");
            Designation = Console.ReadLine();
            Console.WriteLine("enter the Department");
            Department = Console.ReadLine();
        
        
        
        }

        public Employee() { 
             id = count++;
        }

      public Employee(double salary,  string designation,  string department)
        {
            Salary = salary;
         
            Designation = designation;
            
            Department = department;
           
        }
        public override void Printdata()
        {
            base.Printdata();
            
            Console.WriteLine("ID = " + Id);
            Console.WriteLine("Salary = " + Salary);
            Console.WriteLine("Designation = " + Designation);
            Console.WriteLine("Department = "+Department);
        
        }

        public override string ToString()
        {
            return base.ToString() + "Id = "+Id +" Salary = "+Salary+" Designation "+Designation +" Department = "+Department;
        }
    }
}
