using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//используем ресурсы visual basic
using Microsoft.VisualBasic;
namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //текстовая переменная
            string name;
            //отображение окна с поле ввода\
            name = Interaction.InputBox(
                "как вас зовут?", //текст над аолем ввода
                "давай познакомися" //название окна
                );
            string txt = "очень приятно, "+name+"!";
            //окно с сообщением
            MessageBox.Show(txt, "знакомство состоялось");

        }
    }
    
}
