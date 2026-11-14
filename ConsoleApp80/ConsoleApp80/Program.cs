using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp80
{
    internal class AnotherWhileDemo
    {
        static void Main(string[] args)
        {
            //программа с уменьшенным количеством переменных
            //количество слагаемых в сумме и значние суммы
            int n = 10, s = 0;
            //отображение сообщения
            Console.Write("сумма 1 + 3 + 5 +...+ {0} = ",2*n-1);
            //оператор цикла
            while (n > 0)
            {
                s += 2*n-1; //добавляем слагаемое в сумму
                n--; //новое значение переменной n
            }
            Console.WriteLine(s);
        }
    }
}
