using ChoETL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace Journal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void sorted_students(object sender, EventArgs e)
        {
            //указываем путь к файлу
            string path = @"C:\users\Ilzar_LG_Gram\sourse\repos\students";

            /*логика кода
             * у нас будет код следующим образом работать:
             * пользователь заходит в файл.
             * далее система(приложение) у нас считывают json file
             * метод у нас openFileDialog
             * будем использовать LINQ для сортировки
            */
            using (OpenFileDialog  openFileDialog = new OpenFileDialog())
            {
                //получаем путь к выбранному файлу
                string filePath = openFileDialog.FileName;
                //фильтрация файла
                openFileDialog.Filter = "текстовые файлы (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "выберете тестовый файл";    
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string Path = openFileDialog.FileName;
                    try
                    {
                        //считываем фйал
                        string FileText = File.ReadAllText(Path);
                        textBox1.Text = FileText;
                      
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"ошибка: {ex.Message}");
                    }
                }
            }
        }

        private void sorted(object sender, EventArgs e)
        {
            string path = @"C:\users\Ilzar_LG_Gram\sourse\repos\students";
            string FilePath = @"C:\users\Ilzar_LG_Gram\sourse\repos\students";
            /*
             * логика кода:
             * у нас будет открваться проводник далее:
             * пользователь загружает файл далее,
             * происходит переконвертация json file в txt
             * и мы будем делать LINQ запросы
             * и вывод в textbox
            */
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // получаем путь к выбранному файлу
                string path1 = openFileDialog.FileName;
                //фильтрация файла
                openFileDialog.Filter = "json файлы (*.json)|*json";
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                   
                        try
                        {

                            //получаем путь к файлу
                            string Filepath = openFileDialog.FileName;
                            //читаем файл
                            string jsonText = File.ReadAllText(Filepath);
                            //парсим json в список студентов 
                            List<Students> students = JsonSerializer.Deserialize<List<Students>>(jsonText);
                            var SortStudents = students
                                .Where(s => s.math_grade > 4.09)
                                .OrderBy(s => s.name)
                                .ThenBy(s => s.name_group);
                            foreach (var student in SortStudents)
                            {
                                textBox1.Text += $"имя {student.name}, группа: {student.name_group}, оценка: {student.math_grade}";
                            }
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

        
    
        
    

