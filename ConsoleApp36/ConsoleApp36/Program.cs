using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //челочисленная переменая
            int number;
            number = Int32.Parse(
            Interaction.InputBox(
            "привествую вас",
            "введите число"
             )
            );
            if (number >= 10 && number %4 == 0)
            {
                MessageBox.Show("число удовлетворяет условию");
            }
            else
            {
                MessageBox.Show("число не удовлетворяет условию");
            }
        }
    }
}
