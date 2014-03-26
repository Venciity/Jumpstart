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

namespace _9.UnicodeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int i = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
                TextBox1.Text = "강남스타일";
            else if (i == 2)
                TextBox1.Text = "Θέλω να γίνω καλός προγραμματιστής";
            else
            {
                TextBox1.Text = @"Отчє на́шъ ижє єси на нєбєсѣхъ,
да свѣти́тсѧ и́мѧ Твоє ̀,
да прїидетъ царствїе Твоє ̀,
да бȢ́детъ волѧ Твоѧ";
                i = 0;
            }

            i++;
        }
    }
}
