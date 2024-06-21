using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number == 5 || number == 10)
        {
            Console.WriteLine("Число либо равно 5, либо равно 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
    }
}