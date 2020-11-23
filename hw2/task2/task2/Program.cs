using System;

public enum type_acc
{
    current,
    credit,
    deposit,
    budget
}
public struct Account
{
    public int num;
    public type_acc type;
    public decimal balance;
}

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc;
            Console.WriteLine("Введите номер");
            acc.num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер типа");
            acc.type = (type_acc)Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите баланс");
            acc.balance = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Данные банковского счета");
            Console.WriteLine($"номер: {acc.num}");
            Console.WriteLine($"тип: {acc.type}");
            Console.WriteLine($"баланс: {acc.balance}");
        }
    }
}
