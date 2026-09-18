using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //тестовые переменные
            string res, txt;
            //целочисленные переменные
            int year = 2017, age, born;
            //отображение окна с полем ввода
            res = Interaction.InputBox("в каком году вы родились ?", "год рождения");
            //преобрахование теста в число
            born = Int32.Parse(res);
            //вычисление возраста
            age = year - born;
            txt = "тогда вам: " + age + "!";
            //окно с сообщением 
            MessageBox.Show(txt, "возраст");

        }
    }
}
