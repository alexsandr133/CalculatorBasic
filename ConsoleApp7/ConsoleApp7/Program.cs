using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вывл=одим первое число
            Console.WriteLine("привествую ввидите первое число");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите возраст");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("введите фамилию");
            string famylya = Console.ReadLine();

            Console.WriteLine("введите размер зарпоаты");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"привет пользователь: ваши данные:{age} возраст имя {name} фамилия {famylya} зарплата {salary}");

        }
    }
}
