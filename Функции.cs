using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        int sum = SumTwoNumbers(97, 4);
        Console.WriteLine("Сумма двух чисел: " + sum);
        static int SumTwoNumbers(int a, int b)
        {
            return a + b;
        }

        double area = CircleArea(5);
        Console.WriteLine("Площадь окружности: " + area);
        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        int length = StringLength("Hello, Friend!");
        Console.WriteLine("Длина строки: " + length);
        static int StringLength(string s)
        {
            return s.Length;
        }

        int[] numbers = { 4, 7, 1, 3, 9 };
        int max = MaxValueInArray(numbers);
        Console.WriteLine("Наибольшее значение в массиве: " + max);
        static int MaxValueInArray(int[] arr)
        {
            return arr.Max();
        }

        int factorialResult = Factorial(3);
        Console.WriteLine("Факториал числа: " + factorialResult);
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        bool isPalindrome = IsPalindrome("radar");
        Console.WriteLine("Является ли строка палиндромом: " + isPalindrome);
        static bool IsPalindrome(string s)
        {
            return s.SequenceEqual(s.Reverse());
        }

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));
        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            return arr1.Concat(arr2).ToArray();
        }

        bool isPrime = IsPrime(13);
        Console.WriteLine("Является ли число простым: " + isPrime);
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        string reversedString = ReverseString("Hello, Friend!");
        Console.WriteLine("Обратная строка: " + reversedString);
        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        int[,] twoDArray = { { 1, 2, 3 }, { 4, 5, 6 } };
        int sum2DArray = Sum2DArray(twoDArray);
        Console.WriteLine("Сумма всех элементов двумерного массива: " + sum2DArray);
        static int Sum2DArray(int[,] arr)
        {
            int sum = 0;
            foreach (var num in arr)
                sum += num;
            return sum;
        }
    } 
}