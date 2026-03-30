using MemoryPlayground.Demos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPlayground.Models
{
    internal class MethodParameterDemo
    {
        static public void Run()
        {
            Console.WriteLine("[Method Parameter Demo]");
            int number = -1;
            Box box = new Box() { Value = 88 };

            ChangeNumber(number);
            Console.WriteLine($"number after ChangeNumber : {number}");

            ChangeBoxValue(box);
            Console.WriteLine($"box.Value after ChangeBoxValue : {box.Value}");
            Console.WriteLine();
        }

        private static void ChangeNumber(int value)
        {
            value = 3;
        }

        private static void ChangeBoxValue(Box box)
        {
            box.Value = 5;
        }
    }
}
