using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_practice
{
    internal class Demo10
    {
        static void Main1(String[] args)
        {
            SQLServer sqlServer = new SQLServer();
            MyLogDelegate pointer = new MyLogDelegate(Developer2LogCode);
            sqlServer.QueryExecuted += pointer;

            sqlServer.insert();
            Console.ReadLine();
        }
        public static void Developer2LogCode(String code)
        {
            Console.WriteLine("My Log - "+code);
        }
    }
    public delegate void MyLogDelegate(string message);
    public class SQLServer {
        public event MyLogDelegate QueryExecuted;

        public void insert()
        {
            Console.WriteLine("SQL Server Record Inserted");
            QueryExecuted("SQL Data Added");
        }

        public void Update()
        {
            Console.WriteLine("SQL Server Record Updated");
            QueryExecuted("SQL Data Updated");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Server Record Deleted");
            QueryExecuted("SQL Data Deleted");
        }
    }
    public class Logger
    {
        public static Logger logger=new Logger();
        private Logger()
        {

        }
        
        public static Logger CurrentLogger
        {
            get { return logger;}
        }

        public void Log(String message)
        {
            Console.WriteLine("Logged at console : " + DateTime.Now.ToString() + " - " + message);
        }
    }
}
