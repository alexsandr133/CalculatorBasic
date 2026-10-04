using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            Console.WriteLine("введите число");
            int number = Convert.ToInt32((Console.ReadLine()));
            int number1 = Convert.ToInt32((Console.ReadLine()));
            int number2 = Convert.ToInt32((Console.ReadLine()));
            int number3 = Convert.ToInt32((Console.ReadLine()));
            int[] numbers = new int[] { 6, 7, 8, 9 };
            for(int i = 0;  i< numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    Console.WriteLine($"число в массиве есть {number} и массив {numbers[i]}");
                }
                else
                {
                    Console.WriteLine("числа нет");
                }
            }

        }
    }
}
