using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp21
{
    internal class DialogWindow
    {
        static void Main(string[] args)
        {
            string res, txt;
            int born,year = 2027, age ;

            res = Interaction.InputBox(
            "пользователь введите возраст"
            );
            born = Int32.Parse(res);
            age = year - born;
            txt = "тогда вам +" + age + " лет";
            MessageBox.Show(txt);
        }
    }

    
}
