using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void reshit_click(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            /*
             * ЛОГИКА КОДА:
             * пользователь вводит числа в текстбоксы и по нажатию происходит обработка информации и выводим результат расчета
             * плозадь квадрата длину на ширину
             * складываем две строны и умнощаем на два
             * 
            */
            char legth = e.KeyChar;
            char width = e.KeyChar;
            if (!char.IsDigit(legth))
            {
                MessageBox.Show("вы ничего не ввели");
            }
            else
            {
                MessageBox.Show("введите цифры");
                e.Handled = true;
            }
            int Squad = legth * width;
            textBox3.Text = $"площадь прямоугольника: {Squad:N0}";
            MessageBox.Show($"площадь прямоугольника: {Squad:NO}");
        }
    }
}
