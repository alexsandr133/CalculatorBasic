using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp30
{
    internal class Program
    {
        //программа проверка числа на нечентность
        static void Main(string[] args)
        {
            //целочисленные переменые
            int number, remider;
            //считвание целого числа
            number = Int32.Parse(
             Interaction.InputBox(
             //текст в окне
             "введите целое число:",
             //название окна 
             "Проверка")
         );
            //вычисляется остаток от деления на 2
            remider = number % 2;
            string txt = "вы ввели";
            //использован тенарный оператор
            txt += (remider == 0 ? "четное" : "нечетное") + " число";
            MessageBox.Show(txt);
        }
    }
}
