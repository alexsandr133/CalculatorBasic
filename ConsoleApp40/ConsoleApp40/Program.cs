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
            result = number / 8;
            ostatok = result % 8 + result ;
            if (number == 0 )
            {
                Console.WriteLine("вы не ввели число");

            }
            else
            {
                Console.WriteLine($"у вас остаток от числа {result} число в восьмеричной системе {ostatok}");
            }
          
        }
    }
}
