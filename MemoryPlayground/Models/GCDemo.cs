using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryPlayground.Models
{
    internal class GCDemo
    {
        public static void Run()
        {
            Console.WriteLine("[GC Demo]");
            long before = GC.GetTotalMemory(false);
            Console.WriteLine($"Başlangıç memory: {before} bytes");

            List<byte[]> data = new List<byte[]>();

            for (int i = 0; i < 100; i++)
            {
                data.Add(new byte[1024 * 50]);
            }

            long afterAllocation = GC.GetTotalMemory(false);
            Console.WriteLine($"Allocation sonrası memory: {afterAllocation} bytes");

            data = null!;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long afterGC = GC.GetTotalMemory(true);
            Console.WriteLine($"GC sonrası memory: {afterGC} bytes");
            Console.WriteLine();

        }
    }
}
