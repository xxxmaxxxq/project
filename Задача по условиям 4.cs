using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        double interestRate = 0;

        if (depositAmount < 100)
        {
            interestRate = 0.05;
        }
        else if (depositAmount >= 100 && depositAmount <= 200)
        {
            interestRate = 0.07;
        }
        else
        {
            interestRate = 0.10;
        }

        double totalAmount = depositAmount + (depositAmount * interestRate);
        Console.WriteLine($"Сумма вклада с начисленными процентами: {totalAmount}");
    }
}