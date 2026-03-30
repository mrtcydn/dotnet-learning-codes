using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPlayground.Models
{
    internal class RefKeywordDemo
    {
        public static void  Run()
        {
            Console.WriteLine("[Ref Key Demo]");
            int number = -1;

            Console.WriteLine($"number before ChangeNumber : {number}");
            ChangeNumberByRef(ref number);
            Console.WriteLine($"number after ChangeNumber : {number}");
            Console.WriteLine();

        }

        private static void ChangeNumberByRef(ref int value)
        {
            value = 3;
        }
    }
}
