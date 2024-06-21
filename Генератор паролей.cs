using System;
using System.Security.Cryptography;

class PasswordGenerator
{
    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";

    static void Main()
    {
        Console.WriteLine("Введите длину пароля:");
        int passwordLength = int.Parse(Console.ReadLine());

        string password = GeneratePassword(passwordLength);
        Console.WriteLine($"Сгенерированный пароль: {password}");
    }

    static string GeneratePassword(int length)
    {
        byte[] data = new byte[length];
        using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
        {
            crypto.GetNonZeroBytes(data);
        }

        string password = "";
        for (int i = 0; i < length; i++)
        {
            password += chars[data[i] % chars.Length];
        }

        return password;
    }
}