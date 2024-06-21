using System;

class Program
{
    static void Main()
    {
        string[] strings = { "яблоко", "банан", "лимон", "вишня", "арбуз", "апельсин" };

        Console.WriteLine("Введите строку для поиска:");
        string userInput = Console.ReadLine();

        bool found = false;
        foreach (string str in strings)
        {
            if (str.Equals(userInput, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }
}