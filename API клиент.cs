using System;
using System.Net;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        Console.Write("Введите название города: ");
        string city = Console.ReadLine();

        string apiKey = "YOUR_API_KEY"; 
        string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

        using (WebClient client = new WebClient())
        {
            string json = client.DownloadString(apiUrl);
            dynamic data = JsonConvert.DeserializeObject(json);

            string cityName = data["name"];
            string country = data["sys"]["country"];
            string description = data["weather"][0]["description"];
            double temp = data["main"]["temp"];
            int humidity = data["main"]["humidity"];

            Console.WriteLine($"Погода в городе {cityName}, {country}:");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Температура: {temp}°C");
            Console.WriteLine($"Влажность: {humidity}%");
        }
    }
}