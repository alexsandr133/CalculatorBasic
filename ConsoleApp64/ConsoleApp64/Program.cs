using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp64
{
    internal class SwitchDemo
    {
        static void Main(string[] args)
        {
            //переменная для записи числа
            int number;
            //переменная для названия числа числа
            string name;
            //считывание числа 
            number = Int32.Parse(
            Interaction.InputBox(
            "введите число",
            "число"
             )        
             );
            //использование оператора выбора
            //для определения введенного числа
            switch(number)
            {
                case 1:
                name = "единица";
                break;

                case 2:
                name = "двойка";
                break;

                case 3:
                name = "тройка";
                break;

                case 4:
                name = "четверка";
                break;

                case 5:
                name = "пятерка";
                break;

                case 6:
                name = "шестерка";
                break;

                default:
                 //текст сообщения
                 name = "вы ввели неизвестное число";
                 break;

            }
            MessageBox.Show(name,"введенное вами число");
        }
    }
}
