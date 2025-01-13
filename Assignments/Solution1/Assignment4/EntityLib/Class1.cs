
using Attributeslib;

namespace EntityLib
{
	[DataTable(TableName ="employees")]
    public class Employee
    {
		
		private int _EmpNo;
      
        private string _Name;

        private string _Address;
       
        private int _Salary;
  
        private long _AnnualSalary;
      
        private string  _Designation;

        [DataColumn(ColumnName ="Desg",ColumnType ="varchar(30)")]
        public string Designation
        {
			get { return _Designation; }
			set { _Designation = value; }
		}

        [DataColumn(ColumnName ="Annual",ColumnType ="Bigint")]
        public long AnnualSalary
        {
			get { return _AnnualSalary; }
			set { _AnnualSalary = value; }
		}

        [DataColumn(ColumnType ="int",	ColumnName ="salary")]
        public int Salary
{
			get { return _Salary; }
			set { _Salary = value; }
		}


        [DataColumn(ColumnType = "varchar(50)", ColumnName = "Address")]
        public string Address
{
			get { return _Address; }
			set { _Address = value; }
		}


        [DataColumn(ColumnType = "varchar(30)", ColumnName = "name")]
        public string Name
{
			get { return _Name; }
			set { _Name = value; }
		}


        [DataColumn(ColumnType = "int", ColumnName = "salary" ,KeyColumn =true)]
        public int EmpNo
{
			get { return _EmpNo; }
			set { _EmpNo = value; }
		}

	}

	[DataTable(TableName ="students")]
	public class Student
	{
		private int _RollNo;

		private string  _Address;

		private string _Course;

        [DataColumn(ColumnName ="course",ColumnType ="varchar(30)")]
        public string Course
		{
			get { return _Course; }
			set { _Course = value; }
		}
        [DataColumn(ColumnName = "address", ColumnType = "varchar(30)")]
        public string  Address
		{
			get { return _Address; }
			set { _Address = value; }
		}
        [DataColumn(ColumnName = "Rollno", ColumnType = "int",KeyColumn =true)]
        public int ROllNo
		{
			get { return _RollNo; }
			set { _RollNo = value; }
		}
    }

}
