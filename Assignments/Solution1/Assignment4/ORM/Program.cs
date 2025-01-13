using Attributeslib;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace ORM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path= "D:\\CDAC\\Assignments\\MS.Net\\Assignment4\\EntityLib\\bin\\Debug\\net8.0\\EntityLib.dll";
            string queryFile = "D:\\CDAC\\Assignments\\MS.Net\\Assignment4\\Queries.sql";

            Assembly assembly = Assembly.LoadFrom(path);

            Type[] allTypes = assembly.GetTypes();

            foreach (Type type in allTypes)
            {
                string query = "";

                Attribute[] attributesOnType =
                    type.GetCustomAttributes().ToArray();

                foreach (Attribute attribute in attributesOnType)
                {
                    if (attribute is DataTable)
                    {
                        DataTable table = (DataTable)attribute;
                        //Console.WriteLine(table.TableName);
                        query = query +
                                "create table " + table.TableName
                                + "( ";
                        break;
                    }
                }
                PropertyInfo[] properties = type.GetProperties();
                string primaryColumn = "";
                foreach (PropertyInfo property in properties)
                {
                    Attribute[] propertyAttributes =
                          property.GetCustomAttributes().ToArray();

                    foreach (Attribute attribute in propertyAttributes)
                    {
                        if (attribute is DataColumn)
                        {
                            DataColumn column = (DataColumn)attribute;
                            if (column.KeyColumn)
                                primaryColumn = column.ColumnName;
                            query = query + column.ColumnName + " " +
                                    column.ColumnType + ",";
                            break;
                        }
                    }

                   

                }
                query = query + "PRIMARY KEY(" + primaryColumn + ")";
                query = query + " );";

                FileStream fileStream = null;

                if (File.Exists(queryFile))
                {
                    fileStream = new FileStream(queryFile, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fileStream = new FileStream(queryFile, FileMode.OpenOrCreate, FileAccess.Write);
                }

                StreamWriter writer = new StreamWriter(fileStream);
                writer.Write(query);
                writer.Close();
                fileStream.Close();

               /* writer = null;
                fileStream = null;*/

                Console.WriteLine("DONE Writing Query!");
            }


        }
    }
}

