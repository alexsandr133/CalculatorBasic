using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text;
using System.Runtime.CompilerServices;
using System.Diagnostics;
namespace textRedactor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            //получаем текст из текстбокса
            String newStroke = textBox1.Text;
            //проверка если пользователь не ввел текст то высветится окно с сообщением что он ничего не ввел
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(" вы ничего не ввели");
            }
            else
            {
                newStroke += textBox1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show(" вы ничего не ввели поэтому нельзя сохранить файл");
            }
            else
            { 
                FileInfo file = new FileInfo(@"C:\Users\Ilzar_LG_Gram\sourse");
                //создаем файл и указываем директорию
                string path = @"C:\Users\Ilzar_LG_Gram\sourse";
                //string file = Path.GetFileName(textBox1, textBox1.Text);
                //свойства
                if (file.Exists)
                {   
                    //создаем текстовый файл
                    Console.WriteLine($"ИМЯ файла  {file.Name}");
                    //
                    Console.WriteLine($"полный путь {file.FullName}");

                    //копирование файла 
                    //file backup = file.CopyTo(@"C:\Users\Ilzar_LG_Gram\sourse_data_copy.txt", overwrite: true);
                    //
                }
                else
                {
                    using (file.Create())
                    {

                    }
                    Console.WriteLine($"создан пустой файл {file.FullName}");
                    
                }
                //открываем конкретную папку
                string path1 = @"C:\Users\Ilzar_LG_Gram\sourse";
                if (Directory.Exists(path))
                {
                    Process.Start("explorer.exe", path1);
                }
                //открываем папку и выделяем файл
                string  filepath  =@"C:\Users\Ilzar_LG_Gram\sourse\data.txt";
                if (file.Exists(filepath))
                {
                    Process.Start("explorer exe", $"/select/ {filepath}");
                }
                Process.Start("explorer.exe", "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");

                // ====== 4. ОТКРЫТЬ СЕТЕВОЕ ОКРУЖЕНИЕ ======
                Process.Start("explorer.exe", "::{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Close();
        }
    }
}
