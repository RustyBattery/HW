using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2, str3;
            int a, b, c, d;
            double x1, x2;

            Console.Write("a = ");
            str1 = Console.ReadLine();
            Console.Write("b = ");
            str2 = Console.ReadLine();
            Console.Write("c = ");
            str3 = Console.ReadLine();

            if (Int32.TryParse(str1, out a) && Int32.TryParse(str2, out b) && Int32.TryParse(str3, out c))
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if(c==0)
                            Console.WriteLine("x - любое число");
                        else
                            Console.WriteLine("нет решений");
                    }
                    else
                    {
                        x1 = -c / (double)b;
                        Console.WriteLine($"x = {x1}");
                    }
                }
                else
                {
                    d = b * b - 4 * a * c;
                    if(d<0)
                        Console.WriteLine("нет решений");
                    if (d == 0)
                    {
                        x1 = -b / (2 * (double)a);
                        Console.WriteLine($"x = {x1}");
                    }
                    if (d > 0)
                    {
                        x1 = (-b - Math.Sqrt(d)) / (2 * (double)a);
                        x2 = (-b + Math.Sqrt(d)) / (2 * (double)a);
                        Console.WriteLine($"x1 = {x1}");
                        Console.WriteLine($"x2 = {x2}");
                    }
                }
            }
            else
                Console.WriteLine("Некорректные данные!");
        }
    }
}
