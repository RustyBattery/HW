using System;

public enum HEI
{
    SPbSU,
    NSU,
    bonch,
    SFU,
    KFU
}
public struct Worker
{
    public string name;
    public string surname;
    public decimal salary;
    public HEI hei;
}

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker man;
            Console.WriteLine("Введите имя");
            man.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            man.surname = Console.ReadLine();
            Console.WriteLine("Введите зарплату");
            man.salary = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер вуза");
            man.hei = (HEI)Int32.Parse(Console.ReadLine());

            Console.WriteLine("Данные работника");
            Console.WriteLine($"имя: {man.name}");
            Console.WriteLine($"фамилия: {man.surname}");
            Console.WriteLine($"зарплата: {man.salary}");
            Console.WriteLine($"вуз: {man.hei}");
        }
    }
}
