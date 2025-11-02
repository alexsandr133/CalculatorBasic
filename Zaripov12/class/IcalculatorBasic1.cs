using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using CalculatorBasic.BasicCalculator.classes;

public class calculatorBasic
{
    private const string Value = "enter a number";
    private object result;
    private char sign;
    private int value1;
    public calculatorBasic() { }
    public void run() { 
        while (true)
        {   // выводим сообщение об использовании
            Console.WriteLine("вы хотите использовть приложение?");
            Console.WriteLine("вводите ответ да или нет");
            String answer = Console.ReadLine().Trim().ToLower();
            answer = Console.ReadLine("введете ответ");
            if ( answer == "yes" )
            {   // обЬЯвляем переенные
                int value1, value2, result;
                char sign;

                String answer = Console.ReadLin
                value2 = Console.ReadLine(value1);
                value2 = (int)Convert.ToSingle(Console.ReadLine());
                result = Convert.ToInt32(value1, value2);
                Console.Write("введите знак действия:");
                sign = Convert.ToChar(Console.ReadLine());
                Console.Write("введете второе число");
               
                
            }
            if (sign == '+')
            {   
                result = value1 + value2;
                Console.WriteLine("Сумма чисел равна" + result);
                Console.WriteLine("нажмите на любую кнопку для выхода");
   
            }
            else if (sign == '-')
            {
                result = value1 - value2;
                Console.WriteLine("разность чисел равна" + result);
                Console.WriteLine("для выхода нажмите на любую кнопку");
            }
            else if (sign == '/')
            {
                result = value1 / value2;
                Console.WriteLine("деление чисел равно" + result);
                Console.WriteLine(" для выхода нажите любую кнопку");
            }
            else if (sign == '*')
            {
                result = value1 * value2;
                Console.WriteLine("умножение чисел равно" + result);
                Console.WriteLine("для выхода нажмите кнопка");
            }
    }
        


    }

}
