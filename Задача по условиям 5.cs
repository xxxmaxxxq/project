using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер операции: 1. Сложение 2. Вычитание 3. Умножение");
        int operationNumber = Convert.ToInt32(Console.ReadLine());

        switch (operationNumber)
        {
            case 1:
                Console.WriteLine("Выбрана операция: Сложение");
                break;
            case 2:
                Console.WriteLine("Выбрана операция: Вычитание");
                break;
            case 3:
                Console.WriteLine("Выбрана операция: Умножение");
                break;
            default:
                Console.WriteLine("Операция неопределена");
                break;
        }
    }
}