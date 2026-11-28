using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp102
{
    internal class GotDemo
    {
        static void Main(string[] args)
        {
            //использование безусловного перехода goto
            //переменные: количество слагаемых, переменные, индексная
            //переменаая и значение суммы
            int n = 10, k = 1, s = 0;
            //отображение сообщения
            Console.Write("Сумма 1 + 3 + 5 +...+ {0}= ", 2 * n - 1);
            //использование метки:
            myLabel:
            //добавляем слагаемое в сумму
            s += 2 * k - 1;
            k++;
            //использование инструкции goto
            if (k <= n) goto myLabel;
            //отображение результата вычисленяи
            Console.WriteLine(s);


        }
    }
}
