using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите рубли: ");
        uint rub = uint.Parse(Console.ReadLine());
        Console.Write("Введите копейки: ");
        byte kop = byte.Parse(Console.ReadLine());

        Money money = new Money(rub, kop);
        Console.WriteLine($"Создан объект: {money}\n");

        Console.WriteLine("Унарная операция ++ (добавление копейки)");
        Console.WriteLine($"До ++: {money}");
        money++;
        Console.WriteLine($"После ++: {money}\n");

        Console.WriteLine("Унарная операция -- (вычитание копейки)");
        Console.WriteLine($"До --: {money}");
        money--;
        Console.WriteLine($"После --: {money}\n");

        Console.WriteLine("Бинарная операция + (Money + uint)");
        Console.Write("Введите количество рублей для сложения: ");
        uint rubToAdd = uint.Parse(Console.ReadLine());
        Money resultAdd = money + rubToAdd;
        Console.WriteLine($"{money} + {rubToAdd} руб = {resultAdd}\n");

        Console.WriteLine("Бинарная операция: (Money - uint)");
        Console.Write("Введите количество рублей для вычитания: ");
        uint rubToSubtract = uint.Parse(Console.ReadLine());
        Money resultSubtract = money - rubToSubtract;
        Console.WriteLine($"{money} - {rubToSubtract} руб = {resultSubtract}\n");

        Console.WriteLine("Приведение к uint (рубли без копеек)");
        uint rublesOnly = (uint)money;
        Console.WriteLine($"{money} приведение к uint: {rublesOnly} руб.\n");

        Console.WriteLine("Приведение к double (копейки в рублях)");
        double kopInRub = money;
        Console.WriteLine($"{money} приведение к double: {kopInRub:F2} руб.\n");

    }
}
