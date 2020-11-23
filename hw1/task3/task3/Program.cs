using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            char res;
            Console.WriteLine("введите символ: ");
            ch = Console.Read();
            ch++;
            res = (char)ch;
            Console.WriteLine($"следующий символ: {res}");
        }
    }
}
