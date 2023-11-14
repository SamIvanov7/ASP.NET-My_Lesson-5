using System;

class Program
{
    static void Main()
    {
        // користувач вводить початок діапазону
        Console.WriteLine("Enter the beginning of the range:");
        int start = int.Parse(Console.ReadLine());
        // користувач вводить кінець діапазону
        Console.WriteLine("Enter the end of the range:");
        int end = int.Parse(Console.ReadLine());

        // Відображуэмо усі числа у діапазоні
        Console.WriteLine("All numbers in the range:");
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Відображуэмо усі чисел у діапазоні в порядку спадання
        Console.WriteLine("All numbers in descending order:");
        for (int i = end; i >= start; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // числа кратні 7
        Console.WriteLine("Numbers divisible by 7:");
        for (int i = start; i <= end; i++)
        {
            if (i % 7 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        // числа кратні 5 
        int countMultiplesOf5 = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                countMultiplesOf5++;
            }
        }
        Console.WriteLine("Count of numbers that are multiples of 5: " + countMultiplesOf5);
    }
}
