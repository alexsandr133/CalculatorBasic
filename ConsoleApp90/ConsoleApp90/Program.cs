using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
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

            double stavka = 0.020;
            int platege, price, procent, kolycheststvo_detey;
            int srok_pogashenia;
            string message, name, patronymic, branch_post, answer, region_progivanie;
            Console.WriteLine("и мы вам рассчитаем ипотеку");
            answer = Console.ReadLine();
            Console.WriteLine("введите следующие данные: имя");
            name = Console.ReadLine();
            Console.WriteLine("введите количество детей");
            kolycheststvo_detey = Int32.Parse(Console.ReadLine());
            Console.WriteLine("введите срок погашения");
            srok_pogashenia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("цену квартиры");
            price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("свою фамилию");
            patronymic = Console.ReadLine();
            Console.WriteLine("место своей работы");
            branch_post = Console.ReadLine();
            Console.WriteLine("введите регион проживания");
            region_progivanie = Console.ReadLine();
            while (answer == "да")
            {
                if (answer == "да")
                {
                    if (branch_post == "айти" && branch_post == "мвд" && branch_post == "мчс" && kolycheststvo_detey == 2)
                    {
                        stavka = 0.20;
                        double total_stavka = 0.05;
                        platege = (int)(price * total_stavka * (1 + total_stavka) * srok_pogashenia / (1 + total_stavka) * srok_pogashenia - 1);
                        Console.WriteLine($"ваш платеж по кредиту:{platege} ваше имя {name} ваша фамилия {patronymic}, ваше сфера работы{branch_post}");
                    }
                    else if(kolycheststvo_detey == 3 && region_progivanie =="мурмнск" && region_progivanie == "норильск")
                    {
                        double total_stavka1 = 0.08;
                        platege = (int)(price * total_stavka1 * (1 + total_stavka1) * srok_pogashenia / (1 + total_stavka1) * srok_pogashenia - 1);
                        Console.WriteLine($"ваш платеж по кредиту:{platege} ваше имя {name} ваша фамилия {patronymic}, ваше сфера работы{branch_post}");

                    }
                    else if (kolycheststvo_detey == 4 && branch_post =="айти" && branch_post == "мвд" &&  branch_post == "мчс")
                    {
                        stavka = 0.20;
                        double total_stavka2 = 0.05;
                        platege = (int)(price * total_stavka2 * (1 + total_stavka2) * srok_pogashenia / (1 + total_stavka2) * srok_pogashenia - 1);
                        Console.WriteLine($"ваш платеж по кредиту:{platege} ваше имя {name} ваша фамилия {patronymic}, ваше сфера работы{branch_post}");
                    }
                    else if(kolycheststvo_detey == 5 &&  branch_post == "farmacy" && branch_post == "tourism")
                    {
                        stavka = 0.20;
                        //platege = 0;
                        double total_stavka3 = 0.05;
                        platege = (int)(price * total_stavka3 * (1 + total_stavka3) * srok_pogashenia / (1 + total_stavka3) * srok_pogashenia - 1);
                        Console.WriteLine($"ваш платеж по кредиту:{platege} ваше имя {name} ваша фамилия {patronymic}, ваше сфера работы{branch_post}");
                    }
                    else if(kolycheststvo_detey == 6)
                    {
                        Console.WriteLine("вы освобождены от уплаты кредита");
                    }
                    else if(answer == "нет" && patronymic =="" && name == "" && branch_post== "" && srok_pogashenia == 0 && price == 0 )
                    {
                        Console.WriteLine("вы не ввели данные  если желаете продолжить то введите да и данные");
                        continue;

                    }
                    else if (kolycheststvo_detey == 0 && branch_post =="")
                    {
                        stavka = 0.20;
                        //platege = 0;
                        platege = (int)(price * stavka * (1 + stavka) * srok_pogashenia / (1 + stavka) * srok_pogashenia - 1);
                        Console.WriteLine($"ваш платеж по кредиту:{platege} ваше имя {name} ваша фамилия {patronymic}, ваше сфера работы{branch_post}");
                        Console.WriteLine("причина: у вас нет детей и вы не работаете в льготных по кредитах сферах");

                    }
                    else
                    {
                        Console.WriteLine("спасибо за внимание");
                        break;
                    }
                    Console.WriteLine($"платеж по вашей квартире/дому и ваши данные {name} {patronymic} {branch_post}{platege} ");
                   
                }

                }


            }
        }
    }

