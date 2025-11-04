using CalculatorBasic.BasicCalculator.classes;
using NPOI.SS.Formula.Functions;
using NPOI.XSSF.Streaming.Values;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
//код внутри класса icalculator basic
public class IcalculatorBasic1
{
    private double value2;
    private double value1;

    public IcalculatorBasic1() { }
    public void run(char sign) {

        //назначаем кодировку
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        
        //начало работы программы
        while (true)
        {   // выводим сообщение об использовании
            Console.WriteLine("вы хотите использовать приложение?");
            Console.WriteLine("вводите ответ да или нет");
            //переменная для ответа
            String answer = Console.ReadLine().Trim().ToLower();

            if (answer == "нет" || answer == "no")
            {
                break;
            }
               
            else if (answer == "да" || answer == "yes")
             
            {   //используем класс
                BasicCalculation();

            }
            else
            {
                Console.WriteLine("введите ответ да/нет");
            }
            
            double value1 = 0, value2 = 0, result = 0;
            char sign = '+';

            //ввод ответа
            Console.Write("введите первое число:");
            //конвертируем значения в double value
            value1 = Convert.ToDouble(Console.ReadLine());   
            Console.Write("введите оператор +,-,/,*");
            //ввод знака действия
            Console.Write("введите знак действия:");
            sign = Convert.ToChar(Console.ReadLine());
            Console.Write("введете второе число");
            value2 = Convert.ToDouble(Console.ReadLine());
            //выполняем вычисления
            if (sign == '+')
            { 
               
                Console.WriteLine("Сумма чисел равна" + result);
                Console.WriteLine("нажмите на любую кнопку для выхода");

            }
            else if (sign == '-')
            {
                result = value1 - value2;
                Console.WriteLine("разность чисел равна" + result);
                
            }
            
            //действие на  деление
            else if (sign == '/')
            {
                

                result = value1 / value2;
                Console.WriteLine("деление чисел равно" + result);
                Console.WriteLine(" для выхода нажите любую кнопку");
            }
            //действие на вычитание
            else if (sign == '*')
            {        
                Console.WriteLine("умножение чисел равно" + result);
                Console.WriteLine("для выхода нажмите кнопка");
            }
        }

    } 
            private void BasicCalculation()
    {

    }             
             
        


    }

