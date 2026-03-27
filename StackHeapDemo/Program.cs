using StackHeapDemo.Demos;
using System.Runtime.ExceptionServices;

namespace StackHeapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueTypeDemo.Run();
            ReferenceTypeDemo.Run();
            MethodMemoryDemo.Run();
            BoxingDemo.Run();
        }
    }
}