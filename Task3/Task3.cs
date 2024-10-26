using System;

public class ReverseArray
{
    public static void Main(string[] args)
    {
        // Задаем произвольный массив
        int[] array = { 1, 2, 3, 4, 5 };

        // Вызываем рекурсивную функцию для вывода элементов в обратном порядке
        PrintReverse(array, array.Length - 1);

        Console.ReadLine();
    }

    // Рекурсивная функция для вывода элементов массива в обратном порядке
    public static void PrintReverse(int[] array, int index)
    {
        // Базовый случай: если индекс меньше 0, выходим из рекурсии
        if (index < 0)
        {
            return;
        }

        // Выводим текущий элемент
        Console.WriteLine(array[index]);

        // Рекурсивно вызываем функцию для следующего элемента
        PrintReverse(array, index - 1);
    }
}