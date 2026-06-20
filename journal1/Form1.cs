using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Journal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //указываем путь к файлу
            string path = @"C:\users\Ilzar_LG_Gram\sourse\repos\students";


            //используем расщирение для окна проводника
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //получаем путь к выбранному файлу
                string FilePath = openFileDialog.FileName;
                //фильтрация файлов
                openFileDialog.Filter = "текстовые файлы (*.txt)|*.txt";
                //по умолчанию первый фильтр
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "выберите тестовый файл";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //получаем путь к выбранному файлу
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        //читаем файл
                        string content = File.ReadAllText(filePath);
                        //заносим в текстбокс

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"ошибка: {ex.Message}");
                    }
                }

            }

        }
    }
}