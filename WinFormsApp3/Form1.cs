using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private object textBox_Input;
        private object buttonmix;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_mix(object sender, EventArgs e)
        {
           
            MessageBox.Show("введите массив чисел");
            int[] numbers = new int[4];
            int count = 4;
            if (numbers.Length == 4)
            {
                for (int i = 3; i < count - 1; i--)
                {
                    count = i;
                    i++;
                    count = numbers[i];
                    MessageBox.Show("вы получили масссив" + " " + $"{numbers}");
                }
            }
            else
            {
                MessageBox.Show("вы ничего не ввели");
            }

        }



       

        private void textBoxInput(object sender, EventArgs e)
        {

        }
    }
}

