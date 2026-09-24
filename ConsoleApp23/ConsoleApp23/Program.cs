using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp23
{
    internal class ConsoleDialog
    {
        static void Main(string[] args)
        {  
            Console.Title = "приветствую вас пользователь";
            Console.Write("введите имя");
            string name = Console.ReadLine();
            Console.Title = ("введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());
            string txt = $"инофрмацмя о пользователе: {name},{age}";
            Console.WriteLine(txt);
            Console.Title = "знакомство соятоялось";


        }
    }
}
