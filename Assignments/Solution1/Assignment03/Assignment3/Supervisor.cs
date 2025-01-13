using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Supervisor :Employee
    {
        private int subbordinates;
        public int Subbordinates {  get { return subbordinates; } set { subbordinates = value; } }

        public Supervisor()
        {

        }

        public Supervisor(int subbordinates)
        {
            Subbordinates = subbordinates;
         
        }

        public override void AcceptData()
        {
            base.AcceptData();
            base.Designation = "Supervisor";
            Console.WriteLine("Enter the subOrdinates");
            Subbordinates=Convert.ToInt32(Console.ReadLine());  

        }
        public override void Printdata()
        {
            base.Printdata();
            Console.WriteLine("Subordinates="+Subbordinates);
        }

        public override string ToString()
        {
            return $"{{{nameof(Subbordinates)}={Subbordinates.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Department)}={Department}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(Birth)}={Birth}, {nameof(Address)}={Address}, {nameof(Age)}={Age.ToString()}}}";
        }

        



    }
}
