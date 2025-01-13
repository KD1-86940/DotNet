using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab_practice1
{
    internal class Reflection
    {
        static void Main(String[] args)
        {
            string path = "F:\\parag\\backup\\drive E\\cdac course\\sunbeam data\\ms.net\\Day08\\MathsLib\\bin\\Debug\\MathsLib.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            Type[] types=assembly.GetTypes();
            foreach (Type t in types)
            {
                #region print basic details found using reflection
                /*Console.WriteLine(t.FullName);
                Console.WriteLine("Type Name : {0} : ", t.FullName);
                Console.WriteLine("Is Class? {0} : ", t.IsClass);
                Console.WriteLine("Is Generic {0} : ", t.IsGenericType);
                Console.WriteLine("Is Abstract? {0} : ", t.IsAbstract);*/
                #endregion

                object dynamicallyCreatedObject =
                    assembly.CreateInstance(t.FullName);
                MethodInfo[] methods= t.GetMethods();
                foreach (MethodInfo m in methods)
                {
                    Console.WriteLine("Calling {0} Method", m.Name);
                    ParameterInfo[] allparams = m.GetParameters();
                    object[] parametersToMethod = new object[allparams.Length];
                    for (int i = 0; i < allparams.Length; i++)
                    {
                        Console.WriteLine("Enter value for {0} of type {1}",
                            allparams[i].Name,
                            allparams[i].ParameterType);

                        string parameterValueInString = Console.ReadLine();

                        object parameterInRespectiveType =
                            Convert.ChangeType(parameterValueInString,
                            allparams[i].ParameterType);
                        parametersToMethod[i] = parameterInRespectiveType;
                    }

                    object output =
                        t.InvokeMember(m.Name,
                        BindingFlags.Public |
                        BindingFlags.Instance |
                        BindingFlags.InvokeMethod,
                        null,
                        dynamicallyCreatedObject,
                        parametersToMethod);

                    Console.WriteLine("Output is {0}", output);
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}
