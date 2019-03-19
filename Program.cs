using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type Something = typeof(String);
            MethodInfo method = Something.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });
            Object text = method.Invoke("there was a Sapar", new object[] { 11, 6 });
            Console.WriteLine($"{text}");

            Type Lists = typeof(List<>);
            foreach(var something in Lists.GetMembers())
            {
                if(something is ConstructorInfo)
                {
                    Console.WriteLine($"{something}");
                }
            }



        }

        


    }




}
