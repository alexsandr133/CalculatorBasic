using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переменная для целого числа
            int number;
            int thousnds;
            string txt;
            number = Int32.Parse(
            Interaction.InputBox(
             "введите число",
             "число тысяч"
                
                )
            );
            //количесто тысяч для целочисленного
            thousnds = number / 1000 % 10;
            txt = "в этом числе " + thousnds + "тысяч";
            //отображение окна с сообщением
            MessageBox.Show("тысячи", txt);


        }
    }
}
