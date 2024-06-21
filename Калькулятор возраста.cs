using System;

class AgeCalculator
{
    static void Main()
    {
        Console.WriteLine("Введите вашу дату рождения (в формате ГГГГ-ММ-ДД): ");
        DateTime birthDate;
        if (DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            DateTime currentDate = DateTime.Today;
            int years = currentDate.Year - birthDate.Year;
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                years--;
            }
            DateTime nextBirthday = birthDate.AddYears(years);
            int months = 0;
            while (currentDate > nextBirthday)
            {
                nextBirthday = nextBirthday.AddMonths(1);
                months++;
            }
            months--;
            int days = (currentDate - nextBirthday).Days;

            Console.WriteLine("Ваш возраст: " + years + " лет, " + months + " месяцев, " + days + " дней");
        }
        else
        {
            Console.WriteLine("Неверный формат даты");
        }
    }
}