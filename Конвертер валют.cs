using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Введите сумму в исходной валюте:");
        double amount = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите курс обмена (сколько нужно единиц новой валюты для одной единицы исходной):");
        double exchangeRate = double.Parse(Console.ReadLine());

        double convertedAmount = ConvertCurrency(amount, exchangeRate);

        Console.WriteLine($"Сумма после конвертации: {convertedAmount}");
    }

    static double ConvertCurrency(double amount, double exchangeRate)
    {
        return amount * exchangeRate;
    }
}