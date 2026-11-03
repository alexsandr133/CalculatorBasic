using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //программа калькулятор
            Console.WriteLine("Привествую вас пользователь!");
            Console.WriteLine("введите два числа и знак");
            int number1, number2;
            char sign;
            number1 = Int32.Parse(Console.ReadLine());
            number2 = Int32.Parse(Console.ReadLine());
            sign = char.Parse(Console.ReadLine());
            int result=0;
            switch(result)
            {
                case 1:
                sign = '+';
                result = number1 + number2;
                break;

                case 2:
                sign = '-';
                result = number1 - number2;
                break;

                case 3:
                sign = '*';
                result = number1 * number2;
                break;

                case 4:
                sign = '/';
                break;
                default:
                 result = 0;
                 Console.WriteLine($"вы не ввели число {result} ");
                 break;

            }
            Console.WriteLine($"ваш результат {result}");
        }
    }
}
