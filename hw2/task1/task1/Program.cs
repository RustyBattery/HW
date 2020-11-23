using System;

public enum Account
{
    current,
    credit,
    deposit,
    budget
}

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account bank = Account.credit;
            Console.WriteLine($"{bank}");
            bank++;
            Console.WriteLine($"{bank}");
        }
    }
}
