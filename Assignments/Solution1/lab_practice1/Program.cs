using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lab_practice1
{
    internal class Program
    {
        static void Main1(String[] args)
        {
            #region to write
            /*string path = "C:\\New Folder\\Data.txt";
            FileStream fileStream = null;
            if(File.Exists(path))
            {
                fileStream =
                    new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fileStream =
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            }
            StreamWriter writer = new StreamWriter(fileStream);
            Console.WriteLine("Enter Something to write to : ");
            string data =Console.ReadLine();
            writer.WriteLine(data); 

            writer.Close();
            fileStream.Close();*/
            #endregion

            #region to read
            /*string path = "C:\\New Folder\\Data.txt";
            FileStream filestream = null;

            if(File.Exists(path))
            {
                filestream = 
                    new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(filestream);
                String data = sr.ReadToEnd();
                Console.WriteLine(data);

                sr.Close();
                filestream.Close();
            }
            else
            {
                Console.WriteLine("File Does Not Exist!");
            }*/
            #endregion

            #region object write
            string path = "C:\\New Folder\\ObjectInFile.txt";
            FileStream fileStream = null;

            if(File.Exists(path))
            {
                fileStream =
                    new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fileStream =
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            }
            BinaryFormatter specialWriter = new BinaryFormatter();
            Emp emp = new Emp();

            Console.WriteLine("Enter No");
            emp.No = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter Address");
            emp.Address = Console.ReadLine();

            specialWriter.Serialize(fileStream , emp);

            specialWriter = null;
            fileStream.Close();

            #endregion
        }
    }
    [Serializable]
    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

        [NonSerialized]
        private string _Password = "abc@123";

        public string Address
        { get { return _Address; } set {  _Address = value; } }

        public int No 
        { get { return _No; } set { _No = value; } }
        public string Name 
        { get { return _Name; } set { _Name = value; } }


    }
}
