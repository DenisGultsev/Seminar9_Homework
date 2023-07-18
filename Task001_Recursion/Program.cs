// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
        {
            Console.Write("N = " + n + " -> ");
            DisplayNumbers(n);
        }
        else
        {
            Console.WriteLine("Введенное значение должно быть целым числом >= 1");
        }

        Environment.Exit(0); // завершение работы программы
    }

    static void DisplayNumbers(int n)
    {
        if (n == 1)
        {
            Console.Write(n);
            return;
        }
        Console.Write(n + ", ");
        DisplayNumbers(n - 1);
    }
}
