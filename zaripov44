using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UserName_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void email_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void sign_Click(object sender, EventArgs e)
        {
          if (UserName_textbox.Text=="Michael" && password_textbox.Text=="Zaripov122" && Email_textbox.Text =="alexsandramg65@gmail.com")
            {
                HelloWinApp win = new HelloWinApp();
                this.Hide();
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("вы ввели неверные данные");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
