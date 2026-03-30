using MemoryPlayground.Demos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPlayground.Models
{
    internal class ValueTypeDemo
    {
        public static void Run()
        {
            Console.WriteLine("[Value Type Demo]");
            PointStruct p1 = new PointStruct();
            p1.X = 5;
            p1.Y = 12;

            PointStruct p2 = p1;
            p2.X = 34;

            Console.WriteLine($"p1 => X: {p1.X} , Y: {p1.Y}");
            Console.WriteLine($"p2 => X: {p2.X} , Y: {p2.Y}");
            Console.WriteLine();

        }
    }
}
