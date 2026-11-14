using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp89
{
    internal class TryCatchDemo
    {
        static void Main(string[] args)
        {
            //знакомство с перехватом исключений
            //сообщение о начале выполнения программы
            MessageBox.Show("выполянется программа начало", "начало");
            //перехват и обработка исключений
            try
            {
                //контролируемый код
                //попытка преобразовать текст в число
                Double.Parse(
                    Interaction.InputBox(
                     "введите действительное число",
                     "число"
                )
               );
                MessageBox.Show("да это было число!","число");
            }
            //блок обработки исключений
            catch
            {
                //отображение сообщения
                MessageBox.Show(
                "надо было ввести число",
                //заголовок ошиька
                "ошибка",
                //в окне одна кнопка ок
                MessageBoxButtons.OK,
                //используется пиктограмма ошибки
                MessageBoxIcon.Warning
                );
            }
            //завершение блока обработки ошибок
            //сообщение о завершении работы программы
            MessageBox.Show("программа завершена","конец");


        }
    }
}
