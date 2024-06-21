using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Выберите тип конвертации: ");
        Console.WriteLine("1. Цельсий в Фаренгейт");
        Console.WriteLine("2. Фаренгейт в Цельсий");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Введите температуру в Цельсиях: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Температура в Фаренгейтах: " + fahrenheit);
        }
        else if (choice == 2)
        {
            Console.WriteLine("Введите температуру в Фаренгейтах: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Температура в Цельсиях: " + celsius);
        }
        else
        {
            Console.WriteLine("Неверный выбор");
        }
    }
}
