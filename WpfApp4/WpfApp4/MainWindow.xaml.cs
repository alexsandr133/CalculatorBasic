using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DocumentWord word;
        public MainWindow()
        {
            InitializeComponent();
            word = new DocumentWord();
        }

        private void btnCreate_click(object sender, RoutedEventArgs e)
        {
            word.AddDoc(@"С:\Temp\Test.docx");
            MessageBox.Show("документ создан");
        }

        private void btnOpen_click(object sender, RoutedEventArgs e)
        {
            word.OpenDoc(@"C:\Temp\Test.docx");
            MessageBox.Show("документ открыт");
        }

        
    }
}
