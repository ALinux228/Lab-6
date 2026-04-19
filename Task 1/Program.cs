internal class Program
{
    private static void Main(string[] args)
    {
        // Базовый класс
        Console.Write("Введите строку: ");
        string readString = Console.ReadLine();
        StringWrapper newString = new StringWrapper(readString);
        Console.WriteLine($"Создан объект: {newString}");

        newString.Exclamation();
        Console.WriteLine($"Объект после вызова метода Exclamation: {newString}");

        StringWrapper copyString = new StringWrapper(newString); ;
        Console.WriteLine($"Копия объекта {newString}: {copyString}");


        // Дочерний класс
        Console.Write("Введите строку: ");
        readString = Console.ReadLine();
        RegisterString rs1 = new RegisterString(readString, false);
        Console.WriteLine($"Создан объект: {rs1}");

        Console.Write("Введите строку: ");
        readString = Console.ReadLine();
        RegisterString rs2 = new RegisterString(readString, true);
        Console.WriteLine($"Создан объект: {rs2}");

        Console.Write("Введите строку: ");
        readString = Console.ReadLine();
        RegisterString rs4 = new RegisterString(rs1);
        Console.WriteLine($"Оригинал: {rs1}");
        Console.WriteLine($"Копия: {rs4}");



        Console.Write("Введите строку: ");
        readString = Console.ReadLine();
        RegisterString rs3 = new RegisterString(readString, false);

        Console.WriteLine($"До ToUpper(): {rs3}");
        rs3.ToUpper();
        Console.WriteLine($"После ToUpper(): {rs3}");
        Console.WriteLine();

        Console.WriteLine($"До ToLower(): {rs3}");
        rs3.ToLower();
        Console.WriteLine($"После ToLower(): {rs3}");
        Console.WriteLine();
    }
}