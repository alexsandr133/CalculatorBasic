using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp5
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reshenie_click(object sender, KeyPressEventArgs e)
        {
            /*
             * логика кода:
             * у нас в трех текстбоксах будут вводиться 3 числа
             * дальше при нажатии на кнопку решить выведется квадратное уранение 
             * точнее его решение
             * если вользователь попытается ввести не число у него ничего не выйдет ввести
            */
            char value1 = e.KeyChar;
            if (!char.IsDigit(value1))
            {
                MessageBox.Show("вы ничего не ввели");
            }
            else
            {
                MessageBox.Show("вы введи цифры");
                e.Handled = true;
            }
            char value2 = e.KeyChar;
            if ( !char.IsDigit(value2))
            {
                MessageBox.Show("вы ничего не ввели");
            }
            else
            {
                MessageBox.Show("вы введи цифры");
                e.Handled = true;
            }
            char value3 = e.KeyChar;
            if ( !char.IsDigit(value3))
            {
                MessageBox.Show("вы ничего не ввели");
            }
            else
            {
                MessageBox.Show("вы введи цифры");
                e.Handled = true;
            }
            int discriminant = value2 ^ 2 - 4*(value1 - value3);
            int discriminant1 = (int)Math.Sqrt( discriminant);
            int reshehinie = value2 - discriminant1 / 2 * value1;
            //округляем число до целлого
            //MessageBox.Show($"решение уровнения {reshehinie:N0}");
            textBox4.Text = $"решение уровнения: {reshehinie:N0}";
        }

        public static implicit operator ToolStripMenuItem(form2 v)
        {
            throw new NotImplementedException();
        }

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}
