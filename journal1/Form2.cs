using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Diagnostics.Eventing.Reader;
using System.Web;
namespace Journal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void exit4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //функция обработки нажатия для создания ока проводника
        private void btnClick_Click(object sender, EventArgs e)
        {
            Keys modifierKeys = Control.ModifierKeys;
            //проверяем какой модефикатор нажат
            //можефикатор для кнопки отправить файл
            if (ModifierKeys == Keys.Control)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                
                
            }
            else 
            {
                //object Message = System.Windows.Forms.Message.("вы ничего не нажали");
            }

        }
        

        private void  button1_Click(object sender, EventArgs e)
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
                        textBox1.Text = content;

                    }
                    catch ( Exception ex)
                    {  

                        MessageBox.Show($"ошибка: {ex.Message}");
                    }
                }
            }
        }

        private void open_click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        //линк запросы 




    }
       
    }


