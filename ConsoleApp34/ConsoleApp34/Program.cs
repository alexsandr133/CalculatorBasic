using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //программа проверки остатка
            int number1, number2, ostatok1, ostator2;
            string txt;
            //считвание целого числа
            number1 = Int32.Parse(
              Interaction.InputBox(
                  "введите число",
                  "привествую вас пользователь"
             )
             );
            ostatok1 = number1 % 5;
            if (ostatok1 == 2)
            {
                MessageBox.Show("число делится на 5 с остком 2");
            }
            else
            {
                MessageBox.Show("не получается остаток");
            }
            number2 = Int32.Parse(
            Interaction.InputBox(
             "введите число",   
             "привесвую вач пользователь"
             )
            );
            ostatok1 = number1 % 7;
            if (ostatok1 == 1)
            {
                MessageBox.Show("число делится на 7 с остком 1");
            }
            else
            {
                MessageBox.Show("не получается остаток");
            }


        }
    }
}
