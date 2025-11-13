using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_zaripov122
{
    public partial class zaripov125 : Form //использование формы
    {
        public zaripov125() //используем форму 1
        {
            InitializeComponent();
        }

        

        private void btnCloseClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (Form mainform = new Form1())
            {
                this.Hide();
                mainform.ShowDialog();
                this.Show();
            }
        }
    }
}
