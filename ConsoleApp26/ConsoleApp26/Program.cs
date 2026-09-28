using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ConsoleApp26
{
    internal class DialogWindow
    {
        static void Main(string[] args)
        {
            string day, txt, mouth, answer;
            int semptember = 31;
            int octember = 30;
            int november = 31;
            int december = 31;
            int janavary = 31;
            int february = 28;
            int march = 31;
            int april = 30;
            int may = 31;
            int jule = 30;
            int iyuol = 31;
            int august = 31;
            string mouth1 = "september";
            string mouth2 = "octember";
            string mouth3 = "novomber";
            string mouth4 = "december";
            string mouth5 = "janavary";
            string mouth6 = "february";
            string mouth7 = "march";
            string mouth8 = "april";
            string mouth9 = "may";
            string mouth10 = "june";
            string mouth11 = "iyol";
            string mouth12 = "august";


            mouth = Interaction.InputBox(
             "Введите название месяца и я скажу сколь в нем дней"
             );
            if (mouth == mouth1)
            {
                MessageBox.Show($"ваш месяц {mouth1} количество дней в нем: {semptember}");
            }
            else if(mouth == mouth2)
            {
                MessageBox.Show($"ваш месяц {mouth2} количество дней в нем: {octember}");
            }
            else if (mouth == mouth3)
            {
                MessageBox.Show($"ваш месяц {mouth3} количество дней в нем: {november}");
            }
            else if (mouth == mouth4)
            {
                MessageBox.Show($"ваш месяц {mouth4} количество дней в нем: {december}");
            }
            else if (mouth == mouth5)
            {
                MessageBox.Show($"ваш месяц {mouth5} количество дней в нем: {janavary}");
            }
            else if (mouth == mouth6)
            {
                MessageBox.Show($"ваш месяц {mouth6} количество дней в нем: {february}");
            }
            else if (mouth == mouth7)
            {
                MessageBox.Show($"ваш месяц {mouth7} количество дней в нем: {march}");
            }
            else if (mouth == mouth6)
            {
                MessageBox.Show($"ваш месяц {mouth6} количество дней в нем: {february}");
            }


        }
            

        }
    }
}
