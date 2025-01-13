using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Date d1 = new Date();
            Date d2 = new Date();
            d1.AcceptDate();
            d2.AcceptDate();
            d1.ToString();
            d2.ToString();


            if (d1.IsValid() && d2.IsValid())
            {

                Console.WriteLine(Date.YearDiff(d1, d2));

            }
            else
            {
                Console.WriteLine("invalid date format");
            }


            Person person = new Person();   
            person.AcceptData();
            person.Printdata();
            Console.ReadLine();*/
           
           

            Employee employee = new Employee();
            employee.AcceptData();  
            employee.Printdata();
            Manager manager = new Manager();    
            manager.AcceptData();
            manager.Printdata();
            Supervisor supervisor = new Supervisor();   
            supervisor.AcceptData();
                supervisor.Printdata();
            WageEmployees employees = new WageEmployees();  
            employees.AcceptData();
                employees.Printdata();
                    
        }
    }
}
