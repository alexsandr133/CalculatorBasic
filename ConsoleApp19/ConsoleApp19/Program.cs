using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleApp19
{
    internal class DemoWindow
    {
        static void Main(string[] args)
        {
            string name, surname ;
            name = Interaction.InputBox(
            "введите свои имя и фаммилию",
            "в этом диалоговом окне вывкдктся вагше имя и фамилия"
            );
            string txt = "приятно познакоммится, "+name+"!";
            MessageBox.Show("приятно было познакомится",txt);
        }
    }
}
