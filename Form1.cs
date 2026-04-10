namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeClick_Click(object sender, EventArgs e)
        {   //создаем временный файл
            string file = Path.GetTempFileName();

            if (file == Path.GetTempFileName()) {  
               //открываем исходный файл
                using (var reader = new StreamReader(file));
                //открываем уже новый файл
                using (var writer = new StreamWriter(file));
                //построчно изменяем файл
                string line = file;
                while( line != null)
                {
                    richTextBox1.ToString();
               
                }
                //закрываем файл
                //file.ToString.Close();
                Console.ReadLine();

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            String file = richTextBox1.Text;
            if (file == null)
            {
                MessageBox.Show("вы не ввели файл");
            }
            else
            {
                MessageBox.Show("вы ввели");
            }
        }
    }
}
