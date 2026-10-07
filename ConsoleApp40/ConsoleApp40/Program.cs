using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //программа перевода числа из 10 в 8 чистемц счисления
            int number;
            int number2;
            int result;
            int ostatok;
            Console.WriteLine("введите число");
            number = Convert.ToInt32(Console.ReadLine());
            //result = number / 8;
            //ostatok = number % 8;
            string osratok1 = "";
            if (number == 0 )
            {
                Console.WriteLine("вы не ввели число и восьмеричное предсавление 0");

            }
            else
            {
              while(number < 0)
              {
                //выясняем остаток в от числа
                  ostatok = number % 8;
                    //приклеваем в начало
                    osratok1 = ostatok + osratok1;
                    number = number / 8;

              }
                Console.WriteLine($" число {number} в восьмеричной системе {number}");

            }
          
        }
    }
}
