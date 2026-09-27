using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day1 ="monday";
            string day2 = "Tuesday";
            string day3 = "wensday";
            string day4 = "tursday";
            string day5 = "friday";
            string day6 = "satursday";
            string day7 = "sunday";
            string res, txt, name, name1;
            int kolichestvo, count;
            name = Interaction.InputBox(
            "введите название дня недели",
            "привествую вас пользователь"
             );
            name1 = Interaction.InputBox(
            "введите название для месяца",
            "привествую вас пользователь"

            );
            res = Interaction.InputBox(
             "введите число"   
            );
            count = Int32.Parse(res);
            if (name ==day1)
            {
                MessageBox.Show($"день недели у вас {day1} ");
            }
            else if (name==day2)
            {
                MessageBox.Show($"день недели у вас {day2} ");
            }
            else if (name == day3)
            {
                MessageBox.Show($"день недели у вас {day3} ");
            }
            else if (name == day4)
            {
                MessageBox.Show($"день недели у вас {day4} ");
            }
            else if (name == day5)
            {
                MessageBox.Show($"день недели у вас {day5} ");
            }
            else if (name == day6)
            {
                MessageBox.Show($"день недели у вас {day6} ");
            }
            else if (name == day7)
            {
                MessageBox.Show($"день недели у вас {day7} ");
            }
            else
            {
                MessageBox.Show("вы ничего не ввели");
            }
            txt = $"инофррмация о дате сеогдня: {res}, {name}, {name1}";
            MessageBox.Show(txt, "приятно познакомится");
        }
    }
}
