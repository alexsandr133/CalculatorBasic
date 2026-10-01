using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp31
{
    internal class HundredsDemo
    { 
        //программа которая опраделяет число 100
        static void Main(string[] args)
        {

            //целочисленные переменные
            int number, hundreds;
            //считывание целого числа
            number = Int32.Parse(
            Interaction.InputBox(
              //надпись над полем ввода
              "введите целое число: ",
              //загловок окна
              "количество сотен"
             )
            );
            //количество сотен в числе (для целочисленных)
            //операндов деление выполянется налево
            hundreds = number / 100 % 10;
            //текстовая переменная
            string txt = "в этом числе " + hundreds + "  сотен";
            //отображение окна с сообщением
            // (arguments  метода - сообщение и заголовок окна)
            MessageBox.Show(txt, "сотни");
        }
    }
}
