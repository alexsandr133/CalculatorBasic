using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textRedactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createDocument(object sender, EventArgs e)
        {

        }

        private void createDocument_click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void wiew_click(object sender, EventArgs e)
        {
            //открываем конкретную папку
            string path1 = @"C:\Users\Ilzar_LG_Gram\sourse";
            if (Directory.Exists(path1))
            {
                Process.Start("explorer.exe", path1);
            }
            //открываем папку и выделяем файл
            string filepath = @"C:\Users\Ilzar_LG_Gram\sourse\data.txt";
            if (file.Exists(filepath))
            {
                Process.Start("explorer exe", $"/select/ {filepath}");
            }
            Process.Start("explorer.exe", "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}");

            // ====== 4. ОТКРЫТЬ СЕТЕВОЕ ОКРУЖЕНИЕ ======
            Process.Start("explorer.exe", "::{F02C1A0D-BE21-4350-88B0-7367FC96EF3C}");
        }
    }
}
