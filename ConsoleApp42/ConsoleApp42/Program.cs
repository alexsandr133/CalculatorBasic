using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //программа перевода числа в восьмеричную систему счисления
            /*
             * логика программы и вообще как она работает
             * у нас вводится число и система переводит в 8 ричную чистему
             * дальше описание алгоритма
             * сначала делим на 8 получаем частное
             * а далее остатки считаем
             * и  получкеное от деления остатки зписываем
            */
            int number;
            //int ostatok1 ;
            string ostatok2 = "";
            Console.WriteLine("добро пожаловать пользователь");
            Console.WriteLine("введите число");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("вы не ввели число, восьмибитное прдеставление 0");
            }
            else
            {
                while(number <0 )
                {
                    Console.WriteLine("8 битное преставдение числа:");
                    int ostatok3 = number % 8;
                    //склеивание в начало
                    ostatok2 = ostatok2 + ostatok3;
                    //деление
                    number = number / 8;
                }
            }
            Console.WriteLine($"число в восьмеричном преставлении {number} и восьмеричное преставление {number}");
        }
    }
}
