using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp101
{
    internal class ForDemoFive
    {
        static void Main(string[] args)
        {
            int n = 10, k = 1, s=0;
            Console.Write("Cумма 1 + 3 + 5 +..+{0} = ",2*n-1);
            for (; ; )
            {
                s += 2 * k - 1;
                k++;
                //условный оператор
                if (k > n) break; //завершение оператора цикла
            }
            Console.WriteLine(s);
        }
    }
}
