using System;

namespace TaskManagerCLI.Helpers
{
    static class InputHelper
    {
        public static string ReadRequiredText(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                Console.WriteLine("Bu alan bos bırakılamaz!");
            }
        }
        public static int ReadRequiredInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input");
            }
        }
    }
}
