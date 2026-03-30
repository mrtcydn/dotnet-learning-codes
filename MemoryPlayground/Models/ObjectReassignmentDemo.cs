using MemoryPlayground.Demos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPlayground.Models
{
    internal class ObjectReassignmentDemo
    {
        public static void Run()
        {
            Console.WriteLine("[Object Reassignment Demo]");

            Box box = new Box() { Value = 32 };
            Console.WriteLine($"box1.Value: {box.Value}");

            ReassignBox(box);
            Console.WriteLine($"box1.Value after reassignment: {box.Value}");
            Console.WriteLine();
        }

        private static void ReassignBox(Box box)
        {
            box = new Box() { Value = 56 };
        }
    }
}
