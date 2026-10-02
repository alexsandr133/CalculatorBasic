using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //целочисленая переменная числа
            int number, result, ostatok;
            //обработка ввода
            number = Int32.Parse(
             Interaction.InputBox(
             "введите число "    
                 )
             );
            result = number % 3;
            ostatok = 0;
            if ( ostatok > 0)
            {
                MessageBox.Show("число нечетное");
            }
            else
            {
                MessageBox.Show("число четное");
            }
        }
    }
}
