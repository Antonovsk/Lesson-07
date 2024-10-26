// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
using System;

class Program
{
    public Program()
    {
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNumbers(m + 1, n);
        }
    }
}
