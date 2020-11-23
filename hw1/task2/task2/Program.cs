using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            int a, b;
            double res;
            Console.Write("a = ");
            str1 = Console.ReadLine();
            Console.Write("b = ");
            str2 = Console.ReadLine();

            if (Int32.TryParse(str1, out a) && Int32.TryParse(str2, out b))
            {
                if (b == 0)
                    Console.WriteLine("Деление на 0!");
                else
                {
                    res = a / (double)b;
                    Console.WriteLine($"a / b = {res}");
                }

            }
            else
                Console.WriteLine("Некорректные данные!");
                   


        }
    }
}
