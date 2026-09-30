using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt, num1, num2, sign1;
            int number1, number2, result;
            char sign;
            num1 = Interaction.InputBox(
             "введите первое число"   
            );
            num2 = Interaction.InputBox(
            "введите первое число"
            );
            sign = Interaction.SignBox(
            "введите знак"
            );
            number1 = Int32.Parse(num1);
            number2 = Int32.Parse(num2);
            if (sign == '+')
            {
                result = number1 + number2;
                MessageBox.Show(result);
            }
            else if(sign == '-')
            {
                result = number1 - number2;
            }
            else if (sign == '*')
            {
                result = number1 * number2;
            }
            else if (sign == '/')
            {
                result = number1 / number2;
            }
            txt = $"значение выражения: {result}";



        }
    }
}
