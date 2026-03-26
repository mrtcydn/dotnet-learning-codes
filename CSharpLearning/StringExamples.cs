using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    internal class StringExamples
    {
        public static void Run()
        {
            Console.WriteLine("\nStringExamples started....");

            string name = "Can";
            string name2 = name;

            name2 = "Murat";
            Console.WriteLine(name);
            Console.WriteLine(name2);
        }
    }
}
