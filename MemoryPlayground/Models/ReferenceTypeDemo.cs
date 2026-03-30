using MemoryPlayground.Demos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MemoryPlayground.Models
{
    internal class ReferenceTypeDemo
    {
        public static void Run()
        {
            Console.WriteLine("[Reference Type Demo]");

            Box box1 = new Box() { Value = 55 };

            Box box2 = box1;
            box2.Value = 3;

            Console.WriteLine($"box1 => Value: {box1.Value}");
            Console.WriteLine($"box2 => Value: {box2.Value}");
            Console.WriteLine();
        }
    }
}
