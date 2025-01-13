using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

   public  class Date
    {

        int day, month, year;
        public Date() { }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public void AcceptDate()
        {
            Console.WriteLine("Enter the day");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            Year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine("Day= " + Day + " Month= " + Month + " Year = " + Year);
            Console.WriteLine("");
        }

        public static int YearDiff(Date d1, Date d2)
        {
            int diff = 0;
            if (d1.year > d2.year)
            {
                diff = d1.Year - d2.Year;
            }
            else
            {

                diff = d2.year - d1.year;
            }



            return diff;


        }

        public bool IsValid()
        {
            if (Day > 0 || Day <= 31 && Month > 0 || Month <= 12 && Year > 1900 | Year <= 2025)
            {
                
                return true;
            }
            else
            {
                Console.WriteLine("the date is in incorrect format");
                return false;

            }

        }
        public static int operator -(Date d1, Date d2)
        {
            return YearDiff(d1, d2);

        }

        public override string ToString()
        {
            return "Day=" + Day + "Month= " + Month + " Year = " + Year;
        }
    }
}