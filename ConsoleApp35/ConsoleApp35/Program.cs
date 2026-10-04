using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //целочисленная переменная
            int number;
            string txt;
            number = Int32.Parse(
            Interaction.InputBox(
             "введите число"    
                
                )
             );
            if (number >= 10 && number % 4 == 0)
            {
                MessageBox.Show("число подходит");
            }
            else
            {
                MessageBox.Show("число  НЕ подходит");
            }
            

        }
    }
}
