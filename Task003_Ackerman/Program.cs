// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class MainClass
{
    public static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Введите значение m: ");
        int m = Int32.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = Int32.Parse(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine("m = " + m + ", n = " + n + " -> A(m,n) = " + result);
    }
}
