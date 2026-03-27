using StackHeapDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackHeapDemo.Demos
{
    internal class MethodMemoryDemo
    {
        static public void Run()
        {
            Console.WriteLine("[Method Memory Demo]");

            int value = 123;
            ChangeValue(value);
            Console.WriteLine($"ChangeValue value: {value}");
            ChangeValueUsingRef(ref value);
            Console.WriteLine($"ChangeValueUsingRef value: {value}");

            Box box = new Box();
            box.Value = 111;

            ChangeValue(box.Value);
            Console.WriteLine($"ChangeValue box.Value: {box.Value}");
            ChangeObject(box);
            Console.WriteLine($"ChangeObject box.Value: {box.Value}");
            ChangeObjectCreatingNewObject(box);
            Console.WriteLine($"ChangeObjectCreatingNewObject box.Value: {box.Value}\n");
        }

        public static void ChangeValue(int x)
        {
            x = 999;
        }

        public static void ChangeValueUsingRef(ref int x)
        {
            x = 888;
        }

        public static void ChangeObject(Box box)
        {
            box.Value = 999;
        }

        public static void ChangeObjectCreatingNewObject(Box box)
        {
            box = new Box();
            box.Value = 777;
        }
    }
}
