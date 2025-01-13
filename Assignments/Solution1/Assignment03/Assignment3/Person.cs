using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Person
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        
        bool gender;
        public bool Gender { get {  return gender; } set {  gender = value; } }
        Date birth;
        public Date Birth { get { return birth; } set { birth = value; } }
        public Person() { 
        Birth= new Date();
        
        }
        string address;
        public string Address { get { return address; } set { address = value; } }      
        int age;
        public int Age { get { return Date.YearDiff(new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year), Birth); } }

        public virtual void AcceptData() {
            Console.WriteLine("ENter the name");
        Name=Console.ReadLine();
            Console.WriteLine("Enter the gender (Male=true , Female=false)");
            Gender=bool.Parse(Console.ReadLine());
            Birth.AcceptDate();
            Console.WriteLine("Entrt the address");
            Address=Console.ReadLine();
        
        
        
        }
        public virtual void Printdata() { 
        
        Console.WriteLine("Name= "+Name);
            Console.WriteLine("Gender ="+Gender);
            Console.WriteLine("Date of birth ="+Birth);
            Console.WriteLine("Address =" +Address);
            Console.WriteLine("Age ="+Age);

        
        }
       

          


      
       
    

    }
}
