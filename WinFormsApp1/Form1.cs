namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetMulnition_Click(object sender, EventArgs e)
        {

            int value1 = 0;
            Console.WriteLine(value1);
            int value2 = 0;
            Console.WriteLine(value2);
            int result = value1 * value2;
           

            if (value1 == Convert.ToInt32(1) && value2 == Convert.ToInt32(1))
            {
                MessageBox.Show($"ваше значение {value1}");
                MessageBox.Show($"ваше значение {value2}");
                MessageBox.Show($"ваше значение {result}");
            }
            else
            {
                MessageBox.Show("вы не ввели ничего");
            }
        }

        private void GetSum_button(object sender, EventArgs e)
        {
            int value1 = 0;
            Console.WriteLine(value1);
            int value2 = 0;
            Console.WriteLine(value2);
            int result = value1 + value2;
            this.Show();

            if (value1 == Convert.ToInt32(1) && value2== Convert.ToInt32(1))
            {
                MessageBox.Show($"ваше значение {value1}");
                MessageBox.Show($"ваше значение {value2}");
                MessageBox.Show($"ваше значение {result}");
            }
            else
            {
                MessageBox.Show("вы не ввели ничего");
            }

        }

        private void SortArray_button(object sender, EventArgs e)
        {
            int[] numbers = new int[6];
            Console.WriteLine(numbers);
            if (numbers.Length == 6)
            {
                MessageBox.Show($"ваш массив {numbers}");
            }
            else
            {
                MessageBox.Show("введите массив");
            }
            for (int i = 6; i< numbers.Length; i++)
            {
                numbers[i] = i;
                i++;
            }
        }

        private void textbox(object sender, EventArgs e)
        {

        }
    }
}

