using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordLab;
namespace Journal
{
    public partial class Form4 : Form
    {
        private WordDocument word;

        public Form4()
        {
            InitializeComponent();
            word = new WordDocument();
        }

        private void create_documents(object sender, EventArgs e)
        {
            word.AddDoc(@"C:\Temp\Test.docx");
            MessageBox.Show("Документ создан");
        }

        private void open_documents(object sender, EventArgs e)
        {
            word.OpenDoc(@"C:\Temp\Test.docx");
            MessageBox.Show("Документ открыт");
        }

        private void close_doxument(object sender, EventArgs e)
        {

        }
    }
}
