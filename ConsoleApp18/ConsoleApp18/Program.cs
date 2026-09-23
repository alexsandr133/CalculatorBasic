using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp18
{
    internal class DialogWindow
    {
        static void Main(string[] args)
        {
            //текстовая переменная
            string name;
            string surname;

            name = Interaction.InputBox(
            "как вас зовут?",
            "давайте познакомимся"
             );
            //переменная с выводом
            string text = "очень приятно было познакомится, " + name + "!";

            //окно с сообщением
            MessageBox.Show(text, "знакомство состоялось");
        }
    }
}
