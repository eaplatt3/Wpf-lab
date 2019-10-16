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

namespace Wpf_lab
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

        private void DataBtn_Click(object sender, RoutedEventArgs e)
        {
            string s;

            s = FirstNameBox.Text + " ";
            s += LastNameBox.Text + " ";
            s += MajorBox.Text;
            MessageBox.Show(s);
            label.Content = s;
            DataBtn.Content = "I Love C#";
        }
    }
}
