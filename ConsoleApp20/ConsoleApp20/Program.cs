using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class ConsoleDialog
    {
        static void Main(string[] args)
        {
            Console.Title = "в этом оконе вы вводите свое имя и фамилию";
            Console.Write("введите имя и фамилию");
            string name, surname;
            name = Console.ReadLine();
            surname = Console.ReadLine();
            string txt = $"приятно познакомится пользователь,{name} {surname}";
            Console.WriteLine(txt);
        }
    }
}
