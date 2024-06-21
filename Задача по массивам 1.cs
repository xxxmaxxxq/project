using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 15, 17, 3, 40, 22, 69, 42, 87, 95, 10 };

        Console.WriteLine("Нечетные числа из массива:");
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}
