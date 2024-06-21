using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 57, 10, 5, 24, 25 };

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine("Сумма элементов массива: " + sum);
        Console.WriteLine("Среднее арифметическое значение элементов массива: " + average);
    }
}