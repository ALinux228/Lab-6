using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========== ТЕСТИРОВАНИЕ КЛАССА MONEY ==========\n");

        // ========== ТЕСТ 1: Конструкторы ==========
        Console.WriteLine("--- Тест 1: Конструкторы ---");

        Money m1 = new Money(10, 50);      // 10 руб. 50 коп.
        Money m2 = new Money(5, 75);       // 5 руб. 75 коп.
        Money m3 = new Money(12345);       // 12345 копеек = 123 руб. 45 коп.
        Money m4 = new Money(-100);        // Отрицательное значение -> 0 руб. 0 коп.

        Console.WriteLine($"m1 (10 руб, 50 коп): {m1}");
        Console.WriteLine($"m2 (5 руб, 75 коп): {m2}");
        Console.WriteLine($"m3 (12345 копеек): {m3}");
        Console.WriteLine($"m4 (-100 копеек): {m4}\n");

        // ========== ТЕСТ 2: Методы Add и Subtract ==========
        Console.WriteLine("--- Тест 2: Методы Add() и Subtract() ---");

        Money m5 = new Money(10, 30);
        Console.WriteLine($"Исходное значение: {m5}");

        Money m5_add = m5.Add(45);
        Console.WriteLine($"После Add(45): {m5_add}");

        Money m5_sub = m5.Subtract(20);
        Console.WriteLine($"После Subtract(20): {m5_sub}");

        Money m5_sub_more = m5.Subtract(2000);
        Console.WriteLine($"После Subtract(2000) (отрицательное): {m5_sub_more}\n");

        // ========== ТЕСТ 3: Унарные операции ++ и -- ==========
        Console.WriteLine("--- Тест 3: Унарные операции ++ и -- ---");

        Money m6 = new Money(5, 99);
        Console.WriteLine($"Исходное значение: {m6}");

        m6++;
        Console.WriteLine($"После m6++: {m6}");

        m6--;
        Console.WriteLine($"После m6--: {m6}");

        // Префиксная форма
        Money m7 = new Money(1, 0);
        Console.WriteLine($"\nm7 = {m7}");
        Console.WriteLine($"++m7 = {++m7}");
        Console.WriteLine($"--m7 = {--m7}\n");

        // ========== ТЕСТ 4: Операции приведения типов ==========
        Console.WriteLine("--- Тест 4: Операции приведения типов ---");

        Money m8 = new Money(7, 85);
        Console.WriteLine($"m8 = {m8}");

        uint rubles = (uint)m8;
        Console.WriteLine($"Явное приведение к uint (рубли без копеек): {rubles}");

        double kopInRub = m8;
        Console.WriteLine($"Неявное приведение к double (копейки в рублях): {kopInRub:F2}\n");

        // ========== ТЕСТ 5: Бинарные операции + и - с uint ==========
        Console.WriteLine("--- Тест 5: Бинарные операции + и - с uint ---");

        Money m9 = new Money(10, 25);
        Console.WriteLine($"m9 = {m9}");

        Money m9_plus = m9 + 5;
        Console.WriteLine($"m9 + 5 руб = {m9_plus}");

        Money m9_minus = m9 - 3;
        Console.WriteLine($"m9 - 3 руб = {m9_minus}");

        Money m9_minus_error = m9 - 20;
        Console.WriteLine($"m9 - 20 руб (недостаточно рублей): {m9_minus_error}\n");

        // ========== ТЕСТ 6: Работа с копейками (переполнение) ==========
        Console.WriteLine("--- Тест 6: Переполнение копеек ---");

        Money m10 = new Money(0, 99);
        Console.WriteLine($"m10 = {m10}");

        m10++;
        Console.WriteLine($"m10++ (99 коп + 1 коп = 1 руб): {m10}");

        Money m11 = new Money(1, 0);
        Console.WriteLine($"\nm11 = {m11}");

        m11--;
        Console.WriteLine($"m11-- (1 руб - 1 коп = 0 руб 99 коп): {m11}\n");

        // ========== ТЕСТ 7: Сложение и вычитание с большими числами ==========
        Console.WriteLine("--- Тест 7: Работа с большими числами ---");

        Money m12 = new Money(1000, 50);
        Money m13 = m12.Add(500);
        Console.WriteLine($"1000 руб 50 коп + 500 коп = {m13}");

        Money m14 = new Money(999, 99);
        m14++;
        Console.WriteLine($"999 руб 99 коп + 1 коп = {m14}\n");

        // ========== ТЕСТ 8: Цепочки операций ==========
        Console.WriteLine("--- Тест 8: Цепочки операций ---");

        Money m15 = new Money(5, 50);
        Console.WriteLine($"m15 = {m15}");

        m15 = m15.Add(30).Add(20).Add(15);
        Console.WriteLine($"m15.Add(30).Add(20).Add(15) = {m15}");

        Money m16 = new Money(10, 0);
        m16 = m16 + 5 + 3 + 2;
        Console.WriteLine($"m16 + 5 + 3 + 2 = {m16}\n");

        // ========== ТЕСТ 9: Проверка отрицательных значений ==========
        Console.WriteLine("--- Тест 9: Защита от отрицательных значений ---");

        Money m17 = new Money(0, 10);
        Console.WriteLine($"m17 = {m17}");

        Money m17_sub = m17.Subtract(20);
        Console.WriteLine($"m17.Subtract(20) (не может быть отрицательным): {m17_sub}");

        Money m18 = new Money(-500);
        Console.WriteLine($"new Money(-500 копеек): {m18}\n");

        // ========== ТЕСТ 10: ToString() форматирование ==========
        Console.WriteLine("--- Тест 10: Форматирование ToString() ---");

        Money m19 = new Money(0, 5);
        Money m20 = new Money(0, 50);
        Money m21 = new Money(1, 1);
        Money m22 = new Money(100, 99);

        Console.WriteLine($"5 копеек: {m19}");
        Console.WriteLine($"50 копеек: {m20}");
        Console.WriteLine($"1 рубль 1 копейка: {m21}");
        Console.WriteLine($"100 рублей 99 копеек: {m22}");

        Console.WriteLine("\n========== ВСЕ ТЕСТЫ ЗАВЕРШЕНЫ ==========");
    }
}