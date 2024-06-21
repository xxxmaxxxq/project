using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == number2)
        {
            Console.WriteLine("Введенные числа равны.");
        }
        else if (number1 > number2)
        {
            Console.WriteLine("Первое число больше второго.");
        }
        else
        {
            Console.WriteLine("Первое число меньше второго.");
        }
    }
}
