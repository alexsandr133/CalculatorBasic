using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    internal class ForDemo
    {
        static void Main(string[] args)
        {
            //количество слагаемых в сумме индесная
            // переменная и значение суммы
            int n = 10, k, s = 0;
            //отображение сообщения
            Console.Write("сумма 1 + 3 + 5 +...+{0}= ",2*n -1);
            //оператор цикла
            for(k=1; k<=n; k++)
            {
                s += 2 * k - 1;//добавляем слагаемое в сумму
            }
            Console.Write(s);
        }
    }
}
