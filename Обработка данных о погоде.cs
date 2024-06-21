using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество дней: ");
        int num_of_days = Convert.ToInt32(Console.ReadLine());

        double[] temperatures = new double[num_of_days];

        for (int i = 0; i < num_of_days; i++)
        {
            Console.Write($"Введите температуру для дня {i + 1}: ");
            temperatures[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        double max_temp = double.MinValue;
        double min_temp = double.MaxValue;

        foreach (double temp in temperatures)
        {
            sum += temp;
            if (temp > max_temp)
                max_temp = temp;
            if (temp < min_temp)
                min_temp = temp;
        }

        double average_temp = sum / num_of_days;

        Console.WriteLine($"Средняя температура: {average_temp:F2} градусов Цельсия");
        Console.WriteLine($"Максимальная температура: {max_temp} градусов Цельсия");
        Console.WriteLine($"Минимальная температура: {min_temp} градусов Цельсия");
    }
}