using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //пятый пример  с использованием оператором цикла for
            int n = 10, k = 1, s = 0;
            Console.WriteLine("Сумма 1 + 3 + 5 +..+{0}=", 2 * n - 1);
            for (; ; )
            {
                s += 2 * k - 1;
                k++;
                //условный оператор
                if (k > n) break;
            }
            Console.WriteLine(s);
        }
    }
}
