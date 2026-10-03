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
            int number1, number2, ostatok1, ostatok2;
            string txt;
            //считвание целого числа
            number1 = Int32.Parse(
              Interaction.InputBox(
                  "введите число 1",
                  "привествую вас пользователь"
              
             )
             );
            number2 = Int32.Parse(
             Interaction.InputBox(
                 "введите число 2",
                 "привествую вас пользователь"
            )
            );
            ostatok1 = number1 % 5;
            ostatok2 = number2 % 7;
            if (ostatok1 == 2)
            {
                MessageBox.Show("число делится на 5 с остком 2");
                
               
            }
            else
            {
                MessageBox.Show("не получается остаток");
            }
            if (ostatok2 == 1)
            {
                MessageBox.Show("число делится на 7 с остком 1");
            }
            else
            {
                MessageBox.Show("не получается остаток");
            }
            txt = $"остаток от деления: {ostatok1} и {ostatok2}";
            MessageBox.Show("остаток от деления", txt);
           

        }
    }
}
