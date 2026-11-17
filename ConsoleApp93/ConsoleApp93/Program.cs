using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //прошрамма расчета ипотеки
            /*
             * принцип работы программы:
             * сначала пользователь вводит ответ да нет.
             * дальше ввод имени фамилии и возраста,
             * дальше регион проживания,
             * и количество детей,
             * и специальность 
             * если  айти, мвд , или мчс то 
             * то у нас скидка 10 процентов
             * и ставка снижается
             * то просто выодить информацию
             * ставка не уменьшается а остается 
             * стандартной.
             * градация у нвс по количеству детей следующая:
             * 2 ребенка
             * 5 процентов
             * 3 ребенка 8
             * 4 ребенка 
             * 12 процентов
             * 5 детей скидка 15 процентов
             * 6 или более
             * ставка 0 процентов
             * выплачивает госудврство
             * если человек живет в норильске или лрпустим 
             * в мурманске то еще скидка 5 процентов к ставке
             * 
            */
            int price, srok_pogashenia;
            double platege;
            string name, patronymuc, brach_post, region;
            string answer;
            Console.WriteLine("добро пожжаловать в банк");
            Console.WriteLine("введите пожалуйста свои данные: имя и фамилию, и место работы");
            while (true)
            {
                Console.WriteLine("хотите расчитать ипотеку? да/нет");
                answer = Console.ReadLine();
                if (answer == "да")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("досвидания");
                    break;
                }
                Console.WriteLine("продолжайте вводить  данные: имя фамилию и место работы");
                Console.WriteLine("Введите имя:");
                name = Console.ReadLine();
                Console.WriteLine("введите фамилию");
                patronymuc = Console.ReadLine();
                Console.WriteLine("введите свое место работы");
                brach_post = Console.ReadLine();
                Console.WriteLine("введите срок погашения кредита:");
                srok_pogashenia = Int32.Parse(Console.ReadLine());

                //дальше начинаем подсчитывать ипотеку исходя из условия
                /*условия следующие:
                 * базовая ставка у нас 25 процентов.
                 * но если у человека есть следующие условия для льгот:
                 * работа в следующих секторах работ:
                 * мвд,мчс,айти
                 * то там скидка к ипотеке 10 процентов
                 * а про количество детей все описано выше.
                */
                double annul_kredits = 25.0;
                if (brach_post == "мвд" || brach_post == "айти" || brach_post == "мчс")
                {
                    annul_kredits -= 10.0;

                }
                else
                {
                    Console.WriteLine("вы не ммете льгот поэтому у вас стандатная ставка по кркдиту");
                }
                Console.WriteLine("введите количество детей: ");
                int childern = Int32.Parse(Console.ReadLine());
                if (childern == 2)
                {
                    annul_kredits -= 5;
                }
                else if (childern == 3)
                {
                    annul_kredits -= 8;
                }
                else if (childern == 4)
                {
                    annul_kredits -= 12;
                }
                else if (childern == 5)
                {
                    annul_kredits -= 15;
                }
                else if (childern >= 6)
                {
                    annul_kredits = 0;
                }

                //скидка за регион
                if(region =="мурмаск"|| region == "норильск")
                {
                    annul_kredits = -5;
                }
                //дальше обработка случая если платеж у нас льготный и не выплачивается
                if (annul_kredits == 0)
                {
                    platege = price / (srok_pogashenia * 12);
                }
                //если платеж все таки есть 
                else
                {
                    double MonthLyRate = annul_kredits / 100.0 / 12.0;
                    int mounths= srok_pogashenia * 12;

                    platege = price * MonthLyRate * Math.Pow(1 + MonthLyRate, mounths) / (Math.Pow(1 + MonthLyRate, mounths) - 1);

                }


        }
    }
    }
}
