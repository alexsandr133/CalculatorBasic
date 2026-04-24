using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
       public struct Array
       {
        //объявлем массив в форму ввода
        public int numbers;
    
       }

public partial class Form1 : Form
    {   
       
        public Form1()
        {
            InitializeComponent();
        }

        private void mix_click(object sender, EventArgs e)
        {
            Form newForm = new Form();
            newForm.ShowDialog();
            int[] numbers = { };
            //сортировка
            int temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int a = i + 1; a < numbers.Length; a++)
                {
                    temp = numbers[i];
                    numbers[a] = numbers[i];
                    numbers[a] = temp;
                    MessageBox.Show(
                   "Выберите один из вариантов",
                   "Сообщение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                }
            }
                
            }


        }

        private void textbox_input(object sender, EventArgs e)
        {
            MessageBox.Show("введите числа");
            int[] numbers = { };
            //сортировка
            int temp;
            for (int  i = 0; i<numbers.Length; i++)
            {
                for(int a = i+1; a<numbers.Length; a++)
                {
                    temp = numbers[i];
                    numbers[a] = numbers[i];
                    numbers[a] = temp;
                }

            }


        }
    }
}
