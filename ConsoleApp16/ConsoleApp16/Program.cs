using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//использлвание пространства имен
using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace ConsoleApp16
{
    
    class EnteringInteger
    {
        static void main() {

            //текстовая переменные
            string res, txt;
            //целочисденные переменные
            int year = 2026, age, born;
            //отображение окна с полем ввода
            res = Interaction.InputBox("в каком году вы родились?", "год рождения");
            //преобразование текста в число
            born = Int32.Parse(res);
            //вычисление возраста
            age = year - born;
            txt = "тогда вам " + age + "!";
            //окно с сообщением
            MessageBox.Show(txt, "возраст");

         }
    }
}
