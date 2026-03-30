using MemoryPlayground.Demos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPlayground.Models
{
    internal class StringImmutabilityDemo
    {
        public static void Run()
        {
            Console.WriteLine("[String Immutability Demo]");

            Person person = new Person() { Name = "Can" , Age = 28};
            string name = person.Name;
            string name2 = name;

            name = "Murat";

            Console.WriteLine($"name: {name}");
            Console.WriteLine($"name2: {name2}");
            Console.WriteLine();
        }
    }
}
