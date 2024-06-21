using System;

class TimeConverter
{
    static void Main()
    {
        Console.WriteLine("Выберите тип конвертации: ");
        Console.WriteLine("1. 12-часовой формат в 24-часовой формат");
        Console.WriteLine("2. 24-часовой формат в 12-часовой формат");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Введите время в 12-часовом формате (например, 3:30 PM): ");
            string time12Hr = Console.ReadLine();
            DateTime time;
            if (DateTime.TryParse(time12Hr, out time))
            {
                string time24Hr = time.ToString("HH:mm");
                Console.WriteLine("Время в 24-часовом формате: " + time24Hr);
            }
            else
            {
                Console.WriteLine("Неверный формат времени");
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Введите время в 24-часовом формате (например, 15:30): ");
            string time24Hr = Console.ReadLine();
            DateTime time;
            if (DateTime.TryParseExact(time24Hr, "HH:mm", null, System.Globalization.DateTimeStyles.None, out time))
            {
                string time12Hr = time.ToString("h:mm tt");
                Console.WriteLine("Время в 12-часовом формате: " + time12Hr);
            }
            else
            {
                Console.WriteLine("Неверный формат времени");
            }
        }
        else
        {
            Console.WriteLine("Неверный выбор");
        }
    }
}