using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainForm12 : Form
    {   
        //шаги x и y
        private int stepX = 5;
        private int stexY = 5;
        //переменная для хранения ссылки на выбьбранны   переключатель
        private RadioButton selectCheck;
        public MainForm12()
        {
            InitializeComponent();
        }

        private void colorChangeClick(object sender, EventArgs e)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(27, 27, 27);
            
        }

        private void exit_click(object sender, EventArgs e)
        {

        }

        private void move_click(object sender, EventArgs e)
        { GroupBox groupBox = new GroupBox { Text = "группа выбора", Location = new Point(30, 100)
            //помещаем все элементы
        };
            //groupBox.Сontrols.Add(radioButton1);
            groupBox.Controls.Add(radioButton2);
            groupBox.Controls.Add(radioButton3);
            //подписываемся на событие checkChanged для отслеживания выбора

            radioButton1.CheckedChanged += move_click;
            radioButton2.CheckedChanged += move_click;
            radioButton3.CheckedChanged += move_click;

            //подписываемся на события клик кнопки
            

            //проводим сэндер в RadioButton
            //проверка положения  нажат ли radiobutton
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                //сохраняем ссылку на выбранный переключатель
                selectCheck = rb;
            }
            //получаем текущюю позицию
            Point current = label1.Location;
            //получаем новую позицию
            Point newLocation = new Point(current.X + stepX, current.Y + stexY);

        }
            private void GetSelectedCheck_Click(object sender, EventArgs e)
        {
            // Используем сохраненную ссылку для получения результата
            if (selectCheck != null)
            {
                MessageBox.Show("Выбрано: " + selectCheck.Text);
            }
            else
            {
                MessageBox.Show("Ничего не выбрано.");
            }

        }

    }

    
}
