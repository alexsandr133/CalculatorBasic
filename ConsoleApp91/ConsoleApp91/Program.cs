using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Желаете рассчитать ипотеку? (да/нет)");
            string answer = (Console.ReadLine() ?? "").Trim().ToLower();

            if (answer == "нет")
            {
                Console.WriteLine("До свидания.");
                break;
            }

            if (answer != "да")
            {
                Console.WriteLine("Введите 'да' или 'нет'.");
                continue;
            }

            Console.Write("Введите имя: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine() ?? "";

            Console.Write("Введите регион проживания: ");
            string region = (Console.ReadLine() ?? "").Trim().ToLower();

            Console.Write("Введите количество детей: ");
            int children = ReadInt("Количество детей");

            Console.Write("Введите сферу работы (айти/мвд/мчс/другое): ");
            string branch = (Console.ReadLine() ?? "").Trim().ToLower();

            Console.Write("Введите стоимость квартиры: ");
            double price = ReadDouble("Стоимость квартиры");

            Console.Write("Введите срок погашения в годах: ");
            int years = ReadInt("Срок погашения");

            double annualRate = 20.0; // базовая ставка, %

            // Скидка за детей
            if (children == 2)
                annualRate -= 5;
            else if (children == 3)
                annualRate -= 8;
            else if (children == 4)
                annualRate -= 12;
            else if (children == 5)
                annualRate -= 15;
            else if (children >= 6)
                annualRate = 0;

            // Скидка за профессию
            if (branch == "айти" || branch == "мвд" || branch == "мчс")
                annualRate -= 10;

            // Скидка за регион
            if (region == "мурманск" || region == "норильск")
                annualRate -= 5;

            if (annualRate < 0)
                annualRate = 0;

            double payment;

            if (annualRate == 0)
            {
                payment = price / (years * 12);
            }
            else
            {
                double monthlyRate = annualRate / 100.0 / 12.0;
                int months = years * 12;

                payment = price * monthlyRate * Math.Pow(1 + monthlyRate, months)
                          / (Math.Pow(1 + monthlyRate, months) - 1);
            }

            Console.WriteLine();
            Console.WriteLine($"Клиент: {name} {surname}");
            Console.WriteLine($"Сфера работы: {branch}");
            Console.WriteLine($"Регион: {region}");
            Console.WriteLine($"Детей: {children}");
            Console.WriteLine($"Итоговая ставка: {annualRate:F2}%");
            Console.WriteLine($"Ежемесячный платеж: {payment:F2} руб.");
            Console.WriteLine();
        }
    }

    static int ReadInt(string field)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;

            Console.Write($"Некорректное значение. Введите {field} ещё раз: ");
        }
    }

    static double ReadDouble(string field)
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double value))
                return value;

            Console.Write($"Некорректное значение. Введите {field} ещё раз: ");
        }
    }
}