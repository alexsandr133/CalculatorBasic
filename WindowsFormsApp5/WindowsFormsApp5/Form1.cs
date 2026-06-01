using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void двухмерныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void решениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void решитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Если ты уверен, что контекстное меню на Form1 (MDI-контейнере)
            // и Form1 открыта и IsMdiContainer = true

            // Находим родительскую MDI-форму
            Form mdiParent = Application.OpenForms["Form1"]; // Имя твоей MDI-формы

            if (mdiParent != null && mdiParent.IsMdiContainer)
            {
                form2 childForm = new form2(); // Твоя готовая форма
                childForm.MdiParent = mdiParent;
                childForm.Text = "Дочернее окно";
                childForm.Show();
            }
            else
            {
                MessageBox.Show("MDI-контейнер не найден!");
            }
        }
    }
}
