using MemoryPlayground.Models;

namespace MemoryPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueTypeDemo.Run();
            ReferenceTypeDemo.Run();
            MethodParameterDemo.Run();
            RefKeywordDemo.Run();
            BoxingDemo.Run();
            ObjectReassignmentDemo.Run();
            StringImmutabilityDemo.Run();
            GCDemo.Run();
        }
    }
}