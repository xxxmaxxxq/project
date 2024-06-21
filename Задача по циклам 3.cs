using System;

namespace MultiplicationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите два числа от 0 до 10:");

                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                if ((num1 >= 0 && num1 <= 10) && (num2 >= 0 && num2 <= 10))
                {
                    Console.WriteLine($"Результат умножения: {num1} * {num2} = {num1 * num2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите два числа от 0 до 10.");
                }
            }
        }
    }
}