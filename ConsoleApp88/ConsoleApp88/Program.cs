using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    internal class GotoDemo
    {
        static void Main(string[] args)
        {   
            //использование оператора безусловного оператора goto
            //переменные: количество слагаемых, индексная
            //переменная и знчение суммы
            int n = 10, k = 1, s = 0;
            //отображение сообщения
            Console.WriteLine("Сумма 1+3+5+..+{0}=",2*n-1);
            //использование метки
        mylabel:
            //добавляем слагаемое в сумму
            s += 2 * k - 1;
            //изменемение значения индексной переменной
            k++;
            //использование иструкции goto
            if (k <= n) goto mylabel;//переход к помеченному коду
            Console.WriteLine(s);
        }
    }
}
