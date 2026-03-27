using System;
using System.Collections.Generic;
using System.Text;

namespace StackHeapDemo.Demos
{
    internal class BoxingDemo
    {
        static public void Run()
        {
            Console.WriteLine("[Boxing Demo]");
            int number = 65;
            object obj = number;
            number = 21;

            Console.WriteLine($"number: {number}");
            Console.WriteLine($"obj: {obj}");
        }
    }
}
