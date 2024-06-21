using System;

namespace BankDepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада:");
            decimal initialAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев:");
            int months = Convert.ToInt32(Console.ReadLine());

            decimal finalAmount = initialAmount;
            for (int i = 0; i < months; i++)
            {
                finalAmount += finalAmount * 0.07m; // начисление 7% процентов
            }

            Console.WriteLine($"Итоговая сумма вклада после {months} месяцев: {finalAmount}");
        }
    }
}
