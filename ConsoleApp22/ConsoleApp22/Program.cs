using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//используем пространсво имен windowsforms и visualBasic
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //логика кода
            /*
             * у нас выходит диаогивое окно с предлженмем ввести имя и возраст
             * и пользователь вводит оба параметра и выходит диалоговое окно с привествием
             * использем пространсва имен System.Windows.Forsms - для отображения диалоговых окон
             * а пространсво имен Microsoft.VisualBasic - для использования ресурса int32.Parse
             * для перевода числа и его представления в числе а не строке будем использовать этот метод
            */
            string name,  res ,text;
            int born, year = 2026;
            name = Interaction.InputBox(
             "пользователь привествум вас",
             "введите имя"
            );

            res = Interaction.InputBox(
            "введите свой возраст"
            );
            born = Int32.Parse(res);
            text = "причтного знакоства пользлватель:+name+,+age+";
            MessageBox.Show(text);
        }
    }
}
