using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    internal class  DoWhileDemo
    {
        static void Main(string[] args)
        {
            //количество слагаемых в сумме, индексная
            //переменная и значение суммы
            int n = 10, k = 1, s = 0;
            //отображение сообщения
            Console.Write("сумма 1 + 3 + 5 +...+{0} = ",2*n-1);
            //оператор цикла
            do
            {
                s += 2 * k - 1;
                k++;
            } while (k <= n);
            Console.Write(s);
            
        }
    }
}
