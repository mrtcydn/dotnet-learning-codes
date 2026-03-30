using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPlayground.Models
{
    internal class BoxingDemo
    {
        public static void Run()
        {
            Console.WriteLine("[Boxing Demo]");

            int number = 65;
            object boxed = number; // Boxing occurs here
            number = 99; // Changing the original value

            Console.WriteLine($"boxed => {boxed}");
            Console.WriteLine($"number => {number}");

            int unboxed = (int)boxed; // Unboxing occurs here
            unboxed = 15; // Changing the unboxed value

            Console.WriteLine($"unboxed => {unboxed}");
            Console.WriteLine();

        }
    }
}
