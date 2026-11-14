using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp78
{
    internal class WhileDemo
    {
        static void Main(string[] args)
        {
            //количество слагаемых в сумме, индексная
            //переменная значение суммы
            int n = 10, k = 1, s = 0;
            //отображение сообщения
            Console.WriteLine("сумма  1+3+5+..+{0}= ",2*n-1);
            //оператор цикла
            while (k <= 1)
            {
                s+= 2*k-1;
                k++;
            }
            //отображение вычисленного значения
            Console.WriteLine(s);
        }
    }
}
