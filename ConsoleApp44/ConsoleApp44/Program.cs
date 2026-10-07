using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переменная для опредендения типа пентаграммы
            MessageBox Icon;
            //переменные для определения
            //теста сообщения  заголовка окна и имени пользователя
            string msg, title, name;
            //считвание имени пользлвателя
            name = Interaction.InputBox(
            //текст над полем ввода
            "Как вас зовут?",
            //название окна 
            "Знакомися");
            //проверка
            if (name == "")
            {
                //еси пользователь не ввел имя
                Icon = MessageBoxIcon.Error;
                //текст сообщения
                msg = "очень жаль что не познакомились";
                title = "знакомство не состоялось";
            }
            else
            {
                //если текст введен
                //информационная пиктограмма
                Icon = MessageBoxIcon.Information;
                //текст сообщения

            }
             
        }
    }
}
