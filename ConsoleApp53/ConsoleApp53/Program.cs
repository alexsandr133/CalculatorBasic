using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace ConsoleApp53
{
    internal class SwitchDemo
    {
        static void Main(string[] args)
        {
            //программа определения числа
            //но мы используем окно ввода 
            //и оператор swith 

            int number;
            string name;
            //считывание числа
            number = Int32.Parse(
              Interaction.InputBox(
             "введите число",
             "добро пожаловать"

            )
            );
            //использование оператора выбора
            switch (number) {

                case 1:          //если ввели число 1
                name = "единица"; //название числа
                break;            //завершение блока

                case 2:
                name = "двойка";
                break;

                case 3:
                name = "тройка";
                break;

                case 4:
                name = "чнтверка";
                break;

                case 5:
                name = "пятерка";
                break;

                case 6:
                name = "шестерка";
                break;

                default:
                    //текст сообщения
                    name = "неизвестное число";
                    break;

            }
            
            //отображение сообщения
            MessageBox.Show(name,"число");
        }
    }
}
