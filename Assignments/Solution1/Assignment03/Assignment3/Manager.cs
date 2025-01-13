using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Manager : Employee
    {
        public Manager() { }
        private double bonus;
        public double Bonus {  get { return bonus; } set {  bonus = value; } }

        public Manager(double bonus)
        {
            Bonus = bonus;
           
        }

        public override void AcceptData() {
            
            base.AcceptData();
            base.Designation = "manager";
            Console.WriteLine("Enteer the bonus");
            Bonus =Convert.ToDouble(Console.ReadLine()); 
        
        }
        public override void Printdata()
        {
            base.Printdata();
            Console.WriteLine("Bonus="+Bonus);
        }

        public override string ToString()
        {
            return $"{{{nameof(Bonus)}={Bonus.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Department)}={Department}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(Birth)}={Birth}, {nameof(Address)}={Address}, {nameof(Age)}={Age.ToString()}}}";
        }
    }
}
