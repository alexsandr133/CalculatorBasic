using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //текстовая переменная
            string name;
            //заголовок консольного окна
            Console.Title = "давайте познакомимя";
            //сообщение в консоли
            Console.WriteLine("Как вас зовут");
            //считывание текста
            name = Console.ReadLine();
            //еще одна тестовая переменная
            string txt = "очень приятно , "+name+"!";
            //заголовок консольного окна
            Console.Title = "знакомство состялось";
            //сообщение в консоли
            Console.WriteLine(txt);
        }
    }
}
